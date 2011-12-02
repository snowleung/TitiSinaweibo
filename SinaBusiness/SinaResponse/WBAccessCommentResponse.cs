using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Domain;
using System.Xml;

namespace SinaBusiness.SinaResponse
{
    public class WBAccessCommentResponse:AbsSinaResponse
    {

        SinaComment _comment;

        public SinaComment Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }


        public WBAccessCommentResponse (string xmlFile)
        {
            if (xmlFile!=string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("comment");
                SinaComment s = SinaModelFactory.CreateComment(xnroot);
                s.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user"));
                s.status = SinaModelFactory.CreateStatus(xnroot.SelectSingleNode("status"));
                s.status.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("status").SelectSingleNode("user"));
                s.user.status = SinaModelFactory.CreateStatus(xnroot.SelectSingleNode("user").SelectSingleNode("status"));
                s.user.status.retweeted_status = SinaModelFactory.CreateRetweeted_status(xnroot.SelectSingleNode("user").SelectSingleNode("status").SelectSingleNode("retweeted_status"));
                s.user.status.retweeted_status.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user").SelectSingleNode("status").SelectSingleNode("retweeted_status").SelectSingleNode("user"));
                this._comment = s;
            }
        }
    }
}
