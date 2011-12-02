using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SinaBusiness.Domain
{
    public class SinaModelFactory
    {
        public static SinaStatus CreateRetweeted_status(XmlNode xn)
        {
            return CreateStatus(xn); 
        }

        public static SinaComment CreateReply_comment(XmlNode xn) 
        {
            return CreateComment(xn);
        }

        public static SinaComment CreateComment(XmlNode xnComment)
        {
            SinaComment s = null;

            if (xnComment != null)
            {
                s = new SinaComment();


                //                <created_at>Mon Dec 13 14:55:05 +0800 2010</created_at>
                s.created_at = xnComment.SelectSingleNode("created_at").InnerText;

                //<id>4288554507</id>
                s.id = Convert.ToInt64(xnComment.SelectSingleNode("id").InnerText);

                //<text>abcedf</text>
                s.text = xnComment.SelectSingleNode("text").InnerText;



                //s._thrumbnail_pic = xnComment.SelectSingleNode("thrumbnail_pic") != null ? xnComment.SelectSingleNode("thrumbnail_pic").InnerText : null;
                //s._original_pic = xnComment.SelectSingleNode("original_pic") != null ? xnComment.SelectSingleNode("original_pic").InnerText : null;
                //s._bmiddle_pic = xnComment.SelectSingleNode("bmiddle_pic") != null ? xnComment.SelectSingleNode("bmiddle_pic").InnerText : null;

            }
            return s;
        }
        public static SinaStatus CreateStatus(XmlNode xnStatus)
        {
            SinaStatus s = null;

            if (xnStatus!=null)
            {
                s = new SinaStatus();


                //                <created_at>Mon Dec 13 14:55:05 +0800 2010</created_at>
                s.created_at = xnStatus.SelectSingleNode("created_at").InnerText;

                //<id>4288554507</id>
                s.id = Convert.ToInt64(xnStatus.SelectSingleNode("id").InnerText);

                //<text>abcedf</text>
                s.text = xnStatus.SelectSingleNode("text").InnerText;

                //<source>
                //  <a href="http://open.t.sina.com.cn">微博开放平台接口</a>
                //</source>
                s._source = xnStatus.SelectSingleNode("source").InnerText;
                //<favorited>false</favorited>
                s._favorited = Convert.ToBoolean(xnStatus.SelectSingleNode("favorited").InnerText);
                //<truncated>false</truncated>
                s._truncated = Convert.ToBoolean(xnStatus.SelectSingleNode("truncated").InnerText);

                //<geo/>

                //<in_reply_to_status_id></in_reply_to_status_id>
                s._in_reply_to_status_id = xnStatus.SelectSingleNode("in_reply_to_status_id").InnerText;
                //<in_reply_to_user_id></in_reply_to_user_id>
                s._in_reply_to_user_id = xnStatus.SelectSingleNode("in_reply_to_user_id").InnerText;

                //<in_reply_to_screen_name></in_reply_to_screen_name
                s._in_reply_to_screen_name = xnStatus.SelectSingleNode("in_reply_to_screen_name").InnerText;

                s._thrumbnail_pic = xnStatus.SelectSingleNode("thrumbnail_pic") != null ? xnStatus.SelectSingleNode("thrumbnail_pic").InnerText : null;
                s._original_pic = xnStatus.SelectSingleNode("original_pic") != null ? xnStatus.SelectSingleNode("original_pic").InnerText : null;
                s._bmiddle_pic = xnStatus.SelectSingleNode("bmiddle_pic") != null ? xnStatus.SelectSingleNode("bmiddle_pic").InnerText : null;
                
            }
            return s;

        }

        public static SinaUser CreateUser(XmlNode xnUser)
        {
            SinaUser u = null;
            if (xnUser!=null)
            {
                //************************************************************************
                //                Create User
                //************************************************************************
                u = new SinaUser();
                //                <id>1854740027</id>
                u._id = Convert.ToInt64(xnUser.SelectSingleNode("id").InnerText);
                //<screen_name>siegetest</screen_name>
                u._screen_name = xnUser.SelectSingleNode("screen_name").InnerText;
                //<name>siegetest</name>
                u._name = xnUser.SelectSingleNode("name").InnerText;

                //<province>11</province>
                u._province = xnUser.SelectSingleNode("province").InnerText;

                //<city>8</city>
                u._city = xnUser.SelectSingleNode("city").InnerText;

                //<location>北京 海淀区</location>
                u._location = xnUser.SelectSingleNode("location").InnerText;

                //<description>ABCDE</description>
                u._description = xnUser.SelectSingleNode("description").InnerText;

                //<url></url>

                //<profile_image_url>http://tp4.sinaimg.cn/1854740027/50/1291272213/1</profile_image_url>
                u._profile_image_url = xnUser.SelectSingleNode("profile_image_url").InnerText;

                //<domain></domain>
                u._domain = xnUser.SelectSingleNode("domain").InnerText;

                //<gender>m</gender>
                u._gender = xnUser.SelectSingleNode("gender").InnerText;

                //<followers_count>2</followers_count>
                u._followers_count = xnUser.SelectSingleNode("followers_count").InnerText;

                //<friends_count>20</friends_count>
                u._friends_count = xnUser.SelectSingleNode("friends_count").InnerText;

                //<statuses_count>39</statuses_count>
                u._statuses_count = xnUser.SelectSingleNode("statuses_count").InnerText;

                //<favourites_count>0</favourites_count>
                u._favourites_count = xnUser.SelectSingleNode("favourites_count").InnerText;

                //<created_at>Thu Nov 11 00:00:00 +0800 2010</created_at>
                u._created_at = xnUser.SelectSingleNode("created_at").InnerText;

                //<following>false</following>
                u._following = Convert.ToBoolean(xnUser.SelectSingleNode("following").InnerText);

                //<verified>false</verified>
                u._verified = Convert.ToBoolean(xnUser.SelectSingleNode("verified").InnerText);

                //<allow_all_act_msg>true</allow_all_act_msg>
                u._allow_all_act_msg = Convert.ToBoolean(xnUser.SelectSingleNode("allow_all_act_msg").InnerText);

                //<geo_enabled>true</geo_enabled>
                u._geo_enabled = Convert.ToBoolean(xnUser.SelectSingleNode("geo_enabled").InnerText);
                //************************************************************************
                //                Create User
                //************************************************************************  
            }
            return u;
             
        }
    }
}
