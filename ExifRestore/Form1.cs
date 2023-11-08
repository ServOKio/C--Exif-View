using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifRestore
{
    public partial class Exif : Form
    {
        public static Image global_sender;

        public Exif()
        {
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
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
                    this.Text = fileNames[0];

                    using (FileStream fstream = new FileStream(fileNames[0], FileMode.Open)) pictureBox1.Image = Image.FromStream(fstream);

                    //Get type
                    using (FileStream fstream = new FileStream(fileNames[0], FileMode.Open))
                    {
                      
                        var fileType = FileTypeDetector.DetectFileType(fstream);
                        if (fileType == FileType.Png)
                        {
                            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fstream);

                            foreach (var directory in directories)
                                Console.WriteLine($"{directory.Name}");

                            var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                            var dateTime = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagImageWidth);

                            MetadataExtractor.Directory dir = GetByName(directories, "png-text");

                            Tag tag = dir.Tags.First(c => c.Name == "Textual Data");

                            //regex
                            string positivePattern = @"\bparameters: ([\s\S]*?)(?=\nNegative prompt\b)";
                            string negativePattern = @"\bNegative prompt: ([\s\S]*?)(?=\nSteps: \b)";
                            string metaPattern = @"(Steps[\s\S].*)";
                            RegexOptions options = RegexOptions.Multiline;

                            positiveBox.Text = Regex.Matches(tag.Description, positivePattern, options)[0].Groups[1].Value;
                            negativeBox.Text = Regex.Matches(tag.Description, negativePattern, options)[0].Groups[1].Value;
                            metaBox.Text = Regex.Matches(tag.Description, metaPattern, options)[0].Groups[1].Value;
                        } else
                        {
                            Console.WriteLine($"{fileType}"); //Textual Data
                        }
                    }
               
                }
            }

        }

        public MetadataExtractor.Directory GetByName(IEnumerable<MetadataExtractor.Directory> dirs, string name)
        {
            name = name.ToLower();
            return dirs.First(c => c.Name.ToLower() == name);
        }

        private void onLeave(object sender, EventArgs e)
        {

        }
    }
}