using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DbAppTask2.Models
{
    public class Employee: IDataErrorInfo
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(255, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Gender { get; set; }

        public bool Married { get; set; }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "FullName":
                        //Обработка ошибок для свойства Name
                        if (!Regex.IsMatch(FullName, @"^[a-zA-Z]+$"))
                        {
                            error = "Correct your syntax in Full Name";
                        }
                        break;
                    case "AgeV":
                        if ((Age > 0) || (Age < 63))
                        {
                            error = "Возраст должен быть больше 0 и меньше 100";
                        }
                        break;
                    case "Position":
                        //Обработка ошибок для свойства Position
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
