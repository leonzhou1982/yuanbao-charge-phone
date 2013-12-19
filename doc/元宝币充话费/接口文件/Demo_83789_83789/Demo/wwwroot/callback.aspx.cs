using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

public partial class callback : System.Web.UI.Page
{

    private const string Key = "5ts6KCQMXn58EjOeVOwVU4JhgepluTbqMUrSafrkFKZvGdjHrsSNliopwtcdAgm1";
    private const string Partner = "10001";


    private string charset = "utf-8";
    public override void ProcessRequest(HttpContext context)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["charset"]))
            charset = Request.QueryString["charset"];
        context.Request.ContentEncoding = System.Text.Encoding.GetEncoding(charset);
        base.ProcessRequest(context);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string partner = Request.Form["partner"];
        string result = Request.Form["result"];
        string out_trade_id = Request.Form["out_trade_id"];
        string state = Request.Form["state"];
        string account = Request.Form["account"];
        string product_id = Request.Form["product_id"];
        string quantity = Request.Form["quantity"];
        string price = Request.Form["price"];
        string product_info = Request.Form["product_info"];
        string sign = Request.Form["sign"];
        string newSign = string.Format("partner={0}&result={1}&out_trade_id={2}&state={3}&account={4}&product_id={5}&quantity={6}&price={7}&product_info={8}&{9}"
           , partner, result, out_trade_id, state, account, product_id, quantity, price, product_info, Key);

        if (newSign.Equals(sign, StringComparison.CurrentCultureIgnoreCase))
        {
            if (result == "0")
            {
                if (state == "ok")  //充值成功 
                {
                    //TODO 充值成功做订单处理
                }
                else if (state == "fail" || state == "return")
                {
                    //TODO 充值失败做订单处理
                }
            }
            Response.Write("ok");
            Response.End();
        }
    }


    /** 获取大写的MD5签名结果 */
    private static string MD5(string encypStr, string charset)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] bs = Encoding.GetEncoding(charset).GetBytes(encypStr);
        bs = md5.ComputeHash(bs);
        return BytesToHexString(bs);
    }
    private static string BytesToHexString(byte[] bytes)
    {
        System.Text.StringBuilder s = new System.Text.StringBuilder();
        foreach (byte b in bytes)
        {
            s.Append(b.ToString("x2").ToUpper());
        }
        return s.ToString();
    }
}
