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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Cargartipodecredito();
        }
        private void Cargartipodecredito()
        {
            string strConexionSQL = "Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;";

            string comandoSQL = "select Codigo,Nombre from credito ";

            SqlConnection con = new SqlConnection(strConexionSQL);
            DataTable tbTipo = new DataTable();

            // abrir conexion y ejecutar instraucicon sql
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(comandoSQL, con);

            da.Fill(tbTipo);

            // configuracion del combox 
            combocredit.DisplayMember = "Nombre";
            combocredit.ValueMember = "Codigo";

            // poblar el combobox con el resultado del select 
            combocredit.DataSource = tbTipo;

            // cerra la conexion
            con.Close();
        }

        private bool simulacion1(out string MsgRetorno)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            // ejecutar al procedimiento almacenado
            SqlConnection Conexion = new SqlConnection("Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;");
            Conexion.Open();
            comando.Connection = Conexion;
            comando.CommandText = "ValidarCredito";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@rut_cliente", Rutstxt.Text);
            comando.Parameters.AddWithValue("@monto_solicitado", MontoStxt.Text);
            comando.Parameters.AddWithValue("@Codigo_Credito", combocredit.SelectedValue);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.Close();

            // capturar los valores de los campos CodigoRetorno y MensajeRetorno
            string codRetorno = tabla.Rows[0]["cod_retorno"].ToString();
            MsgRetorno = tabla.Rows[0]["Mensaje"].ToString();
            if (codRetorno == "0")
                return true;
            else
                return false;

            //MessageBox.Show(MsgRetorno);
        }

        private bool simulacion2(out string MsgRetorno)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            // ejecutar al procedimiento almacenado
            SqlConnection Conexion = new SqlConnection("Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;");
            Conexion.Open();
            comando.Connection = Conexion;
            comando.CommandText = "ValidarEdad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@rut_cliente", Rutstxt.Text);
            comando.Parameters.AddWithValue("@monto_solicitado", MontoStxt.Text);
            comando.Parameters.AddWithValue("@Codigo_Credito", combocredit.SelectedValue);
            comando.Parameters.AddWithValue("@plazo", PlazoStxt.Text);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.Close();

            // capturar los valores de los campos CodigoRetorno y MensajeRetorno
            string codRetorno = tabla.Rows[0]["cod_retorno"].ToString();
            MsgRetorno = tabla.Rows[0]["Mensaje"].ToString();
            if (codRetorno == "0")
                return true;
            else
                return false;
        }

        private bool simulacion3(out string MsgRetorno)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            // ejecutar al procedimiento almacenado
            SqlConnection Conexion = new SqlConnection("Server=BGLABI00718\\BUSSQL;Database=creditos;User Id=SA;Password=Aiep.2022;");
            Conexion.Open();
            comando.Connection = Conexion;
            comando.CommandText = "ValidarSueldo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@rut_cliente", Rutstxt.Text);
            comando.Parameters.AddWithValue("@monto_solicitado", MontoStxt.Text);
            comando.Parameters.AddWithValue("@Codigo_Credito", combocredit.SelectedValue);
            comando.Parameters.AddWithValue("@plazo", PlazoStxt.Text);
            comando.Parameters.AddWithValue("@sueldo_cliente", sueldotxt.Text);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.Close();

            // capturar los valores de los campos CodigoRetorno y MensajeRetorno
            string codRetorno = tabla.Rows[0]["cod_retorno"].ToString();
            MsgRetorno = tabla.Rows[0]["Mensaje"].ToString();
            if (codRetorno == "0")
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RutS = Rutstxt.Text;
            string MonstoS = MontoStxt.Text;
            string PlazoS = PlazoStxt.Text;
            string prof = combocredit.SelectedValue.ToString();
            string sueldo = sueldotxt.Text;
            string mensaje="";


            bool sim = simulacion1(out mensaje);
            if (sim == false){
                MessageBox.Show(mensaje);
                return;          
            }

            sim = simulacion2(out mensaje);
            if (sim == false)
            {
                MessageBox.Show(mensaje);
                return;
            }

            sim = simulacion3(out mensaje);
            if (sim == false)
            {
                MessageBox.Show(mensaje);
                return;
            }


        }
        
    }

}