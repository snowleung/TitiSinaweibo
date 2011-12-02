using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
namespace SinaBusiness.Domain
{
    public class SinaComment
    {
    
  //       <comment>
  //  <created_at>Thu Nov 11 23:11:28 +0800 2010</created_at>
  //  <id>4439022969</id>
  //  <text>世界上最快的人~~~ They are just Genies~~</text>
  //  <user>
  //    <id>1658122963</id>
  //    <screen_name>zhangwei217245</screen_name>
  //    <name>zhangwei217245</name>
  //    <province>11</province>
  //    <city>5</city>
  //    <location>北京 朝阳区</location>
  //    <description>ABCDE</description>
  //    <url/>
  //    <profile_image_url>http://tp4.sinaimg.cn/1658122963/50/1282754213</profile_image_url>
  //    <domain>zhangwei217245</domain>
  //    <gender>m</gender>
  //    <followers_count>22</followers_count>
  //    <friends_count>43</friends_count>
  //    <statuses_count>0</statuses_count>
  //    <favourites_count>0</favourites_count>
  //    <created_at>Tue Nov 03 00:00:00 +0800 2009</created_at>
  //    <following>false</following>
  //    <verified>false</verified>
  //    <allow_all_act_msg>false</allow_all_act_msg>
  //    <geo_enabled>true</geo_enabled>
  //    <status>
  //      <created_at>Wed Dec 01 12:46:20 +0800 2010</created_at>
  //      <id>3995822273</id>
  //      <text>Twitter的API文档页面竟然有BUG。。。那个可以收缩的API列表。。。无语。</text>
  //      <source>
  //        <a href="">微博开放平台接口</a>
  //      </source>
  //      <favorited>false</favorited>
  //      <truncated>false</truncated>
  //      <geo/>
  //      <in_reply_to_status_id/>
  //      <in_reply_to_user_id/>
  //      <in_reply_to_screen_name/>
  //    </status>
  //  </user>
  //  <status>
  //    <created_at>Thu Nov 11 23:10:49 +0800 2010</created_at>
  //    <id>3583883787</id>
  //    <text>http://sinaurl.cn/7yJgU</text>
  //    <source>
  //      <a href="http://t.sina.com.cn">新浪微博</a>
  //    </source>
  //    <favorited>false</favorited>
  //    <truncated>false</truncated>
  //    <geo/>
  //    <in_reply_to_status_id/>
  //    <in_reply_to_user_id/>
  //    <in_reply_to_screen_name/>
  //    <user>
  //      <id>1658122963</id>
  //      <screen_name>zhangwei217245</screen_name>
  //      <name>zhangwei217245</name>
  //      <province>11</province>
  //      <city>5</city>
  //      <location>北京 朝阳区</location>
  //      <description>ABCDE</description>
  //      <url/>
  //      <profile_image_url>http://tp4.sinaimg.cn/1658122963/50/1282754213</profile_image_url>
  //      <domain>zhangwei217245</domain>
  //      <gender>m</gender>
  //      <followers_count>22</followers_count>
  //      <friends_count>43</friends_count>
  //      <statuses_count>0</statuses_count>
  //      <favourites_count>0</favourites_count>
  //      <created_at>Tue Nov 03 00:00:00 +0800 2009</created_at>
  //      <following>false</following>
  //      <verified>false</verified>
  //      <allow_all_act_msg>false</allow_all_act_msg>
  //      <geo_enabled>true</geo_enabled>
  //    </user>
  //  </status>
  //</comment>

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

        SinaStatus _status;

        public SinaStatus status
        {
            get { return _status; }
            set { _status = value; }
        }

        SinaUser _user;

        public SinaUser user
        {
            get { return _user; }
            set { _user = value; }
        }

        private SinaComment _reply_comment;

        public SinaComment reply_comment
        {
            get { return _reply_comment; }
            set { _reply_comment = value; }
        }

        public string _thrumbnail_pic;

        public string _bmiddle_pic;

        public string _original_pic;

    }
}
