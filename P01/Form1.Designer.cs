namespace P01
{
    partial class Form1
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
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelVysledky1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelVysledky2 = new System.Windows.Forms.Label();
            this.labelVysledky3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "123 tedne no tak tohle 112 je 5";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(216, 30);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelVysledky1
            // 
            this.labelVysledky1.AutoSize = true;
            this.labelVysledky1.Location = new System.Drawing.Point(35, 55);
            this.labelVysledky1.Name = "labelVysledky1";
            this.labelVysledky1.Size = new System.Drawing.Size(42, 13);
            this.labelVysledky1.TabIndex = 2;
            this.labelVysledky1.Text = "Číslice:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(300, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 3;
            // 
            // labelVysledky2
            // 
            this.labelVysledky2.AutoSize = true;
            this.labelVysledky2.Location = new System.Drawing.Point(35, 120);
            this.labelVysledky2.Name = "labelVysledky2";
            this.labelVysledky2.Size = new System.Drawing.Size(37, 13);
            this.labelVysledky2.TabIndex = 4;
            this.labelVysledky2.Text = "Slova:";
            // 
            // labelVysledky3
            // 
            this.labelVysledky3.AutoSize = true;
            this.labelVysledky3.Location = new System.Drawing.Point(35, 189);
            this.labelVysledky3.Name = "labelVysledky3";
            this.labelVysledky3.Size = new System.Drawing.Size(48, 13);
            this.labelVysledky3.TabIndex = 5;
            this.labelVysledky3.Text = "Alfanum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "string bez číslic:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVysledky3);
            this.Controls.Add(this.labelVysledky2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelVysledky1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelVysledky1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelVysledky2;
        private System.Windows.Forms.Label labelVysledky3;
        private System.Windows.Forms.Label label1;
    }
}

