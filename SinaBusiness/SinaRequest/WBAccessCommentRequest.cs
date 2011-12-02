using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.SinaResponse;
using SinaBusiness.Tools;

namespace SinaBusiness.SinaRequest
{

    /// <summary>
    /// ֻ���ڻظ�΢��
    /// </summary>
    public class WBAccessCommentRequest:ISinaResquest<WBAccessCommentResponse>
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

        #region ISinaResquest<WBAccessCommentResponse> ��Ա


        public string GetApiUrl()
        {

            return @"http://api.t.sina.com.cn/statuses/comment";
        }

        public string GetResponse()
        {
            return "WBAccessCommentResponse";
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
