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
    public partial class FilmFestivalForm : Form
    {
        const string FileFilm = "Films.json";
        // const string FileParticipants = "Participants.json";

        int numbersFilm = 0;
        int countFilm = 0;
        public FilmFestivalForm()
        {
            Task.Run(() => File.Open(FileFilm, FileMode.OpenOrCreate).Close());
            //Task.Run(() => File.Open(FileParticipants, FileMode.OpenOrCreate).Close());
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

        async private void ButtonCreateFilm_Click(object sender, EventArgs e)
        {
            FilmForm formFilm = new FilmForm();
            formFilm.ShowDialog();
            string nameFilmForm = FilmForm.NameFilmForm;
            string nominationFilmForm = FilmForm.NominationFilmForm;
            int ticketPriceForm = FilmForm.TicketPriceForm;
            string ratingFilmForm = FilmForm.RatingFilmForm;

            Film newFilm = new Film(nameFilmForm,
                nominationFilmForm, ticketPriceForm, ratingFilmForm);

            if (!string.IsNullOrEmpty(nameFilmForm) &&
                (ticketPriceForm > 0) &&
                !string.IsNullOrEmpty(nominationFilmForm) &&
                !string.IsNullOrEmpty(ratingFilmForm))
            {
                var films = await ReadFromFile<Film>(FileFilm);

                if (!films.Contains(newFilm))
                {
                    foreach (var twoFilms in films)
                    {
                        if (twoFilms.NameFilm == nameFilmForm &&
                            twoFilms.NominationFilm == nominationFilmForm &&
                            twoFilms.TicketPrice == ticketPriceForm &&
                            twoFilms.RatingFilm == ratingFilmForm)
                        {
                            MessageBox.Show($"Фильм {twoFilms.NameFilm} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление фильма", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    films.Add(newFilm);
                    countFilm = films.Count;
                    TextBoxCountFilm.Text = Convert.ToString(countFilm);


                    await WriteToFile(films, FileFilm);

                    dataGridViewFilmTable.Rows.Add(nameFilmForm, nominationFilmForm, ticketPriceForm,
                              ratingFilmForm);
                }
                else
                {
                    MessageBox.Show($"Этот фильм был занесён в базу фестиваль фильмов ранее",
                        "Добавление фильма", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }

        }
        async private void FilmFestivalForm_Load(object sender, EventArgs e)
        {
            dataGridViewFilmTable.AllowUserToAddRows = false;
            if (File.Exists(FileFilm))
            {
                var tableOfFilms = await ReadFromFile<Film>(FileFilm);
                numbersFilm = 0;
                countFilm = tableOfFilms.Count;
                TextBoxCountFilm.Text = Convert.ToString(countFilm);

                if (tableOfFilms != null)
                    foreach (var film in tableOfFilms)
                    {
                        dataGridViewFilmTable.Rows.Add();
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[0].Value = film.NameFilm;
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[1].Value = film.NominationFilm;
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[2].Value = film.TicketPrice;
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[3].Value = film.RatingFilm;
                        numbersFilm++;
                    }
            }
            dataGridViewFilmTable.Rows[0].Selected = false;
        }

        async private void ButtonDeleteFilm_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewFilmTable.CurrentCell.RowIndex;

            if (selectCount >= 0 && dataGridViewFilmTable.CurrentCell.Value != null)
            {
                var films = await ReadFromFile<Film>(FileFilm);

                string nameFilm = dataGridViewFilmTable.SelectedCells[0].Value.ToString();
                string nominationFilm = dataGridViewFilmTable.SelectedCells[1].Value.ToString();
                int ticketPrice = Convert.ToInt32(dataGridViewFilmTable.SelectedCells[2].Value.ToString());
                string ratingFilm = dataGridViewFilmTable.SelectedCells[3].Value.ToString();

                foreach (var f in films)
                {
                    if (nameFilm == f.NameFilm && nominationFilm == f.NominationFilm
                        && ticketPrice == f.TicketPrice && ratingFilm == f.RatingFilm)
                    {
                        films.Remove(f);
                        TextBoxCountFilm.Text = Convert.ToString(films.Count);
                        dataGridViewFilmTable.Rows.Remove(dataGridViewFilmTable.CurrentRow);
                        dataGridViewFilmTable.Refresh();
                        MessageBox.Show($"Фильм {f.NameFilm}  удалён!", "Удаление одного фильма", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(films, FileFilm);
            }
            else
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private void ButtonCloseFilmTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonAllDeleteFilm_Click(object sender, EventArgs e)
        {
            var films = await ReadFromFile<Film>(FileFilm);
            countFilm = films.Count;
            if (countFilm == 0)
            {
                MessageBox.Show("Нет ни одного фильма!", "Удалить все фильмы", 0, MessageBoxIcon.Information);
                return;
            }
            else
            {
                films.Clear();
                TextBoxCountFilm.Text = films.Count.ToString();
                dataGridViewFilmTable.Rows.Clear();
                numbersFilm = 0;
                MessageBox.Show("Данные всех фильмов удалены!", "Удалить все фильмы", 0, MessageBoxIcon.Information);
            }
            await WriteToFile(films, FileFilm);
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

            foreach (DataGridViewRow row in dataGridViewFilmTable.Rows)
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

        private async void dataGridViewFilmTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewFilmTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string nomination = selectedRow.Cells[1].Value.ToString();
            int ticketPrice = Convert.ToInt32(selectedRow.Cells[2].Value);
            string rating = selectedRow.Cells[3].Value.ToString();

            FilmForm formFilm = new FilmForm(name, nomination, ticketPrice, rating);
            formFilm.ShowDialog();

            string nameFilmForm = FilmForm.NameFilmForm;
            string nominationFilmForm = FilmForm.NominationFilmForm;
            int ticketPriceForm = FilmForm.TicketPriceForm;
            string ratingFilmForm = FilmForm.RatingFilmForm;

            Film modifiedFilm = new Film(nameFilmForm,
                nominationFilmForm, ticketPriceForm, ratingFilmForm);

            var films = await ReadFromFile<Film>(FileFilm);

            foreach (var f in films)
            {
                if (name == f.NameFilm && nomination == f.NominationFilm
                    && ticketPrice == f.TicketPrice && rating == f.RatingFilm)
                {
                    if(!(nameFilmForm.Equals(name) && nominationFilmForm.Equals(nomination) && ticketPriceForm == ticketPrice && ratingFilmForm.Equals(rating)))
                    {
                        films.Remove(f);
                        films.Add(modifiedFilm);
                        selectedRow.Cells[0].Value = nameFilmForm;
                        selectedRow.Cells[1].Value = nominationFilmForm;
                        selectedRow.Cells[2].Value = ticketPriceForm;
                        selectedRow.Cells[3].Value = ratingFilmForm;
                        dataGridViewFilmTable.Refresh();
                        MessageBox.Show($"Фильм {f.NameFilm}  изменён!", "Изменение фильма", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Фильм {f.NameFilm} не был изменён, внесите изменения!", "Неудачное изменение фильма", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(films, FileFilm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show($"Введите название фильма для поиска!", "Неудачный поиск фильма", 0,
                            MessageBoxIcon.Information);
            }
            button2.Enabled = true;
            string searchText = textBox2.Text.ToLower();

            bool found = false;

            foreach (DataGridViewRow row in dataGridViewFilmTable.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Contains(searchText))
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
                MessageBox.Show($"Фильм с таким названием: {searchText} - отсутствует!", "Неудачный поиск фильма", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            foreach (DataGridViewRow row in dataGridViewFilmTable.Rows)
            {
                row.Visible = true;
            }
            button2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}