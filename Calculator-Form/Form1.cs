using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SystemCash;

namespace Calculator_Form
{
    
    public partial class Form1 : Form
    {
        public int Count = 0;
        FileSystem cash = new FileSystem("MEMBERCASH.TSHPANDA", "TheDirectory");
        public string FirstNumber="";
        public string SecondNumber="";
        public string Amalgar;
        public int Result;
        public bool IsAdadAvalPor = false;

        List<ClassStructure> listeCS = new List<ClassStructure>();
        


        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_Jam_Click(object sender, EventArgs e)
        {
            Amalgar = "+";
        }
        private void Btn_Tafrigh_Click(object sender, EventArgs e)
        {
            Amalgar = "-";
        }
        private void Btn_Zarb_Click(object sender, EventArgs e)
        {
            Amalgar = "*";
        }

        private void Btn_Taghsim_Click(object sender, EventArgs e)
        {
            Amalgar = "/";
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "1";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "1";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "2";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "2";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "3";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "3";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "4";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "4";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "5";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "5";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "6";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "6";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "7";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "7";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "8";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "8";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "9";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "9";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (IsAdadAvalPor == true)
            {
                SecondNumber = SecondNumber + "0";
                label1.Text = SecondNumber.ToString();
            }
            else
            {
                FirstNumber = FirstNumber + "0";
                IsAdadAvalPor = true;
                label1.Text = FirstNumber.ToString();
            }
            
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Mosavi_Click(object sender, EventArgs e)
        {
            int FirstNumberint = Convert.ToInt32(FirstNumber);
            int SecondNumberint = Convert.ToInt32(SecondNumber);
            switch (Amalgar)
            {
                case "+":
                    Result = FirstNumberint + SecondNumberint;
                    break;
                case "-":
                    Result = FirstNumberint - SecondNumberint;
                    break;
                case "*":
                    Result = FirstNumberint * SecondNumberint;
                    break;
                case "/":
                    Result = FirstNumberint / SecondNumberint;
                    break;
            }
            ClassStructure cs = new ClassStructure();
            cs.FirstNumber = FirstNumber;
            cs.SecondNumber = SecondNumber;
            cs.Result = Result;
            cs.IsAdadAvalPor = IsAdadAvalPor;
            cs.Amalgar = Amalgar;
            listeCS.Add(cs);


            label1.Text = Result.ToString();
            

            

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_res(object sender, EventArgs e)
        {

            FirstNumber = "";
            SecondNumber = "";
            Amalgar = "";
            Result = 0;
            IsAdadAvalPor = false;
            label1.Text = Result.ToString();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            FileSystem saveCash = new FileSystem("File", "TheDirectory");
            string textFromCash = saveCash.TextFromFile();
            List<ClassStructure> listeCs;
            if (string.IsNullOrEmpty(textFromCash))
            {
                listeCs = new List<ClassStructure>();
            }
            else
            {
                listeCs = JsonConvert.DeserializeObject<List<ClassStructure>>(textFromCash);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            string JsonSerialized = JsonConvert.SerializeObject(listeCS);
            FileSystem saveCash = new FileSystem("File", "TheDirectory");
            int res = 0;
            try
            {
                res = saveCash.Write_ToFile(JsonSerialized, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void Btn_up_Click(object sender, EventArgs e)
        {
            if (Count<listeCS.Count)
            {
            label1.Text = listeCS[Count].FirstNumber.ToString() + listeCS[Count].Amalgar + listeCS[Count].SecondNumber.ToString() +"="+ listeCS[Count].Result.ToString();
                Count++;
            }
            else
            {
                if(Count>0)
                Count = listeCS.Count - 1;
            }
        }

        private void Btn_down_Click(object sender, EventArgs e)
        {
            if (Count > -1)
            {
                label1.Text = listeCS[Count].FirstNumber.ToString() + listeCS[Count].Amalgar + listeCS[Count].SecondNumber.ToString() + "=" + listeCS[Count].Result.ToString();
                Count--;
            }
             if(Count==-1)
            {
                Count = 0;
            }
        }
    }
}

       