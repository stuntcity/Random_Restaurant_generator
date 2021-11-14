using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Restaurant_generator
{
    public partial class Form1 : Form
    {
        string[] Restaurant = { "TGIF", "Olive Garden", "Cheesecake Factory", "Joe's Craby Shacky", "Red Lobster", "Bonefish Grillz"};
        string[] DayOfWeek = { "Mondayz", "Tuesdayz", "Wednesday", "Thursday", "Fridayz", "Saturday", "Sunday" };
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            int indexRestaurant = rand.Next(Restaurant.Length);
            int indexDayOfWeek = rand.Next(DayOfWeek.Length);

            this.txtBox_Restaurant.Text = Restaurant[indexRestaurant];
            this.txtBox_DayOfWeek.Text = DayOfWeek[indexDayOfWeek];
        }
    }
}
