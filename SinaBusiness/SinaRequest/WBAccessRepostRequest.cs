using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.SinaResponse;
using SinaBusiness.Tools;

namespace SinaBusiness.SinaRequest
{
    /// <summary>
    /// ת��΢������ѡ�Ƿ�ͬʱ��һ������
    /// </summary>
    public class WBAccessRepostRequest:ISinaResquest<WBAccessRepostResponse>
    {



        Nullable<long> _id;

        public Nullable<long> id
        {
            get { return _id; }
            set { _id = value; }
        }

        
        string _status;

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }




       

        #region ISinaResquest<WBAccessRepostResponse> ��Ա

        public string GetResponse()
        {
            return "WBAccessRepostResponse";
        }

        public string GetApiUrl()
        {
            return @"http://api.t.sina.com.cn/statuses/repost";
        }

        public IDictionary<string, string> GetParamters()
        {
            SinaDictionary dicParamters = new SinaDictionary();
            dicParamters.Add("id", this.id);
            dicParamters.Add("status", this.status);
            dicParamters.Add("is_comment", string.IsNullOrEmpty(this.status) ? "0" : "1");
            return dicParamters;
        }

        #endregion
    }
}
