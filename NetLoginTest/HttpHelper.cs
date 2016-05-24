using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
namespace NetLoginTest
{
    class HttpHelper
    {
        #region 预定义方式变量
        //默认编码方式
        private Encoding encoding = Encoding.Default;
        private Encoding postEncoding = Encoding.Default;
        //HttpwebRequest对象用于发起请求
        private HttpWebRequest request = null;
        //获取影响流的数据对象
        private HttpWebResponse response = null;
        #endregion
        public HttpResult GetHtml(HttpItem item)
        {
            HttpResult result = new HttpResult();
            //准备参数
            try
            {
                SetRequest(item);
            }
            catch(Exception e)
            {
                result.Cookie = String.Empty;
                result.Header = null;
                result.Html = e.Message;
                result.StatusDescription = "配置参数出错:" + e.Message;
                return result;
            }
            //请求数据
            try
            {
                using(response=(HttpWebResponse)request.GetResponse())
                {
                    GetData(item, result);
                }
            }
            catch(WebException e)
            {
                if(e.Response!=null)
                {
                    using (response=(HttpWebResponse)e.Response)
                    {
                        GetData(item, result);
                    }
                }
                else
                {
                    result.Html = e.Message;
                }
            }
            catch(Exception e)
            {
                result.Html = e.Message;
            }
            if (item.Is2Lower)
                result.Html = result.Html.ToLower();
            return result;
        }
        //为请求准备参数
        private void SetRequest(HttpItem item)
        {
            //验证证书
            SetCer(item);
            //设置Header参数
            if(item.Header!=null&&item.Header.Count>0)
            {
                foreach(string key in item.Header.AllKeys)
                {
                    request.Headers.Add(key);
                }
            }
            //设置代理
            SetProxy(item);
        }
        //获取数据的并解析方法
        private void GetData(HttpItem item,HttpResult result)
        {
            //获取statusCode
            result.StatusCode = response.StatusCode;
            //获取StatusDescription
            result.StatusDescription = response.StatusDescription;
            result.Header = response.Headers;
            if(response.Cookies!=null)
            {
                result.CookieCollection = response.Cookies;
            }
            //获取set-cookie
            if(response.Headers["set-cookie"]!=null)
            {
                result.Cookie = response.Headers["set-cookie"];
            }
            //处理网页Byte
            byte[] ResponseByte = GetByte();
        }
        private byte[] GetByte()
        {
            byte[] ResponseByte = null;
            System.IO.MemoryStream _stream = new System.IO.MemoryStream();
            if(response.ContentEncoding!=null&&response.ContentEncoding.Equals("gzip",StringComparison.InvariantCultureIgnoreCase))
            {
                //开始读取流并设置编码方式
                _stream = GetMemoryStream(response.GetResponseStream());
            }
            //获取Byte
            ResponseByte = _stream.ToArray();
            _stream.Close();
            return ResponseByte;
        }
        private MemoryStream GetMemoryStream(Stream streamResponse)
        {
            MemoryStream _stream = new MemoryStream();
            int length = 256;
            Byte[] buffer = new Byte[length];
            int bytesRead = streamResponse.Read(buffer, 0, length);
            while(bytesRead>0)
            {
                _stream.Write(buffer, 0, bytesRead);
                bytesRead = streamResponse.Read(buffer, 0, length);
            }
            return _stream;
        }
        private void SetProxy(HttpItem item)
        {
            bool isIeProxy = false;
            if(!String.IsNullOrEmpty(item.ProxyIp))
            {
                isIeProxy = item.ProxyIp.ToLower().Contains("ieproxy");
            }
            if(!String.IsNullOrEmpty(item.ProxyIp)&&isIeProxy)
            {
                //设置代理服务器
                if(item.ProxyIp.Contains(":"))
                {
                    string[] plist = item.ProxyIp.Split(':');
                    WebProxy myProxy = new WebProxy(plist[0].Trim(), Convert.ToInt32(plist[1].Trim()));
                    myProxy.Credentials = new NetworkCredential(item.ProxyUserName, item.ProxyPwd);
                    request.Proxy = myProxy;
                }
                else
                {
                    //建议连接
                    WebProxy myProxy = new WebProxy(item.ProxyIp, false);
                    //给当前请求对对象
                    myProxy.Credentials = new NetworkCredential(item.ProxyUserName, item.ProxyPwd);
                }
            }
            else if(isIeProxy)
            { }
            else
            {
                request.Proxy=item.WebProcy;
            }
        }
        //设置证书
        private void SetCer(HttpItem item)
        {
            if(!String.IsNullOrEmpty(item.CerPath))
            {
                //这一句一定要写在创建连接的前面。使用回调的方法进行证书验证。  
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(CheckValidationResult);
                //初始化对象，并设置请求的URL
                request = (HttpWebRequest)WebRequest.Create(item.URL);
                SetCerList(item);
                //将证书添加到请求里
                request.ClientCertificates.Add(new X509Certificate(item.CerPath));
          
            }
            else
            {
                //初始化对象，并设置请求的url
                request = (HttpWebRequest)WebRequest.Create(item.URL);
                SetCerList(item);
            }
        }
        //设置多个证书
        private void SetCerList(HttpItem item)
        {
            if(item.ClientCertificates!=null&&item.ClientCertificates.Count>0)
            {
                foreach(X509Certificate c509 in item.ClientCertificates)
                {
                    request.ClientCertificates.Add(c509);
                }
            }
        }
        public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; }
    }
}
