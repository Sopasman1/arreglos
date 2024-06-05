using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Reflection;

namespace arreglos
{
    public partial class Form1 : Form
    {
        macot[] Mascota;
        int price;
        public Form1()
        {

            InitializeComponent();
            Mascota = new macot[2];
            price = 0;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (price == Mascota.Length)
            {
                string datos = "";
                for (int i = 0; i < Mascota.Length; i++)
                {
                    datos += Mascota[i] + " ";
                }
                MessageBox.Show("Array is full " + datos);
                Mascota = null;
                Mascota = new macot[2];
                price = 0;
                return;
            }
            Mascota[price++] = new macot(speciesbox.Text, Racetext.Text, Nametext.Text);
            switch (speciesbox.Text)
            {
                case "Cat":
                    mascotalbl.Text = "\nfor your adoption you can donate 30$";
                    break;
                case "Dog":
                    mascotalbl.Text = "\nfor your adoption you can donate 20$";
                    break;

            }
        }

       
    }
}
