
using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            string plec = "";

            if (cbMezczyzna.IsChecked == true)
                plec = "Mężczyzna";
            else if (cbKobieta.IsChecked == true)
                plec = "Kobieta";
            else if (cbInne.IsChecked == true)
                plec = "Inne";

            if (plec == "")
            {
                MessageBox.Show("Wybierz płeć!");
                return;
            }

            if (!int.TryParse(txtWiek.Text, out int wiek)
                || wiek < 1 || wiek > 120)
            {
                MessageBox.Show("Podaj prawidłowy wiek!");
                return;
            }

            if (cmbKolor.SelectedItem == null)
            {
                MessageBox.Show("Wybierz kolor!");
                return;
            }

            if (cbZgoda.IsChecked != true)
            {
                MessageBox.Show("Musisz wyrazić zgodę!");
                return;
            }

            string kolor =
                ((ComboBoxItem)cmbKolor.SelectedItem).Content.ToString();

            MessageBox.Show(
                $"Zapisano dane!\n\n" +
                $"Płeć: {plec}\n" +
                $"Wiek: {wiek}\n" +
                $"Kolor: {kolor}\n" +
                $"Zgoda: Tak",
                "Informacja",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}
