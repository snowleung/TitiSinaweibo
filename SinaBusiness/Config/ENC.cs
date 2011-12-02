using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness.Config
{
    class ENC
    {
        /// <summary>
        /// º”√‹
        /// </summary>
        /// <param name="enstring"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static string enc (string enstring,int keyword)
        {
            #region enc
            string _userID = enstring;


            int leng = _userID.Length;

            Random rad = new Random();
            int radp = rad.Next(0, leng);

            string perid = "l" + _userID.Substring(0, radp) + "t" + _userID.Substring(radp) + (radp + keyword).ToString();

            return perid;
            #endregion
        }
        /// <summary>
        /// Ω‚√‹
        /// </summary>
        /// <param name="enpstring"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static string enp(string enpstring,int keyword) 
        {
            #region enp

            string bstring = enpstring;

            int pword = Convert.ToInt32(bstring.Substring(bstring.Length - 2)) - keyword;

            string p = bstring.Substring(1, pword) + bstring.Substring(pword + 2, bstring.Length - 2 - (pword + 2));

            return p;

            #endregion 
        }
    }
}
