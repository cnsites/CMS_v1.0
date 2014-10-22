﻿/*****************************************************
 * 本类库的核心系 JNTemplate
 * 作者：翅膀的初衷 QQ:4585839
 * Mail: i@Jiniannet.com
 *****************************************************/

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace HC.TemplateEngine.Parser
{
    /// <summary>
    /// 变量域
    /// </summary>
    public class VariableScope 
    {
        private VariableScope parent;

        private Dictionary<String, Object> dic;

        /// <summary>
        /// VariableScope
        /// </summary>
        public VariableScope()
            : this(null)
        {

        }

        /// <summary>
        /// VariableScope
        /// </summary>
        public VariableScope(VariableScope parent)
        {
            this.parent = parent;
            this.dic = new Dictionary<String, Object>(StringComparer.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="all">是否清空父数据</param>
        public void Clear(Boolean all)
        {
            this.dic.Clear();
            if (all)
            {
                if (this.parent != null)
                {
                    this.parent.Clear(all);
                }
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        public void Clear()
        {
            Clear(false);
        }

        /// <summary>
        /// 父对象
        /// </summary>
        public VariableScope Parent
        {
            get { return this.parent; }
        }

        /// <summary>
        /// 获取索引值
        /// </summary>
        /// <param name="name">索引名称</param>
        /// <returns></returns>
        public Object this[String name]
        {
            get
            {
                Object val;
                if (this.dic.TryGetValue(name, out val))
                    return val;
                if (this.parent != null)
                    return this.parent[name];
                return null;
            }
            set
            {
                this.dic[name] = value;
            }
        }

        ///// <summary>
        ///// 复制数据
        ///// </summary>
        ///// <returns></returns>
        //public VariableScope Copy()
        //{
        //    VariableScope owen = new VariableScope(this.Parent);
        //    foreach (KeyValuePair<String, Object> value in this.dic)
        //    {
        //        owen[value.Key] = value.Value;
        //    }
        //    return owen;
        //}

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void Push(String key, Object value)
        {
            this.dic.Add(key, value);
        }

        /// <summary>
        /// 是否包含指定键
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public Boolean ContainsKey(String key)
        {
            if (this.dic.ContainsKey(key))
            {
                return true;
            }
            if (parent != null)
            {
                return this.parent.ContainsKey(key);
            }
            
            return false;
        }

        /// <summary>
        /// 移除指定对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(String key)
        {
            return this.dic.Remove(key);
        }

    }
}