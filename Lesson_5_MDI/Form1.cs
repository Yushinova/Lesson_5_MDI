using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lesson_5_MDI
{
    public partial class Form1 : Form
    {
        //public List<Person> people = new List<Person>();
        public List<Person> people = new List<Person> {
            new Person { Surname="Иванов", Name = "Иван", SecondName="Иванович", DateBorn=new DateTime(1984,4,15), PlaceBorn="Москва" },
            new Person { Surname="Петрова", Name = "Петра", SecondName="Петровна", DateBorn=new DateTime(1985,2,10), PlaceBorn="Нижний Новгород"},
            new Person { Surname="Зайцева", Name = "Карина", SecondName="Михайловна", DateBorn = new DateTime(1980,1,25), PlaceBorn = "Москва"}
            };
        public int index { get; set; }
        public Form1()
        {
            InitializeComponent();
            Table_Load();

        }

        public void Table_Load()//Для примера существующими объектами 
        {
            foreach (var item in people)
            {
                dataGridView1.Rows.Add(item.Surname, item.Name, item.SecondName, item.DateBorn.ToShortDateString(), item.PlaceBorn);
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (index > -1 && index < people.Count)
            {
                people.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            people.Add(form.person);
            dataGridView1.Rows.Add(form.person.Surname, form.person.Name, form.person.SecondName, form.person.DateBorn.ToShortDateString(), form.person.PlaceBorn);
        }

        private void ChangeItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(people[index]);
            form.ShowDialog();
            people[index] = form.person;
            dataGridView1.Rows.RemoveAt(index);
            dataGridView1.Rows.Add(form.person.Surname, form.person.Name, form.person.SecondName, form.person.DateBorn.ToShortDateString(), form.person.PlaceBorn);
        }

        private void Open_txt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                IFormatter sf = new BinaryFormatter();//бинарный формат 
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    ////Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    if (System.IO.File.Exists(filePath))
                    {
                        try
                        {
                            using (Stream fsteread = File.OpenRead(filePath))
                            {
                                people.Clear();
                                people = (List<Person>)sf.Deserialize(fsteread);
                            }
                            dataGridView1.Rows.Clear();
                            foreach (var item in people)
                            {
                                dataGridView1.Rows.Add(item.Surname, item.Name, item.SecondName, item.DateBorn.ToShortDateString(), item.PlaceBorn);
                            }
                            MessageBox.Show("Файл прочитан!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Данные не обнаружены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Save_txt_Click(object sender, EventArgs e)//сохранение файла
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            IFormatter sf = new BinaryFormatter();//бинарный формат 
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                using (myStream = File.Create(filename))
                {
                    sf.Serialize(myStream, people);
                }
                myStream.Close();
                MessageBox.Show("Файл сохранен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in people)
            {
                dataGridView1.Rows.Add(item.Surname, item.Name, item.SecondName, item.DateBorn.ToShortDateString(), item.PlaceBorn);
            }
        }

        private void MonthMeu_Click(object sender, EventArgs e)
        {
            MonthText.Text = "";
        }

        private void MonthText_TextChanged(object sender, EventArgs e)
        {
            if (MonthText.Text != "")
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    foreach (var item in people)
                    {
                        int month = Convert.ToInt32(MonthText.Text);
                        DateTime tmp = new DateTime(1, month, 1);
                        if (item.DateBorn.Month == tmp.Month)
                        {
                            dataGridView1.Rows.Add(item.Surname, item.Name, item.SecondName, item.DateBorn.ToShortDateString(), item.PlaceBorn);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectMenu_Click(object sender, EventArgs e)
        {
            MonthText.Text = "";
        }

        private void PlaceText_Click(object sender, EventArgs e)
        {
            PlaceText.Text = "";
        }

        private void PlaceText_TextChanged(object sender, EventArgs e)
        {
            if (PlaceText.Text != "")
            {
                dataGridView1.Rows.Clear();
                foreach (var item in people)
                {

                    if (item.PlaceBorn == PlaceText.Text)
                    {
                        dataGridView1.Rows.Add(item.Surname, item.Name, item.SecondName, item.DateBorn.ToShortDateString(), item.PlaceBorn);
                    }
                }
            }
        }
    }
}
