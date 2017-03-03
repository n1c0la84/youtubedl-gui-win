namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.videoRadio = new System.Windows.Forms.RadioButton();
            this.videoCombo = new System.Windows.Forms.ComboBox();
            this.audioRadio = new System.Windows.Forms.RadioButton();
            this.audioCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outFolder = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert YouTube Video URL:";
            // 
            // urlBox
            // 
            this.urlBox.AllowDrop = true;
            this.urlBox.Location = new System.Drawing.Point(15, 31);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(356, 20);
            this.urlBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(11, 9, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GO_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 169);
            this.button2.Margin = new System.Windows.Forms.Padding(33, 6, 6, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancel_click);
            // 
            // outBox
            // 
            this.outBox.BackColor = System.Drawing.Color.White;
            this.outBox.Location = new System.Drawing.Point(12, 198);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(360, 252);
            this.outBox.TabIndex = 5;
            // 
            // videoRadio
            // 
            this.videoRadio.AutoSize = true;
            this.videoRadio.Checked = true;
            this.videoRadio.Location = new System.Drawing.Point(12, 109);
            this.videoRadio.Margin = new System.Windows.Forms.Padding(9, 9, 3, 3);
            this.videoRadio.Name = "videoRadio";
            this.videoRadio.Size = new System.Drawing.Size(105, 17);
            this.videoRadio.TabIndex = 6;
            this.videoRadio.TabStop = true;
            this.videoRadio.Text = "Download video:";
            this.videoRadio.UseVisualStyleBackColor = true;
            // 
            // videoCombo
            // 
            this.videoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCombo.FormattingEnabled = true;
            this.videoCombo.Items.AddRange(new object[] {
            "MPEG-4 Part 14  [extension: mp4]",
            "WebM  [extension: webm]",
            "Flash Video  [extension: flv]",
            "3GP  [extension: 3gp]"});
            this.videoCombo.Location = new System.Drawing.Point(144, 109);
            this.videoCombo.Margin = new System.Windows.Forms.Padding(27, 3, 3, 3);
            this.videoCombo.Name = "videoCombo";
            this.videoCombo.Size = new System.Drawing.Size(228, 21);
            this.videoCombo.TabIndex = 7;
            this.videoCombo.SelectionChangeCommitted += new System.EventHandler(this.videoCombo_SelectionChangeCommitted);
            // 
            // audioRadio
            // 
            this.audioRadio.AutoSize = true;
            this.audioRadio.Location = new System.Drawing.Point(12, 140);
            this.audioRadio.Name = "audioRadio";
            this.audioRadio.Size = new System.Drawing.Size(105, 17);
            this.audioRadio.TabIndex = 8;
            this.audioRadio.Text = "Download audio:";
            this.audioRadio.UseVisualStyleBackColor = true;
            // 
            // audioCombo
            // 
            this.audioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioCombo.FormattingEnabled = true;
            this.audioCombo.Items.AddRange(new object[] {
            "MPEG-2 Layer III  [extension: mp3]",
            "MPEG-4 Part 14  [extension: m4a]",
            "Ogg Vorbis  [extension: ogg]",
            "Advanced Audio Coding  [extension: aac]",
            "Wave uncompressed  [extension: wav]"});
            this.audioCombo.Location = new System.Drawing.Point(144, 136);
            this.audioCombo.Name = "audioCombo";
            this.audioCombo.Size = new System.Drawing.Size(228, 21);
            this.audioCombo.TabIndex = 9;
            this.audioCombo.SelectionChangeCommitted += new System.EventHandler(this.audioCombo_SelectionChangeCommitted);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "About...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.About_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output folder:";
            // 
            // outFolder
            // 
            this.outFolder.Location = new System.Drawing.Point(15, 77);
            this.outFolder.Name = "outFolder";
            this.outFolder.Size = new System.Drawing.Size(275, 20);
            this.outFolder.TabIndex = 12;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(296, 77);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 13;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.outFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.audioCombo);
            this.Controls.Add(this.audioRadio);
            this.Controls.Add(this.videoCombo);
            this.Controls.Add(this.videoRadio);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YouTube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.RadioButton videoRadio;
        private System.Windows.Forms.ComboBox videoCombo;
        private System.Windows.Forms.RadioButton audioRadio;
        private System.Windows.Forms.ComboBox audioCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outFolder;
        private System.Windows.Forms.Button Browse;
    }
}

