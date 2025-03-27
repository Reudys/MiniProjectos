namespace Temperaturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cTemp = new System.Windows.Forms.RadioButton();
            this.fTemp = new System.Windows.Forms.RadioButton();
            this.kTemp = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox.Location = new System.Drawing.Point(240, 153);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(191, 34);
            this.textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(469, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Celsius";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(469, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fahrenheit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(469, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kelvin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cTemp
            // 
            this.cTemp.AutoSize = true;
            this.cTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTemp.Location = new System.Drawing.Point(53, 111);
            this.cTemp.Name = "cTemp";
            this.cTemp.Size = new System.Drawing.Size(114, 33);
            this.cTemp.TabIndex = 5;
            this.cTemp.TabStop = true;
            this.cTemp.Text = "Celsius";
            this.cTemp.UseVisualStyleBackColor = true;
            // 
            // fTemp
            // 
            this.fTemp.AutoSize = true;
            this.fTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTemp.Location = new System.Drawing.Point(53, 150);
            this.fTemp.Name = "fTemp";
            this.fTemp.Size = new System.Drawing.Size(149, 33);
            this.fTemp.TabIndex = 6;
            this.fTemp.TabStop = true;
            this.fTemp.Text = "Fahrenheit";
            this.fTemp.UseVisualStyleBackColor = true;
            // 
            // kTemp
            // 
            this.kTemp.AutoSize = true;
            this.kTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kTemp.Location = new System.Drawing.Point(53, 189);
            this.kTemp.Name = "kTemp";
            this.kTemp.Size = new System.Drawing.Size(100, 33);
            this.kTemp.TabIndex = 7;
            this.kTemp.TabStop = true;
            this.kTemp.Text = "Kelvin";
            this.kTemp.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(240, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(693, 244);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kTemp);
            this.Controls.Add(this.fTemp);
            this.Controls.Add(this.cTemp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(711, 291);
            this.MinimumSize = new System.Drawing.Size(711, 291);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton cTemp;
        private System.Windows.Forms.RadioButton fTemp;
        private System.Windows.Forms.RadioButton kTemp;
        private System.Windows.Forms.Button button4;
    }
}

