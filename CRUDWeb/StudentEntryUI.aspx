<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryUI.aspx.cs" Inherits="CRUDWeb.StudentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            margin-top: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Reg No"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                 <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            </td>
           
        </tr>
    </table>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>

        
        
      
        
        
    
    
    </div>
    </form>
</body>
</html>
