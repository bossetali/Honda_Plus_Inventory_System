using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Honda_Inventory_Entry : Form
    {
        ListBox listbox5;
        public Honda_Inventory_Entry()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
            listbox5 = new ListBox();
        }

        private void Honda_Inventory_Entry_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string curItem2 = listBox1.SelectedItem.ToString();
            String[] Models = new string[100];
            switch (curItem2)
            {
                case "2019":
                    Models = new String[] { "Accord","Civic" };
                    break;
                case "2018":
                    Models = new String[] { "This","That" };
                    break;
                case "2017":
                    Models = new String[] { "this","That" };
                    break;
                case "2016":
                    Models = new String[] { "this","That" };
                    break;
                case "2015":
                    Models = new String[] { "this","That" };
                    break;
                case "2014":
                    Models = new String[] { "this","That" };
                    break;
                case "2013":
                    Models = new String[] { "this", "That" };
                    break;
                case "2012":
                    Models = new String[] { "this", "That" };
                    break;
                case "2011":
                    Models = new String[] { "this", "That" };
                    break;
                case "2010":
                    Models = new String[] { "this", "That" };
                    break;
                case "2009":
                    Models = new String[] { "this", "That" };
                    break;
                case "2008":
                    Models = new String[] { "this", "That" };
                    break;
                case "2007":
                    Models = new String[] { "this", "That" };
                    break;
                case "2006":
                    Models = new String[] { "this", "That" };
                    break;
                case "2005":
                    Models = new String[] { "this", "That" };
                    break;
                case "2004":
                    Models = new String[] { "this", "That" };
                    break;
                case "2003":
                    Models = new String[] { "this", "That" };
                    break;
                case "2002":
                    Models = new String[] { "this", "That" };
                    break;
                case "2001":
                    Models = new String[] { "this", "That" };
                    break;
                case "2000":
                    Models = new String[] { "this", "That" };
                    break;
                case "1999":
                    Models = new String[] { "this", "That" };
                    break;
                case "1998":
                    Models = new String[] { "this", "That" };
                    break;
                case "1997":
                    Models = new String[] { "this", "That" };
                    break;
                case "1996":
                    Models = new String[] { "this", "That" };
                    break;
                case "1995":
                    Models = new String[] { "this", "That" };
                    break;
                case "1994":
                    Models = new String[] { "this", "That" };
                    break;
                case "1993":
                    Models = new String[] { "this", "That" };
                    break;
                case "1992":
                    Models = new String[] { "this", "That" };
                    break;
                case "1991":
                    Models = new String[] { "this", "That" };
                    break;
                case "1990":
                    Models = new String[] { "this", "That" };
                    break;
            }
            foreach (String i in Models)
            {
                listBox2.Items.Add(i);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string curItem2 = listBox2.SelectedItem.ToString();
            String[] Models = new string[100];
            switch (curItem2)
            {
                case "Accord":
                    Models = new String[] { "EX", "LX" };
                    break;
                case "Civic":
                    Models = new String[] { "EX", "LX" };
                    break;
            }
            foreach (String i in Models)
            {
                listBox3.Items.Add(i);
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            string curItem2 = listBox3.SelectedItem.ToString();
            String[] Models = new string[100];
            switch (curItem2)
            {
                case "EX":
                    Models = new String[] { "L4-1.5", "L4-2.0" };
                    break;
                case "LX":
                    Models = new String[] { "L4-1.5", "L4-2.0" };
                    break;
            }
            foreach (String i in Models)
            {
                listBox4.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string curItem1 = listBox1.SelectedItem.ToString();
            string curItem2 = listBox2.SelectedItem.ToString();
            string curItem3 = listBox3.SelectedItem.ToString();
            string curItem4 = listBox4.SelectedItem.ToString();
            listbox5.Items.Add(curItem1);
            listbox5.Items.Add(curItem2);
            listbox5.Items.Add(curItem3);
            listbox5.Items.Add(curItem4);

            //Code for the Parts 


            string filename = string.Join( curItem1, curItem2, curItem3,curItem4 );

            string sPath = "C:\\Users\\korin\\Documents\\Inventory\\Honda\\"+filename+".txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listbox5.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Inventory saved!");

            this.Close();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
