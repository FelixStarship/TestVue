using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestVue.Models;

namespace TestVue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vue01()
        {
            return View();
        }

        public ActionResult Vue02()
        {
            return View();
        }
        public ActionResult jsTest()
        {
            return View();
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }

        public ActionResult JSEncrypt()
        {    
            return View();
        }

        public ActionResult Encrypt(string passwd)
        {

            string PrivateKey = @"-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQCZoXqoJktTWSTolirHAFpLdK3w1eaawiKu9q7VQeqghF7S90IJ
FKlawmuLhiEmrOLOqG0AYQOSdX0WSEcRlGH/VKwz5XNOsLutQWSfG2xt4bXT+nAm
qp/nWpeSlNuFYhsCWSjFydAtoUjLBXi0gusaBDpwfgq4zBGXAA7M3uVmTwIDAQAB
AoGBAIZ0khHJ+hDHKws4KdYik+QICReHTRzSnWI9WUQhPYQgdZDzf2LNJ27cSx1A
VZEwrAur0kILpgGvO7udpD1ZfO2Lg3lcBN+CVjp97oJPFCYQdD1yuRRjpvCsrLLu
zzfuSNatYbgS8lCh6HloSB7XThck8W6GbmNJsiYscn6GztUJAkEAvCeDzQKjZxvc
1+VS+dPzOAq8nBVuQES9V5PZM0tHfNuA1J04l0Y4c9mMWsh6YOBsTz46vs5yuCKk
Ptwg6pLlNQJBANEHGdCZJOgKWUg6Xraz38RBM1cPHKzYEmOu1HiNl30wGCuM1b61
8xsDntaHXYHJxYgiudVwzH5Sj2iRVn2CIfMCQALAGR8gEL9rGtlVEtdwD7gcABHQ
BmKOHq5vDNfBG/RpSQLSoYckkaKv5WtWTuOnpC2sXTN41Rh3+SqqERkcuJkCQAFW
HUkjIYRGRKncjax3W+/iRtTAqPtF6mAuxvb6WMSZIR5uKROuEB7VGBfhB60DwDqN
lkiSDwyjtH0DqNzmjxcCQQCvIhCkietd1YSG1Jl7zSmuT3NksNwj4HGYSfMLdkBV
ag8pleWkHqBf9Z1d/qbOkealNgmmiE8JO/vGuM7T0uDw
-----END RSA PRIVATE KEY-----
";


            string PublicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCZoXqoJktTWSTolirHAFpLdK3w
1eaawiKu9q7VQeqghF7S90IJFKlawmuLhiEmrOLOqG0AYQOSdX0WSEcRlGH/VKwz
5XNOsLutQWSfG2xt4bXT+nAmqp/nWpeSlNuFYhsCWSjFydAtoUjLBXi0gusaBDpw
fgq4zBGXAA7M3uVmTwIDAQAB
-----END PUBLIC KEY-----";


            PrivateKey = PrivateKey.Replace("-----BEGIN RSA PRIVATE KEY-----", "")
              .Replace("-----END RSA PRIVATE KEY-----", "");

            PublicKey = PublicKey.Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "");
              RSACrypto rsaCrypto = new RSACrypto(PrivateKey, PublicKey);

       

        //解密 RSA
        
        string pwd = rsaCrypto.Decrypt(passwd);
            return Json(pwd);
       }


    }
}