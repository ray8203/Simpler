/*******************************************************************************
 * Copyright © 2016 Simpler.Framework 版权所有
 * Author: Simpler
 * Description: Simpler快速开发平台
 * Website：http://www.Simpler.cn
*********************************************************************************/
using System.Configuration;
using System.Web;

namespace Simpler.Code
{

    public sealed class Licence
    {
        public static bool IsLicence(string key)
        {
            string host = HttpContext.Current.Request.Url.Host.ToLower();
            if (host.Equals("localhost"))
                return true;
            string licence = ConfigurationManager.AppSettings["LicenceKey"];
            if (licence != null && licence == Md5.md5(key, 32))
                return true;

            return false;
        }
        public static string GetLicence()
        {
            var licence = Configs.GetValue("LicenceKey");
            if (string.IsNullOrEmpty(licence))
            {
                licence = Common.GuId();
                Configs.SetValue("LicenceKey", licence);
            }
            return Md5.md5(licence, 32);
        }
    }
}
