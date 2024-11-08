using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace noooooo
{
    public partial class Form1 : Form
    {
        string Sqlconnection = "Server=localhost;port=3306;Database=exapractico1;Uid=root;Pwd=laluznu7S!;";
        MySqlConnection connection;
        SerialPort Portino;

        public Form1()
        {
            InitializeComponent();

            connection = new MySqlConnection(Sqlconnection);
            Portino = new SerialPort("COM5", 9600);
            try
            {
                Portino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to Arduino: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTemp();
        }
        private void UpdateTemp()
        {
            float tempC = 25.5f;
            float tempF = (tempC * 9 / 5) + 32;

            TBTempC.Text = tempC.ToString("0.00");
            TBTempF.Text = tempF.ToString("0.00");
            lblLEDStatus.Text = "LED: " + (checkBoxLED.Checked ? "On" : "Off");
        }
        private void ButtSave()
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO pepa (usuario, temperaturaC, temperaturaF, fecha, ledEstado) VALUES (@usuario, @temperaturaC, @temperaturaF, @fecha, @ledEstado)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@usuario", TBUsuario.Text);
                cmd.Parameters.AddWithValue("@temperaturaC", TBTempC.Text);
                cmd.Parameters.AddWithValue("@temperaturaF", TBTempF.Text);

                DateTime fechaSeleccionada;
                if (DateTime.TryParse(TBDate.Text, out fechaSeleccionada))
                {
                    cmd.Parameters.AddWithValue("@fecha", fechaSeleccionada.ToString("yyyy-MM-dd"));
                }
                else
                {
                    MessageBox.Show("Write a valid entry like yyyy-MM-dd.");
                    return;
                }

                cmd.Parameters.AddWithValue("@ledEstado", checkBoxLED.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving data: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private bool isValidText(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z\s]+$");
        }

        private void checkText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidText(textBox.Text))
                {
                    MessageBox.Show("Ingrese un valor valido para usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }

        private void LEDControl()
        {
            if (Portino.IsOpen)
            {
                if (checkBoxLED.Checked)
                {
                    Portino.Write("1"); // Turns On LED
                    lblLEDStatus.Text = "LED: On";
                    MessageBox.Show("The LED is On");
                }
                else
                {
                    Portino.Write("0"); // Turns Off LED
                    lblLEDStatus.Text = "LED: Off";
                    MessageBox.Show("The LED is Off");
                }
            }
            else
            {
                MessageBox.Show("Error, Something happened¿.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ButtSave();
        }

        private void checkBoxLED_CheckedChanged(object sender, EventArgs e)
        {
            LEDControl();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Portino.IsOpen)
            {
                Portino.Close();
            }
            base.OnFormClosing(e);
        }

        private void TBUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}