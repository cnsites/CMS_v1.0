﻿/*****************************************************
 * 本类库的核心系 JNTemplate
 * 作者：翅膀的初衷 QQ:4585839
 * Mail: i@Jiniannet.com
 * 网址：http://www.JiNianNet.com
 *****************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.TemplateEngine
{
    /// <summary>
    /// 系统常用字段
    /// </summary>
    public class Field
    {
        public const String Version = "1.2";
        internal const String KEY_FOREACH = "foreach";
        internal const String KEY_IF = "if";
        internal const String KEY_ELSEIF = "elseif";
        internal const String KEY_ELSE = "else";
        internal const String KEY_SET = "set";
        internal const String KEY_LOAD = "load";
        internal const String KEY_INCLUDE = "include";
        internal const String KEY_END = "end";
        internal const String KEY_FOR = "for";
        internal const String KEY_IN = "in";
    }


}
