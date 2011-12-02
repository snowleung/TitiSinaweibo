using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness.SinaRequest
{
    /// <summary>
    /// Get方法
    /// </summary>
    public class WBEmotionsRequest:ISinaResquest<WBEmotionsResponse>
    {

        string _face;

        public string face
        {
            get { return _face; }
            set { _face = value; }
        }

        string @_type = "face";

        public string @type
        {
            get { return _type; }
            set { _type = value; }
        }

        string _language = "cnname";

        public string language
        {
            get { return _language; }
            set { _language = value; }
        }

        public string GetResponse() 
        {
            
            return "WBEmotionsResponse";
            
        }

        #region ISinaResquest<WBEmotionsResponse> 成员

        public string GetApiUrl()
        {
            return @"http://api.t.sina.com.cn/emotions";
        }

        public IDictionary<string, string> GetParamters()
        {
            SinaDictionary paramters = new SinaDictionary();
            paramters.Add("type", this.type);
            paramters.Add("language", this.language);
            return paramters;
        }

        #endregion
    }
}
