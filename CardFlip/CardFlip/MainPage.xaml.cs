using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CardFlip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function will check the button which was clicked and determine if it should show the face or the back of the card. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip_Clicked(object sender, EventArgs e)
        {
            // this creates a new variable which gives the sender all the attributes of the clicked button. 
            Button selectedBtn = (Button)sender;
            // this will determine if the selected button has the Text "Show Card Face"
            if(selectedBtn.Text == "Show Card Face")
            {
                // IF the text matches, it will change the button text to "Show Card Back"
                BtnFlip.Text = "Show Card Back";
                //Then it will reveal the card face by changing it's visibility to true.
                ImgCardFace.IsVisible = true;
                //while also hiding the back of the card by changing it's visibility to false. 
                ImgCardBack.IsVisible = false;
            }
            else
            {
                //If the sselected button text does not match "Show Card Face" we know it must be "Show Card Back" and we change it to "Show Card Face"
                BtnFlip.Text = "Show Card Face";
                //We make the card face invisible by changing it's visibility to false
                ImgCardFace.IsVisible = false;
                //We make the card back visible by changing it's visibility to true
                ImgCardBack.IsVisible = true;
            }
        }
    }
}
