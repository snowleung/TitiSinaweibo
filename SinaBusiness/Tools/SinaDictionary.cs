using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness.Tools
{
    public class SinaDictionary:Dictionary<string,string>
    {
        private const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
           
        public SinaDictionary() { }

        public SinaDictionary(IDictionary<string, string> dictionary)
            : base(dictionary)
        { }
        public new void Add(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                base.Add(key, value);
            }
        }
        public void Add(string key, object value)
        {
            string strValue;

            if (value == null)
            {
                strValue = null;
            }
            else if (value is string)
            {
                strValue = (string)value;
            }
            else if (value is Nullable<DateTime>)
            {
                Nullable<DateTime> dateTime = value as Nullable<DateTime>;
                strValue = dateTime.Value.ToString(DATE_TIME_FORMAT);
            }
            else if (value is Nullable<int>)
            {
                strValue = (value as Nullable<int>).Value.ToString();
            }
            else if (value is Nullable<long>)
            {
                strValue = (value as Nullable<long>).Value.ToString();
            }
            else if (value is Nullable<double>)
            {
                strValue = (value as Nullable<double>).Value.ToString();
            }
            else if (value is Nullable<bool>)
            {
                strValue = (value as Nullable<bool>).Value.ToString().ToLower();
            }
            else
            {
                strValue = value.ToString();
            }
            this.Add(key, strValue);


        }
    }
}
