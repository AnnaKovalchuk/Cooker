using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Поваренок.Classes;
using Поваренок.View;

namespace Поваренок
{
    public partial class FormAuth : Form
    {
        private string text = String.Empty;
        int w = 2;

        int tsec;
        int tmin;

        string x = null;
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            buttonEnter.BackColor = Color.FromArgb(255, 204, 153);

            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }

        private Bitmap CreateImage(int Width, int Height) //генерация изображения со случайным текстом
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);


            //Добавим различные цвета
            Brush[] colors =
            {
                 Brushes.Black,
                 Brushes.Red,
                 Brushes.RoyalBlue,
                 Brushes.Green
            };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            textBoxCaptcha.Text = text;
            return result;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (w > 0)
            {
                if (textBoxCaptcha.Text == text)
                {

                    string login = textBoxLogin.Text;
                    string password = textBoxPassword.Text;
                    SqlCommand command = ClassSqlConnection.connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from [User] Where [UserLogin] = @login and [UserPassword] = @password";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        ClassSqlConnection.idRole = (int)reader["UserRole"];
                        reader.Close();
                        switch (ClassSqlConnection.idRole)
                        {
                            case (1):
                                MessageBox.Show("Роль: Клиент");
                                break;
                            case (2):
                                MessageBox.Show("Роль: Менеджер");
                                break;
                            case (3):
                                MessageBox.Show("Роль: Администратор");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Логин и/или пароль введены неверно. Осталось попыток:" + w);
                        reader.Close();
                        w--;
                    }
                }
                else
                {
                    MessageBox.Show("Капча введена неверно");
                    pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
                    textBoxCaptcha.Clear();
                }
            }
            else
            {
                tmin = 1;
                tsec = 0;
                labelLogin.Visible = false;
                labelPassword.Visible = false;
                labelName.Visible = false;

                textBoxLogin.Visible = false;
                textBoxPassword.Visible = false;

                pictureBoxCaptcha.Visible = false;
                buttonEnter.Visible = false;

                textBoxCaptcha.Text = "01:00";
                timerBlock.Enabled = true;
                timerBlock.Start();
                ActiveForm.ControlBox = false;
            }
        }

        private void timerBlock_Tick(object sender, EventArgs e)
        {
            if (tmin == 0 && tsec == 0)
            {
                timerBlock.Stop();
                timerBlock.Enabled = false;
                w = 2;
                labelLogin.Visible = true;
                labelPassword.Visible = true;
                labelName.Visible = true;

                textBoxLogin.Visible = true;
                textBoxPassword.Visible = true;
                textBoxCaptcha.Visible = true;

                pictureBoxCaptcha.Visible = true;
                pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
                buttonEnter.Visible = true;
                ActiveForm.ControlBox = true;
            }
            if (tsec > 0)
            {
                tsec--;
            }
            if (tsec == 0)
            {
                if (tmin > 0)
                {
                    tmin--;
                    if (tmin == 0)
                    { tsec = 59; }
                }
                if (tmin > 0)
                { tsec = 59; }
            }
            textBoxCaptcha.Text = printNumber(tmin) + ':' + printNumber(tsec);
        }

        private static string printNumber(int num)
        {
            string str;
            if (num < 10)
                str = "0" + num;
            else
                str = "" + num;
            return str;
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            this.Hide();
            formProduct.ShowDialog();
        }
    }
}
