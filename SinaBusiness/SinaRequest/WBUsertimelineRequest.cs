using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness.SinaRequest
{
    public class WBUsertimelineRequest:ISinaResquest<WBUsertimelineResponse>
    {

//        :id	false	int64/string	根据用户ID(int64)或者微博昵称(string)返回指定用户的最新微博消息列表。该参数为REST风格参数，参见注意事项

        Nullable<long> _user_id;

        /// <summary>
        /// 用户ID，主要是用来区分用户ID跟微博昵称。当微博昵称为数字导致和用户ID产生歧义，特别是当微博昵称和用户ID一样的时候，建议使用该参数
        /// </summary>
        public Nullable<long> user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        string _screen_name;
        /// <summary>
        /// 微博昵称，主要是用来区分用户UID跟微博昵称，当二者一样而产生歧义的时候，建议使用该参数
        /// </summary>
        public string screen_name
        {
            get { return _screen_name; }
            set { _screen_name = value; }
        }
        

        Nullable<long> _since_id;
        /// <summary>
        /// 若指定此参数，则只返回ID比since_id大的微博消息（即比since_id发表时间晚的微博消息）。
        /// </summary>
        public Nullable<long> since_id
        {
            get { return _since_id; }
            set { _since_id = value; }
        }
        Nullable<long> _max_id;
        /// <summary>
        /// 若指定此参数，则返回ID小于或等于max_id的微博消息
        /// </summary>
        public Nullable<long> max_id
        {
            get { return _max_id; }
            set { _max_id = value; }
        }
        Nullable<int> _count;
        /// <summary>
        /// 默认值20，最大值200。	指定要返回的记录条数。
        /// </summary>
        public Nullable<int> count
        {
            get { return _count; }
            set { _count = value; }
        }
        Nullable<int> _page;
        /// <summary>
        /// 默认值1。	指定返回结果的页码。根据当前登录用户所关注的用户数及这些被关注用户发表的微博数，翻页功能最多能查看的总记录数会有所不同，通常最多能查看1000条左右。
        /// </summary>
        public Nullable<int> page
        {
            get { return _page; }
            set { _page = value; }
        }
        Nullable<int> _base_app;
        /// <summary>
        /// 是否基于当前应用来获取数据。1为限制本应用微博，0为不做限制。
        /// </summary>
        public Nullable<int> base_app
        {
            get { return _base_app; }
            set { _base_app = value; }
        }
        Nullable<int> _feature;
        /// <summary>
        /// 微博类型，0全部，1原创，2图片，3视频，4音乐. 返回指定类型的微博信息内容。
        /// </summary>
        public Nullable<int> feature
        {
            get { return _feature; }
            set { _feature = value; }
        }

        #region ISinaResquest<WBUsertimelineResponse> 成员
        public string GetResponse()
        {
            return "WBUsertimelineResponse";
        }

        public string GetApiUrl()
        {
            return @"http://api.t.sina.com.cn/statuses/user_timeline";
        }

        public IDictionary<string, string> GetParamters()
        {
            SinaDictionary dicParamters = new SinaDictionary();
            dicParamters.Add("user_id", this.user_id);
            dicParamters.Add("screen_name", this.screen_name);
            dicParamters.Add("since_id", this.since_id);
            dicParamters.Add("max_id", this.max_id);
            dicParamters.Add("count", this.count);
            dicParamters.Add("page", this.page);
            dicParamters.Add("base_app", this.base_app);
            dicParamters.Add("feature", this.feature);

            return dicParamters;
        }

        #endregion
    }
}
