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

        private void Affirmation(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Affirmation());
            IsPresented = false;
        }

        private void Motivation(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Motivation());
            IsPresented = false;
        }

        private void Master_Mind(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MasterMind());
            IsPresented = false;
        }
    }
}
