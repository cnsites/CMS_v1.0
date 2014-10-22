﻿/*****************************************************
 * 本类库的核心系 JNTemplate
 * 作者：翅膀的初衷 QQ:4585839
 * Mail: i@Jiniannet.com
 * 网址：http://www.JiNianNet.com
 *****************************************************/

using System;
using System.Text;
using System.Collections.Generic;
using HC.TemplateEngine.Parser;

namespace HC.TemplateEngine
{
    /// <summary>
    /// 引擎
    /// </summary>
    public class Engine : IEngine
    {

        #region IEngine 成员

        private TemplateContext context;

        /// <summary>
        /// 创建 Engine 实例 
        /// </summary>
        public Engine()
            : this(null)
        {

        }

        /// <summary>
        /// 创建 Engine 实例 
        /// </summary>
        /// <param name="path">当前模板(主题)路径</param>
        /// <param name="encoding">编码</param>
        public Engine(String path, Encoding encoding)
            : this(new TemplateContext())
        {
            if (!String.IsNullOrEmpty(path) && !Resources.Paths.Contains(path))
            {
                Resources.Paths.Add(path);
            }
            context.Charset = encoding;
        }
        /// <summary>
        /// 创建 Engine 实例 
        /// </summary>
        /// <param name="ctx">TemplateContext</param>
        public Engine(TemplateContext ctx)
        {
            if (ctx == null)
            {
                context = new TemplateContext();
            }
            else
            {
                context = ctx;
            }
        }

        /// <summary>
        /// 根据指定路径创建Template实例
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public ITemplate CreateTemplate(String path)
        {
            return CreateTemplate(path, context.Charset);
        }

        /// <summary>
        /// 根据指定路径创建Template实例
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="encoding">编码</param>
        /// <returns></returns>
        public ITemplate CreateTemplate(String path, Encoding encoding)
        {
            TemplateContext ctx = TemplateContext.CreateContext(context);
            Template template = new Template(ctx, null);
            if (encoding != null)
            {
                template.Context.Charset = encoding;
            }
            if (!String.IsNullOrEmpty(path))
            {
                String fullPath = path;
                //判断是否本地路径的绝对形式
                if (fullPath.IndexOf(System.IO.Path.VolumeSeparatorChar) != -1 || //win下判断是否包含卷分隔符（即：） c:\user\Administrator\default.html
                    fullPath[0] == '/') //liunx判断是否为/开头，/usr/share/doc/default.html  win下请不要使用/开头的路径
                {
                    ctx.CurrentPath = System.IO.Path.GetDirectoryName(fullPath);
                    template.TemplateContent = Resources.Load(fullPath, template.Context.Charset);
                }
                else
                {
                    Int32 index = Resources.FindPath(path, out fullPath); //如果是相对路径，则进行路径搜索
                    if (Resources.FindPath(path, out fullPath) != -1)
                    {
                        //设定当前工作目录 如果模板中存在Inclub或load标签，它们的处理路径会以CurrentPath 设定的路径为基准
                        ctx.CurrentPath = Resources.Paths[index];
                        template.TemplateContent = Resources.Load(fullPath, template.Context.Charset);
                    }
                }
            }

            return template;
        }
        #endregion
    }
}
