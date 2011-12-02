using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;
using SinaBusiness.SinaResponse;

namespace SinaBusiness.SinaRequest
{
    /// <summary>
    /// ��ȡ�����б��ʾ����GET��ʽ
    /// </summary>
    public class WBFriendtimelineRequest:ISinaResquest<WBFriendtimelineResponse>
    {



        Nullable<long> _since_id;
        /// <summary>
        /// ��ָ���˲�������ֻ����ID��since_id���΢����Ϣ������since_id����ʱ�����΢����Ϣ����
        /// </summary>
        public Nullable<long> since_id
        {
            get { return _since_id; }
            set { _since_id = value; }
        }
        Nullable<long> _max_id;
        /// <summary>
        /// ��ָ���˲������򷵻�IDС�ڻ����max_id��΢����Ϣ
        /// </summary>
        public Nullable<long> max_id
        {
            get { return _max_id; }
            set { _max_id = value; }
        }
        Nullable<int> _count;
        /// <summary>
        /// Ĭ��ֵ20�����ֵ200��	ָ��Ҫ���صļ�¼������
        /// </summary>
        public Nullable<int> count
        {
            get { return _count; }
            set { _count = value; }
        }
        Nullable<int> _page;
        /// <summary>
        /// Ĭ��ֵ1��	ָ�����ؽ����ҳ�롣���ݵ�ǰ��¼�û�����ע���û�������Щ����ע�û������΢��������ҳ��������ܲ鿴���ܼ�¼����������ͬ��ͨ������ܲ鿴1000�����ҡ�
        /// </summary>
        public Nullable<int> page
        {
            get { return _page; }
            set { _page = value; }
        }
        Nullable<int> _base_app;
        /// <summary>
        /// �Ƿ���ڵ�ǰӦ������ȡ���ݡ�1Ϊ���Ʊ�Ӧ��΢����0Ϊ�������ơ�
        /// </summary>
        public Nullable<int> base_app
        {
            get { return _base_app; }
            set { _base_app = value; }
        }
        Nullable<int> _feature;
        /// <summary>
        /// ΢�����ͣ�0ȫ����1ԭ����2ͼƬ��3��Ƶ��4����. ����ָ�����͵�΢����Ϣ���ݡ�
        /// </summary>
        public Nullable<int> feature
        {
            get { return _feature; }
            set { _feature = value; }
        }


        



        #region ISinaResquest<WBFriendtimelineResponse> ��Ա

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
