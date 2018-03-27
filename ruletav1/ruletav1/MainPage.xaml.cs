using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ruletav1
{
    
	public partial class MainPage : ContentPage
	{
        
        public MainPage()
		{
			InitializeComponent();
            btncalcular.Clicked += Btncalcular_Clicked;   
		}

        private void Btncalcular_Clicked(object sender, EventArgs e)
        {
            var text = enumber.Text;
            if (enumber.Text =="1")
            {
                progressBar1.Progress += 0.01;
            }
            if (enumber.Text == "2")
            {
                progressBar2.Progress += 0.01;
            }
            if (enumber.Text == "3")
            {
                progressBar3.Progress += 0.01;
            }

        }
    }
}
