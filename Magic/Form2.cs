using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 photoForm = new Form3();
            photoForm.ShowDialog();
            this.Close();  // Закриваємо поточну форму, щоб вона не залишалась на екрані
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 photoForm = new Form3();
            photoForm.ShowDialog();
            this.Close();  // Закриваємо поточну форму, щоб вона не залишалась на екрані
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 photoForm = new Form3();
            photoForm.ShowDialog();
            this.Close();  // Закриваємо поточну форму, щоб вона не залишалась на екрані
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 photoForm = new Form3();
            photoForm.ShowDialog();
            this.Close();  // Закриваємо поточну форму, щоб вона не залишалась на екрані
        }
    }
}
