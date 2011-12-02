using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SinaBusiness.Tools
{
    /// <summary>
    /// �ļ�Ԫ���ݡ�
    /// ����ʹ�����¼��ֹ��췽����
    /// ����·����new FileItem("C:/temp.jpg");
    /// �����ļ���new FileItem(new FileInfo("C:/temp.jpg"));
    /// �ֽ�����new FileItem("abc.jpg", bytes);
    /// </summary>
    public class FileItem
    {
        private string fileName;
        private string mimeType;
        private byte[] content;
        private FileInfo fileInfo;

        /// <summary>
        /// ���ڱ����ļ��Ĺ�������
        /// </summary>
        /// <param name="fileInfo">�����ļ�</param>
        public FileItem(FileInfo fileInfo)
        {
            if (fileInfo == null || !fileInfo.Exists)
            {
                throw new ArgumentException("fileInfo is null or not exists!");
            }
            this.fileInfo = fileInfo;
        }

        /// <summary>
        /// ���ڱ����ļ�ȫ·���Ĺ�������
        /// </summary>
        /// <param name="filePath">�����ļ�ȫ·��</param>
        public FileItem(string filePath)
            : this(new FileInfo(filePath))
        { }

        /// <summary>
        /// �����ļ������ֽ����Ĺ�������
        /// </summary>
        /// <param name="fileName">�ļ����ƣ�����˳־û��ֽ���������ʱ���ļ�����</param>
        /// <param name="content">�ļ��ֽ���</param>
        public FileItem(string fileName, byte[] content)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException("fileName");
            if (content == null || content.Length == 0) throw new ArgumentNullException("content");

            this.fileName = fileName;
            this.content = content;
        }

        /// <summary>
        /// �����ļ������ֽ�����ý�����͵Ĺ�������
        /// </summary>
        /// <param name="fileName">�ļ���������˳־û��ֽ���������ʱ���ļ�����</param>
        /// <param name="content">�ļ��ֽ���</param>
        /// <param name="mimeType">ý������</param>
        public FileItem(String fileName, byte[] content, String mimeType)
            : this(fileName, content)
        {
            if (string.IsNullOrEmpty(mimeType)) throw new ArgumentNullException("mimeType");
            this.mimeType = mimeType;
        }

        public string GetFileName()
        {
            if (this.fileName == null && this.fileInfo != null && this.fileInfo.Exists)
            {
                this.fileName = this.fileInfo.FullName;
            }
            return this.fileName;
        }

        //public string GetMimeType()
        //{
        //    if (this.mimeType == null)
        //    {
        //        this.mimeType = TopUtils.GetMimeType(GetContent());
        //    }
        //    return this.mimeType;
        //}

        public byte[] GetContent()
        {
            if (this.content == null && this.fileInfo != null && this.fileInfo.Exists)
            {
                using (Stream fileStream = this.fileInfo.OpenRead())
                {
                    this.content = new byte[fileStream.Length];
                    fileStream.Read(content, 0, content.Length);
                }
            }

            return this.content;
        }
    }
}
