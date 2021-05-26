using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CADIceTray;
using KompasInteractor;

namespace CADIceTrayUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса параметров.
        /// </summary>
        private readonly IceTrayParameters _parameters;

        /// <summary>
        /// Экземпляр класса соединения с компасом.
        /// </summary>
        private readonly KompasConnector _kompas;

        /// <summary>
        /// Словарь хранящий в себе имена параметров.
        /// Ключами являются соответствующие текстбоксы.
        /// </summary>
        private readonly Dictionary<object, ParameterName> _dictionary =
            new Dictionary<object, ParameterName>();

        /// <summary>
        /// Инициализация данных.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _dictionary.Add(LengthTextBox, ParameterName.Length);
            _dictionary.Add(HeightTextBox, ParameterName.Height);
            _dictionary.Add(WidthTextBox, ParameterName.Width);
            _dictionary.Add(CellWidthTextBox, 
                ParameterName.CellWidth);
            _dictionary.Add(CellLengthTextBox, 
                ParameterName.CellLength);
            _dictionary.Add(CellHeightTextBox,
                ParameterName.CellHeight);
            _kompas = new KompasConnector();
            _parameters = new IceTrayParameters();
        }

        /// <summary>
        /// Создание модели.
        /// </summary>
        private void CreateModel()
        {
            _parameters[ParameterName.Length] =
                double.Parse(LengthTextBox.Text);
            _parameters[ParameterName.Width] =
                double.Parse(WidthTextBox.Text);
            _parameters[ParameterName.Height] =
                double.Parse(HeightTextBox.Text);
            _parameters[ParameterName.CellWidth] =
                double.Parse(CellWidthTextBox.Text);
            _parameters[ParameterName.CellLength] =
                double.Parse(CellLengthTextBox.Text);
            _parameters[ParameterName.CellHeight] =
                double.Parse(CellHeightTextBox.Text);
            _kompas.OpenKompas();
            var model = new IceTrayModeler(_kompas.Kompas);
            model.CreateModel(_parameters);
        }

        /// <summary>
        /// Событие проверка значений текстбокса при выходе из него.
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters[_dictionary[sender]] = double.Parse(
                    ((TextBox)sender).Text);
                if (sender.Equals(HeightTextBox))
                {
                    var max = 
                        _parameters[ParameterName.Height] - 5;
                    CellHeightLabel.Text = $@"(15-{max} мм)";
                }
                if (sender.Equals(WidthTextBox))
                {
                    var max = (
                        _parameters[ParameterName.Width] - 20) / 2;
                    CellWidthLabel.Text = $@"(15-{max} мм)";
                }
                if (sender.Equals(LengthTextBox))
                {
                    var max = (
                        _parameters[ParameterName.Length] - 20) / 2;
                    CellLengthLabel.Text = $@"(15-{max} мм)";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                ((TextBox)sender).Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Focus();
            }
        }

        /// <summary>
        /// Событие нажатия кнопки.
        /// </summary>
        private void CreateModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateModel();
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые", @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Событие ввода с клавиатуры в текстбокс.
        /// </summary>
        private void ValidateDoubleTextBoxs_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(),
                @"[\d\b,]");
        }
    }
}
