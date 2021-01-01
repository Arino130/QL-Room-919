using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QL_Room_919
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Doc File
            string filePath = @"C:/Program Files (x86)/Room_919/Data_Work.txt";
            string filePath2 = @"C:/Program Files (x86)/Room_919/Crew.txt";
            string[] line;
            string[] name;
            string value;
            string[] @tm=new string[10];
            //update quy
            string filePath4 = @"C:/Program Files (x86)/Room_919/Tien.txt";
            value = System.IO.File.ReadAllText(filePath4);
            tien1.Text = value + " vnd";
            textBox1.Text = "Ghi chú";
            //Cong viec
            if (File.Exists(filePath)&& File.Exists(filePath2))
            {
                MessageBox.Show("File Ok");
                if (System.IO.File.Exists(filePath)&& System.IO.File.Exists(filePath2))
                {
                    line = System.IO.File.ReadAllLines(filePath);
                    for (int i = 0; i < 6; i++)
                    {
                        tm[i] = line[i];
                    }         
                    //name
                    name = System.IO.File.ReadAllLines(filePath2);
                    label2.Text = name[0];
                    label3.Text = name[1];
                    label4.Text = name[2];
                    label5.Text = name[3];
                    

                }                 
                else
                {
                    MessageBox.Show("Khong doc duoc file");
                    Environment.Exit(0);
                }

            }
            else
            {
                MessageBox.Show("File khong ton tai");
                Environment.Exit(0);
            }

            //Cong viec  
            //Khang
            if (tm[0] == "1")
            {
                label1.Text = "Quet nha";
            }
            if (tm[0] == "2")
            {
                label1.Text = "Lau nha";
            }
            if (tm[0] == "3")
            {
                label1.Text = "Nuoc uong";
            }
            if (tm[0] == "4")
            {
                label1.Text = "Ve sinh";
            }
            //Khoa
            if (tm[1] == "1")
            {
                label6.Text = "Quet nha";
            }
            if (tm[1] == "2")
            {
                label6.Text = "Lau nha";
            }
            if (tm[1] == "3")
            {
                label6.Text = "Nuoc uong";
            }
            if (tm[1] == "4")
            {
                label6.Text = "Ve sinh";
            }
            //Phuong
            if (tm[2] == "1")
            {
                label7.Text = "Quet nha";
            }
            if (tm[2] == "2")
            {
                label7.Text = "Lau nha";
            }
            if (tm[2] == "3")
            {
                label7.Text = "Nuoc uong";
            }
            if (tm[2] == "4")
            {
                label7.Text = "Ve sinh";
            }
            //Sang
            if (tm[3] == "1")
            {
                label8.Text = "Quet nha";
            }
            if (tm[3] == "2")
            {
                label8.Text = "Lau nha";
            }
            if (tm[3] == "3")
            {
                label8.Text = "Nuoc uong";
            }
            if (tm[3] == "4")
            {
                label8.Text = "Ve sinh";
            }
        }    
        static void Sap_Xep(String[] @tmsx)
        {
            string temp;
            for (int j = 0; j < 3; j++)
            {
                for (int k = 1; k < 4; k++)
                {
                    temp = tmsx[j];
                    tmsx[j] = tmsx[k];
                    tmsx[k] = temp;
                }
            }
        }
        void Form1button1_Click_1(object sender, EventArgs e)
        {
            string ngay = DateTime.Today.ToString().Trim();
            ngay = ngay.Substring(0, 2);
            string[] line;
            string[] @tm = new string[10];
            string filePath = @"C:/Program Files (x86)/Room_919/Data_Work.txt"; ;

            line = System.IO.File.ReadAllLines(filePath);
            for (int i = 0; i < 5; i++)
            {
                tm[i] = line[i];
            }
            if (tm[4] == ngay)
            {
                MessageBox.Show("Ban da Update cho hom nay !");
            }
            else
            {
                Sap_Xep(tm);

            }
            Ghi_File(tm);
            //Cong viec 
            //Khang
            if (tm[0] == "1")
            {
                label1.Text = "Quet nha";
            }
            if (tm[0] == "2")
            {
                label1.Text = "Lau nha";
            }
            if (tm[0] == "3")
            {
                label1.Text = "Nuoc uong";
            }
            if (tm[0] == "4")
            {
                label1.Text = "Ve sinh";
            }
            //Khoa
            if (tm[1] == "1")
            {
                label6.Text = "Quet nha";
            }
            if (tm[1] == "2")
            {
                label6.Text = "Lau nha";
            }
            if (tm[1] == "3")
            {
                label6.Text = "Nuoc uong";
            }
            if (tm[1] == "4")
            {
                label6.Text = "Ve sinh";
            }
            //Phuong
            if (tm[2] == "1")
            {
                label7.Text = "Quet nha";
            }
            if (tm[2] == "2")
            {
                label7.Text = "Lau nha";
            }
            if (tm[2] == "3")
            {
                label7.Text = "Nuoc uong";
            }
            if (tm[2] == "4")
            {
                label7.Text = "Ve sinh";
            }
            //Sang
            if (tm[3] == "1")
            {
                label8.Text = "Quet nha";
            }
            if (tm[3] == "2")
            {
                label8.Text = "Lau nha";
            }
            if (tm[3] == "3")
            {
                label8.Text = "Nuoc uong";
            }
            if (tm[3] == "4")
            {
                label8.Text = "Ve sinh";
            }
        }
        static void Ghi_File(string[] number)
        {
            string ngay = DateTime.Today.ToString("").Trim();          
            ngay = ngay.Substring(0, 2);          
            number[4] = ngay;
            string filePath = @"C:/Program Files (x86)/Room_919/Data_Work.txt";
            for (int i = 0; i < 5; i++)
            {
                System.IO.File.WriteAllLines (filePath, number);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {          
            string notefile;
            string value;
            notefile =textBox1.Text;         
            //note  
            string filePath3 = @"C:/Program Files (x86)/Room_919/Note.txt";
            string filePath4 = @"C:/Program Files (x86)/Room_919/Tien.txt";                       
            //quy                       
            value = System.IO.File.ReadAllText(filePath4);
            //MessageBox.Show(value);
            int tien = Convert.ToInt32(value);
            int s = Convert.ToInt32(nud1.Value);
            int tong=0;
            if (s <= tien)
            {
                File.AppendAllText(filePath3, " _");
                File.AppendAllText(filePath3, textBox1.Text);
                File.AppendAllText(filePath3, "\n");
                tong = tien - s;
                string trave = Convert.ToString(tong);
                System.IO.File.WriteAllText(filePath4, trave);
                value = System.IO.File.ReadAllText(filePath4);
                tien1.Text = value + " vnd";
                note1.Text = "Finish";
            }                
            else
            {
                MessageBox.Show("Tien hien khong du");
            }                                   
            Thread.Sleep(400);
            note1.Text = "Ready";
            textBox1.Text = "Ghi chú";           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            string value;
            string filePath4 = @"C:/Program Files (x86)/Room_919/Tien.txt";
            string filePath3 = @"C:/Program Files (x86)/Room_919/Note.txt";
            value = System.IO.File.ReadAllText(filePath4);
            int tien = Convert.ToInt32(value);
            int s = Convert.ToInt32(nud1.Value);
            tong = tien + s;
            string trave = Convert.ToString(tong);
            System.IO.File.WriteAllText(filePath4,trave);
            value = System.IO.File.ReadAllText(filePath4);
            //note
            File.AppendAllText(filePath3, " _");
            File.AppendAllText(filePath3, textBox1.Text);
            File.AppendAllText(filePath3, "\n");
            tien1.Text = value + " vnd";
            note1.Text = "Finish";
            Thread.Sleep(400);
            note1.Text = "Ready";
            textBox1.Text = "Ghi chú";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void nud1_Click(object sender, EventArgs e)
        {
            nud1.ResetText();
        }
    }
}
