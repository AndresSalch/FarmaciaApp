using System.Text.RegularExpressions;

namespace FarmaciaApp.Components
{
    public class Checks
    {
        public bool checkID(string idConsulta)
        {
            if (Regex.IsMatch(idConsulta, @"^[1-9]\d{8}$"))
            {
                return true;
            }

            return false;
        }
        public bool checkName(string name)
        {
            if (Regex.IsMatch(name, "^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\\s]+$\r\n"))
            {
                return true;
            }

            return false;
        }
        public bool checkEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                return true;
            }

            return false;
        }
        public bool checkTel(string tel)
        {
            if (Regex.IsMatch(tel, @"^[2687]\d{7}$"))
            {
                return true;
            }

            return false;
        }
    }
}
