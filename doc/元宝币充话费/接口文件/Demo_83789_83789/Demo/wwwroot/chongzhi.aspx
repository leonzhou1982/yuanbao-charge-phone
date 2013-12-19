<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chongzhi.aspx.cs" Inherits="chongzhi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 153px">
                        手机号：</td>
                    <td>
                        <input maxlength="11" name="mobile" type="text" id="txtMobile" runat="server" /></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 153px">
                        面额：</td>
                    <td>
                        <select name="50" id="selValue" runat="server">
                            <option value="30">30</option>
                            <option value="50">50</option>
                            <option value="100">100</option>
                        </select>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 153px">
                        交易号：</td>
                    <td>
                        <input id="txtOrder" maxlength="20" name="out_order_id" type="text" runat="server" /></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 153px">
                    </td>
                    <td>
                        <input type="submit" value="submit" id="Submit1" onserverclick="Submit1_ServerClick" runat="server" /></td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
