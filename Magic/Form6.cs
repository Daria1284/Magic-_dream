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
    public partial class Form6 : Form
    {
        private readonly string[] phrases =
        {
            "Сьогодні ти дізнаєшся щось справді чарівне!",
            "У світі знань кожен урок — нова пригода!",
            "Магія починається там, де є цікавість до знань.!",
            "Чарівники стають кращими з кожним уроком!",
            "Не бійся помилок — вони теж частина магічного навчання!"
        };
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(phrases.Length);
            label1.Text = phrases[index];
        }
    }
}
