namespace FrmRegistration
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
            sn = new TextBox();
            ln = new TextBox();
            fn = new TextBox();
            mn = new TextBox();
            a = new TextBox();
            cn = new TextBox();
            ad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            eme = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            cbprogram = new ComboBox();
            SuspendLayout();
            // 
            // sn
            // 
            sn.Location = new Point(53, 62);
            sn.Name = "sn";
            sn.Size = new Size(181, 23);
            sn.TabIndex = 0;
            // 
            // ln
            // 
            ln.Location = new Point(53, 124);
            ln.Name = "ln";
            ln.Size = new Size(181, 23);
            ln.TabIndex = 2;
            // 
            // fn
            // 
            fn.Location = new Point(254, 124);
            fn.Name = "fn";
            fn.Size = new Size(181, 23);
            fn.TabIndex = 3;
            // 
            // mn
            // 
            mn.Location = new Point(461, 124);
            mn.Name = "mn";
            mn.Size = new Size(181, 23);
            mn.TabIndex = 4;
            // 
            // a
            // 
            a.Location = new Point(53, 194);
            a.Name = "a";
            a.Size = new Size(181, 23);
            a.TabIndex = 5;
            // 
            // cn
            // 
            cn.Location = new Point(254, 194);
            cn.Name = "cn";
            cn.Size = new Size(181, 23);
            cn.TabIndex = 6;
            // 
            // ad
            // 
            ad.BackColor = SystemColors.ButtonFace;
            ad.Location = new Point(53, 264);
            ad.Multiline = true;
            ad.Name = "ad";
            ad.Size = new Size(589, 161);
            ad.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 8;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 29);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 9;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 101);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 10;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(254, 101);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 11;
            label4.Text = "First Name:";
            // 
            // eme
            // 
            eme.AutoSize = true;
            eme.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            eme.Location = new Point(461, 101);
            eme.Name = "eme";
            eme.Size = new Size(106, 20);
            eme.TabIndex = 12;
            eme.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(53, 171);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 13;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(254, 171);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 14;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(53, 241);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 15;
            label8.Text = "Address:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(315, 441);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbprogram
            // 
            cbprogram.FormattingEnabled = true;
            cbprogram.Items.AddRange(new object[] { "BSCS", "BSIT", "BSIS", "BSCpE" });
            cbprogram.Location = new Point(254, 62);
            cbprogram.Name = "cbprogram";
            cbprogram.Size = new Size(255, 23);
            cbprogram.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(694, 488);
            Controls.Add(cbprogram);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(eme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ad);
            Controls.Add(cn);
            Controls.Add(a);
            Controls.Add(mn);
            Controls.Add(fn);
            Controls.Add(ln);
            Controls.Add(sn);
            Name = "Form1";
            Text = "Form Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sn;
        private TextBox ln;
        private TextBox fn;
        private TextBox mn;
        private TextBox a;
        private TextBox cn;
        private TextBox ad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label eme;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private ComboBox cbprogram;
    }
}