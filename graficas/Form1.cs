using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(tbX1.Text);
            int y1 = int.Parse(tbY1.Text);
            int x2 = int.Parse(tbX2.Text);
            int y2 = int.Parse(tbY2.Text);

            // Agregar puntos extremos de la línea

            Grafica.Series[0].Points.AddXY(x1, y1);

            Grafica.Series[0].Points.AddXY(x2, y2);

            // Establecer el tipo de gráfico como una línea

            Grafica.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Mostrar los puntos A y B como círculos

            Grafica.Series[0].Points[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

            Grafica.Series[0].Points[1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

            // Etiquetar los puntos A y B

            Grafica.Series[0].Points[0].Label = "A";

            Grafica.Series[0].Points[1].Label = "B";

            //color de los label A y B
            Grafica.Series[0].Points[0].LabelForeColor = Color.Green;
            Grafica.Series[0].Points[1].LabelForeColor = Color.Green;

            double m = CalculaPendiente(x1, y1, x2, y2);

            if (m == 0)
                DibujarCasoEspecialM0(x1, y1, x2, y2);
            else if (double.IsNaN(m))
                DibujarCasoEspecialMIndeterminado(x1, y1, x2, y2);
            else if (m == -1)
                DibujarCasoEspecialM1(x1, y1, x2, y2);
            else if (m == 1)
                DibujarCasoEspecialM1(x1, y1, x2, y2);
            else if (m > 0 && m < 1)
            {
                if (x1 < x2)
                    DibujarCaso1(x1, y1, x2, y2, m);
                else
                    DibujarCaso2(x1, y1, x2, y2, m);
            }
            else if (m > 1)
            {
                if (y1 < y2)
                    DibujarCaso3(x1, y1, x2, y2, m);
                else
                    DibujarCaso4(x1, y1, x2, y2, m);
            }
            else // m negativo
            {
                double mAbs = Math.Abs(m);
                if (mAbs > 0 && mAbs < 1)
                {
                    if (x1 < x2)
                        DibujarCaso2Negativo(x1, y1, x2, y2, m);
                    else
                        DibujarCaso1Negativo(x1, y1, x2, y2, m);
                }
                else // mAbs >= 1
                {
                    if (y1 < y2)
                        DibujarCaso4Negativo(x1, y1, x2, y2, m);
                    else
                        DibujarCaso3Negativo(x1, y1, x2, y2, m);
                }
            }
        }

        double CalculaPendiente(int x1, int y1, int x2, int y2)
        {
            // Verificar si la pendiente es indeterminada (división por cero)
            if (x2 - x1 == 0)
            {
                return double.NaN; // Retornar NaN si la pendiente es indeterminada
            }

            // Calcular y retornar la pendiente
            double m = (double)(y2 - y1) / (x2 - x1);
            return m;
        }

        private void DibujarCaso3Negativo(int x1, int y1, int x2, int y2, double m)
        {
            // Inicializar x con x1
            double x = x1;

            // Iterar desde y1 hasta y2 (de abajo hacia arriba, ya que y1 < y2)
            for (int y = y1; y <= y2; y++)
            {
                // Agregar el punto (x, y) a la gráfica
                Grafica.Series[0].Points.AddXY(x, y);

                // Agregar las coordenadas al ListBox en el formato correcto
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");

                // Calcular el siguiente valor de x
                x += 1 / Math.Abs(m);
            }

            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        private void DibujarCaso4Negativo(int x1, int y1, int x2, int y2, double m)
        {
            //caso negativo4
            double x = x1;
            for (int y = y1; y >= y2; y--)
            {
                Grafica.Series[0].Points.AddXY(x, y);

                // Agregar las coordenadas al ListBox en el formato correcto
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");
                x += 1 / m;
            }
            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        private void DibujarCaso1Negativo(int x1, int y1, int x2, int y2, double m)
        {
            //caso negativo
            double y = y1;
            for (int x = x1; x >= x2; x--)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");
                y += m; // Incrementar y por m (ya que m es negativo)
            }
            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        private void DibujarCaso2Negativo(int x1, int y1, int x2, int y2, double m)
        {
            // Inicializar y con y1
            double y = y1;

            // Iterar desde x1 hasta x2 (de derecha a izquierda, ya que x1 > x2)
            for (int x = x1; x >= x2; x--)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");

                // Mostrar las coordenadas y calcular el siguiente valor de y
                y = Math.Round(y - m, 2);
            }

            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }
        void DibujarCaso1(int x1, int y1, int x2, int y2, double m)
        {
            double y = y1;
            for (int x = x1; x <= x2; x++)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");
                y += m;
            }
            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        void DibujarCaso2(int x1, int y1, int x2, int y2, double m)
        {
            double y = y1;
            for (int x = x1; x >= x2; x--)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");
                y -= m;
            }
            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        // Métodos para dibujar otros casos
        void DibujarCaso3(int x1, int y1, int x2, int y2, double m)
        {
            double x = x1;
            for (int y = y1; y <= y2; y++)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");
                x += 1 / m;
            }

            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        void DibujarCaso4(int x1, int y1, int x2, int y2, double m)
        {
            double x = x1;
            for (int y = y1; y >= y2; y--)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x:F2}\tY: {y:F2}");
                x -= 1 / m;
            }

            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = Math.Round(m, 2).ToString();
        }

        void DibujarCasoEspecialM0(int x1, int y1, int x2, int y2)
        {
            int start = Math.Min(x1, x2);
            int end = Math.Max(x1, x2);
            int increment = x1 < x2 ? 1 : -1;

            for (int x = start; x != end + increment; x += increment)
            {
                Grafica.Series[0].Points.AddXY(x, y1);
                listBCoordAyB.Items.Add($"X: {x}\tY: {y1}");
            }

            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = "0";

        }

        void DibujarCasoEspecialMIndeterminado(int x1, int y1, int x2, int y2)
        {
            for (int y = Math.Min(y1, y2); y <= Math.Max(y1, y2); y++)
            {
                Grafica.Series[0].Points.AddXY(x1, y);
                listBCoordAyB.Items.Add($"X: {x1}\tY: {y}");
            }
            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = "Indeterminada/Error";
            lblPendiente.ForeColor = Color.Red;

        }

        void DibujarCasoEspecialM1(int x1, int y1, int x2, int y2)
        {
            int start = Math.Min(x1, x2);
            int end = Math.Max(x1, x2);
            int y = start == x1 ? y1 : y2;

            for (int x = start; x <= end; x++)
            {
                Grafica.Series[0].Points.AddXY(x, y);
                listBCoordAyB.Items.Add($"X: {x}\tY: {y}");
                y += x1 < x2 ? 1 : -1;
            }

            // Mostrar la pendiente en lblPendiente
            lblPendiente.Text = (x1 < x2 ? 1 : -1).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar los valores de los textbox y resetear la grafica y valores
            tbX1.Text = "";
            tbY1.Text = "";
            tbX2.Text = "";
            tbY2.Text = "";
            Grafica.Series[0].Points.Clear();
            listBCoordAyB.Items.Clear();
            lblPendiente.Text = "";
        }

        private void Grafica_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cambiar el color de la escala del eje X a rojo
            Grafica.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            // Cambiar el color de la escala del eje Y a azul
            Grafica.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }
    }
}
