using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;

namespace SinaBusiness
{
    interface ISinaUploadRequest<T>:ISinaResquest<T> where T:AbsSinaResponse
    {
        /// <summary>
        /// 获取所有的Key-Value形式的文件请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 文件对象
        /// </summary>
        /// <returns>文件请求参数字典</returns>
        IDictionary<string, FileItem> GetFileParameters();
    }
}
