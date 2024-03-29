﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ToDoList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TODOs</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>TODOs</h1>
            <h1>These are my ToDos</h1>
            <div>
                <dc:ToDoListDisplay exception="1" runat="server" />
                <dc:ToDoListDisplay exception="2" runat="server" />
                <dc:ToDoListDisplay exception="3" runat="server" />
                <dc:ToDoListDisplay runat="server" />
                <dc:ToDoListDisplay exception="2" limit="5" runat="server" />
            </div>


            <h1>This is my form</h1>
            <div>
                <fc:ToDoItemForm runat="server" />
            </div>

        </div>
    </form>
</body>
</html>
