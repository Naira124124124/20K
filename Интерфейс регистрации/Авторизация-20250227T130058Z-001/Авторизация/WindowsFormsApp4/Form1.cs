using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("Неверный пароль! Пароль должен быть не менее 8 символов.", "Ошибка");
            }
            else
            {
                string filename = "password.txt"; // Имя файла
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename); // Путь к рабочему столу
                File.WriteAllText(path, password); // Запись пароля в файл

                MessageBox.Show("Авторизация прошла успешно!", "Успех");
            }
        }
    }
}
