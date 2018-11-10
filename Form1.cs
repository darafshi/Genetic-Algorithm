using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gene_Alg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string[] v = new string[10];
     //   public static double[] testaaaa = new double[13];
        public static string[] v_temp2 = new string[13];
        public static string[] v_last_13 = new string[13];

        public static double a1 = -3;
        public static double b1 = 12.1;
        public static double a2 = 4.1;
        public static double b2 = 5.8;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox14.Items.Clear();
            label27.Text = "Start Time : ";
            if (Convert.ToInt32(textBox8.Text) > 0)
             label27.Text +=  System.DateTime.Now.TimeOfDay.Hours.ToString() +":"+ System.DateTime.Now.TimeOfDay.Minutes.ToString()+":"
                + System.DateTime.Now.TimeOfDay.Seconds.ToString() + ":" + System.DateTime.Now.TimeOfDay.Milliseconds.ToString();

             label33.Text = "";
             label32.Text = "";
             label31.Text = "";
             label30.Text = "";
             label29.Text = "";

            double m = 33;
            double m1 = 18;
            double m2 = m - m1;

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
                v[i] = "";

            for (int i = 0; i < 10; i++)
            {
                v[i] += random_v(rnd);
            }

            if (textBox8.Text.Length == 0 || Convert.ToInt32(textBox8.Text) < 1)
            {
                MessageBox.Show("please enter a valid number for itteration");
                
            }
            for (int ittera = 0; ittera < Convert.ToInt32( textBox8.Text) ; ittera++)
            {

                //listBox5.Items.Clear();
                //for (int i = 0; i < 10; i++)
                //{
                //    listBox5.Items.Add(v[i] + " : ");
                //}

                double[] eval_v_f = new double[10];


                string v_1_part_1 = null;
                string v_1_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_1_part_1 += v[0][i];
                for (int i = 18; i < m; i++)
                    v_1_part_2 += v[0][i];

                double eval_v_1_part_1 = mapping_binary_to_realnumber(a1, v_1_part_1, b1, m1);
                double eval_v_1_part_2 = mapping_binary_to_realnumber(a2, v_1_part_2, b2, m2);

                while (!((eval_v_1_part_1 >= -3 && eval_v_1_part_1 <= b1) && (eval_v_1_part_2 >= a2 && eval_v_1_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[0] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_1_part_1 += v[0][i];
                    for (int i = 18; i < m; i++)
                        v_1_part_2 += v[0][i];

                    eval_v_1_part_1 = mapping_binary_to_realnumber(a1, v_1_part_1, b1, m1);
                    eval_v_1_part_2 = mapping_binary_to_realnumber(a2, v_1_part_2, b2, m2);
                }


                eval_v_f[0] = max_f_x_y(eval_v_1_part_1, eval_v_1_part_2);



                //  MessageBox.Show(eval_v_1_part_1.ToString() + "\t\t" + eval_v_1_part_2.ToString() + "\t\t" + eval_v_1_f.ToString());

                string v_2_part_1 = null;
                string v_2_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_2_part_1 += v[1][i];
                for (int i = 18; i < m; i++)
                    v_2_part_2 += v[1][i];

                double eval_v_2_part_1 = mapping_binary_to_realnumber(a1, v_2_part_1, b1, m1);
                double eval_v_2_part_2 = mapping_binary_to_realnumber(a2, v_2_part_2, b2, m2);

                while (!((eval_v_2_part_1 >= -3 && eval_v_2_part_1 <= b1) && (eval_v_2_part_2 >= a2 && eval_v_2_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[1] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_2_part_1 += v[1][i];
                    for (int i = 18; i < m; i++)
                        v_2_part_2 += v[1][i];

                    eval_v_2_part_1 = mapping_binary_to_realnumber(a1, v_2_part_1, b1, m1);
                    eval_v_2_part_2 = mapping_binary_to_realnumber(a2, v_2_part_2, b2, m2);
                }

                eval_v_f[1] = max_f_x_y(eval_v_2_part_1, eval_v_2_part_2);

                string v_3_part_1 = null;
                string v_3_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_3_part_1 += v[2][i];
                for (int i = 18; i < m; i++)
                    v_3_part_2 += v[2][i];

                double eval_v_3_part_1 = mapping_binary_to_realnumber(a1, v_3_part_1, b1, m1);
                double eval_v_3_part_2 = mapping_binary_to_realnumber(a2, v_3_part_2, b2, m2);

                while (!((eval_v_3_part_1 >= -3 && eval_v_3_part_1 <= b1) && (eval_v_3_part_2 >= a2 && eval_v_3_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
           //             v[2] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_3_part_1 += v[2][i];
                    for (int i = 18; i < m; i++)
                        v_3_part_2 += v[2][i];

                    eval_v_3_part_1 = mapping_binary_to_realnumber(a1, v_3_part_1, b1, m1);
                    eval_v_3_part_2 = mapping_binary_to_realnumber(a2, v_3_part_2, b2, m2);
                }

                eval_v_f[2] = max_f_x_y(eval_v_3_part_1, eval_v_3_part_2);

                string v_4_part_1 = null;
                string v_4_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_4_part_1 += v[3][i];
                for (int i = 18; i < m; i++)
                    v_4_part_2 += v[3][i];

                double eval_v_4_part_1 = mapping_binary_to_realnumber(a1, v_4_part_1, b1, m1);
                double eval_v_4_part_2 = mapping_binary_to_realnumber(a2, v_4_part_2, b2, m2);

                while (!((eval_v_4_part_1 >= -3 && eval_v_4_part_1 <= b1) && (eval_v_4_part_2 >= a2 && eval_v_4_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
             //           v[3] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_4_part_1 += v[3][i];
                    for (int i = 18; i < m; i++)
                        v_4_part_2 += v[3][i];

                    eval_v_4_part_1 = mapping_binary_to_realnumber(a1, v_4_part_1, b1, m1);
                    eval_v_4_part_2 = mapping_binary_to_realnumber(a2, v_4_part_2, b2, m2);
                }

                eval_v_f[3] = max_f_x_y(eval_v_4_part_1, eval_v_4_part_2);

                string v_5_part_1 = null;
                string v_5_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_5_part_1 += v[4][i];
                for (int i = 18; i < m; i++)
                    v_5_part_2 += v[4][i];

                double eval_v_5_part_1 = mapping_binary_to_realnumber(a1, v_5_part_1, b1, m1);
                double eval_v_5_part_2 = mapping_binary_to_realnumber(a2, v_5_part_2, b2, m2);

                while (!((eval_v_5_part_1 >= -3 && eval_v_5_part_1 <= b1) && (eval_v_5_part_2 >= a2 && eval_v_5_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[4] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_5_part_1 += v[4][i];
                    for (int i = 18; i < m; i++)
                        v_5_part_2 += v[4][i];

                    eval_v_5_part_1 = mapping_binary_to_realnumber(a1, v_5_part_1, b1, m1);
                    eval_v_5_part_2 = mapping_binary_to_realnumber(a2, v_5_part_2, b2, m2);
                }

                eval_v_f[4] = max_f_x_y(eval_v_5_part_1, eval_v_5_part_2);

                string v_6_part_1 = null;
                string v_6_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_6_part_1 += v[5][i];
                for (int i = 18; i < m; i++)
                    v_6_part_2 += v[5][i];

                double eval_v_6_part_1 = mapping_binary_to_realnumber(a1, v_6_part_1, b1, m1);
                double eval_v_6_part_2 = mapping_binary_to_realnumber(a2, v_6_part_2, b2, m2);

                while (!((eval_v_6_part_1 >= -3 && eval_v_6_part_1 <= b1) && (eval_v_6_part_2 >= a2 && eval_v_6_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[5] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_6_part_1 += v[5][i];
                    for (int i = 18; i < m; i++)
                        v_6_part_2 += v[5][i];

                    eval_v_6_part_1 = mapping_binary_to_realnumber(a1, v_6_part_1, b1, m1);
                    eval_v_6_part_2 = mapping_binary_to_realnumber(a2, v_6_part_2, b2, m2);
                }

                eval_v_f[5] = max_f_x_y(eval_v_6_part_1, eval_v_6_part_2);

                string v_7_part_1 = null;
                string v_7_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_7_part_1 += v[6][i];
                for (int i = 18; i < m; i++)
                    v_7_part_2 += v[6][i];

                double eval_v_7_part_1 = mapping_binary_to_realnumber(a1, v_7_part_1, b1, m1);
                double eval_v_7_part_2 = mapping_binary_to_realnumber(a2, v_7_part_2, b2, m2);

                while (!((eval_v_7_part_1 >= -3 && eval_v_7_part_1 <= b1) && (eval_v_7_part_2 >= a2 && eval_v_7_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[6] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_7_part_1 += v[6][i];
                    for (int i = 18; i < m; i++)
                        v_7_part_2 += v[6][i];

                    eval_v_7_part_1 = mapping_binary_to_realnumber(a1, v_7_part_1, b1, m1);
                    eval_v_7_part_2 = mapping_binary_to_realnumber(a2, v_7_part_2, b2, m2);
                }

                eval_v_f[6] = max_f_x_y(eval_v_7_part_1, eval_v_7_part_2);

                string v_8_part_1 = null;
                string v_8_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_8_part_1 += v[7][i];
                for (int i = 18; i < m; i++)
                    v_8_part_2 += v[7][i];

                double eval_v_8_part_1 = mapping_binary_to_realnumber(a1, v_8_part_1, b1, m1);
                double eval_v_8_part_2 = mapping_binary_to_realnumber(a2, v_8_part_2, b2, m2);

                while (!((eval_v_8_part_1 >= -3 && eval_v_8_part_1 <= b1) && (eval_v_8_part_2 >= a2 && eval_v_8_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[7] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_8_part_1 += v[7][i];
                    for (int i = 18; i < m; i++)
                        v_8_part_2 += v[7][i];

                    eval_v_8_part_1 = mapping_binary_to_realnumber(a1, v_8_part_1, b1, m1);
                    eval_v_8_part_2 = mapping_binary_to_realnumber(a2, v_8_part_2, b2, m2);
                }

                eval_v_f[7] = max_f_x_y(eval_v_8_part_1, eval_v_8_part_2);

                string v_9_part_1 = null;
                string v_9_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_9_part_1 += v[8][i];
                for (int i = 18; i < m; i++)
                    v_9_part_2 += v[8][i];

                double eval_v_9_part_1 = mapping_binary_to_realnumber(a1, v_9_part_1, b1, m1);
                double eval_v_9_part_2 = mapping_binary_to_realnumber(a2, v_9_part_2, b2, m2);

                while (!((eval_v_9_part_1 >= -3 && eval_v_9_part_1 <= b1) && (eval_v_9_part_2 >= a2 && eval_v_9_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
               //         v[8] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_9_part_1 += v[8][i];
                    for (int i = 18; i < m; i++)
                        v_9_part_2 += v[8][i];

                    eval_v_9_part_1 = mapping_binary_to_realnumber(a1, v_9_part_1, b1, m1);
                    eval_v_9_part_2 = mapping_binary_to_realnumber(a2, v_9_part_2, b2, m2);
                }

                eval_v_f[8] = max_f_x_y(eval_v_9_part_1, eval_v_9_part_2);

                string v_10_part_1 = null;
                string v_10_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_10_part_1 += v[9][i];
                for (int i = 18; i < m; i++)
                    v_10_part_2 += v[9][i];

                double eval_v_10_part_1 = mapping_binary_to_realnumber(a1, v_10_part_1, b1, m1);
                double eval_v_10_part_2 = mapping_binary_to_realnumber(a2, v_10_part_2, b2, m2);

                while (!((eval_v_10_part_1 >= -3 && eval_v_10_part_1 <= b1) && (eval_v_10_part_2 >= a2 && eval_v_10_part_2 <= 5.8)))
                {
                    for (int i = 0; i < m; i++)
                    {
              //          v[9] += random_v(rnd);
                    }
                    for (int i = 0; i < 18; i++)
                        v_10_part_1 += v[9][i];
                    for (int i = 18; i < m; i++)
                        v_10_part_2 += v[9][i];

                    eval_v_10_part_1 = mapping_binary_to_realnumber(a1, v_10_part_1, b1, m1);
                    eval_v_10_part_2 = mapping_binary_to_realnumber(a2, v_10_part_2, b2, m2);
                }

                eval_v_f[9] = max_f_x_y(eval_v_10_part_1, eval_v_10_part_2);


                listBox5.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    listBox5.Items.Add(i.ToString() + " : " + v[i] + " : " + eval_v_f[i].ToString());
                }


                double total_fitness = 0;

                for (int i = 0; i < 10; i++)
                    total_fitness += eval_v_f[i];

                label12.Text = "total_fitness : " + total_fitness.ToString();
                

                double[] selection_probablity = new double[10];

                for (int i = 0; i < 10; i++)
                {
                    selection_probablity[i] = eval_v_f[i] / total_fitness;

                }

                listBox2.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    listBox2.Items.Add(selection_probablity[i]);
                }


                double[] cumulative_probablity = new double[10];

                for (int i = 0; i < 1; i++)
                    cumulative_probablity[0] += selection_probablity[i];
                for (int i = 0; i < 2; i++)
                    cumulative_probablity[1] += selection_probablity[i];
                for (int i = 0; i < 3; i++)
                    cumulative_probablity[2] += selection_probablity[i];
                for (int i = 0; i < 4; i++)
                    cumulative_probablity[3] += selection_probablity[i];
                for (int i = 0; i < 5; i++)
                    cumulative_probablity[4] += selection_probablity[i];
                for (int i = 0; i < 6; i++)
                    cumulative_probablity[5] += selection_probablity[i];
                for (int i = 0; i < 7; i++)
                    cumulative_probablity[6] += selection_probablity[i];
                for (int i = 0; i < 8; i++)
                    cumulative_probablity[7] += selection_probablity[i];
                for (int i = 0; i < 9; i++)
                    cumulative_probablity[8] += selection_probablity[i];
                for (int i = 0; i < 10; i++)
                    cumulative_probablity[9] += selection_probablity[i];

                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add(i.ToString() + " : " + cumulative_probablity[i]);
                }


                double[] r_random = new double[10];
                //for (int i = 0; i < 10; i++)
                //    r_random[i] = Convert.ToDouble(rnd.NextDouble().ToString().Substring(0, 7));

                for (int i = 0; i < 10; i++)
                    r_random[i] = rnd.NextDouble();

                listBox3.Items.Clear();
                for (int i = 0; i < 10; i++)
                    listBox3.Items.Add(i.ToString() + " : " + r_random[i]);


                // باید ببینیم مقادیر تولید شده توسط رولت ویل بین کدام کیو ها هستند و اگر بین
                // دو کیو بود ان کیویی که در حد بالا قرار دارد آن بردار اش انتخاب میشود
                string[] v_new = new string[10];
                listBox4.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    if (r_random[i] >= cumulative_probablity[0] && r_random[i] <= cumulative_probablity[1])
                    {
                        v_new[i] = v[1];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(1) : " + v[1] + " : " + eval_v_f[1]);
                    }
                    else if (r_random[i] >= cumulative_probablity[1] && r_random[i] <= cumulative_probablity[2])
                    {
                        v_new[i] = v[2];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(2) : " + v[2] + " : " + eval_v_f[2]);
                    }
                    else if (r_random[i] >= cumulative_probablity[2] && r_random[i] <= cumulative_probablity[3])
                    {
                        v_new[i] = v[3];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(3) : " + v[3] + " : " + eval_v_f[3]);
                    }
                    else if (r_random[i] >= cumulative_probablity[3] && r_random[i] <= cumulative_probablity[4])
                    {
                        v_new[i] = v[4];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(4) : " + v[4] + " : " + eval_v_f[4]);
                    }
                    else if (r_random[i] >= cumulative_probablity[4] && r_random[i] <= cumulative_probablity[5])
                    {
                        v_new[i] = v[5];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(5) : " + v[5] + " : " + eval_v_f[5]);
                    }
                    else if (r_random[i] >= cumulative_probablity[5] && r_random[i] <= cumulative_probablity[6])
                    {
                        v_new[i] = v[6];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(6) : " + v[6] + " : " + eval_v_f[6]);
                    }
                    else if (r_random[i] >= cumulative_probablity[6] && r_random[i] <= cumulative_probablity[7])
                    {
                        v_new[i] = v[7];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(7) : " + v[7] + " : " + eval_v_f[7]);
                    }
                    else if (r_random[i] >= cumulative_probablity[7] && r_random[i] <= cumulative_probablity[8])
                    {
                        v_new[i] = v[8];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(8) : " + v[8] + " : " + eval_v_f[8]);
                    }
                    else if (r_random[i] >= cumulative_probablity[8] && r_random[i] <= cumulative_probablity[9])
                    {
                        v_new[i] = v[9];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(9) : " + v[9] + " : " + eval_v_f[9]);
                    }
                    else if (r_random[i] >= 0 && r_random[i] < cumulative_probablity[0])
                    {
                        v_new[i] = v[0];
                        listBox4.Items.Add(i.ToString() + " : " + "v_new[" + i.ToString() + "]" + " : " + "v_old(0) : " + v[0] + " : " + eval_v_f[0]);
                    }
                }

                listBox6.Items.Clear();
                for (int i = 0; i < 10; i++)
                { // show roulette wheel selected items in tabpage2
                    if (i != 9)
                    {
                        listBox6.Items.Add(listBox4.Items[i].ToString());
                    }
                    if (i == 9)
                    {
                        try
                        {
                            listBox6.Items.Add(listBox4.Items[9].ToString());
                        }
                        catch (Exception ee1) { }
                    }
                }
   
                //crossover procedure
            crossover_procedure:
                string[] v_parrents = new string[10];
                for (int i = 0; i < 10; i++)
                    v_parrents[i] = "";
                int num_of_parrents = 0;
                double[] r_k_rand = new double[10];
                for (int i = 0; i < 10; i++)
                    r_k_rand[i] = rnd.NextDouble();
                for (int i = 0; i < 10; i++)
                    if (r_k_rand[i] <= 0.25)
                    {
                        num_of_parrents++;
                        v_parrents[i] = v_new[i];
                    }
                if (num_of_parrents != 2)
                    goto crossover_procedure;

                int pos = rnd.Next(0, 33);
                string[] v_parr_after_CO = new string[2];
                v_parr_after_CO[0] = v_parr_after_CO[1] = "";
                for (int i = 0; i < 10; i++)
                {
                    if (v_parrents[i] == "")
                    { }
                    else
                    {
                        if (v_parr_after_CO[0] == "")
                            v_parr_after_CO[0] = v_parrents[i];
                        else v_parr_after_CO[1] = v_parrents[i];
                    }

                }

                string[] offsprings = new string[2];
                offsprings[0] = v_parr_after_CO[0].Substring(0, pos) + v_parr_after_CO[1].Substring(pos, Convert.ToInt32(m) - pos);
                offsprings[1] = v_parr_after_CO[1].Substring(0, pos) + v_parr_after_CO[0].Substring(pos, Convert.ToInt32(m) - pos);

                listBox7.Items.Clear();
                listBox7.Items.Add(v_parr_after_CO[0]);
                listBox7.Items.Add(v_parr_after_CO[1]);

                listBox8.Items.Clear();
                listBox8.Items.Add(offsprings[0]);
                listBox8.Items.Add(offsprings[1]);

                //mutation :
                int pos_mutat = rnd.Next(0, 33);
                int witch_offsp = rnd.Next(0, 2);
                char[] offsp = offsprings[witch_offsp].ToCharArray();
                if (offsprings[witch_offsp][pos_mutat] == '0')
                    offsp[pos_mutat] = '1';
                else
                    offsp[pos_mutat] = '0';
                 
                string offsp_muta = "";
                for (int i = 0; i < offsp.Length; i++)

                    offsp_muta += offsp[i].ToString();


                listBox9.Items.Clear();
                listBox9.Items.Add(offsp_muta);



                listBox10.Items.Clear();
                /****************************************************??????????????*/
                for (int i = 0; i < 10; i++)
                    listBox10.Items.Add(v_new[i]);
                    //listBox10.Items.Add(v_new[1]);
                    //listBox10.Items.Add(v_new[2]);
                    //listBox10.Items.Add(v_new[3]);
                    //listBox10.Items.Add(v_new[4]);
                    //listBox10.Items.Add(v_new[5]);
                    //listBox10.Items.Add(v_new[6]);
                    //listBox10.Items.Add(v_new[7]);
                    //listBox10.Items.Add(v_new[8]);
                    //listBox10.Items.Add(v_new[9]);
                listBox10.Items.Add(offsprings[0]);
                listBox10.Items.Add(offsprings[1]);
                listBox10.Items.Add(offsp_muta);

              //  string[] v_last_13 = new string[13];
                for (int i = 0; i < 10; i++)
                    v_last_13[i] = v_new[i];
                v_last_13[10] = offsprings[0];
                v_last_13[11] = offsprings[1];
                v_last_13[12] = offsp_muta;

                double[] eval_final = new double[13];
                for (int i = 0; i < 13; i++)
                {
                    eval_final[i] = max_f_x_y(mapping_binary_to_realnumber(a1, v_last_13[i].Substring(0, (int)m1), b1, m),
                                             mapping_binary_to_realnumber(a2, v_last_13[i].Substring((int)m1, (int)m2), b2, m));
                    
                }               


                listBox11.Items.Clear();
                for (int i = 0; i < 13; i++)
                    listBox11.Items.Add(eval_final[i]);

                double[] eval_final_sorted = new double[13];
                eval_final_sorted = eval_final;
                for (int i = 0; i < 13; i++)
                    for (int j = 0; j < 13; j++)
                        if (eval_final_sorted[i] > eval_final_sorted[j])
                        {
                            double temp = eval_final_sorted[i];
                            eval_final_sorted[i] = eval_final_sorted[j];
                            eval_final_sorted[j] = temp;

                        }

                listBox12.Items.Clear();
                for (int i = 0; i < 13; i++)
                    listBox12.Items.Add(eval_final_sorted[i]);

                textBox5.Text = eval_final_sorted[0].ToString();
      

                double[] eval_temp = new double[13];
                for (int i = 0; i < 13; i++)
                {
                    eval_temp[i] = max_f_x_y(mapping_binary_to_realnumber(a1, v_last_13[i].Substring(0, (int)m1), b1, m),
                                             mapping_binary_to_realnumber(a2, v_last_13[i].Substring((int)m1, (int)m2), b2, m));

                }


               for (int i = 0; i < 13; i++)
                    v_temp2[i] = "";
                biggestnum(eval_temp);
                listBox13.Items.Clear();
                for (int i = 0; i < 13; i++)
                    listBox13.Items.Add(v_temp2[i]);

                for (int i = 0; i < 10; i++)
                    v[i] = v_temp2[i];

               // listBox14.Items.Clear();
                listBox14.Items.Add
                    (
                    "iteration number : " + ittera.ToString() +
                    "     total fitness : " + total_fitness.ToString() +
                    "     max value : " +eval_final_sorted[0].ToString() +
                    "     x : " + mapping_binary_to_realnumber(a1, listBox13.Items[0].ToString().Substring(0, (int)m1), b1, m).ToString() +
                    "     y : " + mapping_binary_to_realnumber(a2, listBox13.Items[0].ToString().Substring((int)m1, (int)m2), b2, m).ToString()
                    );

                //label33.Show();
                //label32.Show();
                //label31.Show();
                //label30.Show();
                //label29.Show();

                label29.Text = "iteration number : " + (ittera+1).ToString();
                label30.Text = "total fitness : " + total_fitness.ToString();
                label31.Text = "max value : " + eval_final_sorted[0].ToString();
                label32.Text = "x : " + mapping_binary_to_realnumber(a1, listBox13.Items[0].ToString().Substring(0, (int)m1), b1, m).ToString();
                label33.Text = "y : " + mapping_binary_to_realnumber(a2, listBox13.Items[0].ToString().Substring((int)m1, (int)m2), b2, m).ToString();

            } // for ring itteration 

            label28.Text = "Finish Time : ";
            if(Convert.ToInt32(textBox8.Text)>0)
            label28.Text += System.DateTime.Now.TimeOfDay.Hours.ToString() + ":" + System.DateTime.Now.TimeOfDay.Minutes.ToString() + ":"
                 + System.DateTime.Now.TimeOfDay.Seconds.ToString() + ":" + System.DateTime.Now.TimeOfDay.Milliseconds.ToString();
           


        } // end of button1_Click

   

        

        private static void biggestnum(double[] aaaaaa)
        {

            double[] eval_final_sorted2 = new double[13];
            for (int i = 0; i < 13; i++)
                eval_final_sorted2[i] = aaaaaa[i];
            double[] evaltemp = new double[13];
            for (int i = 0; i < 13; i++)
                evaltemp[i] = eval_final_sorted2[i];
            for (int i = 0; i < 13; i++)
                for (int j = 0; j < 13; j++)
                    if (eval_final_sorted2[i] > eval_final_sorted2[j])
                    {
                        double temp = eval_final_sorted2[i];
                        eval_final_sorted2[i] = eval_final_sorted2[j];
                        eval_final_sorted2[j] = temp;
                    }

            for (int i = 0; i < 13; i++)
                for (int j = 0; j < 13; j++)
                    if (evaltemp[i] == eval_final_sorted2[j])
                        v_temp2[j] = v_last_13[i];
             
        }
        private double max_f_x_y(double x1, double x2)
        {//function
            return (21.5 + (x1 * Math.Sin(4 * Math.PI  * x1)) + (x2 * Math.Sin(20 * Math.PI  * x2)));
        //  return (21.5 + (x1 * Math.Sin(4 * 3.141592 * x1)) + (x2 * Math.Sin(20 * 3.141592 * x2)));
          // return x1+ x2;
        }
        private double mapping_binary_to_realnumber(double aj,string sub_str, double bj, double mj)
        {
            if (aj == -3)
                if (bj == b1)
                    mj = 18;
            if (aj == a2)
                if (bj == 5.8)
                    mj = 15;

            double bj_aj =  bj - aj;

            double tavan_1 = Math.Pow(2, mj);
            tavan_1 = tavan_1 - 1;

            long conv_int64 = Convert.ToInt64(sub_str,2);
            double calc_p1= bj_aj / tavan_1 ;

            double calc_p2 = conv_int64 * calc_p1;

            double calc_p3 = aj + calc_p2;
           // if(calc_p3.ToString().Length>7)
            //calc_p3 = Convert.ToDouble( calc_p3.ToString().Substring(0, 7));
               
            return calc_p3;

         //   return Convert.ToDouble((aj + (Convert.ToInt64(sub_str, 2) * ((bj - aj) / (Math.Pow(2, mj) - 1)))).ToString().Substring(0, 7));
            
        }
        private string random_v(Random rnd)
        {
            string rand_v = "";
            for (int i = 0; i <33 ; i++)
                rand_v += rnd.Next(0, 2);
            return rand_v;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox14.Items.Clear();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }  
    }
}
