using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace App_sistema_academico
{
    public class cls_estudiantes
    {
        private string str_mensaje;
        SqlCommand con; 
        SqlDataReader Lectura;


        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private string str_acudiente;
        private string str_observaciones;

        private int int_estrato;
        private int int_sexo;


        public void fnt_agregar(string codigo, string nombre, string contacto, string correo,
            string direccion, string acuediente, string estrato, string sexo, string observaciones)
        {
            if ((codigo == "") || (nombre == "") || (contacto == "") || (correo == "") ||
                (direccion == "") || (acuediente == "") || (estrato == "") || (sexo == ""))
            {
                str_mensaje = "Por favor llene todos los campos obligatorios";
            }
            else
            {
                try
                {
                    cls_conexion ObjConexion = new cls_conexion();
                    SqlCommand con = new SqlCommand("SP_Registrar", ObjConexion.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@codigo", codigo);
                    con.Parameters.AddWithValue("@nombre", nombre);
                    con.Parameters.AddWithValue("@contacto", contacto);
                    con.Parameters.AddWithValue("@correo", correo);
                    con.Parameters.AddWithValue("@direccion", direccion);
                    con.Parameters.AddWithValue("@acudiente", acuediente);
                    con.Parameters.AddWithValue("@estrato", estrato);
                    con.Parameters.AddWithValue("@sexo", sexo);
                    con.Parameters.AddWithValue("@observaciones", observaciones);

                    ObjConexion.connection.Open();
                    con.ExecuteNonQuery();
                    ObjConexion.connection.Close();
                    str_mensaje = "Registro exitoso";

                }
                catch (Exception) {
                str_mensaje = "Faltan campos / este registro ya existe";
            }

        }
    }

        public void fnt_consultar(string codigo)
        {
            try
            {
                cls_conexion ObjConexion = new cls_conexion();
                con = new SqlCommand("SP_Consultar", ObjConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@codigo", codigo);
                ObjConexion.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    str_nombre = Convert.ToString(Lectura[0]);
                    str_contacto = Convert.ToString(Lectura[1]);
                    str_correo = Convert.ToString(Lectura[2]);
                    str_direccion = Convert.ToString(Lectura[3]);
                    str_acudiente = Convert.ToString(Lectura[4]);
                    str_observaciones = Convert.ToString(Lectura[7]);

                    int_estrato = Convert.ToInt32(Lectura[5]);
                    int_sexo = Convert.ToInt32(Lectura[6]);

                    str_mensaje = "";

                }
                
            }
            catch (Exception)
            {
                str_mensaje = "No se encontraron registros con ese código";
            }
        }
        //con esta función retorno el valor de la variable y así la puedo usar fuera de este archivo
        public string getMensaje() { return this.str_mensaje; }
        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getCorreo() { return this.str_correo; }
        public string getDireccion() { return this.str_direccion;}
        public string getAcudiente() { return this.str_acudiente;}
        public string getObservaciones() { return this.str_observaciones; }

        public int getEstrato() { return this.int_estrato; }
        public int getSexo() { return this.int_sexo; }
        
    }
}
