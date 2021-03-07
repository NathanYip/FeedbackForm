<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="FeedbackForm.Feedback" %>

<asp:SqlDataSource ID="_Feedback" runat="server" ConnectionString="<%$ ConnectionStrings:FeedbackConnectionString %>" SelectCommand="SELECT * FROM [Feedback]"></asp:SqlDataSource>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Feedback Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName"  placeholder="Name" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress"  placeholder="Address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email Address</td>
                    <td>
                        <asp:TextBox ID="txtEmail"  placeholder="Email Address" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>comments</td>
                    <td>
                        <asp:TextBox ID="txtComment" runat="server" placeholder="Comments" Height="220px" Width="498px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>

            </table>

        </div>

    </form>
</body>
</html>
