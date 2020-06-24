using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common.Utility
{
    /// <summary>
    /// 文件相关的帮助类
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="filenames"></param>
        /// <returns></returns>
        public static bool ZipFile(params string[] filenames)
        {
            //需要安装DotNetZip
            try
            {
                ZipFile zip = new ZipFile(Encoding.UTF8);
                zip.AddDirectory(@"E:\Code\CSharp-Attribute","");
                //MemoryStream memoryStream = new MemoryStream();
                FileStream fs = new FileStream("测试.zip", FileMode.Create);
                //zip.Save(memoryStream);
                zip.Save(fs);

                //memoryStream.WriteTo(fs);
                //memoryStream.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool SaveFile(Stream stream)
        {
            return true;
        }
    }
}
