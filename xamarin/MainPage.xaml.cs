using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin {
    public partial class MainPage :ContentPage {
        int[] maxAges = { 18, 20, 9 };
        int index = 0;
        public MainPage() {
            InitializeComponent();
            Gatunki.ItemsSource = new List<string>() {
                "Pies", "Kot","Świnka Morska"
            };
        }

        private async void Accept_Clicked(object sender, EventArgs e) {
            await DisplayAlert("Zapisana Wizyta", $"{Name.Text}, {Gatunki.SelectedItem as string}, {Math.Round(WiekSlider.Value)}, {Purpose.Text}, {Time.Time}", "OK");
        }

        private void Gatunki_ItemSelected(object sender, SelectedItemChangedEventArgs e) {
            index = e.SelectedItemIndex;
            WiekSlider.Maximum = maxAges[index];
            WiekSlider.Value = 0;
        }

        private void WiekSlider_ValueChanged(object sender, ValueChangedEventArgs e) {
            AgeText.Text = "Ile masz lat? " + Math.Round(e.NewValue);
        }
    }
}
