namespace Cronometro
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.hs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(60, 144);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(187, 56);
            button1.TabIndex = 5;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(60, 249);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(187, 56);
            button2.TabIndex = 6;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hs
            // 
            this.hs.AutoSize = true;
            this.hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hs.ForeColor = System.Drawing.Color.White;
            this.hs.Location = new System.Drawing.Point(61, 46);
            this.hs.Name = "hs";
            this.hs.Size = new System.Drawing.Size(55, 38);
            this.hs.TabIndex = 0;
            this.hs.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.ForeColor = System.Drawing.Color.White;
            this.ms.Location = new System.Drawing.Point(128, 46);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(55, 38);
            this.ms.TabIndex = 2;
            this.ms.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(180, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.ForeColor = System.Drawing.Color.White;
            this.ss.Location = new System.Drawing.Point(204, 46);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(55, 38);
            this.ss.TabIndex = 4;
            this.ss.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(299, 360);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 407);
            this.MinimumSize = new System.Drawing.Size(317, 407);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ss;
    }
}

