using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class GuestFestivalForm : Form
    {
        const string FileGuest = "Guest.json";

        int numbersGuest = 0;
        int countGuest = 0;
        public GuestFestivalForm()
        {
            Task.Run(() => File.Open(FileGuest, FileMode.OpenOrCreate).Close());
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

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync())
                ?? new List<T>());
            }
        }

        async private void ButtonCreateGuest_Click(object sender, EventArgs e)
        {
            GuestForm formGuest = new GuestForm();
            formGuest.ShowDialog();
            string nameGuestForm = GuestForm.NameGuestForm;
            string lastNameGuestForm = GuestForm.LastNameGuestForm;
            int seatNumberGuestForm = GuestForm.SeatNumberGuestForm;
            string emailGuestForm = GuestForm.EmailGuestForm;

            Guests newGuest = new Guests(nameGuestForm,
                lastNameGuestForm, seatNumberGuestForm, emailGuestForm);

            if (!string.IsNullOrEmpty(nameGuestForm) &&
                !string.IsNullOrEmpty(lastNameGuestForm) &&
                (seatNumberGuestForm > 0) &&
                !string.IsNullOrEmpty(emailGuestForm))
            {
                var guest = await ReadFromFile<Guests>(FileGuest);

                if (!guest.Contains(newGuest))
                {
                    foreach (var twoGuest in guest)
                    {
                        if (twoGuest.NameGuest == nameGuestForm &&
                            twoGuest.LastNameGuest == lastNameGuestForm &&
                            twoGuest.SeatNumberGuest == seatNumberGuestForm &&
                            twoGuest.EmailGuest == emailGuestForm)
                        {
                            MessageBox.Show($"Гость {twoGuest.NameGuest} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление гостя", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    guest.Add(newGuest);
                    countGuest = guest.Count;
                    TextBoxCountGuest.Text = Convert.ToString(countGuest);


                    await WriteToFile(guest, FileGuest);

                    dataGridViewGuestTable.Rows.Add(nameGuestForm, lastNameGuestForm, seatNumberGuestForm,
                        emailGuestForm);
                }
                else
                {
                    MessageBox.Show($"Этот гость был занесён в базу фестиваль фильмов ранее",
                        "Добавление гостя", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async private void GuestFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileGuest))
            {
                var tableOfGuest = await ReadFromFile<Guests>(FileGuest);
                numbersGuest = 0;
                countGuest = tableOfGuest.Count;
                TextBoxCountGuest.Text = Convert.ToString(countGuest);

                if (tableOfGuest != null)
                    foreach (var guests in tableOfGuest)
                    {
                        dataGridViewGuestTable.Rows.Add();
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[0].Value = guests.NameGuest;
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[1].Value = guests.LastNameGuest;
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[2].Value = guests.SeatNumberGuest;
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[3].Value = guests.EmailGuest;
                        numbersGuest++;
                    }
            }
        }

       async private void ButtonDeleteGuest_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewGuestTable.CurrentCell.RowIndex;

            if (selectCount >= 0 && dataGridViewGuestTable.CurrentCell.Value != null)
            {
                var guests = await ReadFromFile<Guests>(FileGuest);

                string nameGuest = dataGridViewGuestTable.SelectedCells[0].Value.ToString();
                string lastNameGuest = dataGridViewGuestTable.SelectedCells[1].Value.ToString();
                int seatNumberGuest = Convert.ToInt32(dataGridViewGuestTable.SelectedCells[2].Value.ToString());
                string emailGuest = dataGridViewGuestTable.SelectedCells[3].Value.ToString();

                foreach (var twoGuests in guests)
                {
                    if (nameGuest == twoGuests.NameGuest && lastNameGuest == twoGuests.LastNameGuest
                        && seatNumberGuest == twoGuests.SeatNumberGuest && emailGuest == twoGuests.EmailGuest)
                    {
                        guests.Remove(twoGuests);
                        TextBoxCountGuest.Text = Convert.ToString(guests.Count);
                        dataGridViewGuestTable.Rows.Remove(dataGridViewGuestTable.CurrentRow);
                        MessageBox.Show($"Гость {twoGuests.NameGuest}  удалён!", "Удаление одного гостя", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(guests, FileGuest);
            }
            else
            {
                MessageBox.Show("Нет ни одного гостя или вы не выбрали гостя для удаления!", 
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

       async private void ButtonAllDeleteGuest_Click(object sender, EventArgs e)
        {
            var guests = await ReadFromFile<Guests>(FileGuest);
            countGuest = guests.Count;
            if (countGuest == 0)
            {
                MessageBox.Show("Нет ни одного гостя!", "Удалить всех гостей", 0, MessageBoxIcon.Information);
                return;
            }
            else
            {
                guests.Clear();
                TextBoxCountGuest.Text = guests.Count.ToString();
                dataGridViewGuestTable.Rows.Clear();
                numbersGuest = 0;
                MessageBox.Show("Данные всех гостей удалены!", "Удалить всех гостей", 0, MessageBoxIcon.Information);
            }
            await WriteToFile(guests, FileGuest);
        }

        private void ButtonCloseGuestTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для сортировки!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = textBox1.Text; 
            int columnIndex = comboBox1.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewGuestTable.Rows)
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

        private async void dataGridViewGuestTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewGuestTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string email = selectedRow.Cells[2].Value.ToString();
            int seatNumber = Convert.ToInt32(selectedRow.Cells[3].Value);

            GuestForm guestForm = new GuestForm(name, surname, seatNumber, email);
            guestForm.ShowDialog();

            string modName = ParticipantsForm.NameParticipantsForm;
            string modSurname = ParticipantsForm.LastNameParticipantsForm;
            int modAge = ParticipantsForm.AgeParticipantsForm;
            string modCity = ParticipantsForm.CityParticipantsForm;

            Guests modifiedParticipant = new Guests(modName,
                modSurname, modAge, modCity);

            var guests = await ReadFromFile<Guests>(FileGuest);

            foreach (var g in guests)
            {
                if (name == g.NameGuest && surname == g.LastNameGuest
                    && seatNumber == g.SeatNumberGuest && email == g.EmailGuest)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modAge == seatNumber && modCity.Equals(email)))
                    {
                        guests.Remove(g);
                        guests.Add(modifiedParticipant);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modAge;
                        selectedRow.Cells[3].Value = modCity;
                        dataGridViewGuestTable.Refresh();
                        MessageBox.Show($"Гость {g.NameGuest}, {g.LastNameGuest} изменён!", "Изменение участника", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Гость {g.NameGuest}, {g.LastNameGuest} не был изменён, внесите изменения!", "Неудачное изменение участника", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(guests, FileGuest);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            string searchText = textBox2.Text.ToLower();

            bool found = false;

            foreach (DataGridViewRow row in dataGridViewGuestTable.Rows)
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
                MessageBox.Show($"Гость с введёнными данными: {searchText} - отсутствует!", "Неудачный поиск гостя", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            foreach (DataGridViewRow row in dataGridViewGuestTable.Rows)
            {
                row.Visible = true;
            }
            button2.Enabled = false;
        }
    }
}
