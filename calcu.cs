using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tejada
{
	public enum Operacion
	{
		Nodefinida = 0,
		Suma = 1,
		Resta = 2,
		Division = 3,
		Multiplicacion = 4
	}

	public partial class calcu : Form
	{
		double valorA = 0;
		double valorB = 0;
		Operacion operador = Operacion.Nodefinida;
		bool numeroLeido = false;
		public calcu()
		{
			InitializeComponent();
		}


		private void Numero(string num)
		{
			numeroLeido = true;
			if (resultado.Text == "0" && resultado.Text != null)
			{
				resultado.Text = num;
			}
			else
			{
				resultado.Text += num;
			}
		}
		private double EjecutarAccion()
		{
			double resultado = 0;
			switch (operador)
			{

				case Operacion.Suma:
					resultado = valorA + valorB;
					break;
				case Operacion.Resta:
					resultado = valorA - valorB;
					break;
				case Operacion.Division:
					if (valorB == 0)
					{
						MessageBox.Show("No se puede dividir por 0");
						resultado = 0;
					}
					else
					{
						resultado = valorA / valorB;
					}
					break;
				case Operacion.Multiplicacion:
					resultado = valorA * valorB;
					break;
			}
			return resultado;

		}
		private void resultado_TextChanged(object sender, EventArgs e)
		{

		}

		private void button0_Click(object sender, EventArgs e)
		{
			numeroLeido = true;
			if (resultado.Text == "0")
			{
				return;
			}
			else
			{
				resultado.Text += "0";
			}
		}

		private void buttonIgual_Click(object sender, EventArgs e)
		{
			if (valorB == 0 && numeroLeido)
			{
				valorB = Convert.ToDouble(resultado.Text);
				pantalla.Text += valorB + "=";
				double resultadoFinal = EjecutarAccion();
				valorA = 0;
				valorB = 0;
				numeroLeido = false;
				resultado.Text = Convert.ToString(resultadoFinal);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Numero("1");
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Numero("2");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Numero("3");

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Numero("4");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Numero("5");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Numero("6");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Numero("7");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Numero("8");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Numero("9");
		}

		private void calcu_Load(object sender, EventArgs e)
		{

		}

		private void ObtenerValor(string operador)
		{
			valorA = Convert.ToDouble(resultado.Text);
			pantalla.Text = resultado.Text + operador;
			resultado.Text = "0";
		}
		private void buttonMas_Click(object sender, EventArgs e)
		{
			operador = Operacion.Suma;
			ObtenerValor("+");
		}
		
		

		private void buttonMulti_Click(object sender, EventArgs e)
		{
			operador = Operacion.Multiplicacion;
			ObtenerValor("x");
		}

		private void buttonDiv_Click(object sender, EventArgs e)
		{
			operador = Operacion.Division;
			ObtenerValor("/");
		}

		private void buttonC_Click(object sender, EventArgs e)
		{
			pantalla.Text = "0";
			resultado.Text = "";
		}

		private void buttonCe_Click(object sender, EventArgs e)
		{
			if (resultado.Text.Length > 1)
			{
				string txtResultado = resultado.Text;
				txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

				if (txtResultado.Length == 1 && txtResultado.Contains("-"))
				{

					resultado.Text = "0"; 
				}
				else
				{
					resultado.Text = txtResultado;
				}

			}
		}

		private void buttonPunto_Click(object sender, EventArgs e)
		{
			if (resultado.Text.Contains("."))
			{
				return; 
			}
			resultado.Text += ".";
		}

		private void buttonMen_Click(object sender, EventArgs e)
		
		{
			operador = Operacion.Resta;
			ObtenerValor("-");
		}
		
	}
}