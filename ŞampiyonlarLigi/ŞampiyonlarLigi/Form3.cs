using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞampiyonlarLigi
{
    public partial class Form3 : Form
    {
        List<int> takim1 = new List<int>();
        List<int> takim2 = new List<int>();
        List<int> takim3 = new List<int>();
        List<int> takim4 = new List<int>();

        public Form3()
        {
            InitializeComponent();
        }


        public Form3(List<DateTime> dates, List<string> group, List<int> scores , string name)
        {


            InitializeComponent();

            date1.Text = dates[0].ToString().TrimEnd('0', ':');
            date2.Text = dates[1].ToString().TrimEnd('0', ':');
            date3.Text = dates[2].ToString().TrimEnd('0', ':');
            date4.Text = dates[3].ToString().TrimEnd('0', ':');
            date5.Text = dates[4].ToString().TrimEnd('0', ':');
            date6.Text = dates[5].ToString().TrimEnd('0', ':');

            //1.takım

            label1.Text = group[0];  //takım
            label6.Text = group[0];
            label9.Text = group[0];
            label16.Text = group[0];
            label17.Text = group[0];
            label24.Text = group[0];

            //2. takım

            label2.Text = group[1];
            label7.Text = group[1];
            label11.Text = group[1];
            label14.Text = group[1];
            label20.Text = group[1];
            label23.Text = group[1];

            //3. takım

            label3.Text = group[2];
            label8.Text = group[2];
            label10.Text = group[2];
            label15.Text = group[2];
            label19.Text = group[2];
            label22.Text = group[2];


            //4. takım

            label4.Text = group[3];
            label5.Text = group[3];
            label12.Text = group[3];
            label13.Text = group[3];
            label18.Text = group[3];
            label21.Text = group[3];

            gol1.Text = scores[0].ToString();
            gol2.Text = scores[1].ToString();

            gol3.Text = scores[2].ToString();
            gol4.Text = scores[3].ToString();

            gol5.Text = scores[4].ToString();
            gol6.Text = scores[5].ToString();

            gol7.Text = scores[6].ToString();
            gol8.Text = scores[7].ToString();

            gol9.Text = scores[8].ToString();
            gol10.Text = scores[9].ToString();

            gol11.Text = scores[10].ToString();
            gol12.Text = scores[11].ToString();

            gol13.Text = scores[12].ToString();
            gol14.Text = scores[13].ToString();

            gol15.Text = scores[14].ToString();
            gol16.Text = scores[15].ToString();

            gol17.Text = scores[16].ToString();
            gol18.Text = scores[17].ToString();

            gol19.Text = scores[18].ToString();
            gol20.Text = scores[19].ToString();

            gol21.Text = scores[20].ToString();
            gol22.Text = scores[21].ToString();

            gol23.Text = scores[22].ToString();
            gol24.Text = scores[23].ToString();


            label26.Text = name;

        }

       


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();
          


        }
    }
}
