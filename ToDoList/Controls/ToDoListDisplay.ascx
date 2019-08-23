<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ToDoListDisplay.ascx.cs" Inherits="ToDoList.Controls.ToDoListDisplay" %>

<asp:repeater id="TODOsRepeater" runat="server" onitemcommand="TODOs_ItemCommand">
            <headertemplate>
                <table>
                    <tr>
                        <th>Description</th>
                        <th>Priority</th>
                    </tr>
            </headertemplate>
            <itemtemplate>
                <tr>
                    <td>
                        <asp:label id="RepeaterDescription" runat="server" 
                            text='<%# Eval("Description") %>'
                            font-strikeout='<%# Eval("Done") %>' />
                    </td>

                    <td>

                        <pre>     <asp:label ID="RepeaterPriority" runat ="server"
                            text='<%# Eval("Priority") %>'
                            visible='<%# !((bool)Eval("Done")) %>' /></pre>
                    </td>

                    <td>
                        <pre>   <asp:button id="RepeaterDone" runat="server" text="Done"
                            commandname="Done" 
                            commandargument='<%# Container.ItemIndex %>'
                            visible='<%# !((bool)Eval("Done")) %>' /></pre>
                    </td>
                </tr>
            </itemtemplate>
            <footertemplate>
                </table>
            </footertemplate>
        </asp:repeater>