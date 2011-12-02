using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Domain;
using System.Xml;

namespace SinaBusiness.SinaResponse
{
    public class WBAccessRepostResponse:AbsSinaResponse
    {
        SinaStatus _status;

        public SinaStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public WBAccessRepostResponse(string xmlFile) 
        {
            if (xmlFile!=string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("status");
                SinaStatus s = SinaModelFactory.CreateStatus(xmldoc.SelectSingleNode("status"));
                s.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user"));
                s.retweeted_status = SinaModelFactory.CreateRetweeted_status(xnroot.SelectSingleNode("retweeted_status"));
                s.retweeted_status.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("retweeted_status").SelectSingleNode("user")); 

                this._status = s;
            }
        }
    }
}
