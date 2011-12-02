using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness
{
    public interface ISinaClient
    {
        /// <summary>
        /// 返回一个RESPONSE对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        T Excute<T>(ISinaResquest<T> request) where T : AbsSinaResponse;
    }
}
