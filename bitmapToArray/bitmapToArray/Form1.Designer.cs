namespace bitmapToArray
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bitmapDisplay = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WhiteThreashold = new System.Windows.Forms.TrackBar();
            this.BlackThreashold = new System.Windows.Forms.TrackBar();
            this.whiteThreasholdLabel = new System.Windows.Forms.Label();
            this.blackThreasholdLabel = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitmapDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteThreashold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackThreashold)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Details";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(55, 44);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 22);
            this.PortBox.TabIndex = 3;
            this.PortBox.Text = "6969";
            this.PortBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "192.168.1.25";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(200, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Turn off Ledboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(292, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse Files";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bitmapDisplay
            // 
            this.bitmapDisplay.Image = ((System.Drawing.Image)(resources.GetObject("bitmapDisplay.Image")));
            this.bitmapDisplay.Location = new System.Drawing.Point(182, 116);
            this.bitmapDisplay.Name = "bitmapDisplay";
            this.bitmapDisplay.Size = new System.Drawing.Size(231, 234);
            this.bitmapDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bitmapDisplay.TabIndex = 3;
            this.bitmapDisplay.TabStop = false;
            this.bitmapDisplay.Click += new System.EventHandler(this.bitmapDisplay_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(45, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "Send Picture";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a Picture\r\nto send";
            this.label3.Visible = false;
            // 
            // WhiteThreashold
            // 
            this.WhiteThreashold.BackColor = System.Drawing.Color.DimGray;
            this.WhiteThreashold.Location = new System.Drawing.Point(22, 368);
            this.WhiteThreashold.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.WhiteThreashold.Maximum = 96;
            this.WhiteThreashold.Name = "WhiteThreashold";
            this.WhiteThreashold.Size = new System.Drawing.Size(388, 56);
            this.WhiteThreashold.TabIndex = 100;
            this.WhiteThreashold.Scroll += new System.EventHandler(this.WhiteThreashold_Scroll);
            // 
            // BlackThreashold
            // 
            this.BlackThreashold.BackColor = System.Drawing.Color.DimGray;
            this.BlackThreashold.Location = new System.Drawing.Point(22, 453);
            this.BlackThreashold.Maximum = 96;
            this.BlackThreashold.Name = "BlackThreashold";
            this.BlackThreashold.Size = new System.Drawing.Size(388, 56);
            this.BlackThreashold.TabIndex = 101;
            this.BlackThreashold.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // whiteThreasholdLabel
            // 
            this.whiteThreasholdLabel.AutoSize = true;
            this.whiteThreasholdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiteThreasholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteThreasholdLabel.Location = new System.Drawing.Point(33, 348);
            this.whiteThreasholdLabel.Name = "whiteThreasholdLabel";
            this.whiteThreasholdLabel.Size = new System.Drawing.Size(142, 22);
            this.whiteThreasholdLabel.TabIndex = 102;
            this.whiteThreasholdLabel.Text = "White Threashold";
            this.whiteThreasholdLabel.Click += new System.EventHandler(this.whiteThreasholdLabel_Click);
            // 
            // blackThreasholdLabel
            // 
            this.blackThreasholdLabel.AutoSize = true;
            this.blackThreasholdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackThreasholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackThreasholdLabel.Location = new System.Drawing.Point(33, 431);
            this.blackThreasholdLabel.Name = "blackThreasholdLabel";
            this.blackThreasholdLabel.Size = new System.Drawing.Size(141, 22);
            this.blackThreasholdLabel.TabIndex = 103;
            this.blackThreasholdLabel.Text = "Black Threashold";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(22, 537);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(327, 22);
            this.URL.TabIndex = 104;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 105;
            this.label4.Text = "Picture URL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(355, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 43);
            this.button4.TabIndex = 106;
            this.button4.Text = "Get Picture";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AccessibleDescription = "YERT";
            this.AccessibleName = "YEETABLE";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(422, 581);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blackThreasholdLabel);
            this.Controls.Add(this.whiteThreasholdLabel);
            this.Controls.Add(this.BlackThreashold);
            this.Controls.Add(this.WhiteThreashold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bitmapDisplay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 880);
            this.MinimumSize = new System.Drawing.Size(440, 440);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledboard Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitmapDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteThreashold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackThreashold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox bitmapDisplay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar WhiteThreashold;
        private System.Windows.Forms.TrackBar BlackThreashold;
        private System.Windows.Forms.Label whiteThreasholdLabel;
        private System.Windows.Forms.Label blackThreasholdLabel;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}

