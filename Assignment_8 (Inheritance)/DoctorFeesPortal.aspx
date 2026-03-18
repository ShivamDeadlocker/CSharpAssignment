<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorFeesPortal.aspx.cs" Inherits="DoctorFeesPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                Enter Details of Doctors:
        <br />
            <br />
            Enter the Doctor ID:
        <asp:TextBox ID="txt_DrId" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Doctor Name:
        <asp:TextBox ID="txt_DrName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Consultation Fee :
        <asp:TextBox ID="txt_CFee" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_GeneralPhysician" runat="server" Text="General Physician " OnClick="btn_GeneralPhysician_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Surgeon" runat="server" Text="Surgeon" OnClick="btn_Surgeon_Click" />
            <br />
            <br />
            <asp:Button ID="btn_VisitingDoctor" runat="server" Text="Visiting Doctor" OnClick="btn_VisitingDoctor_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_GeneralPhysician" runat="server" Text="General Physician Charges"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Surgeon" runat="server" Text="Surgeon Charges"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_VisitingDoctor" runat="server" Text="Visiting Doctor Charges"></asp:Label>
    </div>
    </form>
</body>
</html>
