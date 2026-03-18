<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_Age" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Check" runat="server" Text="Submit" OnClick="btn_Check_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Age" runat="server" Text="Age"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Amount" runat="server" Text="Membership"></asp:Label>
        </div>
        <div>
            <br />
            <br />
            <asp:Button ID="btn_Plank" runat="server" Text="Plank Challange" OnClick="btn_Plank_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Plank" runat="server" Text="Plank Challange Output"></asp:Label>
            <br />
        </div>

        <div>
            <br />
            <br />
            Enter your height (m): 
            <asp:TextBox ID="txt_height" runat="server"></asp:TextBox>
            <br />
            <br />

            Enter your weight (kg): 
            <asp:TextBox ID="txt_weight" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_bmi" runat="server" Text="Calculate BMI" OnClick="btn_Bmi_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_bmi" runat="server" Text="Your BMI"></asp:Label>
            <br />
            <br />

        </div>

        <asp:Button ID="btn_run" runat="server" Text="Run" OnClick="btn_Run_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_run" runat="server" Text="Running Lap Output"></asp:Label>
        <br />

        <div>
            <asp:Button ID="btn_name" runat="server" Text="Name" OnClick="btn_Name_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_name" runat="server" Text="Name"></asp:Label>
            <br />

        </div>

        <div>
            Select Intensity:
        <asp:DropDownList ID="ddl_Intensity" runat="server">
            <asp:ListItem Text="Select Intensity" Value="0"></asp:ListItem>
            <asp:ListItem Text="Low (Walk)" Value="1"></asp:ListItem>
            <asp:ListItem Text="Medium (Jog)" Value="2"></asp:ListItem>
            <asp:ListItem Text="High (Run)" Value="3"></asp:ListItem>
        </asp:DropDownList>

            <br />
            <br />
            <asp:Button ID="btn_Suggestion" runat="server" Text="Get Suggestion" OnClick="btn_Suggestion_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Suggestion_Output" runat="server" Text="lbl_Suggestion"></asp:Label>
        </div>

        <div>
            <br />
            Enter your steps count: 
            <asp:TextBox ID="txt_steps_count" runat="server"></asp:TextBox>
            <br />
            <br />

            Enter your active day: 
            <asp:TextBox ID="txt_active_day" runat="server"></asp:TextBox>
            <br />

            <br />
            <br />
            <asp:Button ID="btn_Prize" runat="server" Text="Get Prize" OnClick="btn_Prize_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Prize_Output" runat="server" Text="lbl_Prize"></asp:Label>
        </div>

        <div>
            <br />
            <br />
            <asp:Label ID="lbl_Error" runat="server" Text="Errors Messages!!!"></asp:Label>
        </div>
    </form>
</body>
</html>
