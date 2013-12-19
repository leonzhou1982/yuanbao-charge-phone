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

public partial class query : System.Web.UI.Page
{
    private const string Key = "5ts6KCQMXn58EjOeVOwVU4JhgepluTbqMUrSafrkFKZvGdjHrsSNliopwtcdAgm1";
    private const string Partner = "10001";

    private const string Host = "http://api.99huafei.com/";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit1_ServerClick(object sender, EventArgs e)
    {
        string out_trade_id = txtOrder.Value.Trim();
        string sign = "partner=" + Partner + "&out_trade_id=" + out_trade_id + "&" + Key;
        string directQuery = string.Format("partner=" + Partner + "&out_trade_id=" + out_trade_id + "&sign={0}&charset=utf-8", MD5(sign, "utf-8"));
        string url = Host + "/mobile/directSearch.aspx?" + directQuery;

        Response.Redirect(url);

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
