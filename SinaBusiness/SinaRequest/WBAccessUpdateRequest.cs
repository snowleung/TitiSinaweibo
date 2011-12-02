using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness.SinaRequest
{
   public class WBAccessUpdateRequest:ISinaResquest<WBAccessUpdateResponse>
    {

        private Nullable<long> _in_reply_to_status_id;
       /// <summary>
       /// 转发ID
       /// </summary>
        public Nullable<long> in_reply_to_status_id
        {
            get { return _in_reply_to_status_id; }
            set { _in_reply_to_status_id = value; }
        }

        private Nullable<float> _lat;
       /// <summary>
       /// 经度
       /// </summary>
        public Nullable<float> lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        private Nullable<float> _long;
       /// <summary>
       /// 纬度
       /// </summary>
        public Nullable<float> @long
        {
            get { return _long; }
            set { _long = value; }
        }



        string _status = string.Empty;

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }


        #region ISinaResquest 成员

        public string GetApiUrl()
        {
            return @"http://api.t.sina.com.cn/statuses/update"; 
        }

        public string GetResponse()
        {
            return "WBAccessUpdateResponse";
        }

        public IDictionary<string, string> GetParamters()
        {
            SinaDictionary dicParamters = new SinaDictionary();
            dicParamters.Add("status", this.status);
            return dicParamters;
        }

        #endregion

    }
}             
