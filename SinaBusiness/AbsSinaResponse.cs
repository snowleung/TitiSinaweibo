using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Config;

namespace SinaBusiness
{
    public abstract class AbsSinaResponse
    {
        string _body=null;
        /// <summary>
        /// XML String
        /// </summary>
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        string _erroMsg;
        /// <summary>
        /// ¥ÌŒÛ–≈œ¢
        /// </summary>
        public string ErroMsg
        {
            get { return _erroMsg; }
            set { _erroMsg = value; }
        }
    }
}
