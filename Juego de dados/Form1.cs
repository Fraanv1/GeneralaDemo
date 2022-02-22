using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Juego_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        //Declaraciones BD.
        OleDbConnection conexionconbd;
        OleDbCommand orden;
        string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source =|DataDirectory|//partidas.mdb;"; 
       
        public DateTime fecha = DateTime.Now;

        public int variable = FormPrincipal.variable;

        //Resultado de dados
        int resultado=0;
        int uno = 0, dos = 0, tres = 0, cuatro = 0, cinco = 0, seis = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //Random porque es random(?
                Random dados = new Random();

            //Array promedio de dados y array para sumar los dados
          
                int[] array =new int[6];
                int promedio;

            //Bucle para picturebox
                for (int i = 1; i <= 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            array[1] = dados.Next(1, 6);
                            pictureBox1.Image = imageList1.Images[array[1]];
                            break;
                        case 2:
                            array[2] = dados.Next(1, 6);
                            pictureBox2.Image = imageList1.Images[array[2]];
                            break;
                        case 3:
                            array[3] = dados.Next(1, 6);
                            pictureBox3.Image = imageList1.Images[array[3]];
                            break;
                        case 4:
                            array[4] = dados.Next(1, 6);
                            pictureBox4.Image = imageList1.Images[array[4]];
                            break;
                        case 5:
                            array[5] = dados.Next(1, 6);
                            pictureBox5.Image = imageList1.Images[array[5]];
                            break;
                    }
                    switch (array[i])
                    {
                        case 1:
                            uno = uno + 1;
                            break;
                        case 2:
                            dos = dos + 1;
                            break;
                        case 3:
                            tres = tres + 1;
                            break;
                        case 4:
                            cuatro = cuatro + 1;
                            break;
                        case 5:
                            cinco = cinco + 1;
                            break;
                        case 6:
                            seis = seis + 1;
                            break;
                    }
                    resultado = array.Sum();      
                }

            //dtg
                int pisado1, pisado2;
            pisado1 = (Convert.ToInt32(lbl_players.Text));
            pisado2 = (Convert.ToInt32(lbl_turnos.Text));

            if (pisado2 < 4)
            {
                dtg_jugada.Rows.Add("J" + pisado1 + ",T" + (pisado2+1), uno, dos, tres, cuatro, cinco, seis);
                conexionconbd = new OleDbConnection(conexion);
                string escribirjugada = "Insert into Caras values ('" + "J" + lbl_players.Text + ",T" + lbl_turnos.Text + "','" + uno + "','" + dos + "','" + tres + "','" + cuatro + "','" + cinco + "','" + seis + "','" + fecha + "')";
                orden = new OleDbCommand(escribirjugada, conexionconbd);
                conexionconbd.Open();
                orden.ExecuteNonQuery();
                conexionconbd.Close();
            }
              


                
                //Dado que mas sale
                var groups = array.GroupBy(x => x);
                var largest = groups.OrderByDescending(x => x.Count()).First();
                promedio = largest.Key;
               
                conexionconbd = new OleDbConnection(conexion);
                string escribirdados = "Insert into Dados values ('" + array[1] + ";" + array[2] + ";" + array[3] + ";" + array[4] + ";" + array[5] + "','" + promedio + "','" + fecha + "')";
                orden = new OleDbCommand(escribirdados, conexionconbd);
                conexionconbd.Open();
                orden.ExecuteNonQuery();
                conexionconbd.Close();
          
            //Contador de turnos
                   int c = int.Parse(lbl_turnos.Text);

                    int p = int.Parse(lbl_players.Text);
                    p = p + 1;
                    if (p == FormPrincipal.variable + 1)
                    {
                        p = 1;
                    }
                    lbl_players.Text = p.ToString();

            //Control de turnos por jugador
                    switch (int.Parse(lbl_players.Text))
                    {
                        case 1:
                            c = c + 1;
                            lbl_turnos.Text = c.ToString();
                            break;
                        case 2:
                            c.ToString();
                            break;
                        case 3:
                            c.ToString();
                            break;
                    }
                   
            //Resultado en grilla dependiendo el jugador
            int players = 0;
            players = int.Parse(lbl_players.Text);

            //Guardar en DataGridView resultados de jugadas (dtg)
            if (lbl_turnos.Text != "4")
            {
                switch (players)
                {
                    case 1:
                        dtg_resultados[players, int.Parse(lbl_turnos.Text) - 1].Value = Convert.ToString(resultado);
                        dtg_resultados[1, 3].Value = Convert.ToInt32(dtg_resultados[1, 3].Value) + resultado;
                        break;
                    case 2:
                        dtg_resultados[players, int.Parse(lbl_turnos.Text) - 1].Value = Convert.ToString(resultado);
                        dtg_resultados[2, 3].Value = Convert.ToInt32(dtg_resultados[2, 3].Value) + resultado;
                        break;
                    case 3:
                        dtg_resultados[players, int.Parse(lbl_turnos.Text) - 1].Value = Convert.ToString(resultado);
                        dtg_resultados[3, 3].Value = Convert.ToInt32(dtg_resultados[3, 3].Value) + resultado;
                        break;
                }
            }

            //Array para guardar los puntajes maximos
            int[] max = new int[4];
            int maximo = 0;

            //Habilitar revancha dependiendo el número de jugadores y ganador
            switch(variable)
            {
                case 1:
            if ((lbl_turnos.Text == "3") && (lbl_players.Text == "1"))
            {
                button1.Enabled = false;
                //Ganar
                for (int i = 1; i <= 2; i++)
                {
                    maximo = Convert.ToInt32(dtg_resultados[i, 3].Value);
                    max[i] = maximo;
                }

                if (max[1] == max.Max())
                {
                    MessageBox.Show("Gano el jugador 1 con un puntaje de " + max[1]);
                    try
                    {
                        //Conexión con BD
                        conexionconbd = new OleDbConnection(conexion);
                        string escribir = "Insert into Partidas values ('" + 1 + "','" + max.Max() + "','" + fecha + "')";
                        orden = new OleDbCommand(escribir, conexionconbd);
                        conexionconbd.Open();
                        orden.ExecuteNonQuery();
                        conexionconbd.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                button3.Visible = true;
            }
            break;
                case 2:
            if ((lbl_turnos.Text == "3") && (lbl_players.Text == "2"))
            {
                button1.Enabled = false;
                //Ganar

                for (int i = 1; i <= 2; i++)
                {
                    maximo = Convert.ToInt32(dtg_resultados[i, 3].Value);
                    max[i] = maximo;
                }

                if (max[2] < max[1])
                {
                    MessageBox.Show("Gano el jugador 1 con un puntaje de " +max[1]);
                    try
                    {
                        //Conexión con BD
                        conexionconbd = new OleDbConnection(conexion);
                        string escribir = "Insert into Partidas values ('" + 1 + "','" + max.Max() + "','" + fecha + "')";
                        orden = new OleDbCommand(escribir, conexionconbd);
                        conexionconbd.Open();
                        orden.ExecuteNonQuery();
                        conexionconbd.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                if (max[1] < max[2])
                {
                    MessageBox.Show("Gano el jugador 2 con un puntaje de "+ max[2]);
                    try
                    {
                        //Conexión con BD
                        conexionconbd = new OleDbConnection(conexion);
                        string escribir = "Insert into Partidas values ('" + 2 + "','" + max.Max() + "','" + fecha + "')";
                        orden = new OleDbCommand(escribir, conexionconbd);
                        conexionconbd.Open();
                        orden.ExecuteNonQuery();
                        conexionconbd.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                if ((max[2] == max[1])||(max[1] == max[2]))
                {
                    MessageBox.Show("Hubo un empate");
                }
                button3.Visible = true;
            }
            break;
                case 3:
            if ((lbl_turnos.Text == "3") && (lbl_players.Text == "3"))
            {
          
                    button1.Enabled = false;
                //Ganar
                    
              
                    for (int i = 1; i <= 3; i++)
                    {
                        maximo = Convert.ToInt32(dtg_resultados[i, 3].Value);
                        max[i] = maximo;
                    }
                    if ((max[1] == max[2]) || (max[1] == max[3]) || (max[2] == max[1]) || (max[2] == max[3]) || (max[3] == max[1]) || (max[3] == max[2]))
                    {
                        MessageBox.Show("Hubo un empate entre los jugadores ");
                    }
                    else
                    {
                        int ganador = 0;
                        if (max[1] == max.Max())
                        {
                            ganador = 1;
                        }
                        else if (max[2] == max.Max())
                        {
                            ganador = 2;
                        }
                        else
                        {
                            ganador = 3;
                        }
                        MessageBox.Show("El ganador es el jugador " + ganador + " con un puntaje de " + max.Max());
                        try
                        {
                            //Conexión con BD
                            conexionconbd = new OleDbConnection(conexion);
                            string escribir = "Insert into Partidas values ('" + ganador + "','" + max.Max() + "','" + fecha + "')";
                            //string Alta = "Insert into Personas values('" + txt_dni.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_dire.Text + "','" + txt_telefono.Text + "','" + cmb_box1.Text + "')";
                            orden = new OleDbCommand(escribir, conexionconbd);
                            conexionconbd.Open();
                            orden.ExecuteNonQuery();
                            conexionconbd.Close();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString());
                        }
                    }
                button3.Visible = true;
            }
            break;
        }
        }

        private void lbl_players_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_players.Text = "0";
            lbl_turnos.Text = "0";
            //Agregar filas a dtg
            dtg_resultados.Rows.Add(4);
            for (int i = 0; i <= 3; i++)
            {
                dtg_resultados[0, i].Value = i + 1;
                if (i == 3) dtg_resultados[0, i].Value = "Total:";
            }
            dtg_resultados.Enabled = false;
            dtg_resultados.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
               DialogResult a = MessageBox.Show(" Desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               if (a == DialogResult.OK)
                {
                    Application.Exit();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult acciones = MessageBox.Show("Partido finalizado, Desea jugar la revancha?", "Revancha", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (acciones == DialogResult.OK)
            {
                Application.Restart();
            }
        }
    }
}
