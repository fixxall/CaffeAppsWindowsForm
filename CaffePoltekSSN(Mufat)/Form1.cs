using System.Drawing.Text;

namespace CaffePoltekSSN_Mufat_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String minum = "";
            String ukuran = "";
            decimal Slevel = numericUpDown1.Value;
            decimal IceLevel = numericUpDown2.Value;
            bool notPesanMinum = false;
            int harga = 0;
            if (checkBox1.Checked)
            {
                minum = "Espresso";
                harga += 10000;
            }
            else if (checkBox2.Checked)
            {
                minum = "Latte";
                harga += 15000;
            }
            else if (checkBox3.Checked)
            {
                minum = "Cappucino";
                harga += 12000;
            }
            else notPesanMinum = true;
            if (radioButton1.Checked)
            {
                ukuran = "Big";
                harga += 3000;
            }
            else ukuran = "Medium";
            List<String> MyList = listBox1.SelectedItems.Cast<string>().ToList();




            if (notPesanMinum) MessageBox.Show("Not Pesan Minuman Bozz");
            else
            {
                String orderan = "Your Order was: " + minum + "\n" + "ukuran: " + ukuran + "\n" + "Sugar level: " + Slevel.ToString() + "\n" + "Ice Level: " + IceLevel.ToString() + "\n";
                orderan = orderan + "Topping: ";
                foreach (String i in MyList)
                {
                    int hrgsatuan = int.Parse(i.Split("(")[1].Split(")")[0]);
                    orderan = orderan + i + "\n";
                    harga += hrgsatuan;
                    
                }

                MessageBox.Show(orderan + "Total Harga: " + harga);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}