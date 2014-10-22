/*****************************************************
 * �����ĺ���ϵ JNTemplate
 * ���ߣ����ĳ��� QQ:4585839
 * Mail: i@Jiniannet.com
 * ��ַ��http://www.JiNianNet.com
 *****************************************************/
using System;
using System.IO;

namespace HC.TemplateEngine
{
    /// <summary>
    /// Template ����
    /// </summary>
    public interface ITemplate
    {
        /// <summary>
        /// TemplateContext
        /// </summary>
        TemplateContext Context { get;set; }
        /// <summary>
        /// ģ������
        /// </summary>
        String TemplateContent { get;set; }
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="writer"></param>
        void Render(TextWriter writer);
    }
}
