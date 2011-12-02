using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Domain;
using System.Xml;

namespace SinaBusiness.SinaResponse
{
    public class WBEmotionsResponse:AbsSinaResponse
    {
        List<SinaEmotion> _emotions;

        public List<SinaEmotion> Emotions
        {
            get { return _emotions; }
            set { _emotions = value; }
        }


        public WBEmotionsResponse(string xmlFile) 
        {
            if (xmlFile != string.Empty)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNode xnroot = xmldoc.SelectSingleNode("emotions");
                List<SinaEmotion> list = new List<SinaEmotion>();
                foreach (XmlNode CurrentNode in xnroot.ChildNodes)
                {
                    SinaEmotion s = new SinaEmotion();

                    s.phrase = CurrentNode.SelectSingleNode("phrase").InnerText;
                    s.type = CurrentNode.SelectSingleNode("type").InnerText;
                    s.url = CurrentNode.SelectSingleNode("url").InnerText;
                    s.is_hot = Convert.ToBoolean( CurrentNode.SelectSingleNode("is_hot").InnerText);
                    s.is_common = Convert.ToBoolean(CurrentNode.SelectSingleNode("is_common").InnerText);
                    s.order_number = Convert.ToInt32(CurrentNode.SelectSingleNode("order_number").InnerText);
                    s.category = CurrentNode.SelectSingleNode("category").InnerText;

                    list.Add(s);

                }
                this._emotions = list;
            }
        }
    }
}
