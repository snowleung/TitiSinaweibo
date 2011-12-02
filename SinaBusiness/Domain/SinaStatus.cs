using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
namespace SinaBusiness.Domain
{
    public class SinaStatus
    {
        //<status>
        //  <created_at>Mon Dec 13 14:55:05 +0800 2010</created_at>
        //  <id>4288554507</id>
        //  <text>abcedf</text>
        //  <source>
        //    <a href="http://open.t.sina.com.cn">微博开放平台接口</a>
        //  </source>

        public string _source;

        //  <favorited>false</favorited>
        public bool _favorited;
        //  <truncated>false</truncated>
        public bool _truncated;
        //  <geo/>
        //  <in_reply_to_status_id></in_reply_to_status_id>
        public string _in_reply_to_status_id;
        //  <in_reply_to_user_id></in_reply_to_user_id>
        public string _in_reply_to_user_id;

        //  <in_reply_to_screen_name></in_reply_to_screen_name>
        public string _in_reply_to_screen_name;

    
        long _id;

        public long id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _text;

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        string _created_at;

        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }

        SinaUser _user;

        public SinaUser user
        {
            get { return _user; }
            set { _user = value; }
        }

        SinaStatus _retweeted_status;

        public SinaStatus retweeted_status
        {
            get { return _retweeted_status; }
            set { _retweeted_status = value; }
        }


        public string _thrumbnail_pic;

        public string _bmiddle_pic;

        public string _original_pic;

    }
}
