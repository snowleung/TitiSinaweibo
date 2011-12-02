using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SinaBusiness.Domain;
using System.Xml;

namespace SinaBusiness.SinaResponse
{
    public class WBAccessReplyResponse:AbsSinaResponse
    {
        SinaComment _comment;

        public SinaComment Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }


        public WBAccessReplyResponse(string xmlFile) 
        {
            if (xmlFile!=string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("comment");

                SinaComment s = SinaModelFactory.CreateComment(xnroot);
                s.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user"));
                s.status = SinaModelFactory.CreateStatus(xnroot.SelectSingleNode("status"));
                s.reply_comment = SinaModelFactory.CreateReply_comment(xnroot.SelectSingleNode("reply_comment"));
                s.reply_comment.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("reply_comment").SelectSingleNode("user"));

                s.status.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("status").SelectSingleNode("user"));
                s.status.retweeted_status = SinaModelFactory.CreateRetweeted_status(xnroot.SelectSingleNode("status").SelectSingleNode("user").SelectSingleNode("retweeted_status"));
                s.status.retweeted_status.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("status").SelectSingleNode("user").SelectSingleNode("retweeted_status").SelectSingleNode("user")); 

                s.user.status = SinaModelFactory.CreateStatus(xnroot.SelectSingleNode("user").SelectSingleNode("status"));
                s.user.status.retweeted_status = SinaModelFactory.CreateRetweeted_status(xnroot.SelectSingleNode("user").SelectSingleNode("status").SelectSingleNode("retweeted_status"));
                s.user.status.retweeted_status.user = SinaModelFactory.CreateUser(xnroot.SelectSingleNode("user").SelectSingleNode("status").SelectSingleNode("retweeted_status").SelectSingleNode("user")); 

                this._comment = s;
            }
        }
    }
}
