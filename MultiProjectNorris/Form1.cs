﻿using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiProjectNorris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var list = await ChuckNorrisClient.GetCategories();
            comboBox1.DataSource = list;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(joke.JokeText,"Chuck Norris Joke");
        }
    }
}
