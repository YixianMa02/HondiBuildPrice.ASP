<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HondiBuildPrice.ASP.index" %>

<!DOCTYPE html>
<!-- 
    Author: Yixian Ma
    Created at: 2021-10-22
    -->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hondi Build & Price</title>
    <style>
        .center-text{
            text-align:center;
        }
        .column1-width{
            width:130px;
        }
        .column2-width{
            width:270px;
        }
        .form{
            height:700px;
        }
        .CarInfoHeight{
            height:120px;
        }
        .backColor{
            background-color:azure;
        }
        .panColor{
            background-color:aquamarine;
        }
        .hide{
            overflow:hidden;
        }
        .btn{
            border:1px solid #563d7c;
            border-radius:8px;
            padding: 8px 5px 8px 5px;
            color: white;
            background-color:darkblue;
        }
    </style>
</head>
<body class="backColor">
    <form id="form1" runat="server" class="form">
        <div class="center-text">
            <h1>HONDI BUILD & PRICE</h1>
            <table align="center">
                <tr>
                    <td>
                        <asp:Image ID="imgLogo" runat="server" Height="100px" Width="100px" ImageUrl="~/logo.png"/>
                    </td>
                </tr>
            </table>
        </div>

        <hr />
        <br />

        <table>
            <tr style="vertical-align:top">
                <td class="CarInfoHeight">
                    <asp:Panel ID="panCarInfo" runat="server" GroupingText="Car Information" Height="100%" Width="400px" CssClass="panColor">
                        <table>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblCity" runat="server" Text="Your City: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:TextBox ID="txtCity" runat="server" Width="100px" CssClass="center-text"></asp:TextBox>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblZipCode" runat="server" Text="Zip Code: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:TextBox ID="txtZipCode" runat="server" Width="100px" CssClass="center-text"></asp:TextBox>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblCarModel" runat="server" Text="Select Car Model: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:DropDownList ID="cboCar" runat="server" Width="200px" AutoPostBack="true" OnSelectedIndexChanged="cboCar_SelectedIndexChanged" CssClass="center-text"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblInteriorColor" runat="server" Text="Interior Color: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:ListBox ID="lstColor" runat="server" AutoPostBack="true" Width="150px" Rows="3" CssClass="hide"></asp:ListBox>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblAccessories" runat="server" Text="Accessories: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:CheckBoxList ID="chklstAccessories" runat="server" AutoPostBack="true"></asp:CheckBoxList>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblWarranty" runat="server" Text="Warranty: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:RadioButtonList ID="rdlstWarranty" runat="server" AutoPostBack="true"></asp:RadioButtonList>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblContact" runat="server" Text="Dealer Contact you by phone?"></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:CheckBox ID="chkContact" runat="server" AutoPostBack="true" OnCheckedChanged="chkContact_CheckedChanged"/>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>

                            <tr>
                                <td class="column1-width">
                                    <asp:Label ID="lblPhone" runat="server" Text="Phone Number: "></asp:Label>
                                </td>
                                <td class="column2-width">
                                    <asp:TextBox ID="txtPhone" runat="server" Width="100px" CssClass="center-text"></asp:TextBox>
                                </td>
                            </tr>

                            <tr> <td>&nbsp;</td> </tr>
                        </table>
                    </asp:Panel>
                </td>

                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>

                <td class="CarInfoHeight">
                    <asp:Panel ID="panPrice" runat="server" GroupingText="Price Resume" Height="285px" Width="400px" CssClass="panColor">
                        <asp:Literal ID="litPrice" runat="server"></asp:Literal>
                        <asp:Button ID="btnConclude" runat="server" Text="Conclude" OnClick="btnConclude_Click" CssClass="btn"/>
                    </asp:Panel>
                
                    <p>&nbsp;</p>

                    <asp:Panel ID="panFinalinfo" runat="server" GroupingText="Final Information" Height="305px" Width="400px" CssClass="panColor">
                        <asp:Literal ID="litFinal" runat="server"></asp:Literal>
                        <p>&nbsp;</p>
                        <p>&nbsp;</p>
                        <p>&nbsp;</p>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
