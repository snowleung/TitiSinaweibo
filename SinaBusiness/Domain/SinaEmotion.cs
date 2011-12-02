using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness.Domain
{
    public class SinaEmotion
    {
//        phrase	����ʹ�õ��������
//type	�������ͣ�imageΪ��ͨͼƬ���飬magicΪħ������
//url	����ͼƬ��ŵ�λ��
//is_hot	�Ƿ�Ϊ���ű���
//order_number	�ñ�����ϵͳ�е��������
//category

        string _phrase;

        /// <summary>
        /// ����ʹ�õ��������
        /// </summary>
        public string phrase
        {
            get { return _phrase; }
            set { _phrase = value; }
        }
        string _type;
        /// <summary>
        /// �������ͣ�imageΪ��ͨͼƬ���飬magicΪħ������
        /// </summary>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        string _url;
        /// <summary>
        /// ����ͼƬ��ŵ�λ��
        /// </summary>
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }
        Nullable<bool> _is_hot;
        /// <summary>
        /// �Ƿ�Ϊ���ű���
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
        /// �ñ�����ϵͳ�е��������
        /// </summary>
        public Nullable<int> order_number
        {
            get { return _order_number; }
            set { _order_number = value; }
        }
        string _category;
        /// <summary>
        /// �������
        /// </summary>
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
