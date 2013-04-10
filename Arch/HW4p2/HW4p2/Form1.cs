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

namespace HW4p2
{
    public partial class Form1 : Form, IComponent
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pressed(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            Form form;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|JPEG (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;
            String path;// =  openFileDialog1.FileName;
            form = new Form();
            JPEGBuilder pic = new JPEGBuilder();
            TextBuilder text =  new TextBuilder();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream ofd = openFileDialog1.OpenFile();
                path = openFileDialog1.FileName;
                form.Show();
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            
                            
                            form.BackgroundImage = pic.readImage(path);
                            
                        }
                    }
                }
                catch //(OutOfMemoryException ex)
                {
                   try
                   {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                TextBox box = new TextBox();
                                box.SetBounds(0, 0, form.Width, form.Height);

                                form.Controls.Add(box);
                                box.Text = text.getText(path);
                                 
                            }
                        }
                    }
                    catch
                   {
                        MessageBox.Show("Error:not jpeg or txt file ");
                        form.Close(); 
                    }
                }
            }
            
        }
        
    }
}
