using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string name1 = context.Request["name"];
            int age = Convert.ToInt32(context.Request["age"]);
            string isVIP = context.Request["isVIP"];
            //throw new Exception("这个是我故意抛出的异常");
            context.Response.Redirect("http://www.baidu.com");//重定向跳转到百度；
            context.Response.Write("Hello World:" + name1 + "<br>");
            context.Response.Write("你的年龄是：" + age + "<br>");
            if (isVIP == "on")
            {
                context.Response.Write("是否VIP:是VIP");
            }
            else
            {
                context.Response.Write("是否VIP:不是VIP");
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}