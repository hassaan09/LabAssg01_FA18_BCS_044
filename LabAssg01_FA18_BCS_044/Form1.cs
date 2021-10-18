using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabAssg01_FA18_BCS_044
{
    public partial class Form1 : Form
    {
        // A global variable path will be defined to store path of files
        String path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This prompts an info box on the screen
            MessageBox.Show("Hassaan Moeed");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will close the whole application
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult openResult = openFileDialog1.ShowDialog();
            if(openResult==DialogResult.OK)
            {
                //the path of the filename will be fetched from the openFileDialog,and path
                //will be stored in variable path;
                path = openFileDialog1.FileName;
                // a try and catch block will take care for any error while opening files.
                try
                {
                    //StreamReader. Read method reads the next character or next set of
                    //characters from the input stream.
                    StreamReader obj = new StreamReader(path);
                    String contents = obj.ReadToEnd();
                    obj.Close();
                    textBox1.Text = contents;



                }
                catch(IOException ioe)
                {
                    MessageBox.Show("Error"+ioe.Message);
                }

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            path = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (path== String.Empty)
            {
                DialogResult saveResult = saveFileDialog1.ShowDialog();
                if (saveResult == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    try
                    {
                        //StreamWriter class in C# writes characters to a stream
                        StreamWriter obj2 = new StreamWriter(path);
                        obj2.Write(textBox1.Text);
                        obj2.Close();


                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error" + ioe.Message);

                    }
                }
            }
            else
            {
                try
                {
                    //StreamWriter class in C# writes characters to a stream
                    StreamWriter obj2 = new StreamWriter(path);
                    obj2.Write(textBox1.Text);
                    obj2.Close();


                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error" + ioe.Message);

                }
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This txt extension will filter out text files from other files
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                try
                {
                    //StreamWriter class in C# writes characters to a stream
                    StreamWriter obj2 = new StreamWriter(path);
                    obj2.Write(textBox1.Text);
                    obj2.Close();


                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error" + ioe.Message);

                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hassaan Moeed \n FA18-BCS-044 \n Visual Programming \n Fall 2018");
        }

        private void fontModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }
    }
}
