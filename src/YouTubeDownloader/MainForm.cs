using System;
using System.Windows.Forms;

using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            videoCombo.SelectedIndex = 0;
            audioCombo.SelectedIndex = 0;
        }

        private void GO_click(object sender, EventArgs e)
        {
            if (!urlBox.Text.Equals("") && !outFolder.Text.Equals(""))
                ExecuteDownload(); 
        }

        private void ExecuteDownload()
        {
            String args = null;

            if (videoRadio.Checked == true)
            {
                args = "-f " + getFileExtension(videoCombo.Text);
                System.Console.WriteLine(videoCombo.Text + "  " + getFileExtension(videoCombo.Text));
            }
            else
            {
                args = "-x --audio-format " + getFileExtension(audioCombo.Text);
                System.Console.WriteLine(audioCombo.Text + "  " + getFileExtension(audioCombo.Text));
            }

            args += " -o \".\\ffmpeg\\out\\%(title)s-%(id)s.%(ext)s\" " + urlBox.Text;
            System.Console.WriteLine("args: " + args);

            var youtubedl = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ".\\ffmpeg\\youtube-dl.exe",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            try
            {
                youtubedl.Start();
                outBox.AppendText("Starting download...\n");
                while (!youtubedl.StandardOutput.EndOfStream)
                {
                    string line = youtubedl.StandardOutput.ReadLine();
                    if (line.Contains("Usage:")) throw new Exception();

                    outBox.AppendText(line + "\n");
                }
                youtubedl.WaitForExit();
            }
            catch (Exception)
            {
                if (MessageBox.Show("Something went wrong :(\n" +
                                    "Check URL or try another file format", "Error") == DialogResult.OK)
                {
                    urlBox.ResetText(); outBox.ResetText();
                }
                return;
            }

            foreach (var f in Directory.GetFiles(".\\ffmpeg\\out", "*.*"))
            {
                var file = new FileInfo(f);
                file.MoveTo(Path.Combine(outFolder.Text, file.Name));
            }

            if (MessageBox.Show("Download completed!", "Done") == DialogResult.OK)
            {
                urlBox.ResetText(); outBox.ResetText();
            }
        }

        private string getFileExtension(string selectedText)
        {
            if (selectedText.Contains("3gp"))
                return "3gp";
            else if (selectedText.Contains("aac"))
                return "aac";
            else if (selectedText.Contains("flv"))
                return "flv";
            else if (selectedText.Contains("m4a"))
                return "m4a";
            else if (selectedText.Contains("mp3"))
                return "mp3";
            else if (selectedText.Contains("mp4"))
                return "mp4";
            else if (selectedText.Contains("ogg"))
                return "ogg";
            else if (selectedText.Contains("wav"))
                return "wav";
            else
                return "webm";
        }

        private void videoCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            videoRadio.Checked = true;
        }

        private void audioCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            audioRadio.Checked = true;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                outFolder.Text = dialog.FileName;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YouTube Downloader\n" +
                            "by Nicola Nicodemo 2017\n\n" +
                            "Based on youtube-dl and ffmpeg\n", "About");
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
