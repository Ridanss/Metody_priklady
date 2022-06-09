namespace P02
{
    partial class Form2
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.labelVysl1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(85, 41);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.Text = "5";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(85, 93);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 1;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(85, 67);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "min:";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(201, 65);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "generovat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Checked = true;
            this.checkBoxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefault.Location = new System.Drawing.Point(201, 92);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDefault.TabIndex = 7;
            this.checkBoxDefault.Text = "základní rozsah";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            // 
            // labelVysl1
            // 
            this.labelVysl1.AutoSize = true;
            this.labelVysl1.Location = new System.Drawing.Point(82, 128);
            this.labelVysl1.Name = "labelVysl1";
            this.labelVysl1.Size = new System.Drawing.Size(52, 13);
            this.labelVysl1.TabIndex = 8;
            this.labelVysl1.Text = "Výsledky:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(308, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "před:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "po:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(454, 57);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 225);
            this.listBox2.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 432);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelVysl1);
            this.Controls.Add(this.checkBoxDefault);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxN);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.CheckBox checkBoxDefault;
        private System.Windows.Forms.Label labelVysl1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
    }
}

