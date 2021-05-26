using System;
using System.Collections.Generic;

namespace CADIceTray
{
    /// <summary>
    /// Параметры в виде списка.
    /// </summary>
    public class IceTrayParameters
    {
        /// <summary>
        /// Список параметров.
        /// </summary>
        private readonly List<Parameter> _parameters = new List<Parameter>
        {
            new Parameter(70, ParameterName.Length, 70, 
                100, "Длина формы"),
            new Parameter(70, ParameterName.Width, 70, 
                100, "Ширина формы"),
            new Parameter(30, ParameterName.Height, 20, 
                40, "Высота формы"),
            new Parameter(25, ParameterName.CellLength, 15, 
                40, "Длина ячейки"),
            new Parameter(25, ParameterName.CellWidth, 15, 
                40, "Ширина ячейки"),
            new Parameter(25, ParameterName.CellHeight, 15,
                35, "Высота ячейки")
        };

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="parameterName">Имя параметра.</param>
        /// <returns>Значение параметра.</returns>
        public double this[ParameterName parameterName]
        {
            get => GetParameter(parameterName).Value;
            set
            {
                double min = 0;
                double max = 0;
                var name = "";
                switch (parameterName)
                {
                    case ParameterName.CellLength:
                        min = 15;
                        max = (GetParameter(
                            ParameterName.Length).Value - 20) / 2;
                        name = "Длина ячейки";
                        break;
                    case ParameterName.CellWidth:
                        min = 15;
                        max = (GetParameter(
                            ParameterName.Width).Value - 20) / 2;
                        name = "Ширина ячейки";
                        break;
                    case ParameterName.CellHeight:
                        min = 15;
                        max = GetParameter(
                            ParameterName.Height).Value - 5;
                        name = "Высота ячейки";
                        break;
                }
                if (name != "" && (value < min || value > max))
                {
                    throw new ArgumentException(
                        $"{name} не может быть меньше {min} " +
                        $"и не может быть больше {max}"
                    );
                }
                GetParameter(parameterName).Value = value;
            }
        }


        /// <summary>
        /// Получение параметра по имени.
        /// </summary>
        /// <param name="parameterName">Имя параметра.</param>
        /// <returns>Параметр.</returns>
        private Parameter GetParameter(ParameterName parameterName) =>
            _parameters.Find((parameter) => parameter.Name.Equals(
                parameterName));
    }
}
