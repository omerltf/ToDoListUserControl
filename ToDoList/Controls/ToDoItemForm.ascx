<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ToDoItemForm.ascx.cs" Inherits="ToDoList.Controls.ToDoItemForm" %>

<h2>Add New TODO</h2>

<asp:TextBox ID="TODODescription" runat="server" />
<asp:DropDownList ID="TODOPriority" runat="server">
    <asp:ListItem Text="1"></asp:ListItem>
    <asp:ListItem Text="2"></asp:ListItem>
    <asp:ListItem Text="3"></asp:ListItem>
</asp:DropDownList>
<asp:Button ID="TODOSubmit" runat="server" Text="Submit" OnClick="Submit_Click" />
<br />
<asp:Label ID="ErrorMessage" runat="server" Text="Please provide a description." ForeColor="Red" Visible="false" />
