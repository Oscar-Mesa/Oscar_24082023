using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Security.Cryptography.X509Certificates;

namespace App_Reto1
{
    public class cls_credito
    {
        private string str_mensaje;
        SqlCommand con; SqlDataReader Lectura;

        private string str_nombre;
        private string str_apellido;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private string str_salario;
        private string str_empresa_laboral;

        public void fnt_agregar(string codigo, string nombre, string apellidos, string contacto, string correo,
            string direccion, string salario, string empresa,string plazo,string monto)
        {
            if ((codigo == "") || (nombre == "") || (apellidos == "") || (correo == "") || (direccion == "") ||
                (salario == "") || (empresa == "") || (plazo == "") || (monto == ""))
            {
                str_mensaje = "Llene los campos obligatorios";
            }
            else
            {
                try
                {
                    cls_conexion objConecta = new cls_conexion();
                    SqlCommand con = new SqlCommand("SP_registrar", objConecta.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@Id", codigo);
                    con.Parameters.AddWithValue("@Nombre", nombre);
                    con.Parameters.AddWithValue("@Apellidos", apellidos);
                    con.Parameters.AddWithValue("@Contacto", contacto);
                    con.Parameters.AddWithValue("@Correo", correo);
                    con.Parameters.AddWithValue("@Direccion", direccion);
                    con.Parameters.AddWithValue("@Salario", salario);
                    con.Parameters.AddWithValue("@Empresa", empresa);
                    con.Parameters.AddWithValue("@Plazo", plazo);
                    con.Parameters.AddWithValue("@Monto", monto);

                    objConecta.connection.Open();
                    con.ExecuteNonQuery();
                    objConecta.connection.Close();
                    str_mensaje = "Registro exitoso";
                }
                catch (Exception) { str_mensaje = "Faltan campos / este registro ya existe"; }
                }
            }


        public void fnt_consultar(string codigo)
        {
            try
            {
                cls_conexion objConecta = new cls_conexion();
                con = new SqlCommand("SP_Consultar", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Id", codigo);
                objConecta.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    str_nombre = Convert.ToString(Lectura[0]);
                    str_apellido = Convert.ToString(Lectura[1]);
                    str_contacto = Convert.ToString(Lectura[2]);
                    str_correo = Convert.ToString(Lectura[3]);
                    str_direccion = Convert.ToString(Lectura[4]);
                    str_salario = Convert.ToString(Lectura[5]);
                    str_empresa_laboral = Convert.ToString(Lectura[6]);
                    str_mensaje = "";
                }
            }
            catch (Exception)
            {
                str_mensaje = "No se encontraron registros";
            }
        }
        public string getMensaje() { return this.str_mensaje; }
        public string getNombre() { return this.str_nombre; }
        public string getApellido() { return this.str_apellido; }
        public string getContacto() { return this.str_contacto; }
        public string getCorreo() { return this.str_correo; }
        public string getDireccion() { return this.str_direccion;}
        public string getSalario() { return this.str_salario; }
        public string getEmpresa_Laboral() { return this.str_empresa_laboral; }
    }
}