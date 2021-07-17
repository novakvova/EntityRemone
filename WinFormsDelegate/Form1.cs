using CoffeeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoffeeService coffeeService = new CoffeeService();
            coffeeService.completedCoffee = coffeShowInfo;
            coffeeService.progressCoffee += x => label1.Text = x.ToString();
            //    (x) =>
            //{
            //    label1.Text = x.ToString();
            //};

            //    delegate(int second)
            //{
            //    label1.Text = second.ToString();
            //}; 
            //coffeProgressInfo;
            button1.Enabled = false;
            coffeeService.RunExpresso();
        }

        private void coffeShowInfo(string message)
        {
            MessageBox.Show(message);
            button1.Enabled = true;
        }
        private void coffeProgressInfo(int second)
        {
            label1.Text=second.ToString();
        }

    }
}
