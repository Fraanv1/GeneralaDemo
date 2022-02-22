namespace Juego_de_dados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_resultados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_players = new System.Windows.Forms.Label();
            this.lbl_turnos = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dtg_jugada = new System.Windows.Forms.DataGridView();
            this.JYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cara1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cara2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cara3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cara4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cara5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cara6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_jugada)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tirar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_resultados
            // 
            this.dtg_resultados.AllowUserToAddRows = false;
            this.dtg_resultados.AllowUserToDeleteRows = false;
            this.dtg_resultados.AllowUserToOrderColumns = true;
            this.dtg_resultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtg_resultados.Location = new System.Drawing.Point(529, 5);
            this.dtg_resultados.Name = "dtg_resultados";
            this.dtg_resultados.ReadOnly = true;
            this.dtg_resultados.RowHeadersVisible = false;
            this.dtg_resultados.Size = new System.Drawing.Size(191, 125);
            this.dtg_resultados.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Jugador 1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Jugador 2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Jugador 3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Turno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Jugador:";
            // 
            // lbl_players
            // 
            this.lbl_players.AutoSize = true;
            this.lbl_players.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_players.Location = new System.Drawing.Point(132, 303);
            this.lbl_players.Name = "lbl_players";
            this.lbl_players.Size = new System.Drawing.Size(28, 29);
            this.lbl_players.TabIndex = 15;
            this.lbl_players.Text = "1";
            this.lbl_players.Click += new System.EventHandler(this.lbl_players_Click);
            // 
            // lbl_turnos
            // 
            this.lbl_turnos.AutoSize = true;
            this.lbl_turnos.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turnos.Location = new System.Drawing.Point(97, 350);
            this.lbl_turnos.Name = "lbl_turnos";
            this.lbl_turnos.Size = new System.Drawing.Size(28, 29);
            this.lbl_turnos.TabIndex = 16;
            this.lbl_turnos.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0b61ba096406865f0e76a9b07e36dc69.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(430, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(287, 149);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(148, 118);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(87, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(367, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(185, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(307, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Revancha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtg_jugada
            // 
            this.dtg_jugada.AllowUserToAddRows = false;
            this.dtg_jugada.AllowUserToDeleteRows = false;
            this.dtg_jugada.AllowUserToOrderColumns = true;
            this.dtg_jugada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_jugada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JYT,
            this.Cara1,
            this.Cara2,
            this.Cara3,
            this.Cara4,
            this.Cara5,
            this.Cara6});
            this.dtg_jugada.Location = new System.Drawing.Point(530, 136);
            this.dtg_jugada.Name = "dtg_jugada";
            this.dtg_jugada.ReadOnly = true;
            this.dtg_jugada.RowHeadersVisible = false;
            this.dtg_jugada.Size = new System.Drawing.Size(393, 234);
            this.dtg_jugada.TabIndex = 22;
            // 
            // JYT
            // 
            this.JYT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JYT.HeaderText = "Jugador + Tiro";
            this.JYT.Name = "JYT";
            this.JYT.ReadOnly = true;
            this.JYT.Width = 51;
            // 
            // Cara1
            // 
            this.Cara1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cara1.HeaderText = "Cara 1";
            this.Cara1.Name = "Cara1";
            this.Cara1.ReadOnly = true;
            // 
            // Cara2
            // 
            this.Cara2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cara2.HeaderText = "Cara 2";
            this.Cara2.Name = "Cara2";
            this.Cara2.ReadOnly = true;
            // 
            // Cara3
            // 
            this.Cara3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cara3.HeaderText = "Cara 3";
            this.Cara3.Name = "Cara3";
            this.Cara3.ReadOnly = true;
            // 
            // Cara4
            // 
            this.Cara4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cara4.HeaderText = "Cara 4";
            this.Cara4.Name = "Cara4";
            this.Cara4.ReadOnly = true;
            // 
            // Cara5
            // 
            this.Cara5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cara5.HeaderText = "Cara 5";
            this.Cara5.Name = "Cara5";
            this.Cara5.ReadOnly = true;
            // 
            // Cara6
            // 
            this.Cara6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cara6.HeaderText = "Cara 6";
            this.Cara6.Name = "Cara6";
            this.Cara6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1067, 388);
            this.ControlBox = false;
            this.Controls.Add(this.dtg_jugada);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_turnos);
            this.Controls.Add(this.lbl_players);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_resultados);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala trucha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_jugada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dtg_resultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_players;
        private System.Windows.Forms.Label lbl_turnos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dtg_jugada;
        private System.Windows.Forms.DataGridViewTextBoxColumn JYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cara1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cara2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cara3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cara4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cara5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cara6;
    }
}

