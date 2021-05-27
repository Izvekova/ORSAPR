using System;

namespace CADIceTray
{
    //TODO: XML комментарии?
    public class Parameter
    {
        /// <summary>
        /// Конструктор параметров.
        /// </summary>
        /// <param name="value">Значение параметра.</param>
        /// <param name="name">Имя параметра.</param>
        /// <param name="min">Минимум значения.</param>
        /// <param name="max">Максимум значения.</param>
        /// <param name="printName">Имя для вывода.</param>
        public Parameter(double value, ParameterName name, double min,
            double max, string printName)
        {
            Min = min;
            Max = max;
            Name = name;
            Value = value;
            PrintName = printName;
        }

        /// <summary>
        /// Значение параметра не может быть меньше min и больше max.
        /// </summary>
        public double Value
        {
            get => _value;
            set
            {
                if (value < Min || value > Max)
                {
                    var message =
                        $"{PrintName} не может быть меньше {Min} или " +
                        $"больше {Max}.\n";
                    throw new ArgumentException(string.Join(
                        "\n", message));
                }
                _value = value;
            }
        }
        
        /// <summary>
        /// Минимальное значение параметра.
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// Максимальное значение параметра.
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// Имя параметра.
        /// </summary>
        public ParameterName Name { get; set; }

        /// <summary>
        /// Имя для вывода.
        /// </summary>
        public string PrintName { get; set; }

        /// <summary>
        /// Значение параметра.
        /// </summary>
        private double _value;
    }
}