using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness.SinaRequest
{
    public class WBAccessUploadRequest:ISinaUploadRequest <WBAccessUploadResponse>
    {
        SRequest req = new SRequest();

        FileItem _pic;

        public FileItem pic
        {
            get { return _pic; }
            set { _pic = value; }
        }


        string _status;

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }



        #region ISinaUploadRequest<WBAccessUploadResponse> ≥…‘±


        public string GetApiUrl()
        {
            return "http://api.t.sina.com.cn/statuses/upload";
        }

        public string GetResponse()
        {
            return "WBAccessUploadResponse";
        }


        public IDictionary<string, string> GetParamters()
        {
            SinaDictionary dicParamters = new SinaDictionary();
            dicParamters.Add("status", this.status);
            return dicParamters;
        }
        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> fdic = new Dictionary<string, FileItem>();
            fdic.Add("pic", this.pic);
            return fdic;
        }

        #endregion
    }
}
