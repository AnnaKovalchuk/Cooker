using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Поваренок.Classes;

namespace Поваренок
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClassSqlConnection.connection = new SqlConnection(); //Создание объекта подключения
            ClassSqlConnection.connection.ConnectionString = ClassSqlConnection.connectionString;
            try
            {
                ClassSqlConnection.connection.Open();      //Опасная команда
                Application.Run(new FormAuth());

            }
            catch (SqlException ex)     //Обработка сбоя при подключении
            {
                switch (ex.Number)      //Номер ошибки
                {
                    case 17: MessageBox.Show("Неверное имя сервера"); break;
                    case 4060: MessageBox.Show("Неверное имя БД"); break;
                    case 18456: MessageBox.Show("Неверное имя пользователя или пароль"); break;
                }
                MessageBox.Show(ex.Message + Environment.NewLine + "Уровень ошибки " + ex.Class); return;
            }
            catch (Exception ex)            //Общий сбой при подключении
            {
                MessageBox.Show("Ошибка подключения " + ex.Message); return;
            }
            finally
            {
                if (ClassSqlConnection.connection.State == ConnectionState.Open) ClassSqlConnection.connection.Close();
            }

        }
    }
}
