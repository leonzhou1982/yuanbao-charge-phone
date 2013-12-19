<%@ Page Language="C#" AutoEventWireup="true" CodeFile="query.aspx.cs" Inherits="query" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<div>
            <table width="100%">
                <tr>
                    <td style="width: 153px">
                        交易号：</td>
                    <td>
                        <input id="txtOrder" runat="server" maxlength="20" name="out_order_id" type="text" /></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 153px">
                    </td>
                    <td>
                        <input id="Submit1" runat="server" onserverclick="Submit1_ServerClick" type="submit"
                            value="submit" /></td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
