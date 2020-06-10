using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        VideoJuego video = new VideoJuego();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                video.Nombre = txtNombre.Text;
                video.Campaña = cmbMulti.Text;
                video.Multijugador = cmbCampaña.Text;

                if (rdbFisico.Checked)
                {
                    video.TipoJuego = "Fisico";
                }
                else
                {
                    video.TipoJuego = "Digital";
                }

                video.Plataforma = cmbPlataforma.Text;
                video.Edad = cmbEdad.Text;
                video.Compañia = txtCompañia.Text;
                video.Direccion = lblRutaImagen.Text;

                dgvJuegos.Rows.Add(video.Nombre, video.Campaña, video.Multijugador, video.TipoJuego, video.Plataforma, video.Edad, video.Compañia, video.Direccion);
                Insertar();
            }
            catch (Exception x)
            {
                MessageBox.Show("!Error: " + x.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Insertar()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=videojuegos;";

            string query = "INSERT INTO juegos(`Id`,`Nombre`, `Campaña`, `Multijugador`, `Tipo`, `Plataforma`, `Restricción`, `Compañía`, `Imagen`) VALUES (Null ,'" + txtNombre.Text + "', '" + cmbCampaña.Text + "', '" + cmbMulti.Text + "', '" + video.TipoJuego + "', '" + cmbPlataforma.Text + "', '" + cmbEdad.Text + "', '" + txtCompañia.Text + "', '" + lblRutaImagen.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Juego registrado en la base de datos");

                databaseConnection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            txtNombre.Text = "";
            txtCompañia.Text = "";
            cmbCampaña.Text = "";
            cmbMulti.Text = "";
            cmbPlataforma.Text = "";
            cmbEdad.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=videojuegos;";

            string query = "SELECT * FROM juegos";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            dgvJuegos.Rows.Clear();

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvJuegos.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro nada");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=videojuegos;";

            string juego = dgvJuegos.CurrentRow.Cells[0].Value.ToString();

            string query = "DELETE FROM `juegos` WHERE Nombre = '" + juego + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Juego eliminado de la base de datos");

                databaseConnection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=videojuegos;";

            string juego = dgvJuegos.CurrentRow.Cells[0].Value.ToString();

            string query = "UPDATE `juegos` SET  `Id`= NULL, `Nombre`='" + txtNombre.Text + "',`Campaña`='" + cmbCampaña.Text + "',`Multijugador`='" + cmbMulti.Text + "',`Tipo`='" + video.TipoJuego + "',`Plataforma`='" + cmbPlataforma.Text + "',`Restricción`='" + cmbEdad.Text + "',`Compañía`='" + txtCompañia.Text + "', `Imagen`='" + lblRutaImagen.Text + "' WHERE Nombre = '" + juego + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("La informacion del juego se actualizó correctamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtNombre.Text = "";
            txtCompañia.Text = "";
            cmbCampaña.Text = "";
            cmbMulti.Text = "";
            cmbPlataforma.Text = "";
            cmbEdad.Text = "";
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "* .bmp; * .jpg; * .gif; * .png * | * .bmp; * .jpg; * .gif; * .png *";
            Abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Abrir.Title = "Selecciona la portada del juego";
            Abrir.RestoreDirectory = true;

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                lblRutaImagen.Text = lblComillas.Text + Abrir.FileName + lblComillas.Text; 
                //lblRutaImagen.Text = Abrir.FileName;
                pictureBox1.Image = Image.FromFile(Abrir.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                lblRutaImagen.Text = "";
                pictureBox1.Image = null;
            }
            }
            catch (Exception x)
            {
                MessageBox.Show("!Error al cargar la imagen: " + x);
            }
        }

        private void dgvJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=videojuegos;";

            string juego = dgvJuegos.CurrentRow.Cells[0].Value.ToString();

            string query = "SELECT * FROM juegos WHERE Nombre = '" + juego + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string Filename = (reader.GetString(8));
                        pictureBox1.Image = Image.FromFile(Filename);
                        //pictureBox1.Image = System.Drawing.Image.FromFile(Filename);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro nada");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        } //no abrir, en reparacion

        //Metodo que se imprime cada que se invoca el evento
        public void  MetodoGestor(string Nombre)
        {
            MessageBox.Show("La portada del juego " + Nombre + " se ingreso correctamente");
        }
        //suscribiendo el evento a mi metodo gestor
        private void Form3_Load(object sender, EventArgs e)
        {
            video.Aviso += MetodoGestor;
        }
    }
}
