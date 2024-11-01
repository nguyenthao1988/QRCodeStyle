namespace TestMultiQR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_bodyShape = new System.Windows.Forms.ComboBox();
            this.cb_eyeFrame = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_eyeBall = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Shape:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "QRCode Style Result:";
            // 
            // cb_bodyShape
            // 
            this.cb_bodyShape.FormattingEnabled = true;
            this.cb_bodyShape.Location = new System.Drawing.Point(28, 135);
            this.cb_bodyShape.Name = "cb_bodyShape";
            this.cb_bodyShape.Size = new System.Drawing.Size(188, 22);
            this.cb_bodyShape.TabIndex = 2;
            // 
            // cb_eyeFrame
            // 
            this.cb_eyeFrame.FormattingEnabled = true;
            this.cb_eyeFrame.Location = new System.Drawing.Point(599, 137);
            this.cb_eyeFrame.Name = "cb_eyeFrame";
            this.cb_eyeFrame.Size = new System.Drawing.Size(188, 22);
            this.cb_eyeFrame.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eye Frame Shape:";
            // 
            // cb_eyeBall
            // 
            this.cb_eyeBall.FormattingEnabled = true;
            this.cb_eyeBall.Location = new System.Drawing.Point(1100, 137);
            this.cb_eyeBall.Name = "cb_eyeBall";
            this.cb_eyeBall.Size = new System.Drawing.Size(188, 22);
            this.cb_eyeBall.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1097, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eye Ball Shape:";
            // 
            // btnColor1
            // 
            this.btnColor1.BackColor = System.Drawing.Color.Red;
            this.btnColor1.Location = new System.Drawing.Point(945, 437);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(188, 29);
            this.btnColor1.TabIndex = 7;
            this.btnColor1.Text = "#FF0000";
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackColor = System.Drawing.Color.White;
            this.btnColor2.Location = new System.Drawing.Point(1160, 437);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(188, 29);
            this.btnColor2.TabIndex = 8;
            this.btnColor2.Text = "#FFFFFF";
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TestMultiQR.Properties.Resources.eyeball;
            this.pictureBox4.Location = new System.Drawing.Point(1101, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(395, 239);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TestMultiQR.Properties.Resources.eye;
            this.pictureBox3.Location = new System.Drawing.Point(599, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(479, 239);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestMultiQR.Properties.Resources.body;
            this.pictureBox2.Location = new System.Drawing.Point(28, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 374);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Location = new System.Drawing.Point(606, 437);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(300, 300);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 9;
            this.picResult.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(950, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 109);
            this.button1.TabIndex = 13;
            this.button1.Text = "Genarate QR Style";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // piclogo
            // 
            this.piclogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piclogo.Location = new System.Drawing.Point(1273, 491);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(86, 81);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 14;
            this.piclogo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1273, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Select Logo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(578, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "DEMO QRCODE STYLE SAMPLE ";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(950, 491);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(205, 22);
            this.txtText.TabIndex = 17;
            this.txtText.Text = "LAPTRINHVB.NET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 474);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 815);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.cb_eyeBall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_eyeFrame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_bodyShape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test QRStyle - https://laptrinhvb.net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_bodyShape;
        private System.Windows.Forms.ComboBox cb_eyeFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_eyeBall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label6;
    }
}

