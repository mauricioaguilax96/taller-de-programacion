using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        
        }

        private void TXTRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
                 if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                e.Handled = true;
                return;
        }

        }

        private void TXTDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ('K') && (e.KeyChar != ('k'))))
            {
                e.Handled = true;
                return;
            }
        }
        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RUT = int.Parse(TXTRUT.Text);
            string DV = Digito(RUT);

            if (DV != TXTDV.Text)
            {
                MessageBox.Show ("Rut ingresado no es valido");
            }

            // Inicio

            // Capturar desde las cajas de textos los valores
            string rut1 = TXTRUT.Text;
            string DV1 = TXTDV.Text;
            string nomb = TXTnombre.Text;
            string fnac = fnactxt.Text; 
            string ap1 = TXTapellido1.Text;
            string ap2 = TXTapellido2.Text;
            string prof = txtprof.SelectedValue.ToString();
            string sueldo = TXTsliquido.Text;
            // Definir string de conexion y el comando sal

            // Autenticacion Windows
            string strConexionSQL = "Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;";

            // Instruccion SQL
            string comandoSQL = "INSERT INTO clientes (Rut, DV, nombre,fecha_nacimiento, apellido_paterno, Apellido_materno,id_profesion, Sueldo_liquido) VALUES ('" + rut1 + "','" + DV1 + "','" + nomb + "','" + fnac + "','" + ap1 + "','" + ap2 + "','" + prof + "','" + sueldo + "')";
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
                CargarGrila();

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

        private void CargarGrila(){
            
                // Definir string de conexion y el comando sql
                string strConexionSQL = "Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;";

                // Crear los objetos para la conexion a la BD
                SqlConnection con = new SqlConnection(strConexionSQL); 

                DataTable tbTipogrilla = new DataTable();

                // abrir conexion y ejecutar instraucicon sql
                con.Open();
                String comandoSQL = "select * from clientes";
                SqlDataAdapter dagrilla = new SqlDataAdapter(comandoSQL, con);

                dagrilla.Fill(tbTipogrilla);

                
                // poblar el combobox con el resultado del select 
                dataGridView1.DataSource = tbTipogrilla;

                // cerra la conexion
                con.Close();
        }
        private void CargarComboBox()
        {
            // Poblar combobox

            // Definir string de conexion y el comando sql

            string strConexionSQL = "Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;";

            // Instruccion SQL
            string comandoSQL = "select id_profesion,descripcion from profesion ";


            // Crear los objetos para la conexion a la BD
            SqlConnection con = new SqlConnection(strConexionSQL);
            DataTable tbTipo = new DataTable();

            // abrir conexion y ejecutar instraucicon sql
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(comandoSQL, con);

            da.Fill(tbTipo);

            // configuracion del combox 
            txtprof.DisplayMember = "descripcion";
            txtprof.ValueMember = "id_profesion";

            // poblar el combobox con el resultado del select 
            txtprof.DataSource = tbTipo;

            // cerra la conexion
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                CargarComboBox();
                CargarGrila();

  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            // Fin 
        }
    }
}

 
