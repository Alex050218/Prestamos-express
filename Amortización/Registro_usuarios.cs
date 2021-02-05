using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Amortización
{
    public partial class Usuario : Form
    {
        private readonly Dictionary<string, string> Datos_usuario = new Dictionary<string, string>() {
            {"Nombre", null},
            {"Telefono",null},
            {"Monto", null},
            {"Plazo", null},
            {"Interes", null},
            {"Directorio" , null}
        };

        private readonly Dictionary<string, string> Intereses = new Dictionary<string, string>() {
            {"6", "20"},
            {"12", "25"},
            {"24", "30"},
            {"36", "35"},
            {"48", "40"},
            {"72", "50"}
        };

        public Usuario()
        {
            InitializeComponent();
        }

        private void Plazos(object sender, EventArgs e)
        {
            RadioButton btnPlazos = (RadioButton)sender;
            string Plazo_selec = btnPlazos.Text.Split(' ')[0];

            Datos_usuario["Plazo"] = Plazo_selec;
            Datos_usuario["Interes"] = Intereses[Plazo_selec];

            lblInteres.Text = $"Taza de interes: {Datos_usuario["Interes"]}%";
        }

        private void Nuevo_dato(object sender, EventArgs e)
        {
            TextBox txtDatoNuevo = (TextBox)sender;
            string NombreDato = txtDatoNuevo.Name;

            switch (NombreDato)
            {
                case "txtNombre":
                    Datos_usuario["Nombre"] = txtDatoNuevo.Text;
                    break;
                case "txtTelefono":
                    Datos_usuario["Telefono"] = txtDatoNuevo.Text;
                    break;
                case "txtMonto":
                    Datos_usuario["Monto"] = txtDatoNuevo.Text;
                    break;
            }
        }

        private void agregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog DialogoFoto = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if (DialogoFoto.ShowDialog() == DialogResult.OK)
            {
                string DirFoto = DialogoFoto.FileName;
                Datos_usuario["Directorio"] = DirFoto;

                Image FotoUsuario = Image.FromFile(DirFoto);
                vistaImg.Image = FotoUsuario;
            }
        }
    }
}
