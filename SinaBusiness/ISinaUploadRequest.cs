using System;
using System.Collections.Generic;
using System.Text;
using SinaBusiness.Tools;

namespace SinaBusiness
{
    interface ISinaUploadRequest<T>:ISinaResquest<T> where T:AbsSinaResponse
    {
        /// <summary>
        /// ��ȡ���е�Key-Value��ʽ���ļ���������ֵ䡣���У�
        /// Key: ���������
        /// Value: �ļ�����
        /// </summary>
        /// <returns>�ļ���������ֵ�</returns>
        IDictionary<string, FileItem> GetFileParameters();
    }
}
