using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5_MDI
{
    public partial class Form2 : Form
    {
       public Person person = new Person
        {
            Surname = "",
            Name = "",
            SecondName = "",
            DateBorn = new DateTime(2000, 1, 1),
            PlaceBorn = ""
        };
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Person person_change)//заполняем форму приходящими данными и инициализируем юзера
        {
            InitializeComponent();
            person.Surname = person_change.Surname;
            person.Name = person_change.Name;
            person.SecondName = person_change.SecondName;
            person.DateBorn = person_change.DateBorn;
            person.PlaceBorn = person_change.PlaceBorn;
            SurnameText.Text = person.Surname;
            NameText.Text = person.Name;
            SecondNameText.Text = person.SecondName;
            dateTimePicker1.Value = person.DateBorn;
            PlaceBornText.Text = person.PlaceBorn;
        }
        private void SurnameText_TextChanged(object sender, EventArgs e)
        {
            person.Surname = SurnameText.Text;
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            person.Name = NameText.Text;
        }

        private void SecondNameText_TextChanged(object sender, EventArgs e)
        {
            person.SecondName = SecondNameText.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            person.DateBorn = dateTimePicker1.Value;
        }

        private void PlaceBornText_TextChanged(object sender, EventArgs e)
        {
            person.PlaceBorn = PlaceBornText.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
