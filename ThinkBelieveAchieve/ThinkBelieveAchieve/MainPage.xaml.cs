using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThinkBelieveAchieve
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new BurningDesire());

            IsPresented = false;
        }

        private void Burning_Desire(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new BurningDesire());
            IsPresented = false;
        }

        private void Vision_Board(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new VisionBoard());
            IsPresented = false;
        }
    }
}
