using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness.Domain
{
    public class SinaUser
    {
        //  <user>
        //    <id>1854740027</id>
        //    <screen_name>siegetest</screen_name>
        //    <name>siegetest</name>
        //    <province>11</province>
        public string _province;

        //    <city>8</city>
        public string _city;
        //    <location>北京 海淀区</location>
        public string _location;

        //    <description>ABCDE</description>
        //    <url></url>
        //    <profile_image_url>http://tp4.sinaimg.cn/1854740027/50/1291272213/1</profile_image_url>
        //    <domain></domain>
        public string _domain;
        //    <gender>m</gender>
        public string _gender;
        //    <followers_count>2</followers_count>
        public string _followers_count;
        //    <friends_count>20</friends_count>
        public string _friends_count;
        //    <statuses_count>39</statuses_count>
        public string _statuses_count;
        //    <favourites_count>0</favourites_count>
        public string _favourites_count;
        //    <created_at>Thu Nov 11 00:00:00 +0800 2010</created_at>
        public string _created_at;
        //    <following>false</following>
        public bool _following;
        //    <verified>false</verified>
        public bool _verified;
        //    <allow_all_act_msg>true</allow_all_act_msg>
        public bool _allow_all_act_msg;
        //    <geo_enabled>true</geo_enabled>
        public bool _geo_enabled;

        public long _id;
        public string _screen_name;
        public string _description;
        public string _name;
        public string _profile_image_url;
        public SinaStatus status;
    }
}
