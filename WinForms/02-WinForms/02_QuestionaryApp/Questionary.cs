using System;
using System.Text.RegularExpressions;

namespace QuestionaryApp
{
    [Serializable]
    public class Questionary
    {
        private string _name;
        private string _lastName;
        private int _age;
        private string _number;

        public string Name
        {
            get => _name;
            set
            {
                if (!Regex.IsMatch(value,
                    @"^([А-Я]|[A-Z])([\p{IsCyrillic}]|[A-Z]|[a-z])*$"))
                    throw new Exception();

                _name = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (!Regex.IsMatch(value,
                    @"^([А-Я]|[A-Z])([\p{IsCyrillic}]|[A-Z]|[a-z])*$"))
                    throw new Exception();

                _lastName = value;
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                if (!Regex.IsMatch(value,
                    @"\+? ?3?[ -]?8?[ -]?\(?(\d[ -]?){3}\)?[ -]?(\d[ -]?){7}"))
                    throw new Exception();

                _number = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0 || value > 100)
                    throw new Exception();

                _age = value;
            }
        }

        public override string ToString()
        {
            return (string)this;
        }

        public static explicit operator string(Questionary questionary)
        {
            return
                $"{questionary.Name} {questionary.LastName} \t{questionary.Age} y.o." +
                $"\t{questionary.Number}";
        }
    }
}
