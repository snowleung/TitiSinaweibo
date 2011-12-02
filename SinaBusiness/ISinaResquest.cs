using System;
using System.Collections.Generic;
using System.Text;

namespace SinaBusiness
{
    public interface ISinaResquest<T>
    {
        string GetApiUrl();
        string GetResponse();
        IDictionary<string, string> GetParamters();
    }
}
