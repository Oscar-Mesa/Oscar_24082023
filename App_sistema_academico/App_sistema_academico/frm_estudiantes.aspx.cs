using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_sistema_academico
{
    public partial class frm_estudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            cls_estudiantes ObjEstudiantesRegistrar = new cls_estudiantes();
            //le paso los parametros diciendole que quiero pasarle el texto de los campos
            ObjEstudiantesRegistrar.fnt_agregar
                (
                txt_codigo.Text,
                txt_nombre.Text,
                txt_contacto.Text,
                txt_correo.Text,
                txt_direccion.Text,
                txt_acudiente.Text,
                cbx_estrato.SelectedValue,
                cbx_sexo.SelectedValue,
                txt_observaciones.Text
                );
            //del objeto de la clase cls_estudiante traigo la funcion getMensaje()
            //para poner el contenido de esa variable en el label que está en pantalla

            lbl_mensaje.Text = ObjEstudiantesRegistrar.getMensaje();

        }

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            cls_estudiantes ObjEstudianteConsultar = new cls_estudiantes();
            ObjEstudianteConsultar.fnt_consultar(txt_codigo.Text);
            txt_nombre.Text = ObjEstudianteConsultar.getNombre();
            txt_contacto.Text = ObjEstudianteConsultar.getContacto();
            txt_correo.Text = ObjEstudianteConsultar.getContacto();
            txt_direccion.Text = ObjEstudianteConsultar.getDireccion();
            txt_acudiente.Text = ObjEstudianteConsultar.getAcudiente();
            txt_observaciones.Text = ObjEstudianteConsultar.getObservaciones();

            cbx_estrato.SelectedIndex = ObjEstudianteConsultar.getEstrato();
            cbx_sexo.SelectedIndex = ObjEstudianteConsultar.getSexo();

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_contacto.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_acudiente.Text = "";
            cbx_estrato.SelectedIndex = 0;
            cbx_sexo.SelectedIndex = 0;
            txt_observaciones.Text = "";
        }
    }
}