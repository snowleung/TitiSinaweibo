using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Domain;
using System.Xml;

namespace SinaBusiness.SinaResponse
{
    public class WBAccessUploadResponse:AbsSinaResponse
    {
        SinaStatus _status;

        public SinaStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public WBAccessUploadResponse(string xmlFile) 
        {
            if (xmlFile!=string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("status");

                SinaStatus s = SinaModelFactory.CreateStatus(xnroot);
                s.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user")); 

                this.Status = s;
            }
        }
    }
}
