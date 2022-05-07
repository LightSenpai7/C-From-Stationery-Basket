using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KırtasiyeÜrünUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        int piece;
        int total;
        int amount;
        int Pencil = 12, Book = 15, Rubber = 5, Uhu = 6, CraftPaper = 3, 
            Bristol = 24, RapidoPen = 15, GouachePaint = 30, OilPaint = 35;

       

        private void button1_Click(object sender, EventArgs e)
        {
            piece = Convert.ToInt32(textBox1.Text);
            if (comboBox1.Text == "Pencil")
            {

                total = Pencil * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";
            }
            if (comboBox1.Text == "Book")
            {

                total = Book * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";
            }
            if (comboBox1.Text == "Rubber")
            {
                total = Rubber * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }
            if (comboBox1.Text == "Uhu")
            {
                total = Uhu * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }
            if (comboBox1.Text == "Craft Paper")
            {
                total = CraftPaper * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }
            if (comboBox1.Text == "Bristol")
            {
                total = Bristol * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }
            if (comboBox1.Text == "Rapido Pen")
            {
                total = RapidoPen * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }
            if (comboBox1.Text == "Gouache Paint")
            {
                total = GouachePaint * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }
            if (comboBox1.Text == "Oil Paint")
            {
                total = OilPaint * piece;
                listBox1.Items.Add(comboBox1.Text + "\t" + piece + "\t" + total);
                textBox1.Text = "";

            }


                amount = amount + total;
            
                textBox2.Text = amount.ToString();

           

        }
        
     
    }
}
