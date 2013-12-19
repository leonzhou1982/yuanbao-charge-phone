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

public partial class chongzhi : System.Web.UI.Page
{
    private const string Key = "5ts6KCQMXn58EjOeVOwVU4JhgepluTbqMUrSafrkFKZvGdjHrsSNliopwtcdAgm1";
    private const string Partner = "10001";
    private const string MyWebSite = "http://www.mywebsite.com";

    private const string Host = "http://api.99huafei.com/";

    protected void Page_Load(object sender, EventArgs e)
    {
        //string province = "广东";

        //string corp = "移动";

        //string value = "1";

       //query = string.Format("partner=" + Partner + "&mobile=" + mobile + "&value=" + value + "&type=0&sign={0}&charset=utf-8", MD5(sign, "utf-8"));

        //sign = "partner=" + partner + "&out_trade_id=" + out_trade_id + "&mobile=" + mobile + "&province=" + province + "&corp=" + corp + "&value=" + value + "&type=0&notify_url=" + callback + "&" + key;
        //direct_sel = string.Format("partner=" + partner + "&out_trade_id=" + out_trade_id + "&mobile=" + mobile + "&province=" + province + "&corp=" + corp + "&value=" + value + "&type=0&notify_url=" + callback + "&sign={0}&charset=utf-8", Utils.MD5(sign, "utf-8"));

        //sign = "partner=" + partner + "&out_trade_id=" + out_trade_id + "&" + key;
        //directQuery = string.Format("partner=" + partner + "&out_trade_id=" + out_trade_id + "&sign={0}&charset=utf-8", Utils.MD5(sign, "utf-8"));     
    }
    protected void Submit1_ServerClick(object sender, EventArgs e)
    {
        if (txtMobile.Value.Trim() == "")
        {
            MsgBox(Page, "请输入手机号");
            return;
        }
        if (txtOrder.Value.Trim() == "")
        {
            MsgBox(Page, "请输入订单号");
            return;
        }
        string direct = GetDirect1(txtMobile.Value.Trim(), selValue.Value.Trim(), txtOrder.Value.Trim());
        Response.Redirect(direct);
    }

    private static string GetDirect1(string mobile, string value, string out_trade_id)
    {
        string sign = "partner=" + Partner + "&mobile=" + mobile + "&value=" + value + "&type=0&" + Key;


        string callback = MyWebSite + "/callback.aspx";

        sign = "partner=" + Partner + "&out_trade_id=" + out_trade_id + "&mobile=" + mobile + "&value=" + value + "&type=0&notify_url=" + callback + "&" + Key;
        string direct = string.Format("partner=" + Partner + "&out_trade_id=" + out_trade_id + "&mobile=" + mobile + "&value=" + value + "&type=0&notify_url=" + callback + "&sign={0}&charset=utf-8", MD5(sign, "utf-8"));

        return Host + "mobile/direct.aspx?" + direct;

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

    /** 获取大写的MD5签名结果 */
    private static string MD5(string encypStr, string charset)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] bs = Encoding.GetEncoding(charset).GetBytes(encypStr);
        bs = md5.ComputeHash(bs);
        return BytesToHexString(bs);
    }

    public static void MsgBox(System.Web.UI.Control control, string message)
    {
        string script = "alert('{0}');";
        control.Page.ClientScript.RegisterStartupScript(control.GetType()
                     , "Msg_" + System.DateTime.Now.Millisecond.ToString()
                     , string.Format(script, message.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\""))
                     , true);
    }
}
