using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Domain;
using System.Xml;

namespace SinaBusiness.SinaResponse
{
    public class WBUsertimelineResponse:AbsSinaResponse
    {
        
        List<SinaStatus> _statuses;

        public List<SinaStatus> Statuses
        {
            get { return _statuses; }
            set { _statuses = value; }
        }


        public WBUsertimelineResponse(string xmlFile) 
        {
            if (xmlFile != string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("statuses");
                List<SinaStatus> list = new List<SinaStatus>();
                foreach (XmlNode CurrentNode in xnroot.ChildNodes)
                {

                    SinaStatus s = SinaModelFactory.CreateStatus(CurrentNode);
                    s.user = SinaModelFactory.CreateUser(CurrentNode.SelectSingleNode("user")); 
                    list.Add(s);

                }
                this._statuses = list;
            }
        }
    }
}

