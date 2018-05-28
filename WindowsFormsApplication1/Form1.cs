using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Film _film;
        public Form1()
        {
            InitializeComponent();
            _film = new Film();
            AdviseToControlEvents();
            AdviseToFilmEvents();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Film Titile : {_film.Title}\nGenre : {_film.Genre}\nTime : {_film.Time}\nRevenue : {_film.Revenue}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _film.Title = TitleBox1.Text;
            _film.Genre = GenreBox2.Text;
            _film.Director = DirectorBox3.Text;
            try
            {
                _film.Time = Convert.ToInt32(TimeBox4.Text);
                _film.Rate = Convert.ToInt32(RateBox5.Text);
                _film.Revenue = Convert.ToInt32(RevenueBox6.Text);
            }
            catch (Exception)
            {
                _film.Time = 0;
                _film.Rate = 0;
                _film.Revenue = 0;
            }
        }

        private void AdviseToControlEvents()
        {
            TitleBox1.TextChanged += (a, e) =>
            {
                  _film.Title = TitleBox1.Text;
            };
            GenreBox2.TextChanged += (a, e) =>
            {
                _film.Genre = GenreBox2.Text;
            };
            DirectorBox3.TextChanged += (a, e) =>
            {
                _film.Director = DirectorBox3.Text;
            };
            TimeBox4.TextChanged += (a, e) =>
            {
                try
                {
                    _film.Time = Convert.ToInt32(TimeBox4.Text);
                }
                catch
                {
                    _film.Time = 0;
                }
            };
            RateBox5.TextChanged += (a, e) =>
            {
                try
                {
                    _film.Rate = Convert.ToInt32(RateBox5.Text);
                }
                catch (Exception)
                {
                    _film.Rate = 0;
                }
            };
            RevenueBox6.TextChanged += (a, e) =>
            {
                try
                {
                  _film.Revenue = Convert.ToInt32(RevenueBox6.Text);
                }
                catch (Exception)
                {
                    _film.Revenue = 0;
                }

            };
        }
        private void AdviseToFilmEvents()
        {
            _film.TitleChanged += (o, e) =>
            {
                TitleBox1.Text = ((Film)o).Title;
            };
            _film.GenreChanged += (o, e) =>
            {
                GenreBox2.Text = ((Film)o).Genre;
            };
            _film.DirectorChanged += (o, e) =>
            {
                DirectorBox3.Text = ((Film)o).Director;
            };
            _film.TimeChanged += (o, e) =>
            {
                TimeBox4.Text = ((Film)o).Time.ToString();
            };
            _film.RateChanged += (o, e) =>
            {
                RateBox5.Text = ((Film)o).Rate.ToString();
            };
            _film.RevenueChanged += (o, e) =>
            {
                RevenueBox6.Text = ((Film)o).Revenue.ToString();
            };
        }

        #region
        private void TitleBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenreBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirectorBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RateBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RevenueBox6_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            _film.Revenue = r.Next(50000000, 150000000);
        }
    }
}
