using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crehana.Clase20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void button1_ClickAsync(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void Search()
        {
            textBox1.Text = "Iniciando búsqueda";
            textBox1.BackColor = Color.Red;
            Thread.Sleep(10000);
            textBox1.BackColor = Color.White;
            textBox1.Text = "La busqueda ha terminado";

        }

        private void LoadData()
        {
            textBox2.Text = "Iniciando carga de datos";
            textBox2.BackColor = Color.Beige;
            Thread.Sleep(30000);
            textBox2.BackColor = Color.White;
            textBox2.Text = "La carga del archivo ha terminado";
        }

        private void SendEmail()
        {
            textBox3.Text = "Enviando Email";
            textBox3.BackColor = Color.Beige;
            Thread.Sleep(1000);
            textBox3.BackColor = Color.White;
            textBox3.Text = "El email se ha enviado";
        }

        //private async void btn_search_Click(object sender, EventArgs e)
        //{
        //    await SearchAsync();
        //}
        //private async void button1_ClickAsync(object sender, EventArgs e)
        //{
        //    await LoadDataAsync();
        //}
        //private async void button2_Click(object sender, EventArgs e)
        //{
        //    await SendEmailAsyn();
        //}

        //private void btn_search_Click(object sender, EventArgs e)
        //{
        //    _ = SearchAsync();
        //}
        //private void button1_ClickAsync(object sender, EventArgs e)
        //{
        //    _ = LoadDataAsync();
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    _ = SendEmailAsyn();
        //}

        private async Task SearchAsync()
        {
            textBox1.Text = "Iniciando búsqueda";
            textBox1.BackColor = Color.Red;
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
            });
            textBox1.BackColor = Color.White;
            textBox1.Text = "La busqueda ha terminado";
        }
        private async Task LoadDataAsync()
        {
            textBox2.Text = "Iniciando carga de datos";
            textBox2.BackColor = Color.Beige;
            await Task.Run(() =>
            {
                Thread.Sleep(30000);
            });
            textBox2.BackColor = Color.White;
            textBox2.Text = "La carga del archivo ha terminado";
        }

        private async Task SendEmailAsyn()
        {
            textBox3.Text = "Enviando Email";
            textBox3.BackColor = Color.Beige;
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });
            textBox3.BackColor = Color.White;
            textBox3.Text = "El email se ha enviado";
        }
    }
}
