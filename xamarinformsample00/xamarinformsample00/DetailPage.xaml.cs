﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinformsample00
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
    {
        bool hantei1 = true;
        bool hantei2 = true;
        bool hantei3 = true;
        public DetailPage ()
		{
			InitializeComponent ();

        }
        private void OnImageClicked1(object sender, EventArgs e)
        {
            if (hantei1 == true)
            {
                this.image1.Image = "blue_book_72.png";
                hantei1 = false;
            }

            else
            {
                this.image1.Image = "gray_book_72.png";
                hantei1 = true;
            }
        }
        private void OnImageClicked2(object sender, EventArgs e)
        {
            if (hantei2 == true)
            {
                this.image2.Image = "red_star_72.png";
                hantei2 = false;
            }

            else
            {
                this.image2.Image = "gray_star_72.png";
                hantei2 = true;
            }
        }

        private void OnToggled(object sender, ToggledEventArgs e)
        {
            if (unread1.IsToggled == true)
            {
                this.unread2.Text = "既読";
            }
            if (unread1.IsToggled == false)
            {
                this.unread2.Text = "未読";
            }
        }
    }
}