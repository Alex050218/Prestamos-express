using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace Amortización
{
    public partial class Usuario : Form
    {
        private readonly Dictionary<string, string> Datos_usuario = new Dictionary<string, string>() {
            {"Nombre", ""},
            {"Telefono", ""},
            {"Monto", ""},
            {"Plazo", ""},
            {"Interes", ""},
            {"Directorio" , ""}
        };

        private readonly Dictionary<string, string> Intereses = new Dictionary<string, string>() {
            {"6", "20"},
            {"12", "25"},
            {"24", "30"},
            {"36", "35"},
            {"48", "40"},
            {"72", "50"}
        };

        readonly DataTable Datos = new DataTable();

        private readonly Image DefaultImage = null;

        public Usuario()
        {
            InitializeComponent();
            grpRegistro.BringToFront();
            grpRegistro.Visible = true;

            DefaultImage = vistaImg.Image;

            Datos.Columns.AddRange(
                new DataColumn[5]
                {
                    new DataColumn("Periodo", typeof(int)),
                    new DataColumn("Cuota", typeof(double)),
                    new DataColumn("Intereses", typeof(double)),
                    new DataColumn("Abono Capital", typeof(double)),
                    new DataColumn("Saldo", typeof(double))
                }
            );

            tblAmortizacion.DataSource = Datos;
        }

        private void Plazos(object sender, EventArgs e)
        {
            RadioButton btnPlazos = (RadioButton)sender;
            string Plazo_selec = btnPlazos.Text.Split(' ')[0];

            Datos_usuario["Plazo"] = Plazo_selec;
            Datos_usuario["Interes"] = $"0.{Intereses[Plazo_selec]}";

            lblInteres.Text = $"Taza de interes: {Intereses[Plazo_selec]}%";
        }

        private void Nuevo_dato(object sender, EventArgs e)
        {
            TextBox txtDatoNuevo = (TextBox)sender;
            string NombreDato = txtDatoNuevo.Name;

            string Dato_nuevo = txtDatoNuevo.Text;
            switch (NombreDato)
            {
                case "txtNombre":
                    Datos_usuario["Nombre"] = Regex.Match(Dato_nuevo, @"^[A-Z][a-zA-Z\s]{2,40}$").Success
                        ? Dato_nuevo : "";
                    break;
                case "txtTelefono":
                    Datos_usuario["Telefono"] = Regex.Match(Dato_nuevo, @"^[0-9]{10}$").Success
                        ? Dato_nuevo: "";
                    break;
                case "txtMonto":
                    Datos_usuario["Monto"] = Regex.Match(Dato_nuevo, @"[0-9]{4,}").Success
                        ? Dato_nuevo: "";
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

        private void CambiarVentana(object sender, EventArgs e)
        {
            Button BtnClickeado = (Button)sender;
            string NombreBtn = BtnClickeado.Name;

            bool TodoLleno = Datos_usuario.Values.Contains("");
            switch (NombreBtn)
            {
                case "btnRegresar":
                    grpRegistro.BringToFront();
                    grpRegistro.Visible = true;
                    grpTabla.Visible = false;
                    grpTabla.SendToBack();

                    Cuota_total = 0;
                    Interes_total = 0;
                    LimpiarRegistro();
                    lblInteres.Text = "Interes: 0%";
                    Datos.Clear();
                    break;
                case "btnContinuar":
                    if (!TodoLleno)
                    {
                        grpRegistro.SendToBack();
                        grpRegistro.Visible = false;
                        grpTabla.Visible = true;
                        grpTabla.BringToFront();
                        Mostrar_datos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Campos vacios o invalidos. Trate de introducir valores nuevos",
                            "Valor invalido", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                       );
                    }
                    break;
            }
        }

        private void LimpiarRegistro()
        {
            txtMonto.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            lblInteres.Text = "Taza de interes: 0%";
            vistaImg.Image = DefaultImage;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }
   }
}
