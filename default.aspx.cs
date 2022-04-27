using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevPool
{
    public partial class _default : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {//load  ครั้งแรก
                Session["countAll"] = 0;

                Session["memberGroup1"] = null;
                Session["memberGroup2"] = null;
                Session["memberGroup3"] = null;
                Session["memberGroup4"] = null;
                var memberGroup1 = (List<String>)Session["memberGroup1"];
                var memberGroup2 = (List<String>)Session["memberGroup2"];
                var memberGroup3 = (List<String>)Session["memberGroup3"];
                var memberGroup4 = (List<String>)Session["memberGroup4"];





                // เช็คว่าแต่ละกลุ่มเต็มหรือยัง
                string Group1IsMax = "";
                Session["Group1IsMax"] = Group1IsMax;
                string Group2IsMax = "";
                Session["Group2IsMax"] = Group2IsMax;
                string Group3IsMax = "";
                Session["Group3IsMax"] = Group3IsMax;
                string Group4IsMax = "";
                Session["Group4IsMax"] = Group4IsMax;
                string GroupAllIsMax = "";
                Session["GroupAllIsMax"] = GroupAllIsMax;





            }
            else
            {



                LabelError.Text = "";
                try
                {


                    // 4 Group
                    /*
                     LabelGroup1  ก็อดดริก กริฟฟินดอร์
                       LabelGroup2 เฮลก้า ฮัฟเฟิลพัฟ
                        LabelGroup3 โรวีน่า เรเวนคลอ

                      LabelGroup4  ซัลลาซาร์ สลีธีริน

                        LabelTotal 
                    */

                    // LabelShow.Text = setPrepareName[0];





                    //countall() นับจำนวนทั้งหมด เพื่อแสดง

                    countall();
                }
                catch (Exception ex)
                {
                    LabelError.Text += ex.Message;

                }

            }//end postback



            countall();
        } // end load





        //สุ่มชื่อ
        protected void ButtonRandom_Click(object sender, EventArgs e)
        {

            string[] setPrepareName = new string[] { "สุภาภร ครื้นจิต","ธัญญรัชต์ สาระชาติ",
"jaejaewife","ปิ่น กมลนัทธ์","ส*******","ธนาภา ธนกิจวาณิชกุล","ศศิวิภา ฉันทพัชนี","ณัฐชยา สังข์เกษม","พัชราวดี วิตตะ","บราลี ญาโนภาส",
"เจตธิดา หล่อลักษณ์","ปรารถนา พ่วงบางโพ",
"เอก วิตตะ","นิติ นิจนิติกุล","ภัทรวรินทร์ บริรักษ์",
"อารยา","นายวิษณุ เกิดสินธ์ชัย","วิทยา เกิดสินธ์ชัย","จุฑามาศ อรพินท์พิศุทธิ์","พริมา ถิระบัญชาศักดิ์","ปุณยวีร์ เรืองอร่าม",
"ชาลิสา พงษ์พันธุ์","NUTA","ชลาลัย วีระโสภณ","ธันยรัศมิ์ ช่อเพ็ชรไทย",
"ธิติสุดา ช่วยนาเขต","มณฑีรัชต์ หาญมงคลชัย","อริศรา ผะเดิมชิต","พักตร์วิภา สมจิตร","ธราณัฏฐ์ ชินประพินพร","ธิดาสรวง คำดี","พิชญาภา","ณัฐภัทร เทียนสุวรรณ","ประกาศิต","แพรวรรณ รุ่งวชิรา","แพรวา รุ่งวชิรา",
"กรณัฐ วงศ์ศรีศรศักดิ์","ณัฐริณีย์ บุญประคอง","วรรณภา กำจัดภัย","ภัทรวดี ล้อมวงศ์","อินทัช วัจนะพุกกะ","ทักษพร ลีลารุ่งโรจน์","รดารัตน์ ปิยะวรรณรัตน์","กัณฑ์กวี","กานพลู เอี่ยมสอาด","พุฒิพงศ์ อยู่สบาย","ธนเสฏฐ์ ธนภูริพรรธน์","เพชรอาภรณ์ ชลพัฒนา","นพร เสถียรพงศ์","ศุภาภัค ศิริประยูร","ปิยวดี","ภัทรศยา","จิราพร สารินทร์","ศรัญญา ดวงดี","ภัทรพงศ์ ดิษฐกรโภคิน","ศศินา เอกศิรสุวรรณ","ปรีชญา เดชศรี","ญาณิศา ขวัญจันทร์","ปณิธาน พรไพบูลย์","ธมนต์ลักษณ์ ","ภาณุมาศ","ธนพร ภาณุมาศ",
 "jaejaewife","ปิ่น กมลนัทธ์","ส*******","ธนาภา ธนกิจวาณิชกุล","ศศิวิภา ฉันทพัชนี","ณัฐชยา สังข์เกษม","พัชราวดี วิตตะ","บราลี ญาโนภาส",
"เจตธิดา หล่อลักษณ์","ปรารถนา พ่วงบางโพ",
"เอก วิตตะ","นิติ นิจนิติกุล","ภัทรวรินทร์ บริรักษ์",
"อารยา","นายวิษณุ เกิดสินธ์ชัย","วิทยา เกิดสินธ์ชัย","จุฑามาศ อรพินท์พิศุทธิ์","พริมา ถิระบัญชาศักดิ์","ปุณยวีร์ เรืองอร่าม",
"ชาลิสา พงษ์พันธุ์","NUTA","ชลาลัย วีระโสภณ","ธันยรัศมิ์ ช่อเพ็ชรไทย",
"ธิติสุดา ช่วยนาเขต","มณฑีรัชต์ หาญมงคลชัย","อริศรา ผะเดิมชิต","พักตร์วิภา สมจิตร","ธราณัฏฐ์ ชินประพินพร","ธิดาสรวง คำดี","พิชญาภา","ณัฐภัทร เทียนสุวรรณ","ประกาศิต","แพรวรรณ รุ่งวชิรา","แพรวา รุ่งวชิรา",
"กรณัฐ วงศ์ศรีศรศักดิ์","ณัฐริณีย์ บุญประคอง","วรรณภา กำจัดภัย","ภัทรวดี ล้อมวงศ์","อินทัช วัจนะพุกกะ","ทักษพร ลีลารุ่งโรจน์","รดารัตน์ ปิยะวรรณรัตน์","กัณฑ์กวี","กานพลู เอี่ยมสอาด","พุฒิพงศ์ อยู่สบาย","ธนเสฏฐ์ ธนภูริพรรธน์","เพชรอาภรณ์ ชลพัฒนา","นพร เสถียรพงศ์","ศุภาภัค ศิริประยูร","ปิยวดี","ภัทรศยา","จิราพร สารินทร์","ศรัญญา ดวงดี","ภัทรพงศ์ ดิษฐกรโภคิน","ศศินา เอกศิรสุวรรณ","ปรีชญา เดชศรี","ญาณิศา ขวัญจันทร์","ปณิธาน พรไพบูลย์","ธมนต์ลักษณ์ ","ภาณุมาศ","ธนพร ธมนต์ลักษณ์" ,
"jaejaewife","ปิ่น กมลนัทธ์","ส*******","ธนาภา ธนกิจวาณิชกุล","ศศิวิภา ฉันทพัชนี","ณัฐชยา สังข์เกษม","พัชราวดี วิตตะ","บราลี ญาโนภาส",
"เจตธิดา หล่อลักษณ์","ปรารถนา พ่วงบางโพ",
"เอก วิตตะ","นิติ นิจนิติกุล","ภัทรวรินทร์ บริรักษ์",
"อารยา","นายวิษณุ เกิดสินธ์ชัย","วิทยา เกิดสินธ์ชัย","จุฑามาศ อรพินท์พิศุทธิ์","พริมา ถิระบัญชาศักดิ์","ปุณยวีร์ เรืองอร่าม",
"ชาลิสา พงษ์พันธุ์","NUTA","ชลาลัย วีระโสภณ","ธันยรัศมิ์ ช่อเพ็ชรไทย",
"ธิติสุดา ช่วยนาเขต","มณฑีรัชต์ หาญมงคลชัย","อริศรา ผะเดิมชิต","พักตร์วิภา สมจิตร","ธราณัฏฐ์ ชินประพินพร","ธิดาสรวง คำดี","พิชญาภา","ณัฐภัทร เทียนสุวรรณ","ประกาศิต","แพรวรรณ รุ่งวชิรา","แพรวา รุ่งวชิรา",
"กรณัฐ วงศ์ศรีศรศักดิ์","ณัฐริณีย์ บุญประคอง","วรรณภา กำจัดภัย","ภัทรวดี ล้อมวงศ์","อินทัช วัจนะพุกกะ","ทักษพร ลีลารุ่งโรจน์","รดารัตน์ ปิยะวรรณรัตน์","กัณฑ์กวี","กานพลู เอี่ยมสอาด","พุฒิพงศ์ อยู่สบาย","ธนเสฏฐ์ ธนภูริพรรธน์","เพชรอาภรณ์ ชลพัฒนา","นพร เสถียรพงศ์","ศุภาภัค ศิริประยูร","ปิยวดี","ภัทรศยา","จิราพร สารินทร์","ศรัญญา ดวงดี","ภัทรพงศ์ ดิษฐกรโภคิน","ศศินา เอกศิรสุวรรณ","ปรีชญา เดชศรี","ญาณิศา ขวัญจันทร์","ปณิธาน พรไพบูลย์","ธมนต์ลักษณ์ ","ภาณุมาศ","ธนพร พรไพบูลย์"};


            Random rand = new Random();
            int i = rand.Next(0, 70);


            TextBoxName.Text = setPrepareName[i];





        }//end สุ่มชื่อ


        //เริ่มสุ่มห้อง
        protected void ButtonRun_Click(object sender, EventArgs e)
        {
            LabelError.Text = "";
            if (TextBoxName.Text == "")
            {
                LabelError.Text = "กรูณากรอกชื่อ นามสกุล หากคิดไม่ออก กดปุ่มสุ่มชื่อได้เลย";
            }
            else
            {



                //test

                int countAll = 0;


                //เช็คแต่ละกลุ่มว่าเต็มยัง ถ้าเต็ม set ismax = 1


                var memberGroup1 = (List<String>)Session["memberGroup1"];
                var memberGroup2 = (List<String>)Session["memberGroup2"];
                var memberGroup3 = (List<String>)Session["memberGroup3"];
                var memberGroup4 = (List<String>)Session["memberGroup4"];




                LabelShow.Text = "";
                int countGroup1 = 0;
                int countGroup2 = 0;
                int countGroup3 = 0;
                int countGroup4 = 0;

                try
                {
                    countGroup1 = memberGroup1.Count();
                }
                catch
                {
                    countGroup1 = 0;
                }

                try
                {
                    countGroup2 = memberGroup2.Count();
                }
                catch
                {
                    countGroup2 = 0;
                }

                try
                {
                    countGroup3 = memberGroup3.Count();
                }
                catch
                {
                    countGroup3 = 0;
                }

                try
                {
                    countGroup4 = memberGroup4.Count();
                }
                catch
                {
                    countGroup4 = 0;
                }

                try
                {
                    countAll = countGroup1 + countGroup2 + countGroup3 + countGroup4;
                }
                catch
                {
                    countAll = 0;
                }





                if (countGroup1 > 12)
                {
                    Session["Group1IsMax"] = "1";
                }

                if (countGroup2 > 12)
                {
                    Session["Group2IsMax"] = "1";
                }

                if (countGroup3 > 12)
                {
                    Session["Group3IsMax"] = "1";
                }

                if (countGroup4 > 12)
                {
                    Session["Group4IsMax"] = "1";
                }


                //calculate  แบ่งเป็น 4 กลุ่ม

                int countname = TextBoxName.Text.Length;

                int result = (countname % 4) + 1;








                //  คราวนี้ เช็คว่า  แต่ละกลุ่ม ครบ 13 หรือยัง    ถ้าเกินแล้ว  ให้ไปกลุ่มอื่น








                //เช็คว่าครบ 50 หรือยัง
                if (countAll > 49)
                {
                    Session["GroupAllIsMax"] = "1";
                }





                if (Session["GroupAllIsMax"].ToString() == "1")
                {
                    LabelError.Text = "คนครบ 50 คน แล้ว";
                } //end if GroupAllIsMax
                else
                {


                    if ((result == 1) && (Session["Group1IsMax"].ToString() == "1"))
                    {

                        //ย้ายไปกลุ่ม 2
                        result = 2;

                    }



                    if ((result == 2) && (Session["Group2IsMax"].ToString() == "1"))
                    {

                        //ย้ายไปกลุ่ม 3
                        result = 3;

                    }

                    if ((result == 3) && (Session["Group3IsMax"].ToString() == "1"))
                    {

                        //ย้ายไปกลุ่ม 4
                        result = 4;

                    }

                    if ((result == 4) && (Session["Group4IsMax"].ToString() == "1"))
                    {

                        //ย้ายไปกลุ่ม 1
                        result = 1;

                    }



                    try
                    {


                        if (result == 1)
                        {
                            addgroup1(TextBoxName.Text);
                        }

                        if (result == 2)
                        {
                            addgroup2(TextBoxName.Text);
                        }

                        if (result == 3)
                        {
                            addgroup3(TextBoxName.Text);
                        }

                        if (result == 4)
                        {
                            addgroup4(TextBoxName.Text);
                        }










                    }//end try
                    catch (Exception ex)
                    {

                        LabelError.Text = ex.Message;
                    }//end catch


                } //end else GroupAllIsMax
                countall();


                TextBoxName.Text = "";
            }
        }//end สุ่มห้อง



        //add group1
        public void addgroup1(string name)
        {


            List<string> memberGroup1 = new List<string>();
            if (Session["memberGroup1"] != null)
            {
                memberGroup1 = (List<String>)Session["memberGroup1"];
            }

            memberGroup1.Add(name);

            Session["memberGroup1"] = memberGroup1;

            LabelShow.Text = "คุณได้อยู่ห้อง ก็อดดริก กริฟฟินดอร์";
        } //end group 1



        //add group2
        public void addgroup2(string name)
        {
            List<string> memberGroup2 = new List<string>();
            if (Session["memberGroup2"] != null)
            {
                memberGroup2 = (List<String>)Session["memberGroup2"];
            }
            memberGroup2.Add(name);

            Session["memberGroup2"] = memberGroup2;
            LabelShow.Text = "คุณได้อยู่ห้อง เฮลก้า ฮัฟเฟิลพัฟ";

        } //end group 2

        //add group3
        public void addgroup3(string name)
        {
            List<string> memberGroup3 = new List<string>();

            if (Session["memberGroup3"] != null)
            {
                memberGroup3 = (List<String>)Session["memberGroup3"];
            }

            memberGroup3.Add(name);

            Session["memberGroup3"] = memberGroup3;
            LabelShow.Text = "คุณได้อยู่ห้อง โรวีน่า เรเวนคลอ";
        } //end group 3


        //add group4
        public void addgroup4(string name)
        {

            List<string> memberGroup4 = new List<string>();

            if (Session["memberGroup4"] != null)
            {
                memberGroup4 = (List<String>)Session["memberGroup4"];
            }

            memberGroup4.Add(name);

            Session["memberGroup4"] = memberGroup4;

            LabelShow.Text = "คุณได้อยู่ห้อง ซัลลาซาร์ สลีธีริน ";
        } //end group 4


        //count
        public void countall()
        {




            var memberGroup1 = (List<String>)Session["memberGroup1"];
            var memberGroup2 = (List<String>)Session["memberGroup2"];
            var memberGroup3 = (List<String>)Session["memberGroup3"];
            var memberGroup4 = (List<String>)Session["memberGroup4"];

            int countGroup1 = 0;
            int countGroup2 = 0;
            int countGroup3 = 0;
            int countGroup4 = 0;
            int countAll = 0;
            try
            {
                countGroup1 = memberGroup1.Count();
            }
            catch
            {
                countGroup1 = 0;
            }

            try
            {
                countGroup2 = memberGroup2.Count();
            }
            catch
            {
                countGroup2 = 0;
            }

            try
            {
                countGroup3 = memberGroup3.Count();
            }
            catch
            {
                countGroup3 = 0;
            }

            try
            {
                countGroup4 = memberGroup4.Count();
            }
            catch
            {
                countGroup4 = 0;
            }

            try
            {
                countAll = countGroup1 + countGroup2 + countGroup3 + countGroup4;
            }
            catch
            {
                countAll = 0;
            }


            LabelGroup1.Text = countGroup1.ToString();
            LabelGroup2.Text = countGroup2.ToString();
            LabelGroup3.Text = countGroup3.ToString();
            LabelGroup4.Text = countGroup4.ToString();
            LabelTotal.Text = countAll.ToString();

            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            for (int i = 0; i < countGroup1; i++)
            {
                Label1.Text += memberGroup1[i];
                Label1.Text += "<br />";
            }
            for (int i = 0; i < countGroup2; i++)
            {
                Label2.Text += memberGroup2[i];
                Label2.Text += "<br />";
            }
            for (int i = 0; i < countGroup3; i++)
            {
                Label3.Text += memberGroup3[i];
                Label3.Text += "<br />";
            }
            for (int i = 0; i < countGroup4; i++)
            {
                Label4.Text += memberGroup4[i];
                Label4.Text += "<br />";
            }

        }//endd count all



    } //end class
}