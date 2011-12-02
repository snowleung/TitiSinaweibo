using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness
{
   public class SinaClient:ISinaClient
    {

       SRequest sreq = new SRequest();
        #region ISinaClient ≥…‘±

       public T Excute<T>(ISinaResquest<T> request) where T : AbsSinaResponse
       {
           SinaDictionary dicParamters = new SinaDictionary(request.GetParamters());
           dicParamters.Add("source", sreq.APPKEY);
           string xmlfile = string.Empty;
           string ErrMsg = string.Empty;
           try
           {
               if (request is ISinaUploadRequest<T>)
               {
                   ISinaUploadRequest<T> uRequest = (ISinaUploadRequest<T>)request;
                   IDictionary<string, FileItem> fileparamters = sreq.CleanupDictionary(uRequest.GetFileParameters());
                   xmlfile = sreq.DoPost(request.GetApiUrl(), dicParamters, fileparamters);
               }
               else
               {
                   xmlfile = sreq.DoPost(request.GetApiUrl(), dicParamters, null);
               }
           }
           catch (Exception ex)
           {
               ErrMsg = ex.Message;
           }
           T rsp;
           object obj = AssemblyFactory.CreateResponseObject(request,xmlfile);
           if (obj !=null)
           {
               rsp = (T)obj;
               
               rsp.Body = xmlfile;
               rsp.ErroMsg = ErrMsg;
           }
           else
           {
               rsp = default(T);
           }

           return rsp;
       }

        #endregion
    }
}
