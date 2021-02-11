using System;

namespace Amortización
{
    public partial class Usuario
    {
        private double Monto_req = 0;
        private double Plazo_pr = 0;
        private double Interes_pr = 0;

        private double Cuota_total = 0;
        private double Interes_total = 0;

        private void ParsearDatos()
        {
            Monto_req = double.Parse(Datos_usuario["Monto"]);
            Plazo_pr = double.Parse(Datos_usuario["Plazo"]);
            Interes_pr = double.Parse(Datos_usuario["Interes"]);
        }

        private void Calcular()
        {
            ParsearDatos();
            double
                Exp = Math.Pow(1 + Interes_pr, Plazo_pr),
                Cuota = Monto_req * ((Exp * Interes_pr) / (Exp - 1)),
                Interes_actual = Monto_req * Interes_pr,
                Abono = Cuota - Interes_actual,
                Saldo = Monto_req - Abono;

            int Periodo = 1;
            while (Periodo <= Plazo_pr)
            {
                Cuota_total += Cuota;
                Interes_total += Interes_actual;

                Datos.Rows.Add(
                    Periodo,
                    Math.Round(Cuota, 2),
                    Math.Round(Interes_actual, 2),
                    Math.Round(Abono, 2),
                    Math.Round(Saldo, 2)
                );

                Interes_actual = Saldo * Interes_pr;
                Abono = Cuota - Interes_actual;

                Saldo -= Abono;
                Periodo++;
            }
        }

        private void Mostrar_datos()
        {
            Calcular();

            string Plazo_usuario = Datos_usuario["Plazo"];

            lblNombre.Text = $"Cliente: {Datos_usuario["Nombre"]}";
            lblPlazo.Text = $"Plazo: {Datos_usuario["Plazo"]} meses";
            lblMonto.Text = $"Monto: {Datos_usuario["Monto"]}$";
            lblnteresFinal.Text = $"Interes: {Intereses[Plazo_usuario]}%";

            lblTACuota.Text = $"Cuota total: {Math.Round(Cuota_total, 2)}$";
            lblTInteres.Text = $"Interes total: {Math.Round(Interes_total, 2)}$";
        }
    }
}
