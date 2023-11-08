using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifRestore
{
    public partial class Form1 : Form
    {
        public static Image global_sender;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void onDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileNames = data as string[];
                if(fileNames.Length > 0)
                {
                    pictureBox1.Image = Image.FromFile(fileNames[0]);
                    richTextBox1.Text = fileNames[0];
                }
            }

        }

        private void onLeave(object sender, EventArgs e)
        {

        }
    }
}
