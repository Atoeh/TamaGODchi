using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TamaGODchi
{
    public partial class MainPage : ContentPage
    {
        int age = 0;

        public float hunger = .3f;
        public float thirst = .3f;
        public float bored = .3f;
        public float lonely = .3f;
        public float stimul = .3f;
        public float sleep = .3f;

        public string creature = "Jesus Christchi";
        public string creator = "Arthur Toebosch";

        public float total;
        public float Total
        {
            get => total;
            set
            {
                total = value;
                OnPropertyChanged();
            }
        }

        private string ageText = "0 days old";
        public string AgeText
        {
            get => ageText;
            set
            {
                ageText = value;
                OnPropertyChanged();
            }
        }

        //private string stateText= "TamaState = Doing Alright";

        public float AmountTotal { get; set; } = 1f;
        //public string StateText => AmountTotal switch
        //{
        //    >= 2.0f => "1",
        //    >= 1.0f => "2",
        //    > .0f => "3",
        //    => throw new Exception("Impossible");
        //};

        public MainPage()
        {
            BindingContext = this;
            total = hunger + thirst + bored + lonely + stimul + sleep;
            InitializeComponent();
        }
               
        private void AgeButton_Clicked(object sender, EventArgs e)
        {
            FloatChanged("hunger", false, 0.1f);

            age++;
            AgeText = age + " days old";

            //StateText = "TamaState = My blood is wine, for I am an alcoholic";

        }
        private async void HungerButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HungerPage());
        }
        private async void ThirstButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirstPage());
        }
        private async void BoredomButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoredPage());
        }
        private async void StimulButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StimulPage());
        }
        private async void LonelyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lonely()); // LonelyPage = Lonely
        }
        private async void SleepButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SleepPage());
        }

        public void FloatChanged(string impacted, bool positive, float ammOfImpact)
        {

            if (positive == true)
            {
                if(impacted == "hunger")
                    hunger = hunger - ammOfImpact;

                if (impacted == "thirst")
                    thirst = thirst - ammOfImpact;

                if (impacted == "bored")
                    bored = bored - ammOfImpact;

                if (impacted == "lonely")
                    lonely = lonely - ammOfImpact;

                if (impacted == "stimul")
                    stimul = stimul - ammOfImpact;

                if (impacted == "sleep")
                    sleep = sleep - ammOfImpact;
            }
            else
            {
                if (impacted == "hunger")
                    hunger = hunger + ammOfImpact;

                if (impacted == "thirst")
                    thirst = thirst + ammOfImpact;

                if (impacted == "bored")
                    bored = bored + ammOfImpact;

                if (impacted == "lonely")
                    lonely = lonely + ammOfImpact;

                if (impacted == "stimul")
                    stimul = stimul + ammOfImpact;

                if (impacted == "sleep")
                    sleep = sleep + ammOfImpact;
            }

            total = hunger + thirst + bored + lonely + stimul + sleep;
            Total = total;
        }
    }
}
