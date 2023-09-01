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
            cls_credito obj_cls_Credito = new cls_credito();
            obj_cls_Credito.fnt_agregar(txt_codigo.Text, txt_nombre.Text, txt_apellido.Text,
                txt_contacto.Text, txt_correo.Text, txt_direccion.Text, txt_salario.Text, txt_empresa_laboral.Text,
                cbx_plazo.SelectedValue,txt_monto.Text);
            obj_cls_Credito.getMensaje();
        }
    }
}