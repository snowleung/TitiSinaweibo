using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness.Domain
{
    public class SinaEmotion
    {
//        phrase	表情使用的替代文字
//type	表情类型，image为普通图片表情，magic为魔法表情
//url	表情图片存放的位置
//is_hot	是否为热门表情
//order_number	该表情在系统中的排序号码
//category

        string _phrase;

        /// <summary>
        /// 表情使用的替代文字
        /// </summary>
        public string phrase
        {
            get { return _phrase; }
            set { _phrase = value; }
        }
        string _type;
        /// <summary>
        /// 表情类型，image为普通图片表情，magic为魔法表情
        /// </summary>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        string _url;
        /// <summary>
        /// 表情图片存放的位置
        /// </summary>
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }
        Nullable<bool> _is_hot;
        /// <summary>
        /// 是否为热门表情
        /// </summary>
        public Nullable<bool> is_hot
        {
            get { return _is_hot; }
            set { _is_hot = value; }
        }
        Nullable<bool> _is_common;
        
        public Nullable<bool> is_common
        {
            get { return _is_common; }
            set { _is_common = value; }
        }
        Nullable<int> _order_number;
        /// <summary>
        /// 该表情在系统中的排序号码
        /// </summary>
        public Nullable<int> order_number
        {
            get { return _order_number; }
            set { _order_number = value; }
        }
        string _category;
        /// <summary>
        /// 表情分类
        /// </summary>
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
