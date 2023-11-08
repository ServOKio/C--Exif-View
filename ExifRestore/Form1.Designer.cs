using System.Drawing;
using System.Windows.Forms;

namespace ExifRestore
{
    partial class Exif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metaBox = new System.Windows.Forms.RichTextBox();
            this.negativeBox = new System.Windows.Forms.RichTextBox();
            this.positiveBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(482, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.onDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.onEnter);
            this.pictureBox1.DragLeave += new System.EventHandler(this.onLeave);
            // 
            // metaBox
            // 
            this.metaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.metaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metaBox.ForeColor = ColorTranslator.FromHtml("#cbcbcb");
            this.metaBox.Location = new System.Drawing.Point(12, 462);
            this.metaBox.Name = "metaBox";
            this.metaBox.Size = new System.Drawing.Size(464, 76);
            this.metaBox.TabIndex = 1;
            this.metaBox.Text = "";
            // 
            // negativeBox
            // 
            this.negativeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.negativeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.negativeBox.Location = new System.Drawing.Point(12, 264);
            this.negativeBox.Name = "negativeBox";
            this.negativeBox.Size = new System.Drawing.Size(464, 192);
            this.negativeBox.TabIndex = 2;
            this.negativeBox.Text = "";
            // 
            // positiveBox
            // 
            this.positiveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.positiveBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.positiveBox.Location = new System.Drawing.Point(12, 66);
            this.positiveBox.Name = "positiveBox";
            this.positiveBox.Size = new System.Drawing.Size(464, 192);
            this.positiveBox.TabIndex = 3;
            this.positiveBox.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Location = new System.Drawing.Point(12, 12);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(464, 48);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "";
            // 
            // Exif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1017, 550);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.positiveBox);
            this.Controls.Add(this.negativeBox);
            this.Controls.Add(this.metaBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exif";
            this.Text = "Exif";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox metaBox;
        private RichTextBox negativeBox;
        private RichTextBox positiveBox;
        private RichTextBox richTextBox4;
    }
}

