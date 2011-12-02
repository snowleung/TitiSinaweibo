using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.Config;
using System.IO;
using SinaBusiness.Tools;
using System.Web;

namespace SinaBusiness
{
    public class SRequest
    {


        oAuthSina oauth = new oAuthSina();

        public readonly string APPKEY = "1059314629";
        public readonly string APP_SECRET = "9e0fc7b629797f6b16145142ddc14b85";

        private const string DATAFORMAT = ".xml";
        readonly SConfig sc;
        public SRequest() { sc = new SConfig(); }
        public SRequest(SConfig s) { sc = s; }



        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public IDictionary<string, T> CleanupDictionary<T>(IDictionary<string, T> dict)
        {
            IDictionary<string, T> newDict = new Dictionary<string, T>(dict.Count);
            IEnumerator<KeyValuePair<string, T>> dem = dict.GetEnumerator();

            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                T value = dem.Current.Value;
                if (value != null)
                {
                    newDict.Add(name, value);
                }
            }

            return newDict;
        }


        /// <summary>
        /// 组合字串
        /// </summary>
        /// <param name="dicParamters"></param>
        /// <returns></returns>
        private string BuildPostData (SinaDictionary dicParamters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;
            foreach (KeyValuePair<string,string> keyValue in dicParamters)
            {
                string name=keyValue.Key;
                string value=keyValue.Value;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value)) 
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }
                    postData.Append(name);
                    postData.Append("=");
                    postData.Append(oauth.UrlEncode(HttpUtility.UrlEncode(value))) ; 
                    hasParam = true;
                }
            }
            return postData.ToString();
        }

        /// <summary>
        /// 字典参数的重载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dicParamters"></param>
        /// <returns></returns>
        private string SendRequest(string url, SinaDictionary dicParamters)
        {

            return oauth.oAuthWebRequest(oAuthSina.Method.POST, url+=DATAFORMAT, BuildPostData(dicParamters)); 


        }

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dicParamters"></param>
        /// <param name="fileParamters"></param>
        /// <returns></returns>
        public string DoPost(string url,SinaDictionary dicParamters, IDictionary<string,FileItem> fileParamters) 
        {
            return this.SendRequest(url, dicParamters,fileParamters);
        }

        /// <summary>
        /// 执行请求,含有文件上传的请求，字典参数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="status"></param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private string SendRequest(string url, SinaDictionary dicParamters, IDictionary<string,FileItem> fileParamters)
        {

            if (fileParamters == null || fileParamters.Count == 0)
            {
                return this.SendRequest(url, dicParamters);
            }

            var UploadApiUrl = (url += DATAFORMAT) ;
            string contentEncoding;
            string boundary;
            HttpWebRequest httpRequest;
            oauth.GetPicHttpRequest(oAuthSina.Method.POST, url += "?"+this.BuildPostData(dicParamters), UploadApiUrl, out contentEncoding, out boundary, out httpRequest); 

            httpRequest.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
            string header = string.Format("--{0}", boundary);
            string footer = string.Format("--{0}--", boundary);

            StringBuilder contents = new StringBuilder();
            foreach (KeyValuePair<string,string> kv in dicParamters)
            {
                contents.AppendLine(header);
                contents.AppendLine(String.Format("Content-Disposition: form-data; name=\"{0}\"", kv.Key));
                contents.AppendLine("Content-Type: text/plain; charset=utf-8");//US-ASCII
                contents.AppendLine("Content-Transfer-Encoding: 8bit");
                contents.AppendLine();
                //微博文字
                contents.AppendLine(HttpUtility.UrlEncode(kv.Value)); //中文要urlencode
            }

            byte[] bytesToPost = Encoding.UTF8.GetBytes(contents.ToString());

            //微博图片
            contents = null;
            contents = new StringBuilder();


            foreach (KeyValuePair<string,FileItem> kvf in fileParamters)
            {
                contents.AppendLine(header);
                string fileHeader = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"", kvf.Key, boundary);
                string fileData = Encoding.GetEncoding(contentEncoding).GetString(kvf.Value.GetContent());

                contents.AppendLine(fileHeader);
                contents.AppendLine("Content-Type: application/octet-stream; charset=utf-8");
                contents.AppendLine("Content-Transfer-Encoding: binary");
                contents.AppendLine();
                contents.AppendLine(fileData);
                contents.AppendLine(footer); 
            }

            byte[] bytesToPost2 = Encoding.GetEncoding(contentEncoding).GetBytes(contents.ToString()); 

            httpRequest.ContentLength = bytesToPost.Length + bytesToPost2.Length;
            Stream requestStream = httpRequest.GetRequestStream();
            requestStream.Write(bytesToPost, 0, bytesToPost.Length);
            requestStream.Write(bytesToPost2, 0, bytesToPost2.Length);
            requestStream.Close();

            return oauth._WebResponseGet(httpRequest) ;
        }


        



        ///// <summary>
        ///// HTTP普通验证(Basic Authentication)方式
        ///// </summary>
        ///// <param name="url">API URL</param>
        ///// <param name="httpRequestMethod)">HTTP请求方式：GET或POST</param>
        ///// <returns></returns>
        //private WebRequest BasicAuthorizationRequest(string url, string httpRequestMethod)
        //{
        //    string usernamePassword = sc.UserName + ":" + sc.Password;
        //    url += DATAFORMAT;
        //    CredentialCache mycache = new CredentialCache();
        //    mycache.Add(new Uri(url), "Basic", new NetworkCredential(sc.UserName, sc.Password));
        //    WebRequest myReq = WebRequest.Create(url);
        //    myReq.Credentials = mycache;
        //    myReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword)));
        //    myReq.Method = httpRequestMethod;
        //    return myReq;
        //}

        //private string GetResponseToString(HttpWebRequest httpRequest, Encoding encoding)
        //{
        //    using (System.Net.WebResponse wr = httpRequest.GetResponse())
        //    {
        //        using (System.IO.Stream receiveStream = wr.GetResponseStream())
        //        {
        //            using (System.IO.StreamReader reader = new System.IO.StreamReader(receiveStream, encoding))
        //            {
        //                string responseContent = reader.ReadToEnd();
        //                return responseContent;
        //            }
        //        }    
        //    }
            
            
        //}
        //private string GetResponseToString(HttpWebRequest httpRequest)
        //{
        //    return GetResponseToString(httpRequest, Encoding.UTF8);
        //}

    }
}