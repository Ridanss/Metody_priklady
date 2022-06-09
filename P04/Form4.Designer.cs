namespace P04
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecuteAll = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelModified = new System.Windows.Forms.Label();
            this.labelDisolved = new System.Windows.Forms.Label();
            this.label4NsnNsd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " a no je Ta t   o Tak    a nea  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "string pro úpravu:";
            // 
            // buttonExecuteAll
            // 
            this.buttonExecuteAll.Location = new System.Drawing.Point(239, 45);
            this.buttonExecuteAll.Name = "buttonExecuteAll";
            this.buttonExecuteAll.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteAll.TabIndex = 2;
            this.buttonExecuteAll.Text = "execute";
            this.buttonExecuteAll.UseVisualStyleBackColor = true;
            this.buttonExecuteAll.Click += new System.EventHandler(this.buttonExecuteAll_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "121";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "17";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. číslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2. číslo";
            // 
            // labelModified
            // 
            this.labelModified.AutoSize = true;
            this.labelModified.Location = new System.Drawing.Point(23, 86);
            this.labelModified.Name = "labelModified";
            this.labelModified.Size = new System.Drawing.Size(43, 13);
            this.labelModified.TabIndex = 7;
            this.labelModified.Text = "úprava:";
            // 
            // labelDisolved
            // 
            this.labelDisolved.AutoSize = true;
            this.labelDisolved.Location = new System.Drawing.Point(177, 140);
            this.labelDisolved.Name = "labelDisolved";
            this.labelDisolved.Size = new System.Drawing.Size(141, 13);
            this.labelDisolved.TabIndex = 8;
            this.labelDisolved.Text = "rozklad na provčísla 1. čísla";
            // 
            // label4NsnNsd
            // 
            this.label4NsnNsd.AutoSize = true;
            this.label4NsnNsd.Location = new System.Drawing.Point(177, 166);
            this.label4NsnNsd.Name = "label4NsnNsd";
            this.label4NsnNsd.Size = new System.Drawing.Size(56, 13);
            this.label4NsnNsd.TabIndex = 9;
            this.label4NsnNsd.Text = "NSN NSD";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 236);
            this.Controls.Add(this.label4NsnNsd);
            this.Controls.Add(this.labelDisolved);
            this.Controls.Add(this.labelModified);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonExecuteAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExecuteAll;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelModified;
        private System.Windows.Forms.Label labelDisolved;
        private System.Windows.Forms.Label label4NsnNsd;
    }
}

