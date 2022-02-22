<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P03DynamicznyKodHTML.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <%
            for (int i = 0; i < 10; i++)
            {
                Response.Write("<p>" + Napis + "</p>");
            }
            %>



        <% 
            // string s = "ala ma kota";
            // s = s.ToUpper();

            for (int i = 0; i < 10; i++)
            {
                //Response.Write("<p>"+Napis+"</p>");
                %>
              <p><%= Napis %></p>
              <%--<p><% Response.Write(Napis); %></p>--%>
        <%
            }
            %>


    </form>
</body>
</html>
