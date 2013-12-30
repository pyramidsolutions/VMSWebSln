using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVSThemeTemplateWeb
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

          try
            {
                 lock (this)
                 {
                    context.Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
                    context.Response.ContentType = "image/png";
                    string picture = context.Request.QueryString["image"];
            
                    context.Response.WriteFile(picture);
      
                    context.Response.Flush();
                    context.Response.Close();
                    context.Response.End();
                 }
          }
            catch (Exception e1)
            {
                context.Response.Write(e1.Message);
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