using System;
using System.Windows.Forms;
using Temperaturas.Models;

namespace Temperaturas
{
    public partial class Form1: Form
    {
        public bool ceTemp;
        public bool faTemp;
        public bool keTemp;

        public Form1()
        {
            InitializeComponent();
            
        }
        ErrorMessage em = new ErrorMessage();
        //btn Para Celsius
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox.Text;

            double t;

            GetTemp gt = new GetTemp(temp);

            if (gt.IsEmpty(temp) != true)
            {
                if (gt.IsDouble(temp) == true)
                {
                    if (!cTemp.Checked)
                    {
                        t = double.Parse(temp);
                        ConvertTo ct = new ConvertTo(t);
                        if (fTemp.Checked)
                        {
                            textBox.Text = ct.FahrenHeatToCelsius(t).ToString();
                        }
                        else if (kTemp.Checked)
                        {
                            textBox.Text = ct.KelvinToCelsius(t).ToString();
                        }
                        else
                        {
                            MessageBox.Show(em.Error2, "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show(em.Error3, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show(em.Error1, "Error");
            }
        }

        //btn Fahrenheit
        private void button2_Click(object sender, EventArgs e)
        {
            string temp = textBox.Text;

            double t;

            GetTemp gt = new GetTemp(temp);

            if (gt.IsEmpty(temp) != true)
            {
                if (gt.IsDouble(temp) == true)
                {
                    if (!fTemp.Checked)
                    {
                        t = double.Parse(temp);
                        ConvertTo ct = new ConvertTo(t);
                        if (cTemp.Checked)
                        {
                            textBox.Text = ct.CelsiusToFahrenheit(t).ToString();
                        }
                        else if (kTemp.Checked)
                        {
                            textBox.Text = ct.KelvinToFahrenheit(t).ToString();
                        }
                        else
                        {
                            MessageBox.Show(em.Error2, "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show(em.Error3, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show(em.Error1, "Error");
            }
        }

        //btn Kelvin
        private void button3_Click(object sender, EventArgs e)
        {
            string temp = textBox.Text;

            double t;

            GetTemp gt = new GetTemp(temp);

            if (gt.IsEmpty(temp) != true)
            {
                if (gt.IsDouble(temp) == true)
                {
                    if (!kTemp.Checked)
                    {
                        t = double.Parse(temp);
                        ConvertTo ct = new ConvertTo(t);
                        if (cTemp.Checked)
                        {
                            textBox.Text = ct.CelsiusToKelvin(t).ToString();
                        }
                        else if (fTemp.Checked)
                        {
                            textBox.Text = ct.FahrenheitToKelvin(t).ToString();
                        } else
                        {
                            MessageBox.Show(em.Error2, "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show(em.Error3, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show(em.Error1, "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textBox.Clear();
        }


    }
}
