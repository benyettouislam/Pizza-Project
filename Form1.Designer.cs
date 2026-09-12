namespace _14projectpizza
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnorderpizza = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.gbsize = new System.Windows.Forms.GroupBox();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmeduim = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.gbcrusttype = new System.Windows.Forms.GroupBox();
            this.rbtinkcrust = new System.Windows.Forms.RadioButton();
            this.rbthincrust = new System.Windows.Forms.RadioButton();
            this.gbwheretoeat = new System.Windows.Forms.GroupBox();
            this.rbeatout = new System.Windows.Forms.RadioButton();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltoppings = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcrusttype = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblwheretoeat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.gbtoppings = new System.Windows.Forms.GroupBox();
            this.chkgreenpeppers = new System.Windows.Forms.CheckBox();
            this.chkolives = new System.Windows.Forms.CheckBox();
            this.chkonion = new System.Windows.Forms.CheckBox();
            this.chktomaoes = new System.Windows.Forms.CheckBox();
            this.chkmushroms = new System.Windows.Forms.CheckBox();
            this.chkextrachess = new System.Windows.Forms.CheckBox();
            this.gbsize.SuspendLayout();
            this.gbcrusttype.SuspendLayout();
            this.gbwheretoeat.SuspendLayout();
            this.gbtoppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(429, -4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 68);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "MAKE YOUR PIZZA";
            // 
            // btnorderpizza
            // 
            this.btnorderpizza.Location = new System.Drawing.Point(515, 352);
            this.btnorderpizza.Name = "btnorderpizza";
            this.btnorderpizza.Size = new System.Drawing.Size(133, 36);
            this.btnorderpizza.TabIndex = 1;
            this.btnorderpizza.Text = "Order Pizza";
            this.btnorderpizza.UseVisualStyleBackColor = true;
            this.btnorderpizza.Click += new System.EventHandler(this.btnorderpizza_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(783, 352);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(133, 36);
            this.btnreset.TabIndex = 2;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // gbsize
            // 
            this.gbsize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbsize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbsize.Controls.Add(this.rblarge);
            this.gbsize.Controls.Add(this.rbmeduim);
            this.gbsize.Controls.Add(this.rbsmall);
            this.gbsize.Location = new System.Drawing.Point(145, 69);
            this.gbsize.Name = "gbsize";
            this.gbsize.Size = new System.Drawing.Size(158, 151);
            this.gbsize.TabIndex = 16;
            this.gbsize.TabStop = false;
            this.gbsize.Text = "Size";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Location = new System.Drawing.Point(55, 106);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(75, 24);
            this.rblarge.TabIndex = 8;
            this.rblarge.Tag = "10";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmeduim
            // 
            this.rbmeduim.AutoSize = true;
            this.rbmeduim.Checked = true;
            this.rbmeduim.Location = new System.Drawing.Point(55, 70);
            this.rbmeduim.Name = "rbmeduim";
            this.rbmeduim.Size = new System.Drawing.Size(90, 24);
            this.rbmeduim.TabIndex = 7;
            this.rbmeduim.TabStop = true;
            this.rbmeduim.Tag = "6";
            this.rbmeduim.Text = "Meduim";
            this.rbmeduim.UseVisualStyleBackColor = true;
            this.rbmeduim.CheckedChanged += new System.EventHandler(this.rbmeduim_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Location = new System.Drawing.Point(55, 34);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(73, 24);
            this.rbsmall.TabIndex = 6;
            this.rbsmall.Tag = "5";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // gbcrusttype
            // 
            this.gbcrusttype.Controls.Add(this.rbtinkcrust);
            this.gbcrusttype.Controls.Add(this.rbthincrust);
            this.gbcrusttype.Location = new System.Drawing.Point(145, 246);
            this.gbcrusttype.Name = "gbcrusttype";
            this.gbcrusttype.Size = new System.Drawing.Size(200, 148);
            this.gbcrusttype.TabIndex = 17;
            this.gbcrusttype.TabStop = false;
            this.gbcrusttype.Text = "Crust Type";
            // 
            // rbtinkcrust
            // 
            this.rbtinkcrust.AutoSize = true;
            this.rbtinkcrust.Location = new System.Drawing.Point(44, 85);
            this.rbtinkcrust.Name = "rbtinkcrust";
            this.rbtinkcrust.Size = new System.Drawing.Size(113, 24);
            this.rbtinkcrust.TabIndex = 9;
            this.rbtinkcrust.Tag = "7";
            this.rbtinkcrust.Text = "Tinck Crust";
            this.rbtinkcrust.UseVisualStyleBackColor = true;
            this.rbtinkcrust.CheckedChanged += new System.EventHandler(this.rbtinkcrust_CheckedChanged);
            // 
            // rbthincrust
            // 
            this.rbthincrust.AutoSize = true;
            this.rbthincrust.Checked = true;
            this.rbthincrust.Location = new System.Drawing.Point(44, 38);
            this.rbthincrust.Name = "rbthincrust";
            this.rbthincrust.Size = new System.Drawing.Size(106, 24);
            this.rbthincrust.TabIndex = 8;
            this.rbthincrust.TabStop = true;
            this.rbthincrust.Tag = "2";
            this.rbthincrust.Text = "Thin Crust";
            this.rbthincrust.UseVisualStyleBackColor = true;
            this.rbthincrust.CheckedChanged += new System.EventHandler(this.rbthincrust_CheckedChanged);
            // 
            // gbwheretoeat
            // 
            this.gbwheretoeat.Controls.Add(this.rbeatout);
            this.gbwheretoeat.Controls.Add(this.rbeatin);
            this.gbwheretoeat.Location = new System.Drawing.Point(529, 246);
            this.gbwheretoeat.Name = "gbwheretoeat";
            this.gbwheretoeat.Size = new System.Drawing.Size(280, 100);
            this.gbwheretoeat.TabIndex = 18;
            this.gbwheretoeat.TabStop = false;
            this.gbwheretoeat.Text = "Where To Eat";
            // 
            // rbeatout
            // 
            this.rbeatout.AutoSize = true;
            this.rbeatout.Location = new System.Drawing.Point(167, 38);
            this.rbeatout.Name = "rbeatout";
            this.rbeatout.Size = new System.Drawing.Size(89, 24);
            this.rbeatout.TabIndex = 11;
            this.rbeatout.Text = "Eat Out";
            this.rbeatout.UseVisualStyleBackColor = true;
            this.rbeatout.CheckedChanged += new System.EventHandler(this.rbeatout_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Checked = true;
            this.rbeatin.Location = new System.Drawing.Point(21, 38);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(77, 24);
            this.rbeatin.TabIndex = 10;
            this.rbeatin.TabStop = true;
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(997, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1036, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1173, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1036, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Toppings";
            // 
            // lbltoppings
            // 
            this.lbltoppings.AutoSize = true;
            this.lbltoppings.Location = new System.Drawing.Point(1173, 179);
            this.lbltoppings.Name = "lbltoppings";
            this.lbltoppings.Size = new System.Drawing.Size(120, 20);
            this.lbltoppings.TabIndex = 24;
            this.lbltoppings.Text = "Order Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1036, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Crust Type";
            // 
            // lblcrusttype
            // 
            this.lblcrusttype.AutoSize = true;
            this.lblcrusttype.Location = new System.Drawing.Point(1173, 221);
            this.lblcrusttype.Name = "lblcrusttype";
            this.lblcrusttype.Size = new System.Drawing.Size(109, 20);
            this.lblcrusttype.TabIndex = 26;
            this.lblcrusttype.Text = "No Curst Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1036, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Where To Eat";
            // 
            // lblwheretoeat
            // 
            this.lblwheretoeat.AutoSize = true;
            this.lblwheretoeat.Location = new System.Drawing.Point(1173, 288);
            this.lblwheretoeat.Name = "lblwheretoeat";
            this.lblwheretoeat.Size = new System.Drawing.Size(131, 20);
            this.lblwheretoeat.TabIndex = 28;
            this.lblwheretoeat.Text = "No Where To Eat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1036, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total price";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltotalprice.Location = new System.Drawing.Point(1174, 352);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(84, 72);
            this.lbltotalprice.TabIndex = 30;
            this.lbltotalprice.Text = "0$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1173, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 31;
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(1173, 119);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(64, 20);
            this.lblsize.TabIndex = 32;
            this.lblsize.Text = "No Size";
            // 
            // gbtoppings
            // 
            this.gbtoppings.Controls.Add(this.chkgreenpeppers);
            this.gbtoppings.Controls.Add(this.chkolives);
            this.gbtoppings.Controls.Add(this.chkonion);
            this.gbtoppings.Controls.Add(this.chktomaoes);
            this.gbtoppings.Controls.Add(this.chkmushroms);
            this.gbtoppings.Controls.Add(this.chkextrachess);
            this.gbtoppings.Location = new System.Drawing.Point(491, 91);
            this.gbtoppings.Name = "gbtoppings";
            this.gbtoppings.Size = new System.Drawing.Size(364, 149);
            this.gbtoppings.TabIndex = 33;
            this.gbtoppings.TabStop = false;
            this.gbtoppings.Text = "Toppings";
            // 
            // chkgreenpeppers
            // 
            this.chkgreenpeppers.AccessibleDescription = "6";
            this.chkgreenpeppers.AccessibleName = "Green Pepppers";
            this.chkgreenpeppers.AutoSize = true;
            this.chkgreenpeppers.Location = new System.Drawing.Point(191, 105);
            this.chkgreenpeppers.Name = "chkgreenpeppers";
            this.chkgreenpeppers.Size = new System.Drawing.Size(152, 24);
            this.chkgreenpeppers.TabIndex = 21;
            this.chkgreenpeppers.Tag = "9";
            this.chkgreenpeppers.Text = "Green Pepppers";
            this.chkgreenpeppers.UseVisualStyleBackColor = true;
            this.chkgreenpeppers.CheckedChanged += new System.EventHandler(this.chkgreenpeppers_CheckedChanged);
            // 
            // chkolives
            // 
            this.chkolives.AccessibleDescription = "9";
            this.chkolives.AccessibleName = "Olives";
            this.chkolives.AutoSize = true;
            this.chkolives.Location = new System.Drawing.Point(191, 61);
            this.chkolives.Name = "chkolives";
            this.chkolives.Size = new System.Drawing.Size(77, 24);
            this.chkolives.TabIndex = 20;
            this.chkolives.Tag = "8";
            this.chkolives.Text = "Olives";
            this.chkolives.UseVisualStyleBackColor = true;
            this.chkolives.CheckedChanged += new System.EventHandler(this.chkolives_CheckedChanged);
            // 
            // chkonion
            // 
            this.chkonion.AccessibleDescription = "5";
            this.chkonion.AccessibleName = "Onion";
            this.chkonion.AutoSize = true;
            this.chkonion.Location = new System.Drawing.Point(191, 25);
            this.chkonion.Name = "chkonion";
            this.chkonion.Size = new System.Drawing.Size(77, 24);
            this.chkonion.TabIndex = 19;
            this.chkonion.Tag = "5";
            this.chkonion.Text = "Onion";
            this.chkonion.UseVisualStyleBackColor = true;
            this.chkonion.CheckedChanged += new System.EventHandler(this.chkonion_CheckedChanged);
            // 
            // chktomaoes
            // 
            this.chktomaoes.AccessibleDescription = "3";
            this.chktomaoes.AccessibleName = "Tomatoes";
            this.chktomaoes.AutoSize = true;
            this.chktomaoes.Location = new System.Drawing.Point(6, 105);
            this.chktomaoes.Name = "chktomaoes";
            this.chktomaoes.Size = new System.Drawing.Size(106, 24);
            this.chktomaoes.TabIndex = 18;
            this.chktomaoes.Tag = "7";
            this.chktomaoes.Text = "Tomatoes";
            this.chktomaoes.UseVisualStyleBackColor = true;
            this.chktomaoes.CheckedChanged += new System.EventHandler(this.chktomaoes_CheckedChanged);
            // 
            // chkmushroms
            // 
            this.chkmushroms.AccessibleDescription = "7";
            this.chkmushroms.AccessibleName = "Mushrooms";
            this.chkmushroms.AutoSize = true;
            this.chkmushroms.Location = new System.Drawing.Point(6, 61);
            this.chkmushroms.Name = "chkmushroms";
            this.chkmushroms.Size = new System.Drawing.Size(118, 24);
            this.chkmushroms.TabIndex = 17;
            this.chkmushroms.Tag = "3";
            this.chkmushroms.Text = "Mushrooms";
            this.chkmushroms.UseVisualStyleBackColor = true;
            this.chkmushroms.CheckedChanged += new System.EventHandler(this.chkmushroms_CheckedChanged);
            // 
            // chkextrachess
            // 
            this.chkextrachess.AccessibleDescription = "2";
            this.chkextrachess.AccessibleName = "Extra Chees";
            this.chkextrachess.AutoSize = true;
            this.chkextrachess.Location = new System.Drawing.Point(2, 24);
            this.chkextrachess.Name = "chkextrachess";
            this.chkextrachess.Size = new System.Drawing.Size(122, 24);
            this.chkextrachess.TabIndex = 16;
            this.chkextrachess.Tag = "2";
            this.chkextrachess.Text = "Extra Chees";
            this.chkextrachess.UseVisualStyleBackColor = true;
            this.chkextrachess.CheckedChanged += new System.EventHandler(this.chkextrachess_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1514, 474);
            this.Controls.Add(this.gbtoppings);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblwheretoeat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblcrusttype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltoppings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbwheretoeat);
            this.Controls.Add(this.gbcrusttype);
            this.Controls.Add(this.gbsize);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnorderpizza);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbsize.ResumeLayout(false);
            this.gbsize.PerformLayout();
            this.gbcrusttype.ResumeLayout(false);
            this.gbcrusttype.PerformLayout();
            this.gbwheretoeat.ResumeLayout(false);
            this.gbwheretoeat.PerformLayout();
            this.gbtoppings.ResumeLayout(false);
            this.gbtoppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnorderpizza;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.GroupBox gbsize;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmeduim;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.GroupBox gbcrusttype;
        private System.Windows.Forms.RadioButton rbtinkcrust;
        private System.Windows.Forms.RadioButton rbthincrust;
        private System.Windows.Forms.GroupBox gbwheretoeat;
        private System.Windows.Forms.RadioButton rbeatout;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltoppings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcrusttype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblwheretoeat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.GroupBox gbtoppings;
        private System.Windows.Forms.CheckBox chkgreenpeppers;
        private System.Windows.Forms.CheckBox chkolives;
        private System.Windows.Forms.CheckBox chkonion;
        private System.Windows.Forms.CheckBox chktomaoes;
        private System.Windows.Forms.CheckBox chkmushroms;
        private System.Windows.Forms.CheckBox chkextrachess;
    }
}

