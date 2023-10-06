using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileIODemoProduct
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductFolder\Product.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtID.Text = br.ReadInt32().ToString();
                txtProductName.Text = br.ReadString();
                txtProductPrice.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\ProductFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\ProductFolder\Product.dat";
                if (File.Exists(path))
                {
                    MessageBox.Show("Product already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("Product Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductFolder\Product.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtID.Text));
                bw.Write(txtProductName.Text);
                bw.Write(Convert.ToDouble(txtProductPrice.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStreWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductFolder\data.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();

                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStreamRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductFolder\data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
    

