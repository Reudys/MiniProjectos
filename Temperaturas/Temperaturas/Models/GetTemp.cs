using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Temperaturas.Models
{
    class GetTemp
    {
        //Attributes
        private string temp;

        //Constructor
        public GetTemp(string temp)
        {
            this.temp = temp;
        }

        //Methods
        public bool IsDouble(string temp)
        {
            try
            {
                double.Parse(temp);
                return true;
            }
            catch (System.Exception)
            {
                MessageBox.Show("El valor ingresado no es un número", "Error");
                return false;
            }
        }

        public bool IsEmpty(string temp)
        {
            return string.IsNullOrEmpty(temp);
        }


     
    }
}
