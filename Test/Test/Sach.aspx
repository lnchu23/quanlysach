<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sach.aspx.cs" Inherits="Test.Sach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 293px;
        }
        .auto-style3 {
            width: 293px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Thêm mới" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Mã sách:</td>
                    <td>
                        <asp:TextBox ID="txtMasach" runat="server"></asp:TextBox>
                        (*)</td>
                </tr>
                <tr>
                    <td class="auto-style2">Tên sách:</td>
                    <td>
                        <asp:TextBox ID="txtTensach" runat="server"></asp:TextBox>
                        (*)</td>
                </tr>
                <tr>
                    <td class="auto-style2">Giá bán:</td>
                    <td>
                        <asp:TextBox ID="txtGiaban" runat="server" Height="26px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mô tả:</td>
                    <td>
                        <asp:TextBox ID="txtMota" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ngày cập nhật:</td>
                    <td>
                        <asp:TextBox ID="txtNgaycapnhat" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Số lượng:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtSoluong" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ảnh bìa:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Update" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="422px" DataKeyNames="Masach">
                            <Columns>
                                <asp:BoundField DataField="Masach" HeaderText="Mã sách" />
                                <asp:BoundField DataField="Tensach" HeaderText="Tên sách" />
                                <asp:BoundField DataField="Giaban" HeaderText="Giá bán" />
                                <asp:BoundField DataField="Mota" HeaderText="Mô tả" />
                                <asp:BoundField DataField="Ngaycapnhat" HeaderText="Ngày cập nhật" />
                                <asp:BoundField DataField="Soluongton" HeaderText="Số lượng" />
                                <asp:ImageField DataImageUrlField="Anhbia" HeaderText="Ảnh bìa">
                                </asp:ImageField>
                                <asp:ButtonField CommandName="Edit" Text="Edit" />
                                <asp:ButtonField CommandName="Update" Text="Update" />
                                <asp:ButtonField CommandName="Delete" Text="Delete" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
