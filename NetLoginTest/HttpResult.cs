using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NetLoginTest
{
    //http参数返回类
    class HttpResult
    {
        private string _Cookie;
        private CookieCollection _CookieCollection;
        private string _html = String.Empty;
        //返回的Byte数组 只有ResultType.Byte时才返回数据，其他情况为空
        private byte[] _ResultByte;
        //header对象
        private WebHeaderCollection _Header;
        //状态说明
        private string _StatusDescription;
        private HttpStatusCode _StatusCode;
        public enum ResultType
        {
            //返回字符串 只有html数据
            String,
            //返回字符串和字节流 ReslutByte和html都有数据返回
            Byte
        }
        public enum PostDataType
        {
            //字符串类型，此时编码Encoding可不设置
            String,
            //Byte类型，需要设置postDataByte参数的值编码Encoding为空
            Byte,
            //传文件，postdata必须设置为文件的绝对路径，必须设置Encoding的值
            FilePath
        }
        public enum ResultCookieType
        {
            String,
            //Cookiecollection 格式的Cookie集合同时也返回String类型的Cookie
            CookieCollection
        }
        public string Cookie
        {
            get { return _Cookie; }
            set { _Cookie = value; }
        }
        public CookieCollection CookieCollection
        {
            get { return _CookieCollection; }
            set { _CookieCollection = value; }
        }
        public string Html
        {
            get { return _html; }
            set { _html = value;}
        }
        public byte[] ResultByte
        {
            get { return _ResultByte; }
            set { _ResultByte = value; }
        }
        public WebHeaderCollection Header
        {
            get { return _Header; }
            set { _Header = value; }
        }
        public string StatusDescription
        {
            get { return _StatusDescription; }
            set { _StatusDescription = value; }
        }
        public HttpStatusCode StatusCode
        {
            get { return _StatusCode; }
            set { _StatusCode = value; }
        }
    }
}
