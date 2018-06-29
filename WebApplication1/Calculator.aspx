<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplication1.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Calculator</title>
    	


<link href="~/main.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
</head>
<body>
    <form id="form1" method="post" runat="server">
        <div id="container">


            <div id="calculator">


                &nbsp;&nbsp;
                <br />
                <div id="TextFields">
                    &nbsp;&nbsp;
                    <asp:Label id="tbValues" runat="server" class="fields" style="text-align:right; Width:100px;height:40px"></asp:Label>
                    <asp:Label id="tbResult" runat="server" class="fields" style="text-align:left; Width:100px;height:40px"></asp:Label>
                </div>

                <div id="buttonsPanel">

                    <div id="addPanel">

                         <asp:Button id="ButtonPower" class="buttons" type="button" runat="server" onclick="ButtonPower_Click" Text="^2" />  <asp:Button id="ButtonPercent" class="buttons" type="button" runat="server" onclick="ButtonPercent_Click" Text="%" />  <asp:Button id="ButtonRad" class="buttons" type="button" runat="server" onclick="ButtonRad_Click" Text="(sqrt)" /><br />
                         <asp:Button id="ButtonMul" class="buttons" type="button" runat="server" onclick="ButtonMul_Click" Text="*" /> <asp:Button id="ButtonDiv" class="buttons" type="button" runat="server" onclick="ButtonDiv_Click" Text="/" />  <asp:Button id="ButtonClear" class="buttons" type="button" runat="server" onclick="ButtonClear_Click" Text="C" /><br />
                         <asp:Button id="ButtonAdd" class="buttons" type="button" runat="server" onclick="ButtonAdd_Click" Text="+" /> <asp:Button id="ButtonSubb" class="buttons" type="button" runat="server" onclick="ButtonSubb_Click" Text="-" /><br />
                         <asp:Button id="ButtonResult" style="width:103px" class="buttons" type="button" runat="server" onclick="ButtonResult_Click" Text="=" />

                    </div>
                    <br />

                    <asp:Button id="Button1" class="buttons" type="button" runat="server" onclick="Button1_Click" Text="1" /> <asp:Button id="Button2" class="buttons" type="button" runat="server" onclick="Button2_Click" Text="2" /><asp:Button id="Button3" class="buttons" type="button" runat="server" onclick="Button3_Click" Text="3" />
                    <br />
                    <asp:Button id="Button4" class="buttons" type="button" runat="server"  onclick="Button4_Click" Text="4" /> <asp:Button id="Button5" class="buttons" type="button" runat="server" onclick="Button5_Click" Text="5" /><asp:Button id="Button6" class="buttons" type="button" runat="server" onclick="Button6_Click" Text="6" /> <br />
                    <asp:Button id="Button7" class="buttons" type="button" runat="server" onclick="Button7_Click" Text="7" /> <asp:Button id="Button8" class="buttons" type="button" runat="server" onclick="Button8_Click" Text="8" /><asp:Button id="Button9" class="buttons" type="button" runat="server" onclick="Button9_Click" Text="9" /><br />
                    <asp:Button id="Button0" style="width:100px" class="buttons" type="button" runat="server" onclick="Button0_Click" Text="0" /> <asp:Button id="ButtonD" class="buttons" type="button" runat="server" onclick="ButtonD_Click" Text="," />
                </div>

            </div>
        </div>

    </form>
</body>
</html>
