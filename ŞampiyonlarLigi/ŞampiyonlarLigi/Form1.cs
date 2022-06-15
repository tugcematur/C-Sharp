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
    public partial class Form1 : Form
    {
        List<Takim> teams = new List<Takim>();

        List<Takim> Bag1 = new List<Takim>();
        List<Takim> Bag2 = new List<Takim>();
        List<Takim> Bag3 = new List<Takim>();
        List<Takim> Bag4 = new List<Takim>();

        List<ListBox> bags = new List<ListBox>();

        List<ListBox> groups = new List<ListBox>();


        List<DateTime> datesA = new List<DateTime>();
        List<DateTime> datesB = new List<DateTime>();
        List<DateTime> datesC = new List<DateTime>();
        List<DateTime> datesD = new List<DateTime>();
        List<DateTime> datesE = new List<DateTime>();
        List<DateTime> datesF = new List<DateTime>();
        List<DateTime> datesG = new List<DateTime>();
        List<DateTime> datesH = new List<DateTime>();


        List<string> group1 = new List<string>();
        List<string> group2 = new List<string>();
        List<string> group3 = new List<string>();
        List<string> group4 = new List<string>();
        List<string> group5 = new List<string>();
        List<string> group6 = new List<string>();
        List<string> group7 = new List<string>();
        List<string> group8 = new List<string>();



        List<string> A = new List<string>();
        List<string> B = new List<string>();
        List<string> C = new List<string>();
        List<string> D = new List<string>();
        List<string> E = new List<string>();
        List<string> F = new List<string>();
        List<string> G = new List<string>();
        List<string> H = new List<string>();


        //Her takım 6 maç yapacak 
        // Skorlar

        List<int> scoresA = new List<int>();
        List<int> scoresB = new List<int>();
        List<int> scoresC = new List<int>();
        List<int> scoresD = new List<int>();
        List<int> scoresE = new List<int>();
        List<int> scoresF = new List<int>();
        List<int> scoresG = new List<int>();
        List<int> scoresH = new List<int>();


        List<string> birinci = new List<string>();
        List<string> ikinci = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim newTeam = null;


            //1. Torba
            newTeam = new Takim("Bayern Munich", "Almanya");
            Bag1.Add(newTeam);
            newTeam = new Takim("Sevilla", "İspanya");
            Bag1.Add(newTeam);
            newTeam = new Takim("Real Madrid", "İspanya");
            Bag1.Add(newTeam);
            newTeam = new Takim("Liverpool", "İngiltere");
            Bag1.Add(newTeam);
            newTeam = new Takim("Juventus", "İtalya");
            Bag1.Add(newTeam);
            newTeam = new Takim("Paris Saint-Germain", "Fransa");
            Bag1.Add(newTeam);
            newTeam = new Takim("Zenit", "Rusya");
            Bag1.Add(newTeam);
            newTeam = new Takim("Porto", "Portekiz");
            Bag1.Add(newTeam);

            //2.Torba

            newTeam = new Takim("Barcelona", "İspanya");
            Bag2.Add(newTeam);
            newTeam = new Takim("Atlético Madrid", "İspanya");
            Bag2.Add(newTeam);
            newTeam = new Takim("Manchester City", "İngiltere");
            Bag2.Add(newTeam);
            newTeam = new Takim("Manchester United", "İngiltere");
            Bag2.Add(newTeam);
            newTeam = new Takim("Borussia Dortmund", "Almanya");
            Bag2.Add(newTeam);
            newTeam = new Takim("Shakhtar Donetsk", "Ukrayna");
            Bag2.Add(newTeam);
            newTeam = new Takim("Chelsea", "İngiltere");
            Bag2.Add(newTeam);
            newTeam = new Takim("Ajax", "Hollanda");
            Bag2.Add(newTeam);

            //3.Torba

            newTeam = new Takim("Dynamo Kiev", "Ukrayna");
            Bag3.Add(newTeam);
            newTeam = new Takim("Red Bull Salzburg", "Almanya");
            Bag3.Add(newTeam);
            newTeam = new Takim("RB Leipzig", "Almanya");
            Bag3.Add(newTeam);
            newTeam = new Takim("Internazionale", "İtalya");
            Bag3.Add(newTeam);
            newTeam = new Takim("Olympiacos", "Yunanistan");
            Bag3.Add(newTeam);
            newTeam = new Takim("Lazio", "İtalya");
            Bag3.Add(newTeam);
            newTeam = new Takim("Krasnodar", "Rusya");
            Bag3.Add(newTeam);
            newTeam = new Takim("Atalanta", "İtalya");
            Bag3.Add(newTeam);

            //4.Torba


            newTeam = new Takim("Lokomotiv Moskova", "Rusya");
            Bag4.Add(newTeam);
            newTeam = new Takim("Marseille", "Almanya");
            Bag4.Add(newTeam);
            newTeam = new Takim("Club Brugge", "Belçika");
            Bag4.Add(newTeam);
            newTeam = new Takim("Bor. Mönchengladbach", "Almanya");
            Bag4.Add(newTeam);
            newTeam = new Takim("Galatasaray", "Türkiye");
            Bag4.Add(newTeam);
            newTeam = new Takim("Midtjylland", "Danimarka");
            Bag4.Add(newTeam);
            newTeam = new Takim("Rennes", "Fransa");
            Bag4.Add(newTeam);
            newTeam = new Takim("Ferencváros", "Maceristan");
            Bag4.Add(newTeam);


            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("G");
            comboBox1.Items.Add("H");

            group.Enabled = false;
            dagit.Enabled = false;
            fikstur.Enabled = false;
            comboBox1.Enabled = false;
            
        }

        private void bag_Click(object sender, EventArgs e)
        {



            foreach (Takim item in Bag1)
            {
                listTorba1.Items.Add(item);
                teams.Add(item);
            }


            foreach (Takim item in Bag2)
            {
                listTorba2.Items.Add(item);
                teams.Add(item);
            }


            foreach (Takim item in Bag3)
            {
                listTorba3.Items.Add(item);
                teams.Add(item);
            }

            foreach (Takim item in Bag4)
            {
                listTorba4.Items.Add(item);
                teams.Add(item);
            }

            bags.Add(listTorba1);
            bags.Add(listTorba2);
            bags.Add(listTorba3);
            bags.Add(listTorba4);

            groups.Add(listBox1);
            groups.Add(listBox2);
            groups.Add(listBox3);
            groups.Add(listBox4);
            groups.Add(listBox5);
            groups.Add(listBox6);
            groups.Add(listBox7);
            groups.Add(listBox8);

            group.Enabled = true;
        }

        private void group_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            List<int> selectedTeams = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                selectedTeams.Clear();

                for (int j = 0; j < 8; j++)
                {
                    int selectedTeamNo = random.Next(0, teams.Count / 4); // Rastgele bir takım seçiliyor(indexi)

                    if (selectedTeams.Contains(selectedTeamNo))
                    {
                        j--;
                    }
                    else
                    {
                        selectedTeams.Add(selectedTeamNo);
                    }

                }

                bool isTeamFromSameCountry = false;


                for (int k = 0; k < 8; k++)
                {
                    isTeamFromSameCountry = IsTeamFromSameCountry(groups[k], bags[i].Items[selectedTeams[k]] as Takim);

                    if (isTeamFromSameCountry)
                        break;
                }

                if (!isTeamFromSameCountry)
                {                              //Her bir torbadaki her 8 takım  birer birer 8 gruba dağılıyor (4 er  tane)
                    listBox1.Items.Add(bags[i].Items[selectedTeams[0]] as Takim);
                    listBox2.Items.Add(bags[i].Items[selectedTeams[1]] as Takim);
                    listBox3.Items.Add(bags[i].Items[selectedTeams[2]] as Takim);
                    listBox4.Items.Add(bags[i].Items[selectedTeams[3]] as Takim);
                    listBox5.Items.Add(bags[i].Items[selectedTeams[4]] as Takim);
                    listBox6.Items.Add(bags[i].Items[selectedTeams[5]] as Takim);
                    listBox7.Items.Add(bags[i].Items[selectedTeams[6]] as Takim);
                    listBox8.Items.Add(bags[i].Items[selectedTeams[7]] as Takim);
                }

                else
                {
                    i--;
                }

            }


            bag.Enabled = false;
            group.Enabled = false;
            dagit.Enabled = true;
           
        }



        private bool IsTeamFromSameCountry(ListBox group, Takim team)
        {
            bool status = false;

            for (int i = 0; i < group.Items.Count; i++)
            {
                Takim groupTeam = group.Items[i] as Takim;

                if (groupTeam.Country == team.Country)
                {
                    status = true;
                    break;
                }
            }

            return status;


        }



        private List<string> getListBox(int i)
        {

            List<string> list = new List<string>();


            if (i == 1)
            {
                foreach (var item in listBox1.Items)
                {
                    list.Add(item.ToString());

                }

            }
            else if (i == 2)
            {
                foreach (var item in listBox2.Items)
                {
                    list.Add(item.ToString());
                }

            }
            else if (i == 3)
            {
                foreach (var item in listBox3.Items)
                {
                    list.Add(item.ToString());
                }

            }
            else if (i == 4)
            {
                foreach (var item in listBox4.Items)
                {
                    list.Add(item.ToString());
                }

            }
            else if (i == 5)
            {
                foreach (var item in listBox5.Items)
                {
                    list.Add(item.ToString());
                }

            }
            else if (i == 6)
            {
                foreach (var item in listBox6.Items)
                {
                    list.Add(item.ToString());
                }

            }
            else if (i == 7)
            {
                foreach (var item in listBox7.Items)
                {
                    list.Add(item.ToString());
                }


            }
            else if (i == 8)
            {
                foreach (var item in listBox8.Items)
                {
                    list.Add(item.ToString());
                }


            }



            return list;

        }




        private void fikstur_Click(object sender, EventArgs e)
        {


            switch (comboBox1.Text)
            {
                case "A":
                    Form3 g1 = new Form3(datesA, group1, scoresA ,"A Grubu");
                    g1.ShowDialog();
                    //  this.Hide();
                    break;

                case "B":
                    Form3 g2 = new Form3(datesB, group2, scoresB, "B Grubu");
                    g2.ShowDialog();
                    // this.Hide();

                    break;




                case "C":
                    Form3 g3 = new Form3(datesC, group3, scoresC, "C Grubu");
                    g3.ShowDialog();
                    //  this.Hide();

                    break;

                case "D":
                    Form3 g4 = new Form3(datesD, group4, scoresD, "D Grubu");

                    g4.ShowDialog();
                    //this.Hide();

                    break;


                case "E":
                    Form3 g5 = new Form3(datesE, group5, scoresE, "E Grubu");
                    g5.Show();
                    //   this.Hide();

                    break;

                case "F":
                    Form3 g6 = new Form3(datesF, group6, scoresF, "F Grubu");
                    g6.ShowDialog();
                    // this.Hide();
                    break;




                case "G":
                    Form3 g7 = new Form3(datesG, group7, scoresG, "G Grubu");
                    g7.ShowDialog();
                    // this.Hide();

                    break;

                case "H":
                    Form3 g8 = new Form3(datesH, group8, scoresH, "H Grubu");
                    g8.ShowDialog();
                    // this.Hide();

                    break;


            }

            // comboBox1.Enabled = false;
        }


        private void dagit_Click(object sender, EventArgs e)
        {


            determineDates(datesA);
            determineDates(datesB);
            determineDates(datesC);
            determineDates(datesD);
            determineDates(datesE);
            determineDates(datesF);
            determineDates(datesG);
            determineDates(datesH);




            group1 = determineMatchs(getListBox(1), A);
            group2 = determineMatchs(getListBox(2), B);
            group3 = determineMatchs(getListBox(3), C);
            group4 = determineMatchs(getListBox(4), D);
            group5 = determineMatchs(getListBox(5), E);
            group6 = determineMatchs(getListBox(6), F);
            group7 = determineMatchs(getListBox(7), G);
            group8 = determineMatchs(getListBox(8), H);


            scoresA = getScores();
            scoresB = getScores();
            scoresC = getScores();
            scoresD = getScores();
            scoresE = getScores();
            scoresF = getScores();
            scoresG = getScores();
            scoresH = getScores();

            hesapla(scoresA, group1);
            hesapla(scoresB, group2);
            hesapla(scoresC, group3);
            hesapla(scoresD, group4);
            hesapla(scoresE, group5);
            hesapla(scoresF, group6);
            hesapla(scoresG, group7);
            hesapla(scoresH, group8);


            foreach (var item in birinci)
            {
                listBox9.Items.Add(item);
            }

            foreach (var item in ikinci)
            {
                listBox10.Items.Add(item);
            }

            dagit.Enabled = false;
            comboBox1.Enabled = true;
            fikstur.Enabled = true;

        }


        private void hesapla(List<int> scores, List<string> group)
        {
            List<int> takim1 = new List<int>(); // takim1 in puanları
            List<int> takim2 = new List<int>();
            List<int> takim3 = new List<int>();
            List<int> takim4 = new List<int>();



            int AG1 = 0;
            int AG2 = 0;
            int AG3 = 0;
            int AG4 = 0;

            int YG1 = 0;
            int YG2 = 0;
            int YG3 = 0;
            int YG4 = 0;

            int AV1 = 0;
            int AV2 = 0;
            int AV3 = 0;
            int AV4 = 0;


            for (int i = 1; i < 7; i++) //dates
            {
                ///içinde grubun 1. ve 2si belirlenecek birinci ve ikinci listesine atama olacak

                if (i == 1)
                {
                    if (scores[0] == scores[1])  //0:0 ,   1:1
                    {
                        takim1.Add(1);
                        takim2.Add(1);


                    }

                    else if (scores[0] > scores[1])
                    {
                        takim1.Add(3);

                    }

                    else if (scores[1] > scores[0])
                    {
                        takim2.Add(3);

                    }                                                        // date1 in 1.maçı için

                    AG1 = AG1 + scores[0];
                    AG2 = AG2 + scores[1];

                    YG1 = YG1 + scores[1];
                    YG2 = YG2 + scores[0];

                    AV1 = AV1 + AG1 - YG1;
                    AV2 = AV2 + AG2 - YG2;


                    if (scores[2] == scores[3]) //3. ve 4.takım
                    {
                        takim3.Add(1);
                        takim4.Add(1);
                    }

                    else if (scores[2] > scores[3])
                    {
                        takim3.Add(3);
                    }

                    else if (scores[3] > scores[2])
                    {
                        takim4.Add(3);
                    }                                                        // date1 in 2.maçı için


                    AG3 = AG3 + scores[2];
                    AG4 = AG4 + scores[3];

                    YG3 = YG3 + scores[3];
                    YG4 = YG4 + scores[2];

                    AV3 = AV3 + AG3 - YG3;
                    AV4 = AV4 + AG4 - YG4;


                }

                if (i == 2)
                {
                    if (scores[4] == scores[5])   // 4. ve 1.takım
                    {
                        takim1.Add(1);
                        takim2.Add(1);
                    }

                    else if (scores[4] > scores[5])
                    {
                        takim1.Add(3);
                    }

                    else if (scores[5] > scores[4])
                    {
                        takim4.Add(3);
                    }                                                        // date2 in 1.maçı için



                    AG1 = AG1 + scores[4];
                    AG4 = AG4 + scores[5];

                    YG1 = YG1 + scores[5];
                    YG4 = YG4 + scores[4];

                    AV1 = AV1 + AG1 - YG1;
                    AV4 = AV4 + AG4 - YG4;

                    if (scores[6] == scores[7])   // 2. ve 3.takım
                    {
                        takim2.Add(1);
                        takim3.Add(1);
                    }

                    else if (scores[6] > scores[7])
                    {
                        takim2.Add(3);
                    }

                    else if (scores[7] > scores[6])
                    {
                        takim3.Add(3);
                    }                                                        // date2 in 2.maçı için


                    AG2 = AG2 + scores[6];
                    AG3 = AG3 + scores[7];

                    YG2 = YG2 + scores[7];
                    YG3 = YG3 + scores[6];

                    AV2 = AV2 + AG2 - YG2;
                    AV3 = AV3 + AG3 - YG3;
                }

                if (i == 3)
                {
                    if (scores[8] == scores[9])   // 1. ve 3.takım
                    {
                        takim1.Add(1);
                        takim3.Add(1);
                    }

                    else if (scores[8] > scores[9])
                    {
                        takim1.Add(3);
                    }

                    else if (scores[9] > scores[8])
                    {
                        takim3.Add(3);
                    }                                                        // date3 in 1.maçı için



                    AG1 = AG1 + scores[8];
                    AG3 = AG3 + scores[9];

                    YG1 = YG1 + scores[9];
                    YG3 = YG3 + scores[8];

                    AV1 = AV1 + AG1 - YG1;
                    AV3 = AG3 - YG3;

                    if (scores[10] == scores[11])   // 2. ve 4.takım
                    {
                        takim2.Add(1);
                        takim4.Add(1);
                    }

                    else if (scores[10] > scores[11])
                    {
                        takim2.Add(3);
                    }

                    else if (scores[11] > scores[10])
                    {
                        takim4.Add(3);
                    }                                                        // date3 in 2.maçı için

                    AG2 = AG2 + scores[10];
                    AG4 = AG4 + scores[11];

                    YG2 = YG2 + scores[11];
                    YG4 = YG4 + scores[10];

                    AV2 = AV2 + AG2 - YG2;
                    AV4 = AV4 + AG4 - YG4;

                }

                if (i == 4)
                {
                    if (scores[12] == scores[13])   // 4. ve 2.takım  gol11 2.takım         gol12  label11 -> 2 label12 ->4
                    {                                                 //scores[12]  scores[13]   
                        takim4.Add(1);
                        takim2.Add(1);
                    }
                    else if (scores[12] > scores[13])
                    {
                        takim2.Add(3);
                    }

                    else if (scores[13] > scores[12])
                    {
                        takim4.Add(3);
                    }

                    // date4 in 1.maçı için

                    AG2 = AG2 + scores[12];
                    AG4 = AG4 + scores[13];

                    YG2 = YG2 + scores[13];
                    YG4 = YG4 + scores[12];

                    AV2 = AV2 + AG2 - YG2;
                    AV4 = AV4 + AG4 - YG4;

                    if (scores[14] == scores[15])   // 3. ve 1.takım
                    {
                        takim3.Add(1);
                        takim1.Add(1);
                    }

                    else if (scores[14] > scores[15])
                    {
                        takim1.Add(3);
                    }

                    else if (scores[15] > scores[14])
                    {
                        takim3.Add(3);
                    }                                                                     // date4 in 2.maçı için

                    AG1 = AG1 + scores[14];
                    AG3 = AG3 + scores[15];

                    YG1 = YG1 + scores[15];
                    YG3 = YG3 + scores[14];

                    AV1 = AV1 + AG1 - YG1;
                    AV3 = AV3 + AG3 - YG3;


                }

                if (i == 5)
                {
                    if (scores[16] == scores[17])   // 1. ve 4.takım
                    {
                        takim1.Add(1);
                        takim4.Add(1);
                    }

                    else if (scores[16] > scores[17])
                    {
                        takim1.Add(3);
                    }

                    else if (scores[17] > scores[16])
                    {
                        takim4.Add(3);
                    }                                                        // date5 in 1.maçı için


                    AG1 = AG1 + scores[16];
                    AG4 = AG4 + scores[17];

                    YG1 = YG1 + scores[17];
                    YG4 = YG4 + scores[16];

                    AV1 = AV1 + AG1 - YG1;
                    AV4 = AV4 + AG4 - YG4;



                    if (scores[18] == scores[19])   // 3. ve 2.takım
                    {
                        takim3.Add(1);
                        takim2.Add(1);
                    }

                    else if (scores[18] > scores[19])
                    {
                        takim2.Add(3);
                    }

                    else if (scores[19] > scores[18])
                    {
                        takim3.Add(3);
                    }                                                            // date5 in 2.maçı için

                    AG2 = AG2 + scores[18];
                    AG3 = AG3 + scores[19];


                    YG2 = YG2 + scores[19];
                    YG3 = YG3 + scores[18];

                    AV2 = AV2 + AG2 - YG2;
                    AV3 = AV3 + AG3 - YG3;
                }

                if (i == 6)
                {
                    if (scores[20] == scores[21])   // 4. ve 3.takım
                    {
                        takim4.Add(1);
                        takim3.Add(1);
                    }

                    else if (scores[20] > scores[21])
                    {
                        takim3.Add(3);
                    }

                    else if (scores[21] > scores[20])
                    {
                        takim4.Add(3);
                    }                                                        // date6 in 1.maçı için


                    AG3 = AG3 + scores[20];
                    AG4 = AG4 + scores[21];

                    YG3 = YG3 + scores[21];
                    YG4 = YG4 + scores[20];

                    AV3 = AV3 + AG3 - YG3;
                    AV4 = AV4 + +AG4 - YG4;


                    if (scores[22] == scores[23])   // 2. ve 1.takım
                    {
                        takim2.Add(1);
                        takim1.Add(1);
                    }

                    else if (scores[22] > scores[23])
                    {
                        takim1.Add(3);
                    }

                    else if (scores[23] > scores[22])
                    {
                        takim2.Add(3);
                    }                                                        // date6 in 2.maçı için



                    AG1 = AG1 + scores[22];
                    AG2 = AG2 + scores[23];


                    YG1 = YG1 + scores[23];
                    YG2 = YG2 + scores[22];

                    AV1 = AV1 + AG1 - YG1;
                    AV2 = AV2 + AG2 - YG2;

                }



            }

            int p1 = 0;  //group[0]
            int p2 = 0;  //group[1]
            int p3 = 0;  //group[2]
            int p4 = 0;  //group[3]

            List<int> points = new List<int>();

            foreach (var item in takim1)
            {
                p1 = p1 + item;
            }


            foreach (var item in takim2)
            {
                p2 = p2 + item;
            }


            foreach (var item in takim3)
            {
                p3 = p3 + item;
            }


            foreach (var item in takim4)
            {
                p4 = p4 + item;
            }
            List<string> newtList = new List<string>();

            if (p1 != p2 && p1 != p3 && p1 != p4 && p2 != p3 && p2 != p4 && p3 != p4) 

            {
                points.Add(p1);//8
                points.Add(p2);//3
                points.Add(p3);//10
                points.Add(p4);//12

                int temp = 0;



                for (int i = 0; i < points.Count; i++)
                {
                    for (int j = i + 1; j < points.Count; j++) //büyüktan küçüğe
                    {
                        if (points[i] < points[j])
                        {
                            temp = points[j];
                            points[j] = points[i];
                            points[i] = temp;
                        }
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    if (points[i] == p1)
                    {
                        newtList.Add(group[0]);
                    }

                    else if (points[i] == p2)
                    {
                        newtList.Add(group[1]);
                    }

                    else if (points[i] == p3)
                    {
                        newtList.Add(group[2]);
                    }

                    else if (points[i] == p4)
                    {
                        newtList.Add(group[3]);
                    }
                }

                birinci.Add(newtList[0]);
                ikinci.Add(newtList[1]);

            }

            else //Averajlara bakılacak
            { 
                List<int> array = new List<int>();



                array.Add(AV1);
                array.Add(AV2);
                array.Add(AV3);
                array.Add(AV4);

                if (AV1 != AV2 && AV1 != AV3 && AV1 != AV4 && AV2 != AV3 && AV2 != AV4 && AV3 != AV4)
                {
                    array.Sort();
                    array.Reverse();


                    for (int i = 0; i < 2; i++)
                    {
                        if (array[i] == AV1)
                        {
                            newtList.Add(group[0]);
                        }

                        else if (array[i] == AV2)
                        {
                            newtList.Add(group[1]);
                        }

                        else if (array[i] == AV3)
                        {
                            newtList.Add(group[2]);
                        }

                        else if (array[i] == AV4)
                        {
                            newtList.Add(group[3]);
                        }
                    }
                    birinci.Add(newtList[0]);
                    ikinci.Add(newtList[1]);
                }
                else // toplam atılan gol sayısına bakılacak
                {
                    array.Add(AG1);
                    array.Add(AG2);
                    array.Add(AG3);
                    array.Add(AG4);

                    array.Sort();
                    array.Reverse();


                    for (int i = 0; i < 2; i++)
                    {
                        if (array[i] == AG1)
                        {
                            newtList.Add(group[0]);
                        }

                        else if (array[i] == AG2)
                        {
                            newtList.Add(group[1]);
                        }

                        else if (array[i] == AG3)
                        {
                            newtList.Add(group[2]);
                        }

                        else if (array[i] == AG4)
                        {
                            newtList.Add(group[3]);
                        }
                    }
                    birinci.Add(newtList[0]);
                    ikinci.Add(newtList[1]);
                }
            }









        }


        private List<string> determineMatchs(List<string> list, List<string> groupList)
        {

            foreach (var item in list)
            {
                groupList.Add(item);
            }

            return groupList;
        }

        private void determineDates(List<DateTime> dates) /////////////////////
        {



            List<DateTime> selectedDates = new List<DateTime>();
            List<DateTime> dateList = new List<DateTime>();
            Random rnd = new Random();
            DateTime dateToday = DateTime.Now;



            try
            {

                for (int i = 1; i < 7; i++)
                {

                    if (i == 1)
                    {

                        DateTime gameDate = new DateTime(rnd.Next(2022, dateToday.Year), rnd.Next(9, 11), rnd.Next(1, 15));

                        dateList.Add(gameDate);
                        selectedDates.Add(gameDate);
                    }

                    else
                    {
                        for (int j = 0; j < selectedDates.Count; j++)
                        {

                            if (i == 2)
                            {
                                DateTime gameDate = new DateTime(rnd.Next(2022, dateToday.Year), rnd.Next(9, 11), rnd.Next(17, 31));

                                if (gameDate <= selectedDates[j])
                                {


                                    i--;
                                    break;
                                }
                                else
                                {
                                    dateList.Add(gameDate);
                                    selectedDates.Add(gameDate);
                                    break;
                                }
                            }

                            else if (i == 3)
                            {
                                DateTime gameDate = new DateTime(rnd.Next(2022, dateToday.Year), rnd.Next(10, 12), rnd.Next(1, 13));

                                if (gameDate <= selectedDates[j + 1])
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    dateList.Add(gameDate);
                                    selectedDates.Add(gameDate);
                                    break;
                                }
                            }
                            else if (i == 4)
                            {
                                DateTime gameDate = new DateTime(rnd.Next(2022, dateToday.Year), rnd.Next(10, 12), rnd.Next(14, 20));
                                if (gameDate <= selectedDates[j + 2])
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    dateList.Add(gameDate);
                                    selectedDates.Add(gameDate);
                                    break;
                                }
                            }
                            else if (i == 5)
                            {
                                DateTime gameDate = new DateTime(rnd.Next(2022, dateToday.Year), rnd.Next(10, 12), rnd.Next(14, 27));
                                if (gameDate <= selectedDates[j + 3])
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    dateList.Add(gameDate);
                                    selectedDates.Add(gameDate);

                                    break;
                                }
                            }
                            else if (i == 6)
                            {
                                DateTime gameDate = new DateTime(rnd.Next(2022, dateToday.Year), rnd.Next(10, 12), rnd.Next(7, 31));
                                if (gameDate <= selectedDates[j + 4])
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    dateList.Add(gameDate);
                                    break;

                                }
                            }


                        }


                    }

                }

        

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            foreach (var item in dateList)
            {
                dates.Add(item);
            }



        }


        private List<int> getScores()
        {
            List<int> scores = new List<int>();
            Random rnd = new Random();
            int x;

            for (int i = 0; i < 24; i++)
            {
                x = rnd.Next(0, 3);
                scores.Add(x);

            }

            return scores;
        }


     
    }
}


