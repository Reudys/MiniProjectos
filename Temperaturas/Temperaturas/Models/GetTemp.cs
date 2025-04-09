using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Temperaturas.Models
{
    class GetTemp
    {
        ErrorMessage e = new ErrorMessage();
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
                MessageBox.Show(e.Error4, "Error");
                return false;
            }
        }

        public bool IsEmpty(string temp)
        {
            return string.IsNullOrEmpty(temp);
        }
    }
}
