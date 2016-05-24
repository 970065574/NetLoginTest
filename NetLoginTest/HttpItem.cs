using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetLoginTest
{
    //http请求参考类
    class HttpItem
    {
        private string _URL = String.Empty;
        //请求方式默认为GET方式,当为POST方式时必须设置Postdata的值 
        private string _Method = "GET";
        private int _TimeOut = 100000;
        //默认写入post数据超时时间
        private int _ReadWriteTimeOut = 30000;
        //指示是否与 Internet 资源建立持久性连接 默认为true。  
        private Boolean _KeepAlive = false;
        //请求标头值
        private string _Accept = "text/html, application/xhtml+xml, */*";
        //请求返回类型
        private string _ContentType = "text/html";
        //客户端访问信息
        private string _UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
        //返回数据默认编码为null，可以自动识别，一般为utf-8，gbk，jb2312
        Encoding _Encoding = null;
        //post数据类型
        private HttpResult.PostDataType _PostDataType = HttpResult.PostDataType.String;
        //post请求时要发送的post数据 字符串
        private string _PostData = String.Empty;
        //post请求时要发送的post数据 byte
        private byte[] _PostDataByte = null;
        //设置代理对象，不想使用IE默认配置就设置为NULL，而且不要设置ProxyIP
        private WebProxy _WebProcxy;
        private CookieCollection cookieCollection = null;
        private string _Cookie = String.Empty;
        //来源地址，上次访问的地址
        private string _Referer = String.Empty;
        //证书绝对路径
        private string _CerPath = String.Empty;
        //设置是否为全小写
        private Boolean is2Lower = false;
        //是否是支持跳转页面，查询结果将是跳转后的页面
        private Boolean allowAutoRedirect = false;
        //最大连接数
        private int connectionLimit = 1024;
        //代理服务器用户名
        private string proxyUserName = String.Empty;
        //代理服务器密码
        private string proxyPwd = String.Empty;
        //代理服务IP，如果要设置IE就设置代理ieproxy
        private string proxyIp = String.Empty;
        //请求返回类型
        private HttpResult.ResultType resultType = HttpResult.ResultType.String;
        //header对象
        private WebHeaderCollection header = new WebHeaderCollection();
        //获取或设置用于请求的 HTTP 版本。返回结果:用于请求的 HTTP 版本。默认为 System.Net.HttpVersion.
        private Version _ProtocolVersion;
        // 获取或设置一个 System.Boolean 值，该值确定是否使用 100-Continue 行为。如果 POST 请求需要 100-Continue 响应，则为 true；否则为 false。默认值为 true。 
        private Boolean _Expect100Continue = true;
        //设置509证书集合
        private X509CertificateCollection _ClientCertificates;
        //post参数编码，默认为Def编码
        private Encoding _PostEncoding;
        //Cookie返回类型。默认返回字符串类型
        private HttpResult.ResultCookieType _ResultCookieType = HttpResult.ResultCookieType.String;
        //身份验证信息
        private ICredentials _ICredentials = CredentialCache.DefaultCredentials;
        //将跟随的重定向的最大数目
        private int _MaximumAutomaticRedirections;
        //获取和设置IfModifiedSince
        private DateTime? _IfModifiedSince = null;
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
        public string Method
        {
            get { return _Method; }
            set { _Method = value; }
        }
        public int TimeOut
        {
            get { return _TimeOut; }
            set { _TimeOut = value; }
        }
        public int ReadWriteTimeOut
        {
            get { return _ReadWriteTimeOut; }
            set { _ReadWriteTimeOut = value; }
        }
        public Boolean KeepAlive
        {
            get { return _KeepAlive; }
            set { _KeepAlive = value; }
        }
        public string Accept
        {
            get { return _Accept; }
            set { _Accept = value; }
        }
        public string ContentType
        {
            get { return _ContentType; }
            set { _Accept = value; }
        }
        public string UserAgent
        {
            get { return _UserAgent; }
            set { _UserAgent = value; }
        }
        public Encoding Encoding
        {
            get { return _Encoding; }
            set { _Encoding = value; }
        }
        public HttpResult.PostDataType PostDataType
        {
            get { return _PostDataType; }
            set { _PostDataType = value; }
        }
        public string PostData
        {
            get { return _PostData; }
            set { _PostData = value; }
        }
        public byte[] PostDataByte
        {
            get { return _PostDataByte; }
            set { _PostDataByte = value; }
        }
        public WebProxy WebProcy
        {
            get { return _WebProcxy; }
            set { _WebProcxy = value; }
        }
        public CookieCollection CookieCollection
        {
            get { return cookieCollection; }
            set { cookieCollection = value; }
        }
        public string Cookie
        {
            get { return _Cookie; }
            set { _Cookie = value; }
        }
        public string Referer
        {
            get { return _Referer; }
            set { _Referer = value; }
        }
        public string CerPath
        {
            get { return _CerPath; }
            set { _CerPath = value; }
        }
        public Boolean Is2Lower
        {
            get { return is2Lower; }
            set { is2Lower = value; }
        }
        public Boolean AllowAutoRedirect
        {
            get { return allowAutoRedirect; }
            set { allowAutoRedirect = value; }
        }
        public int ConnectionLimit
        {
            get { return connectionLimit; }
            set { connectionLimit = value; }
        }
        public string ProxyUserName
        {
            get { return proxyUserName; }
            set { proxyUserName = value; }
        }
        public string ProxyPwd
        {
            get { return proxyPwd; }
            set { proxyPwd = value; }
        }
        public string ProxyIp
        {
            get { return proxyIp; }
            set { proxyIp = value; }
        }
        public HttpResult.ResultType ResultType
        {
            get { return resultType; }
            set { resultType = value; }
        }
        public WebHeaderCollection Header
        {
            get { return header; }
            set { header = value; }
        }
        public Version ProtocolVersion
        {
            get { return _ProtocolVersion; }
            set { _ProtocolVersion = value; }
        }
        public Boolean Expect100Continue
        {
            get { return _Expect100Continue; }
            set { _Expect100Continue = value; }
        }
        public X509CertificateCollection ClientCertificates
        {
            get { return _ClientCertificates; }
            set { _ClientCertificates = value; }
        }
        public Encoding PostEncoding
        {
            get { return _PostEncoding; }
            set { _PostEncoding = value; }
        }
        public HttpResult.ResultCookieType ResultCookieType
        {
            get { return _ResultCookieType; }
            set { _ResultCookieType = value; }
        }
        public ICredentials ICredentials
        {
            get { return _ICredentials; }
            set { _ICredentials = value; }
        }
        public int MaximumAutomaticRedirections
        {
            get { return _MaximumAutomaticRedirections; }
            set { _MaximumAutomaticRedirections = value; }
        }
        public DateTime? IfModifiedSince
        {
            get { return _IfModifiedSince; }
            set { _IfModifiedSince = value; }
        }
    }
}
