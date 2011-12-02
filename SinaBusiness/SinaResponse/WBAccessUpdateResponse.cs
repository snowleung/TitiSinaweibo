using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.Tools;
using SinaBusiness.Domain;
using System.Data;
using System.Xml;
namespace SinaBusiness.SinaResponse
{
    public class WBAccessUpdateResponse:AbsSinaResponse
    {
        SinaStatus _status;

        public SinaStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public WBAccessUpdateResponse(string xmlFile) 
        {
            if (xmlFile!=string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("status");
                SinaStatus s = SinaModelFactory.CreateStatus(xmldoc.SelectSingleNode("status"));
                s.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user"));
                this._status = s;
            }
        }
    }
}             
