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
    /// �������
    /// </summary>
    public interface IEngine
    {
        //void Render(TemplateContext context, TextWriter writer);

        /// <summary>
        /// ����Templateʵ��
        /// </summary>
        /// <returns></returns>
        ITemplate CreateTemplate(String path);
    }
}
