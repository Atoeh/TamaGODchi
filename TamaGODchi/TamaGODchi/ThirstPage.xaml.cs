using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TamaGODchi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirstPage : ContentPage
    {
        public String Image1 = "Water_Water";
        public String Image2 = "RedWine_Water";
        public String Image3 = "WhiteWine_Water*";

        public int image1Int = 1;
        public int image2Int = 1;
        public int image3Int = 1;

        public ThirstPage()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            image1Int++;
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            image2Int++;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            image3Int++;
        }

    }
}