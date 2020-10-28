using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        Client mClient;

        enum Answers
        {
            USER_NAME_ALREADY_USED, // Имя пользовател уже используется
            USER_NAME_OK, // Имя пользователя подходит
            REGISTRATION_OK, // Регистрация завершена
            USER_NOT_EXIST,
            USER_LOGIN_OK,
            USER_LOGIN_BREAK,
            USER_NOT_LOGIN,
            COMMAND_OK,
        }

        enum StateLogin
        {
            USER_NOT_LOGIN,
            USER_LOGIN
        }

        StateLogin loginState;

        public Form1()
        {
            InitializeComponent();

            mClient = new Client();

            gridViewHouseroomsInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isOk = false;

            isOk = mClient.Connect();

            if(!isOk)
            {
                MessageBox.Show("Соединение НЕ установлено!");
            }
            else
            {
                MessageBox.Show("Соединение установлено!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Точно закрываем?", "Бро", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
                mClient.Disconnect();
            else
                e.Cancel = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            fillHouseroomsGridView();
        }

        private void fillHouseroomsGridView()
        {
            string City = textBoxCity.Text;
            string Street = textBoxStreet.Text;
            string Price = textBoxPrice.Text;

            string[][] fields = new string[1][];
            int answer = mClient.getHouseroom(City, Street, Price, ref fields);

            switch(answer)
            {
                case (int)Answers.COMMAND_OK:
                    {
                        GridViewSearchHouseroom.Rows.Clear();
                        GridViewSearchHouseroom.RowCount = fields.Length;

                        for(int i = 0; i < fields.Length; i++)
                        {
                            GridViewSearchHouseroom[0, i].Value = i+1;
                            GridViewSearchHouseroom[1, i].Value = fields[i][1];
                            GridViewSearchHouseroom[2, i].Value = fields[i][2];
                        }

                        break;
                    }
                case (int)Answers.USER_NOT_LOGIN:
                    {
                        MessageBox.Show("Ошибочка!\nНет квартир с таким параметром!", "АЛЛЁРТ!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBoxCity.Clear();
                        textBoxStreet.Clear();
                        textBoxPrice.Clear();

                        break;
                    }
            }
        }

        private void gridViewHouseroomsInit()
        {
            GridViewSearchHouseroom.ColumnCount = 3;

            GridViewSearchHouseroom.Columns[0].HeaderText = "№ п/п";
            GridViewSearchHouseroom.Columns[1].HeaderText = "Описание";
            GridViewSearchHouseroom.Columns[2].HeaderText = "Цена";

            GridViewSearchHouseroom.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GridViewSearchHouseroom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridViewSearchHouseroom.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GridViewSearchHouseroom.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            GridViewSearchHouseroom.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            GridViewSearchHouseroom.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            GridViewSearchHouseroom.Columns[0].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            GridViewSearchHouseroom.Columns[1].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            GridViewSearchHouseroom.Columns[2].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            GridViewSearchHouseroom.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            GridViewSearchHouseroom.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            GridViewSearchHouseroom.RowHeadersVisible = false;

            GridViewSearchHouseroom.AllowUserToAddRows = false;
            GridViewSearchHouseroom.AllowUserToDeleteRows = false;
            GridViewSearchHouseroom.AllowUserToResizeColumns = false;
            GridViewSearchHouseroom.AllowUserToResizeRows = false;

            GridViewSearchHouseroom.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GridViewSearchHouseroom.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            GridViewSearchHouseroom.CellBorderStyle =
                DataGridViewCellBorderStyle.None;

            GridViewSearchHouseroom.MultiSelect = false;
        }

        private void buttonAddHouseroom_Click(object sender, EventArgs e)
        {
            string city = textBoxAddCity.Text;
            string street = textBoxAddStreet.Text;
            string price = textBoxAddPrice.Text;
            string description = textBoxAddDescription.Text;

            //string city = "Check";
            //string street = "Check";
            //string price = "1005";
            //string description = "Proverochka";

            int answer = mClient.addHouseroom(city, street, price, description);

            switch(answer)
            {
                case (int)Answers.COMMAND_OK:
                    {
                        MessageBox.Show("Квартира добавлена!");

                        textBoxAddCity.Clear();
                        textBoxAddStreet.Clear();
                        textBoxAddPrice.Clear();
                        textBoxAddDescription.Clear();

                        break;
                    }
            }
        }
    }
}
