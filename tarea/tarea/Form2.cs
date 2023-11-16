using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tarea
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Capturar desde las cajas de textos los valores
            string codigo = txtcodigo.Text;
            string Ncredito = txtnombcredito.Text;
            string tasainte = txttasaint.Text;
            string edadmax = txtedadmax.Text;
            string montomin = txtmontomax.Text;
            string montomax = txtmontomin.Text;
            string Sminimo = txtsueldomin.Text;
            // Definir string de conexion y el comando sal

            // Autenticacion Windows
            string strConexionSQL = "Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;";

            // Instruccion SQL
            string comandoSQL = "INSERT INTO credito (Codigo, Nombre, tasa_interes,Edad_maxima, monto_minimo, monto_maximo,Sueldo_minimo) VALUES ('" + codigo + "','" + Ncredito + "','" + tasainte + "','" + edadmax + "','" + montomin + "','" + montomax + "','" + Sminimo + "')";
            // Crear los objetos para la conexion a la BD
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection(strConexionSQL);
            try
            {
                // Abrir la conexion 
                con.Open();

                // Ejecutar la instrucicon SQL
                da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(comandoSQL, con);
                da.InsertCommand.ExecuteNonQuery();

                // Cerra la conexion
                con.Close();

                // Mostrar mensaje de exito
                MessageBox.Show("Registro grabado exitosamente.");

            }
            catch (Exception ex)
            {
                // en caso de algun error, mostrar el error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
            // Fin 
        }


        }
    }

