using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        /*private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = int.Parse(txtNilaiB.Text);
            
            lstHasil.Items.Clear();

            var cal = new Calculator();

            /*
            lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b)));
            */

            lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pangkat: {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Module: {0} % {1} = {2}", a, b, cal.Module(a, b)));
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNilaiB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
