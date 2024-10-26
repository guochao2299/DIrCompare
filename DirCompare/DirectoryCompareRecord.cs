using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirCompare
{
    public class DirectoryCompareRecord
    {
        /// <summary>
        /// 对象类型，文件或文件夹
        /// </summary>
        public string ObjectType { get; set; }=string.Empty;

        /// <summary>
        /// 结果类型，文件夹缺失、文件缺失、文件有差异
        /// </summary>
        public string ResultType {  get; set; }=string.Empty;

        /// <summary>
        /// 左侧文件夹路径
        /// </summary>
        public string LeftDirectory { get; set; } = string.Empty;   

        /// <summary>
        /// 左侧文件名称
        /// </summary>
        public string LeftFile { get; set; } = string.Empty;

        /// <summary>
        /// 左侧文件最后修改时间
        /// </summary>
        public string LeftFileLastModifyDate {  get; set; } = string.Empty; 

        /// <summary>
        /// 右侧文件夹路径
        /// </summary>
        public string RightDirectory { get; set; } = string.Empty;

        /// <summary>
        /// 右侧文件名称
        /// </summary>
        public string RightFile { get; set; } = string.Empty;

        /// <summary>
        /// 右侧文件最后修改时间
        /// </summary>
        public string RightFileLastModifyDate { get; set; } = string.Empty;
    }
}
