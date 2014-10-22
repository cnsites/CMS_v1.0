﻿using HC.TemplateEngine.Parser.Node;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.TemplateEngine.Exception
{
    /// <summary>
    /// 常规性错误
    /// </summary>
    public class TemplateException : System.Exception
    {
        private Int32 errorLine;
        private Int32 errorColumn;
        private String errorCode;
        /// <summary>
        /// 所在行
        /// </summary>
        public Int32 Line
        {
            get { return errorLine; }
            set { errorLine = value; }
        }
        /// <summary>
        /// 所在字符
        /// </summary>
        public Int32 Column
        {
            get { return errorColumn; }
            set { errorColumn = value; }
        }
        /// <summary>
        /// 错误代码
        /// </summary>
        public String Code
        {
            get { return errorCode; }
            set { errorCode = value; }
        }
        /// <summary>
        /// 模板错误
        /// </summary>
        public TemplateException()
            : base()
        {

        }

        ///// <summary>
        ///// 常规性错误
        ///// </summary>
        ///// <param name="tag">错误标签</param>
        ///// <param name="innerException"></param>
        //public TemplateException(Tag tag, System.Exception innerException)
        //    : base(tag.ToString(), innerException)
        //{
        //    this.errorLine = tag.FirstToken.BeginLine;
        //    this.errorColumn = tag.FirstToken.BeginColumn;
        //}

        /// <summary>
        /// 模板错误
        /// </summary>
        /// <param name="message">异常信息</param>
        /// <param name="line">行</param>
        /// <param name="column">字符</param>
        public TemplateException(String message, Int32 line, Int32 column)
            : base(String.Concat("Line:",
                line.ToString(),
                " Column:",
                column.ToString(),
                "\r\n",
                message))
        {
            this.errorColumn = column;
            this.errorLine = line;
        }

        /// <summary>
        /// 模板错误
        /// </summary>
        /// <param name="message">错误信息</param>
        public TemplateException(String message)
            : base(message)
        {

        }

        /// <summary>
        /// 模板错误
        /// </summary>
        /// <param name="message">错误信息</param>
        /// <param name="innerException">基础信息</param>
        public TemplateException(String message, System.Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
