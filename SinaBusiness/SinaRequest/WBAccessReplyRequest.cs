using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.SinaResponse;
using SinaBusiness.Tools;

namespace SinaBusiness.SinaRequest
{
    public class WBAccessReplyRequest:ISinaResquest<WBAccessReplyResponse>
    {



        private Nullable<long> _cid;

        public Nullable<long> cid
        {
            get { return _cid; }
            set { _cid = value; }
        }

        private string _comment;

        public string comment
        {
            get { return _comment; }
            set { _comment = value; }
        }


        #region ISinaResquest<WBAccessReplyResponse> ≥…‘±

        public string GetApiUrl()
        {

            return @"http://api.t.sina.com.cn/statuses/reply";
        }

        public string GetResponse()
        {
            return "WBAccessReplyResponse";
        }

        public IDictionary<string, string> GetParamters()
        {
            SinaDictionary dicParamters = new SinaDictionary();
            dicParamters.Add("cid", this.cid);
            dicParamters.Add("comment", this.comment);
            return dicParamters;
        }


        #endregion
    }
}
