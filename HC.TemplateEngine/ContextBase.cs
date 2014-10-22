/*****************************************************
 * �����ĺ���ϵ JNTemplate
 * ���ߣ����ĳ��� QQ:4585839
 * Mail: i@Jiniannet.com
 * ��ַ��http://www.JiNianNet.com
 *****************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using HC.TemplateEngine.Parser;

namespace HC.TemplateEngine
{
    /// <summary>
    /// ContextBase ����
    /// </summary>
    public class ContextBase : ICloneable
    {

        private VariableScope variableScope;
        /// <summary>
        /// ģ������
        /// </summary>
        public VariableScope TempData
        {
            get { return variableScope; }
            set { variableScope = value; }
        }

        /// <summary>
        /// ContextBase 
        /// </summary>
        public ContextBase()
        {
            variableScope = new VariableScope();
        }

        #region ICloneable ��Ա

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
