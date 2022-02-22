namespace Juego_de_dados
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.rb_jugador1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_jugador2 = new System.Windows.Forms.RadioButton();
            this.rb_jugador3 = new System.Windows.Forms.RadioButton();
            this.btn_aceptarprin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // rb_jugador1
            // 
            this.rb_jugador1.AutoSize = true;
            this.rb_jugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_jugador1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_jugador1.Location = new System.Drawing.Point(28, 231);
            this.rb_jugador1.Name = "rb_jugador1";
            this.rb_jugador1.Size = new System.Drawing.Size(54, 43);
            this.rb_jugador1.TabIndex = 2;
            this.rb_jugador1.TabStop = true;
            this.rb_jugador1.Text = "1";
            this.rb_jugador1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(69, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuantas personas jugarán?";
            // 
            // rb_jugador2
            // 
            this.rb_jugador2.AutoSize = true;
            this.rb_jugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_jugador2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_jugador2.Location = new System.Drawing.Point(264, 231);
            this.rb_jugador2.Name = "rb_jugador2";
            this.rb_jugador2.Size = new System.Drawing.Size(54, 43);
            this.rb_jugador2.TabIndex = 6;
            this.rb_jugador2.TabStop = true;
            this.rb_jugador2.Text = "2";
            this.rb_jugador2.UseVisualStyleBackColor = true;
            // 
            // rb_jugador3
            // 
            this.rb_jugador3.AutoSize = true;
            this.rb_jugador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_jugador3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_jugador3.Location = new System.Drawing.Point(479, 231);
            this.rb_jugador3.Name = "rb_jugador3";
            this.rb_jugador3.Size = new System.Drawing.Size(54, 43);
            this.rb_jugador3.TabIndex = 7;
            this.rb_jugador3.TabStop = true;
            this.rb_jugador3.Text = "3";
            this.rb_jugador3.UseVisualStyleBackColor = true;
            // 
            // btn_aceptarprin
            // 
            this.btn_aceptarprin.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarprin.Location = new System.Drawing.Point(164, 316);
            this.btn_aceptarprin.Name = "btn_aceptarprin";
            this.btn_aceptarprin.Size = new System.Drawing.Size(242, 59);
            this.btn_aceptarprin.TabIndex = 8;
            this.btn_aceptarprin.Text = "ACEPTAR";
            this.btn_aceptarprin.UseVisualStyleBackColor = true;
            this.btn_aceptarprin.Click += new System.EventHandler(this.btn_aceptarprin_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(564, 430);
            this.Controls.Add(this.btn_aceptarprin);
            this.Controls.Add(this.rb_jugador3);
            this.Controls.Add(this.rb_jugador2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_jugador1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_jugador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_jugador2;
        private System.Windows.Forms.RadioButton rb_jugador3;
        private System.Windows.Forms.Button btn_aceptarprin;
    }
}