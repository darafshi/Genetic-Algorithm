using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gene_Alg_Console
{
    class GA_Console
    {
        public static string[] v = new string[10];
        public static string[] v_temp2 = new string[13];
        public static string[] v_last_13 = new string[13];

        public static double a1 = -3;
        public static double b1 = 12.1;
        public static double a2 = 4.1;
        public static double b2 = 5.8;

        public GA_Console()
        {
            throw new System.NotImplementedException();
        }

        ~GA_Console()
        {
            throw new System.NotImplementedException();
        }

        static void Main(string[] args)
        {
            double m = 33;
            double m1 = 18;
            double m2 = m - m1;

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
                v[i] = "";

            for (int i = 0; i < 10; i++)
                v[i] += random_v(rnd);

            Console.WriteLine("enter itteration number : ");
            int itteration_number = Convert.ToInt32(Console.ReadLine());
            for (int ittera = 0; ittera < itteration_number ; ittera++)
            {
                double[] eval_v_f = new double[10];

                string v_1_part_1 = null;
                string v_1_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_1_part_1 += v[0][i];
                for (int i = 18; i < m; i++)
                    v_1_part_2 += v[0][i];

                double eval_v_1_part_1 = mapping_binary_to_realnumber(a1, v_1_part_1, b1, m1);
                double eval_v_1_part_2 = mapping_binary_to_realnumber(a2, v_1_part_2, b2, m2);

                while (!((eval_v_1_part_1 >= a1 && eval_v_1_part_1 <= b1) && (eval_v_1_part_2 >= a2 && eval_v_1_part_2 <= b2)))
                {
                    for (int i = 0; i < 18; i++)
                        v_1_part_1 += v[0][i];
                    for (int i = 18; i < m; i++)
                        v_1_part_2 += v[0][i];

                    eval_v_1_part_1 = mapping_binary_to_realnumber(a1, v_1_part_1, b1, m1);
                    eval_v_1_part_2 = mapping_binary_to_realnumber(a2, v_1_part_2, b2, m2);
                }

                eval_v_f[0] = max_f_x_y(eval_v_1_part_1, eval_v_1_part_2);

                string v_2_part_1 = null;
                string v_2_part_2 = null;

                for (int i = 0; i < 18; i++)
                    v_2_part_1 += v[1][i];
                for (int i = 18; i < m; i++)
                    v_2_part_2 += v[1][i];

                double eval_v_2_part_1 = mapping_binary_to_realnumber(a1, v_2_part_1, b1, m1);
                double eval_v_2_part_2 = mapping_binary_to_realnumber(a2, v_2_part_2, b2, m2);

                while (!((eval_v_2_part_1 >= a1 && eval_v_2_part_1 <= b1) && (eval_v_2_part_2 >= a2 && eval_v_2_part_2 <= b2)))
                {
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

                while (!((eval_v_3_part_1 >= a1 && eval_v_3_part_1 <= b1) && (eval_v_3_part_2 >= a2 && eval_v_3_part_2 <= b2)))
                {
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

                while (!((eval_v_4_part_1 >= a1 && eval_v_4_part_1 <= b1) && (eval_v_4_part_2 >= a2 && eval_v_4_part_2 <= b2)))
                {
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

                while (!((eval_v_5_part_1 >= a1 && eval_v_5_part_1 <= b1) && (eval_v_5_part_2 >= a2 && eval_v_5_part_2 <= b2)))
                {
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

                while (!((eval_v_6_part_1 >= a1 && eval_v_6_part_1 <= b1) && (eval_v_6_part_2 >= a2 && eval_v_6_part_2 <= b2)))
                {
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

                while (!((eval_v_7_part_1 >= a1 && eval_v_7_part_1 <= b1) && (eval_v_7_part_2 >= a2 && eval_v_7_part_2 <= b2)))
                {
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

                while (!((eval_v_8_part_1 >= a1 && eval_v_8_part_1 <= b1) && (eval_v_8_part_2 >= a2 && eval_v_8_part_2 <= b2)))
                {
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

                while (!((eval_v_9_part_1 >= a1 && eval_v_9_part_1 <= b1) && (eval_v_9_part_2 >= a2 && eval_v_9_part_2 <= b2)))
                {
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

                while (!((eval_v_10_part_1 >= a1 && eval_v_10_part_1 <= b1) && (eval_v_10_part_2 >= a2 && eval_v_10_part_2 <= b2)))
                {
                    for (int i = 0; i < 18; i++)
                        v_10_part_1 += v[9][i];
                    for (int i = 18; i < m; i++)
                        v_10_part_2 += v[9][i];

                    eval_v_10_part_1 = mapping_binary_to_realnumber(a1, v_10_part_1, b1, m1);
                    eval_v_10_part_2 = mapping_binary_to_realnumber(a2, v_10_part_2, b2, m2);
                }

                eval_v_f[9] = max_f_x_y(eval_v_10_part_1, eval_v_10_part_2);
                
                double total_fitness = 0;

                for (int i = 0; i < 10; i++)
                    total_fitness += eval_v_f[i];
                
                double[] selection_probablity = new double[10];

                for (int i = 0; i < 10; i++)
                    selection_probablity[i] = eval_v_f[i] / total_fitness;
               
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

                double[] r_random = new double[10];
                for (int i = 0; i < 10; i++)
                    r_random[i] = rnd.NextDouble();
               
                // باید ببینیم مقادیر تولید شده توسط رولت ویل بین کدام کیو ها هستند و اگر بین
                // دو کیو بود ان کیویی که در حد بالا قرار دارد آن بردار اش انتخاب میشود
                string[] v_new = new string[10];

                for (int i = 0; i < 10; i++)
                    if (r_random[i] >= cumulative_probablity[0] && r_random[i] <= cumulative_probablity[1])
                        v_new[i] = v[1];
                    else if (r_random[i] >= cumulative_probablity[1] && r_random[i] <= cumulative_probablity[2])
                        v_new[i] = v[2];
                    else if (r_random[i] >= cumulative_probablity[2] && r_random[i] <= cumulative_probablity[3])
                        v_new[i] = v[3];
                    else if (r_random[i] >= cumulative_probablity[3] && r_random[i] <= cumulative_probablity[4])
                        v_new[i] = v[4];
                    else if (r_random[i] >= cumulative_probablity[4] && r_random[i] <= cumulative_probablity[5])              
                        v_new[i] = v[5];
                    else if (r_random[i] >= cumulative_probablity[5] && r_random[i] <= cumulative_probablity[6])
                        v_new[i] = v[6];
                    else if (r_random[i] >= cumulative_probablity[6] && r_random[i] <= cumulative_probablity[7])
                        v_new[i] = v[7];
                    else if (r_random[i] >= cumulative_probablity[7] && r_random[i] <= cumulative_probablity[8])
                        v_new[i] = v[8];
                    else if (r_random[i] >= cumulative_probablity[8] && r_random[i] <= cumulative_probablity[9])
                        v_new[i] = v[9];
                    else if (r_random[i] >= 0 && r_random[i] < cumulative_probablity[0])
                        v_new[i] = v[0];
                

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
#if false 
                for (int i = 0; i < 10; i++)
                {
                    if (v_parrents[i] == "")
                    { }
                    else
                    {
                        Console.WriteLine(v_parrents[i].ToString());
                        
                    }

                }
#endif 
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

                
                double[] eval_temp = new double[13];
                for (int i = 0; i < 13; i++)
                {
                    eval_temp[i] = max_f_x_y(mapping_binary_to_realnumber(a1, v_last_13[i].Substring(0, (int)m1), b1, m),
                                             mapping_binary_to_realnumber(a2, v_last_13[i].Substring((int)m1, (int)m2), b2, m));

                }


                for (int i = 0; i < 13; i++)
                    v_temp2[i] = "";
                biggestnum(eval_temp);

                for (int i = 0; i < 10; i++)
                    v[i] = v_temp2[i];
                Console.WriteLine();
                Console.WriteLine("iteration number : " + (ittera + 1).ToString());
               // Console.WriteLine("total fitness : " + total_fitness.ToString());
                Console.WriteLine("max value : " + eval_final_sorted[0].ToString());
                Console.WriteLine("x : " + mapping_binary_to_realnumber(a1, v_temp2[0].ToString().Substring(0, (int)m1), b1, m).ToString());
                Console.WriteLine("y : " + mapping_binary_to_realnumber(a2, v_temp2[0].ToString().Substring((int)m1, (int)m2), b2, m).ToString());
#if false 
                for (int i = 0; i < 10; i++)
                    if (v_parrents[i] != "")
                        Console.WriteLine(v_parrents[i]);
#endif
            } // for ring itteration 


            Console.WriteLine("\nDone... press enter to exit\n");
            Console.ReadLine();


        }
        private static double max_f_x_y(double x, double y)
        {//function
         //   return x1 + x2;
            double z = (21.5 + (x * Math.Sin(4 * Math.PI * x)) + (y * Math.Sin(20 * Math.PI * y)));
            return z;
        }
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
        private static string random_v(Random rnd)
        {
            string rand_v = "";
            for (int i = 0; i < 33; i++)
                rand_v += rnd.Next(0, 2);
            return rand_v;
        }
        private static double mapping_binary_to_realnumber(double aj, string sub_str, double bj, double mj)
        {
            if (aj == a1)
                if (bj == b1)
                    mj = 18;
            if (aj == a2)
                if (bj == b2)
                    mj = 15;

            double bj_aj = bj - aj;

            double tavan_1 = Math.Pow(2, mj);
            tavan_1 = tavan_1 - 1;

            long conv_int64 = Convert.ToInt64(sub_str, 2);
            double calc_p1 = bj_aj / tavan_1;

            double calc_p2 = conv_int64 * calc_p1;

            double calc_p3 = aj + calc_p2;
            
            return calc_p3;
            
        }

        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
