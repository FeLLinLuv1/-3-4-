using EncapsulationExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreatePerson_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение данных с формы
                string name = textBoxName.Text;
                int age = int.TryParse(textBoxAge.Text, out int result) ? result : 0;

                // Создание объекта Person
                Person person = new Person
                {
                    Name = name,
                    Age = age
                };

                // Отображение информации
                labelInfo.Text = person.GetInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
