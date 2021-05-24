
namespace lab2_zadanie2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVBig = new System.Windows.Forms.RadioButton();
            this.rdoBig = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkCurved = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVBig);
            this.groupBox1.Controls.Add(this.rdoBig);
            this.groupBox1.Controls.Add(this.rdoSmall);
            this.groupBox1.Location = new System.Drawing.Point(156, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // rdoVBig
            // 
            this.rdoVBig.AutoSize = true;
            this.rdoVBig.Location = new System.Drawing.Point(7, 75);
            this.rdoVBig.Name = "rdoVBig";
            this.rdoVBig.Size = new System.Drawing.Size(89, 19);
            this.rdoVBig.TabIndex = 2;
            this.rdoVBig.TabStop = true;
            this.rdoVBig.Text = "Bardzo duża";
            this.rdoVBig.UseVisualStyleBackColor = true;
            this.rdoVBig.CheckedChanged += new System.EventHandler(this.rdoVBig_CheckedChanged);
            // 
            // rdoBig
            // 
            this.rdoBig.AutoSize = true;
            this.rdoBig.Location = new System.Drawing.Point(7, 49);
            this.rdoBig.Name = "rdoBig";
            this.rdoBig.Size = new System.Drawing.Size(51, 19);
            this.rdoBig.TabIndex = 1;
            this.rdoBig.TabStop = true;
            this.rdoBig.Text = "Duża";
            this.rdoBig.UseVisualStyleBackColor = true;
            this.rdoBig.CheckedChanged += new System.EventHandler(this.rdoBig_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(7, 23);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(51, 19);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Mała";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUnderline);
            this.groupBox2.Controls.Add(this.chkCurved);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Location = new System.Drawing.Point(301, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(7, 75);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(93, 19);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Podkreślenie";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkCurved
            // 
            this.chkCurved.AutoSize = true;
            this.chkCurved.Location = new System.Drawing.Point(7, 49);
            this.chkCurved.Name = "chkCurved";
            this.chkCurved.Size = new System.Drawing.Size(84, 19);
            this.chkCurved.TabIndex = 1;
            this.chkCurved.Text = "Pochylenie";
            this.chkCurved.UseVisualStyleBackColor = true;
            this.chkCurved.CheckedChanged += new System.EventHandler(this.chkCurved_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(7, 22);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(90, 19);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Pogrubienie";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoGreen);
            this.groupBox3.Controls.Add(this.rdoBlue);
            this.groupBox3.Controls.Add(this.rdoRed);
            this.groupBox3.Location = new System.Drawing.Point(523, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(7, 75);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(64, 19);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Zielony";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(7, 49);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(73, 19);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Niebieski";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(7, 22);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(77, 19);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Czerwony";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVBig;
        private System.Windows.Forms.RadioButton rdoBig;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkCurved;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.Button button1;
    }
}

