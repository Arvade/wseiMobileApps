using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wseiMobileApps {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void onHelpButtonClicked(object sender, EventArgs e) {
            DisplayAlert("My cool alert", "Message of alert", "Accept", "Cancel123");
        }
    }
}