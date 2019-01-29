<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewEmployee.aspx.cs" Inherits="Employ_Project.viewEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:gridview ID="grdView" AutoGenerateColumns="false" runat="server" OnRowCommand="grdView_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Employ_id" HeaderText="ID" />
                    <asp:BoundField DataField="Employ_name" HeaderText="Name" />
                    <asp:BoundField DataField="Employ_salary" HeaderText="Salary" />
                    <asp:BoundField DataField="Employ_dept" HeaderText="Department" />


                    <asp:TemplateField>
                        <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="cmdEdit" CommandArgument='<%# Eval("Employ_id") %>'/> 
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="cmdDelete" CommandArgument='<%# Eval("Employ_id") %>'/>
                         </ItemTemplate>
                    </asp:TemplateField>


                </Columns>
            </asp:gridview>
        </div>
    </form>
</body>
</html>

