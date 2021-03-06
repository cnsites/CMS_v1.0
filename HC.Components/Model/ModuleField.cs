﻿//--------------------------------------------------------------------------------
// 文件描述：模型字段实体类
// 文件作者：张清山
// 创建日期：2014-08-30 15:14:43
// 修改记录： 
//--------------------------------------------------------------------------------
using System;
using HC.Repository;
namespace HC.Components.Model
{
    /// <summary> 
    /// 模型字段实体类
    /// </summary>
    [TableName("HC_ModuleField")]
    [PrimaryKey("Id")]
    [Serializable]
    public class ModuleField : ModelBase
    {

        /// <summary> 
        /// Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary> 
        /// 内容模型Id 
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// 模型表名
        /// </summary> 
        public string TableName { get; set; }

        /// <summary> 
        /// 字段名称 
        /// </summary>
        public string Name { get; set; }

        /// <summary> 
        /// 字段注释 
        /// </summary>
        public string Note { get; set; }

        /// <summary> 
        /// 字段类型（枚举） 
        /// </summary>
        public int Type { get; set; }

        /// <summary> 
        /// 字段类型（枚举） 
        /// </summary>
        [Ignore]
        public string TypeName { get; set; }

        /// <summary>
        /// 字段提示信息
        /// </summary>
        public string Tips { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }
    }
}


