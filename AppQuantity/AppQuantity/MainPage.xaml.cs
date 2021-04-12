using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        List<string> result_list = new List<string>();
        int total = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Funções dos Números
        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "1";
                result_list.Add(ScreenResult.Text);
            } else
            {
                ScreenResult.Text += "1";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "2";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "2";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "3";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "3";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "4";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "4";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "5";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "5";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "6";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "6";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "7";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "7";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "8";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "8";
                result_list.Add(ScreenResult.Text);
            }
        }
        private void Button9_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "9";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "9";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "0";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "0";
                result_list.Add(ScreenResult.Text);
            }
        }

        // Funções das operações
        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text != "0")
            {
                ScreenResult.Text += "+";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void ButtonLess_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text == "0")
            {
                ScreenResult.Text = "-";
                result_list.Add(ScreenResult.Text);
            }
            else
            {
                ScreenResult.Text += "-";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Multplay_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text != "0")
            {
                ScreenResult.Text += "*";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Divisor_Clicked(object sender, EventArgs e)
        {
            if (ScreenResult.Text != "0")
            {
                ScreenResult.Text += "/";
                result_list.Add(ScreenResult.Text);
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            result_list.Clear();
            total = 0;
            ScreenResult.Text = "0";
            ScreenTotal.Text = "0";
        }

        // Função para mostrar o resultado
        private void Equals_Clicked(object sender, EventArgs e)
        {
            string[] arr_sample = result_list.ToArray();
            var valores = arr_sample[arr_sample.Length - 1];

            if (valores.Contains("+"))
            {
                string[] NumDigitados = valores.Split('+');
                for (int i = 0; i < Convert.ToInt32(NumDigitados.Count()); i++)
                {
                    total += Convert.ToInt32(NumDigitados[i]);
                }               
            }

            if (valores.Contains("-"))
            {
                string[] NumDigitados = valores.Split('-');
                for (int i = 0; i < Convert.ToInt32(NumDigitados.Count()); i++)
                {
                    total -= Convert.ToInt32(NumDigitados[i]);
                }
            }
            
            if (valores.Contains("*"))
            {
                string[] NumDigitados = valores.Split('*');
                for (int i = 0; i < Convert.ToInt32(NumDigitados.Count()); i++)
                {
                    total *= Convert.ToInt32(NumDigitados[i]);
                }
            }
            
            if (valores.Contains("/"))
            {
                string[] NumDigitados = valores.Split('/');
                for (int i = 0; i < Convert.ToInt32(NumDigitados.Count()); i++)
                {
                    total /= Convert.ToInt32(NumDigitados[i]);
                }
            }
                ScreenTotal.Text = Convert.ToString(total);

        }


    }
}