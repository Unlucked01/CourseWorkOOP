using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class ParticipantsFestivalForm : Form
    {
        const string FileParticipants = "Participants.json";
        //const string FileFilm = "Film.json";

        int numberParticipants = 0;
        int countParticipants = 0;

        public ParticipantsFestivalForm()
        {
            Task.Run(() => File.Open(FileParticipants, FileMode.OpenOrCreate).Close());
            //  Task.Run(() => File.Open(FileFilm, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }
        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //  чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        async private void ButtonCreateParticipants_Click(object sender, EventArgs e)
        {

            ParticipantsForm formParticipants = new ParticipantsForm();
            formParticipants.ShowDialog();

            string nameParticipantsForm = ParticipantsForm.NameParticipantsForm;
            string lastNameParticipantsForm = ParticipantsForm.LastNameParticipantsForm;
            string cityParticipantsForm = ParticipantsForm.CityParticipantsForm;
            int ageParticipantsForm = ParticipantsForm.AgeParticipantsForm;

            Participants newParticipants = new Participants(nameParticipantsForm, lastNameParticipantsForm,
                cityParticipantsForm, ageParticipantsForm);
            if (!string.IsNullOrEmpty(nameParticipantsForm) &&
                (ageParticipantsForm > 0) &&
                !string.IsNullOrEmpty(lastNameParticipantsForm) &&
                !string.IsNullOrEmpty(cityParticipantsForm)) 
            {
                var participants = await ReadFromFile<Participants>(FileParticipants);

                if (!participants.Contains(newParticipants))
                {
                    foreach (var twoparticipants in participants)
                    {
                        if (twoparticipants.Name == nameParticipantsForm &&
                            twoparticipants.LastName == lastNameParticipantsForm &&
                            twoparticipants.City == cityParticipantsForm &&
                             twoparticipants.Age == ageParticipantsForm)
                        {
                            MessageBox.Show($"Участника {twoparticipants.Name} уже занесён" +
                                $" в базу Фестиваль фильмов. ", "Добавление участника",
                                0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    participants.Add(newParticipants);
                    countParticipants = participants.Count;
                    TextBoxCountParticipants.Text = Convert.ToString(countParticipants);


                    await WriteToFile(participants, FileParticipants);

                    dataGridViewParticipantsTable.Rows.Add(nameParticipantsForm, lastNameParticipantsForm,
                       cityParticipantsForm , ageParticipantsForm);
                }
                else
                {
                    MessageBox.Show($"Этот участник был занесён в базу Фестиваль фильмов ранее",
                        "Добавление участника", 0,MessageBoxIcon.Information);
                    return;
                }
            }
        }
        async private void ParticipantsFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileParticipants))
            {

                var tableOfParticipants = await ReadFromFile<Participants>(FileParticipants);

                countParticipants = tableOfParticipants.Count;
                TextBoxCountParticipants.Text = Convert.ToString(countParticipants);

                if (tableOfParticipants != null)

                    foreach (var participants in tableOfParticipants)
                    {
                        dataGridViewParticipantsTable.Rows.Add();
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[0].Value = participants.Name;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[1].Value = participants.LastName;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[2].Value = participants.City;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[3].Value = participants.Age;
                        numberParticipants++;
                    }
            }
        }
        async  private void ButtonDeleteParticipants_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewParticipantsTable.CurrentCell.RowIndex;

            if (selectCount >= 0 && dataGridViewParticipantsTable.CurrentCell.Value != null)
            {
                var participants = await ReadFromFile<Participants>(FileParticipants);

                string name = dataGridViewParticipantsTable.SelectedCells[0].Value.ToString();
                string lastName = dataGridViewParticipantsTable.SelectedCells[1].Value.ToString();
                string city = dataGridViewParticipantsTable.SelectedCells[2].Value.ToString();
                int age = Convert.ToInt32(dataGridViewParticipantsTable.SelectedCells[3].Value.ToString());

                foreach (var twoparticipants in participants)
                {
                    if (name == twoparticipants.Name && lastName == twoparticipants.LastName && city == twoparticipants.City
                        && age == twoparticipants.Age)
                    {
                        participants.Remove(twoparticipants);
                        TextBoxCountParticipants.Text = Convert.ToString(participants.Count);
                        dataGridViewParticipantsTable.Rows.Remove(dataGridViewParticipantsTable.CurrentRow);
                        dataGridViewParticipantsTable.Refresh();
                        MessageBox.Show($"Участник  {twoparticipants.Name}  удалён!", "Удаление одного" +
                            " участника", 0,MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(participants, FileParticipants);
            }
            else
            {
                MessageBox.Show("Нет ни одного участника или вы не выбрали участника для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }
       async private void ButtonAllDeleteParticipants_Click(object sender, EventArgs e)
        {
            var participants = await ReadFromFile<Participants>(FileParticipants);
            countParticipants = participants.Count;
            if (countParticipants == 0)
            {
                MessageBox.Show("Нет ни одного участника!", "Удалить всех участников", 0, 
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                participants.Clear();
                TextBoxCountParticipants.Text = participants.Count.ToString();
                dataGridViewParticipantsTable.Rows.Clear();
                numberParticipants = 0;
                MessageBox.Show("Данные всех участников удалены!", "Удалить всех участников", 
                    0, MessageBoxIcon.Information);
            }
            await WriteToFile(participants, FileParticipants);
        }
        private void ButtonCloseFilmTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void dataGridViewParticipantsTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewParticipantsTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string city = selectedRow.Cells[2].Value.ToString();
            int age = Convert.ToInt32(selectedRow.Cells[3].Value);

            ParticipantsForm oldParticipant = new ParticipantsForm(name, surname, city, age);
            oldParticipant.ShowDialog();

            string modName = ParticipantsForm.NameParticipantsForm;
            string modSurname = ParticipantsForm.LastNameParticipantsForm;
            int modAge = ParticipantsForm.AgeParticipantsForm;
            string modCity = ParticipantsForm.CityParticipantsForm;

            Participants modifiedParticipant = new Participants(modName,
                modSurname, modCity, modAge);

            var participants = await ReadFromFile<Participants>(FileParticipants);

            foreach (var p in participants)
            {
                if (name == p.Name && surname == p.LastName
                    && age == p.Age && city == p.City)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modAge == age && modCity.Equals(city)))
                    {
                        participants.Remove(p);
                        participants.Add(modifiedParticipant);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modAge;
                        selectedRow.Cells[3].Value = modCity;
                        dataGridViewParticipantsTable.Refresh();
                        MessageBox.Show($"Участник {p.Name}, {p.LastName} изменён!", "Изменение участника", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Участник {p.Name}, {p.LastName} не был изменён, внесите изменения!", "Неудачное изменение участника", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(participants, FileParticipants);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text; 
            int columnIndex = comboBox1.SelectedIndex; 
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewParticipantsTable.Rows)
            {
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(searchValue))
                {
                    row.Visible = true;
                    hasVisibleRows = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            if (!hasVisibleRows)
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            string searchText = textBox2.Text.ToLower();

            bool found = false;

            foreach (DataGridViewRow row in dataGridViewParticipantsTable.Rows)
            {
                if (row.Cells[comboBox2.SelectedIndex].Value != null && row.Cells[comboBox2.SelectedIndex].Value.ToString().Contains(searchText))
                {
                    row.Visible = true;
                    found = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            if (!found)
            {
                MessageBox.Show($"Участник с введёнными данными: {searchText} - отсутствует!", "Неудачный поиск участника", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox2.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            foreach (DataGridViewRow row in dataGridViewParticipantsTable.Rows)
            {
                row.Visible = true;
            }
            button2.Enabled = false;
            textBox2.Focus();
        }
    }
}
