using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_Reto1
{
    public partial class frm_registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            cls_credito obj_cls_credito_agregar = new cls_credito();
            obj_cls_credito_agregar.fnt_agregar
                (
                txt_codigo.Text, 
                txt_nombre.Text, 
                txt_apellido.Text,
                txt_contacto.Text, 
                txt_correo.Text, 
                txt_direccion.Text, 
                txt_salario.Text, 
                txt_empresa_laboral.Text,
                cbx_plazo.SelectedValue,
                txt_monto.Text
                );
            lbl_mensaje.Text= obj_cls_credito_agregar.getMensaje();
        }

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            cls_credito obj_cls_credito_consultar = new cls_credito();
            obj_cls_credito_consultar.fnt_consultar(txt_codigo.Text);
            txt_nombre.Text = obj_cls_credito_consultar.getNombre();
            txt_apellido.Text = obj_cls_credito_consultar.getApellido();
            txt_contacto.Text = obj_cls_credito_consultar.getContacto();
            txt_correo.Text = obj_cls_credito_consultar.getCorreo();
            txt_direccion.Text = obj_cls_credito_consultar.getDireccion();
            txt_salario.Text = obj_cls_credito_consultar.getSalario();
            txt_empresa_laboral.Text = obj_cls_credito_consultar.getEmpresa_Laboral();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_contacto.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_salario.Text = "";
            txt_empresa_laboral.Text = "";
            txt_monto.Text = "";
            cbx_plazo.SelectedIndex = 0;
        }
    }
}