using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness;
using SinaBusiness.SinaRequest;
using System.Windows.Forms;
using System.Xml.Serialization;
using SinaBusiness.Domain;
using SinaBusiness.SinaResponse;
namespace WeiboTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestModel.test();

            //object o = AssemblyFactory.CreateResponseObject();

            Console.ReadKey();
        }

        static class TestModel 
        {
            //string filepath = @"C:\aaamy\vs2005Solution\sinaweibo\WeiboTest\FrmTiti\bin\Debug\friend.xml";

            public static void test() 
            {
                string xml = "<statuses><status><created_at>Thu Feb 03 00:39:09 +0800 2011</created_at><id>6016500137</id><text>坐等真相~~~</text></status></statuses>";
                string xml2 = "<status><created_at>Mon Dec 13 14:55:05 +0800 2010</created_at><id>4288554507</id><text>abcedf</text><source><a href=\"http://open.t.sina.com.cn\">微博开放平台接口</a></source><favorited>false</favorited><truncated>false</truncated><geo/><in_reply_to_status_id></in_reply_to_status_id><in_reply_to_user_id></in_reply_to_user_id><in_reply_to_screen_name></in_reply_to_screen_name><user><id>1854740027</id><screen_name>siegetest</screen_name><name>siegetest</name><province>11</province><city>8</city><location>北京 海淀区</location><description>ABCDE</description> <url></url> <profile_image_url>http://tp4.sinaimg.cn/1854740027/50/1291272213/1</profile_image_url> <domain></domain> <gender>m</gender><followers_count>2</followers_count> <friends_count>20</friends_count> <statuses_count>39</statuses_count>  <favourites_count>0</favourites_count>  <created_at>Thu Nov 11 00:00:00 +0800 2010</created_at><following>false</following> <verified>false</verified><allow_all_act_msg>true</allow_all_act_msg><geo_enabled>true</geo_enabled></user><annotations><annotation class=\"object\"> <type2 type=\"number\">123</type2></annotation></annotations> </status>";
                string status="sina WebTest 测试中文[给力]，测试English[给力],测试こんにちは[给力]，测试￥$[给力],测试网址:http://t.sina.com/snowleung [给力],测试@ :@earicleung " + DateTime.Now.Ticks.ToString();
                WBAccessUpdateRequest up = new WBAccessUpdateRequest();
                up.status = status;
                ISinaClient client = new SinaClient();
                WBAccessUpdateResponse rsp;

                rsp = new WBAccessUpdateResponse(xml2);
                //WBAccessUploadRequest upload = new WBAccessUploadRequest();
                //upload.pic = new SinaBusiness.Tools.FileItem(@"C:\Users\snow\Desktop\中.gif");
                //upload.status = status;

                //WBAccessUploadResponse rsp = client.Excute(upload);



                //WBFriendtimelineRequest req = new WBFriendtimelineRequest();
                //WBFriendtimelineResponse rsp = client.Excute(req);



                //WBEmotionsRequest req = new WBEmotionsRequest();

                //WBEmotionsResponse rsp = client.Excute(req);


                Console.WriteLine(rsp.Status.created_at);







                //up.GetResponse<WBAccessUpdateRequest>(up);


                //string filepath = @"C:\Users\snow\Desktop\中.gif";
                //WBAccessUploadRequest up = new WBAccessUploadRequest();
                //up.GetResponse(status, filepath);

            }            
        }
    }
}
