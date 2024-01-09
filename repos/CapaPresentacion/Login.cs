using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_ingresar_Click(object sender, EventArgs e)
        {
            List<Users> TEST = new CN_Usuario().Listar();

            Users ousuario = new CN_Usuario().Listar().Where(u=> u.Identification_card == textBox_usuario.Text && u.Password == textBox_password.Text).FirstOrDefault();


       if (ousuario != null)
            {
                Inicio form = new Inicio();
                form.Show();
                //cerrar el form
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Datos Incorrectos,vuelva a intentar!!","Mesaage",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.textBox_usuario.Text = "";
            this.textBox_password.Text = "";
            this.Show();
        }
    }
}
