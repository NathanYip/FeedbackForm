<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitSuccess.aspx.cs" Inherits="FeedbackForm.SubmitSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Submission Sent!</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


        </div>
        You have successfully submitted your feedback!<br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back" />
    </form>
</body>
</html>
