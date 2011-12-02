using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace SinaBusiness.SinaResponse
{
    public class AssemblyFactory
    {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestObject"></param>
        /// <returns></returns>
        public static object CreateResponseObject<T>(ISinaResquest<T> requestObject)where T:AbsSinaResponse
        {
            return Assembly.Load("SinaBusiness").CreateInstance("SinaBusiness.SinaResponse." + requestObject.GetResponse());
        }


        public static object CreateResponseObject<T>(ISinaResquest<T> requestObject,string objArgs) where T : AbsSinaResponse
        {
            
            return Assembly.Load("SinaBusiness").CreateInstance("SinaBusiness.SinaResponse." + requestObject.GetResponse(), false, BindingFlags.CreateInstance, null, new object[] { objArgs }, null, null);
        }
    }
}
