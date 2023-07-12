using System;
using System.Windows.Forms;

namespace Sos_Bulan_Program_Dizi_Ile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] dizi = new string[3, 3];
        Random rnd = new Random();
        string st;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int sayi = rnd.Next(1, 3);
                    if (sayi == 1) dizi[i, j] = "S";
                    if (sayi == 2) dizi[i, j] = "O";
                }
            }

            for (int i = 0; i < 3; i++)
            {
                st = dizi[i, 0] + dizi[i, 1] + dizi[i, 2];
                listBox1.Items.Add(st);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int say = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        if (dizi[i, j] + dizi[i - 1, j] + dizi[i - 2, j] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        if (dizi[i, j] + dizi[i + 1, j] + dizi[i + 2, j] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        if (dizi[i, j] + dizi[i, j + 1] + dizi[i, j + 2] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        if (dizi[i, j] + dizi[i, j - 1] + dizi[i, j - 2] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        if (dizi[i, j] + dizi[i + 1, j + 1] + dizi[i + 2, j + 2] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }

                    try
                    {
                        if (dizi[i, j] + dizi[i - 1, j - 1] + dizi[i - 2, j - 2] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }

                    try
                    {
                        if (dizi[i, j] + dizi[i + 1, j - 1] + dizi[i + 2, j - 2] == "SOS") say++;
                    }
                    catch (Exception)
                    {

                    }

                    try
                    {
                        if (dizi[i, j] + dizi[i - 1, j + 1] + dizi[i - 2, j + 2] == "SOS") say++;
                    }

                    catch (Exception)
                    {

                    }
                }

            }

            double son = say / 2;
            label1.Text = son.ToString();
        }
    }
}
