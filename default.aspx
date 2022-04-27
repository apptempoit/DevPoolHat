<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DevPool._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

 
 <link rel="stylesheet" href="css/w3.css">
<link rel="preconnect" href="https://fonts.gstatic.com">
<link href="https://fonts.googleapis.com/css2?family=Kanit:wght@200&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
     <link rel="stylesheet" href="css/animate.min.css">
    <link href="css/aos.css" rel="stylesheet">
    <script src="css/aos.js"></script>
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-colors-highway.css">
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-colors-2018.css">
</head>

   <style>

    body, html {
  height: 100%;
  font-family: 'Kanit', sans-serif;
}

       .auto-style1 {
           height: 38px;
       }

       </style>

<body>
    <form id="form1" runat="server">
        <div>

                    <div class="w3-content w3-border w3-margin-top ">


                        <div class ="w3-row">

                            <div class="w3-half w3-border w3-border-black w3-light-blue"> 
                                
                                กรอกชื่อ
                                
                               <br />
                                 <br />


                                
                            <asp:Label ID="LabelName" runat="server" Text="ชื่อ"></asp:Label><asp:TextBox ID="TextBoxName" placeholder="ใส่ชื่อ-สกุล" runat="server"></asp:TextBox>
                            <asp:Button ID="ButtonRandom" runat="server" Text="สุ่มชื่อ" class="w3-button w3-blue" OnClick="ButtonRandom_Click" />


                            <br />      <br />

                            <asp:Button ID="ButtonRun" runat="server" Text="สุ่มห้อง" CssClass="w3-button w3-green" OnClick ="ButtonRun_Click" />


                               <br />      <br />


                            <asp:Label ID="LabelError" runat="server" Text="" CssClass="w3-red"></asp:Label>

                                <br />      <br />


                           <asp:Label ID="LabelShow" runat="server" Text="" CssClass="w3-green "></asp:Label>





                            </div>




                          <div class="w3-half w3-light-green w3-container">แสดงชื่อแต่ละบ้าน



                       <br />
                     

                            <table class="w3-table w3-striped w3-light-grey">
                                <tr>
                                    <td>ชื่อห้อง</td>
                                     <td>จำนวน(คน)</td>
                                </tr>

                                   <tr>
                                    <td>ก็อดดริก กริฟฟินดอร์</td>
                                     <td>       
                                         <asp:Label ID="LabelGroup1" runat="server" Text=""></asp:Label>

                                     </td>
                                </tr>

                                   <tr>
                                    <td>เฮลก้า ฮัฟเฟิลพัฟ</td>
                                       <td>
                                         <asp:Label ID="LabelGroup2" runat="server" Text=""></asp:Label>

                                     </td>
                                </tr>

                                   <tr>
                                    <td>โรวีน่า เรเวนคลอ</td>
                                         <td>
                                         <asp:Label ID="LabelGroup3" runat="server" Text=""></asp:Label>

                                     </td>    </tr>

                                   <tr>
                                    <td>ซัลลาซาร์ สลีธีริน </td>
                                            <td>
                                         <asp:Label ID="LabelGroup4" runat="server" Text=""></asp:Label>

                                     </td>
                                </tr>


                                         <tr class="w3-blue">
                                    <td class="auto-style1 w3-large">รวม</td>
                                     <td class="auto-style1">
                                         <asp:Label ID="LabelTotal" runat="server" Text="" CssClass=" w3-large"></asp:Label>

                                     </td>
                                </tr>


                            </table>



                        </div>
                        
                        </div>





                        <div class="w3-container">
                                    <br />
                            
                            <br />
                            
                            <br />


                                 <table class="w3-table w3-striped w3-light-grey">
                                <tr class="w3-light-blue">
                                    <td>ชื่อห้อง</td>
                                     <td>สมาชิก</td>
                                </tr>

                                   <tr>
                                    <td>ก็อดดริก กริฟฟินดอร์</td>
                                     <td>       
                                         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

                                     </td>
                                </tr>

                                   <tr>
                                    <td>เฮลก้า ฮัฟเฟิลพัฟ</td>
                                       <td>
                                         <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

                                     </td>
                                </tr>

                                   <tr>
                                    <td>โรวีน่า เรเวนคลอ</td>
                                         <td>
                                         <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

                                     </td>    </tr>

                                   <tr>
                                    <td>ซัลลาซาร์ สลีธีริน </td>
                                            <td>
                                         <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

                                     </td>
                                </tr>


                                         <tr>
                    
                                </tr>


                            </table>
  

                            <br />
                            
                            <br />
                            
                            <br />

                        </div>
                                <br />
                            
                            <br />
                            
                            <br />

                        </div>




        </div>
    </form>
</body>
</html>
