using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace NLog
{
    public partial class Form1 : Form
    {
        private const string V = "C:\\Users\\Marses\\Desktop\\Test.txt";
        private string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.OpenAsync();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i > -1; i++)
                {

                }
            }
            catch(Exception i)
            {
                Console.WriteLine("{0} Exception caught.", i);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime x;
            if (DateTime.TryParse(textBox1.Text, out x))
            { }
            try
            {
                Convert.ToDateTime(textBox1.Text);
            }
            catch
            {
                Console.WriteLine("Not a date");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (File.Exists(V))
            {
                File.WriteAllText(V, textBox2.Text);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}
