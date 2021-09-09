namespace Nimi13
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
            this.vastaus_label = new System.Windows.Forms.Label();
            this.nimi_textBox = new System.Windows.Forms.TextBox();
            this.takista_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimi ja katsotaan onko 50 suosituiden joukossa (2020)";
            // 
            // vastaus_label
            // 
            this.vastaus_label.AutoSize = true;
            this.vastaus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastaus_label.Location = new System.Drawing.Point(24, 81);
            this.vastaus_label.Name = "vastaus_label";
            this.vastaus_label.Size = new System.Drawing.Size(55, 25);
            this.vastaus_label.TabIndex = 1;
            this.vastaus_label.Text = "Vast";
            this.vastaus_label.Visible = false;
            // 
            // nimi_textBox
            // 
            this.nimi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimi_textBox.Location = new System.Drawing.Point(634, 24);
            this.nimi_textBox.Name = "nimi_textBox";
            this.nimi_textBox.Size = new System.Drawing.Size(248, 31);
            this.nimi_textBox.TabIndex = 2;
            // 
            // takista_button
            // 
            this.takista_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takista_button.Location = new System.Drawing.Point(737, 72);
            this.takista_button.Name = "takista_button";
            this.takista_button.Size = new System.Drawing.Size(144, 32);
            this.takista_button.TabIndex = 3;
            this.takista_button.Text = "Tarkista";
            this.takista_button.UseVisualStyleBackColor = true;
            this.takista_button.Click += new System.EventHandler(this.takista_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 120);
            this.Controls.Add(this.takista_button);
            this.Controls.Add(this.nimi_textBox);
            this.Controls.Add(this.vastaus_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vastaus_label;
        private System.Windows.Forms.TextBox nimi_textBox;
        private System.Windows.Forms.Button takista_button;
    }
}

