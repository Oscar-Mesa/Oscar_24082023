using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace App_Reto1
{
    public class cls_credito
    {
        private string str_mensaje;
        SqlCommand con; SqlDataReader Lectura;

        public void fnt_agregar(string codigo, string nombre, string contacto, string correo, string direccion,
            string apellidos, string salario, string empresa,string plazo,string monto)
        {
            if ((nombre == "") || (contacto == "") || (correo == "") || (direccion == ""))
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
            public string getMensaje() { return this.str_mensaje; }
    }
}