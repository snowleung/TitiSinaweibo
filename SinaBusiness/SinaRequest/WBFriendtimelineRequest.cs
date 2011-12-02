using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness.SinaRequest
{
    /// <summary>
    /// 获取好友列表的示例，GET方式
    /// </summary>
    public class WBFriendtimelineRequest:ISinaResquest<WBFriendtimelineResponse>
    {



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


        



        #region ISinaResquest<WBFriendtimelineResponse> 成员

        public string GetApiUrl()
        {
            return @"http://api.t.sina.com.cn/statuses/friends_timeline";
        }
        

        public string GetResponse()
        {
            return "WBFriendtimelineResponse";
        }
        public IDictionary<string, string> GetParamters()
        {

            SinaDictionary dicParamters = new SinaDictionary();
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
