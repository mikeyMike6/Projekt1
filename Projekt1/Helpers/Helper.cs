using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1.Helpers
{
    public static class Helper
    {
        public static bool CheckName(string name, out string firstName, out string lastName)
        {
            var names = name.Split(' ');
            firstName = names[0];
            if (names.Length > 1)
            {
                lastName = names[1];
                if (lastName != "")
                {
                    switch (names.Length)
                    {
                        case 0:
                            MessageBox.Show("Nie wprowadzono wartości");
                            return false;
                        case 2:
                            if (firstName.Length < 3 || lastName.Length < 3)
                            {
                                MessageBox.Show("Wprowadzone dane są za krótkie");
                                return false;
                            }
                                return true;
                        default:
                            MessageBox.Show("Wymagany dwuczłonowy wyraz");
                            return false;

                    }
                }
                else
                {
                    MessageBox.Show("Wymagane jest nazwisko");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Wymagane jest nazwisko");
                lastName = "";
                return false;
            }
        }
        public static string ConverDate(DateTime dateTime)
        {
            var day = dateTime.Day.ToString("d");
            var month = dateTime.Month.ToString("d");
            var year = dateTime.Year.ToString("d");

            return year + "-" + month + "-" + day;
        }
    }
}
