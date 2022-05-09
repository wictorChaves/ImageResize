namespace ImageResize.WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabImage = new System.Windows.Forms.TabControl();
            this.tabOneImage = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxAlignTop = new System.Windows.Forms.CheckBox();
            this.checkBoxEnlarge = new System.Windows.Forms.CheckBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDestiny = new System.Windows.Forms.Button();
            this.textBoxDestiny = new System.Windows.Forms.TextBox();
            this.buttonOpenFileSource = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.tabMultiImage = new System.Windows.Forms.TabPage();
            this.buttonMultiSave = new System.Windows.Forms.Button();
            this.checkBoxMultiAlignTop = new System.Windows.Forms.CheckBox();
            this.checkBoxMultiEnlarge = new System.Windows.Forms.CheckBox();
            this.textBoxMultiHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMultiWidth = new System.Windows.Forms.TextBox();
            this.buttonMultiOpenDestiny = new System.Windows.Forms.Button();
            this.textBoxMultiDestiny = new System.Windows.Forms.TextBox();
            this.buttonMultiOpenSource = new System.Windows.Forms.Button();
            this.textBoxMultiSource = new System.Windows.Forms.TextBox();
            this.tabImage.SuspendLayout();
            this.tabOneImage.SuspendLayout();
            this.tabMultiImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.tabOneImage);
            this.tabImage.Controls.Add(this.tabMultiImage);
            this.tabImage.Location = new System.Drawing.Point(12, 12);
            this.tabImage.Name = "tabImage";
            this.tabImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabImage.SelectedIndex = 0;
            this.tabImage.Size = new System.Drawing.Size(483, 123);
            this.tabImage.TabIndex = 0;
            // 
            // tabOneImage
            // 
            this.tabOneImage.Controls.Add(this.buttonSave);
            this.tabOneImage.Controls.Add(this.checkBoxAlignTop);
            this.tabOneImage.Controls.Add(this.checkBoxEnlarge);
            this.tabOneImage.Controls.Add(this.textBoxHeight);
            this.tabOneImage.Controls.Add(this.label2);
            this.tabOneImage.Controls.Add(this.textBoxWidth);
            this.tabOneImage.Controls.Add(this.buttonOpenFileDestiny);
            this.tabOneImage.Controls.Add(this.textBoxDestiny);
            this.tabOneImage.Controls.Add(this.buttonOpenFileSource);
            this.tabOneImage.Controls.Add(this.textBoxSource);
            this.tabOneImage.Location = new System.Drawing.Point(4, 24);
            this.tabOneImage.Name = "tabOneImage";
            this.tabOneImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabOneImage.Size = new System.Drawing.Size(475, 95);
            this.tabOneImage.TabIndex = 0;
            this.tabOneImage.Text = "An image";
            this.tabOneImage.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(390, 63);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxAlignTop
            // 
            this.checkBoxAlignTop.AutoSize = true;
            this.checkBoxAlignTop.Location = new System.Drawing.Point(308, 68);
            this.checkBoxAlignTop.Name = "checkBoxAlignTop";
            this.checkBoxAlignTop.Size = new System.Drawing.Size(76, 19);
            this.checkBoxAlignTop.TabIndex = 10;
            this.checkBoxAlignTop.Text = "Align Top";
            this.checkBoxAlignTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnlarge
            // 
            this.checkBoxEnlarge.AutoSize = true;
            this.checkBoxEnlarge.Location = new System.Drawing.Point(237, 67);
            this.checkBoxEnlarge.Name = "checkBoxEnlarge";
            this.checkBoxEnlarge.Size = new System.Drawing.Size(65, 19);
            this.checkBoxEnlarge.TabIndex = 9;
            this.checkBoxEnlarge.Text = "Enlarge";
            this.checkBoxEnlarge.UseVisualStyleBackColor = true;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(77, 63);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.PlaceholderText = "Height";
            this.textBoxHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxHeight.Size = new System.Drawing.Size(46, 23);
            this.textBoxHeight.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(6, 63);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.PlaceholderText = "Width";
            this.textBoxWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxWidth.Size = new System.Drawing.Size(46, 23);
            this.textBoxWidth.TabIndex = 6;
            // 
            // buttonOpenFileDestiny
            // 
            this.buttonOpenFileDestiny.Location = new System.Drawing.Point(390, 34);
            this.buttonOpenFileDestiny.Name = "buttonOpenFileDestiny";
            this.buttonOpenFileDestiny.Size = new System.Drawing.Size(81, 23);
            this.buttonOpenFileDestiny.TabIndex = 4;
            this.buttonOpenFileDestiny.Text = "Open Folder";
            this.buttonOpenFileDestiny.UseVisualStyleBackColor = true;
            this.buttonOpenFileDestiny.Click += new System.EventHandler(this.buttonOpenFileDestiny_Click);
            // 
            // textBoxDestiny
            // 
            this.textBoxDestiny.Location = new System.Drawing.Point(6, 35);
            this.textBoxDestiny.Name = "textBoxDestiny";
            this.textBoxDestiny.PlaceholderText = "Destiny";
            this.textBoxDestiny.ReadOnly = true;
            this.textBoxDestiny.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDestiny.Size = new System.Drawing.Size(378, 23);
            this.textBoxDestiny.TabIndex = 3;
            // 
            // buttonOpenFileSource
            // 
            this.buttonOpenFileSource.Location = new System.Drawing.Point(390, 6);
            this.buttonOpenFileSource.Name = "buttonOpenFileSource";
            this.buttonOpenFileSource.Size = new System.Drawing.Size(81, 23);
            this.buttonOpenFileSource.TabIndex = 2;
            this.buttonOpenFileSource.Text = "Open File";
            this.buttonOpenFileSource.UseVisualStyleBackColor = true;
            this.buttonOpenFileSource.Click += new System.EventHandler(this.buttonOpenFileSource_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(6, 6);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.PlaceholderText = "Source";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSource.Size = new System.Drawing.Size(378, 23);
            this.textBoxSource.TabIndex = 1;
            // 
            // tabMultiImage
            // 
            this.tabMultiImage.Controls.Add(this.buttonMultiSave);
            this.tabMultiImage.Controls.Add(this.checkBoxMultiAlignTop);
            this.tabMultiImage.Controls.Add(this.checkBoxMultiEnlarge);
            this.tabMultiImage.Controls.Add(this.textBoxMultiHeight);
            this.tabMultiImage.Controls.Add(this.label1);
            this.tabMultiImage.Controls.Add(this.textBoxMultiWidth);
            this.tabMultiImage.Controls.Add(this.buttonMultiOpenDestiny);
            this.tabMultiImage.Controls.Add(this.textBoxMultiDestiny);
            this.tabMultiImage.Controls.Add(this.buttonMultiOpenSource);
            this.tabMultiImage.Controls.Add(this.textBoxMultiSource);
            this.tabMultiImage.Location = new System.Drawing.Point(4, 24);
            this.tabMultiImage.Name = "tabMultiImage";
            this.tabMultiImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiImage.Size = new System.Drawing.Size(475, 95);
            this.tabMultiImage.TabIndex = 1;
            this.tabMultiImage.Text = "Folder with images";
            this.tabMultiImage.UseVisualStyleBackColor = true;
            // 
            // buttonMultiSave
            // 
            this.buttonMultiSave.Location = new System.Drawing.Point(390, 64);
            this.buttonMultiSave.Name = "buttonMultiSave";
            this.buttonMultiSave.Size = new System.Drawing.Size(82, 23);
            this.buttonMultiSave.TabIndex = 21;
            this.buttonMultiSave.Text = "Save";
            this.buttonMultiSave.UseVisualStyleBackColor = true;
            this.buttonMultiSave.Click += new System.EventHandler(this.buttonMultiSave_Click);
            // 
            // checkBoxMultiAlignTop
            // 
            this.checkBoxMultiAlignTop.AutoSize = true;
            this.checkBoxMultiAlignTop.Location = new System.Drawing.Point(308, 69);
            this.checkBoxMultiAlignTop.Name = "checkBoxMultiAlignTop";
            this.checkBoxMultiAlignTop.Size = new System.Drawing.Size(76, 19);
            this.checkBoxMultiAlignTop.TabIndex = 20;
            this.checkBoxMultiAlignTop.Text = "Align Top";
            this.checkBoxMultiAlignTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiEnlarge
            // 
            this.checkBoxMultiEnlarge.AutoSize = true;
            this.checkBoxMultiEnlarge.Location = new System.Drawing.Point(237, 68);
            this.checkBoxMultiEnlarge.Name = "checkBoxMultiEnlarge";
            this.checkBoxMultiEnlarge.Size = new System.Drawing.Size(65, 19);
            this.checkBoxMultiEnlarge.TabIndex = 19;
            this.checkBoxMultiEnlarge.Text = "Enlarge";
            this.checkBoxMultiEnlarge.UseVisualStyleBackColor = true;
            // 
            // textBoxMultiHeight
            // 
            this.textBoxMultiHeight.Location = new System.Drawing.Point(77, 64);
            this.textBoxMultiHeight.Name = "textBoxMultiHeight";
            this.textBoxMultiHeight.PlaceholderText = "Height";
            this.textBoxMultiHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMultiHeight.Size = new System.Drawing.Size(46, 23);
            this.textBoxMultiHeight.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "x";
            // 
            // textBoxMultiWidth
            // 
            this.textBoxMultiWidth.Location = new System.Drawing.Point(6, 64);
            this.textBoxMultiWidth.Name = "textBoxMultiWidth";
            this.textBoxMultiWidth.PlaceholderText = "Width";
            this.textBoxMultiWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMultiWidth.Size = new System.Drawing.Size(46, 23);
            this.textBoxMultiWidth.TabIndex = 16;
            // 
            // buttonMultiOpenDestiny
            // 
            this.buttonMultiOpenDestiny.Location = new System.Drawing.Point(390, 35);
            this.buttonMultiOpenDestiny.Name = "buttonMultiOpenDestiny";
            this.buttonMultiOpenDestiny.Size = new System.Drawing.Size(82, 23);
            this.buttonMultiOpenDestiny.TabIndex = 15;
            this.buttonMultiOpenDestiny.Text = "Open Folder";
            this.buttonMultiOpenDestiny.UseVisualStyleBackColor = true;
            this.buttonMultiOpenDestiny.Click += new System.EventHandler(this.buttonMultiOpenDestiny_Click);
            // 
            // textBoxMultiDestiny
            // 
            this.textBoxMultiDestiny.Location = new System.Drawing.Point(6, 36);
            this.textBoxMultiDestiny.Name = "textBoxMultiDestiny";
            this.textBoxMultiDestiny.PlaceholderText = "Destiny";
            this.textBoxMultiDestiny.ReadOnly = true;
            this.textBoxMultiDestiny.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMultiDestiny.Size = new System.Drawing.Size(378, 23);
            this.textBoxMultiDestiny.TabIndex = 14;
            // 
            // buttonMultiOpenSource
            // 
            this.buttonMultiOpenSource.Location = new System.Drawing.Point(390, 7);
            this.buttonMultiOpenSource.Name = "buttonMultiOpenSource";
            this.buttonMultiOpenSource.Size = new System.Drawing.Size(82, 23);
            this.buttonMultiOpenSource.TabIndex = 13;
            this.buttonMultiOpenSource.Text = "Open Folder";
            this.buttonMultiOpenSource.UseVisualStyleBackColor = true;
            this.buttonMultiOpenSource.Click += new System.EventHandler(this.buttonMultiOpenSource_Click);
            // 
            // textBoxMultiSource
            // 
            this.textBoxMultiSource.Location = new System.Drawing.Point(6, 7);
            this.textBoxMultiSource.Name = "textBoxMultiSource";
            this.textBoxMultiSource.PlaceholderText = "Source";
            this.textBoxMultiSource.ReadOnly = true;
            this.textBoxMultiSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMultiSource.Size = new System.Drawing.Size(378, 23);
            this.textBoxMultiSource.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 145);
            this.Controls.Add(this.tabImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Resize";
            this.tabImage.ResumeLayout(false);
            this.tabOneImage.ResumeLayout(false);
            this.tabOneImage.PerformLayout();
            this.tabMultiImage.ResumeLayout(false);
            this.tabMultiImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabImage;
        private TabPage tabOneImage;
        private TabPage tabMultiImage;
        private TextBox textBoxSource;
        private Button buttonOpenFileSource;
        private TextBox textBoxHeight;
        private Label label2;
        private TextBox textBoxWidth;
        private Button buttonOpenFileDestiny;
        private TextBox textBoxDestiny;
        private CheckBox checkBoxEnlarge;
        private CheckBox checkBoxAlignTop;
        private Button buttonSave;
        private Button buttonMultiSave;
        private CheckBox checkBoxMultiAlignTop;
        private CheckBox checkBoxMultiEnlarge;
        private TextBox textBoxMultiHeight;
        private Label label1;
        private TextBox textBoxMultiWidth;
        private Button buttonMultiOpenDestiny;
        private TextBox textBoxMultiDestiny;
        private Button buttonMultiOpenSource;
        private TextBox textBoxMultiSource;
    }
}