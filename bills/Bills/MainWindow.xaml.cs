using Bills.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media.Animation;

namespace Bills
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   
            InitializeComponent();
            FV();
            LabelOfPaymentMonth();
            SumUpVoid();
            ReadData();
        }
        public List<string> Types = new List<string>()
        {
            "internet",
            "leasing",
            "gap",
            "studia",
            "paliwo",
            "softwareplant",
            "angielski",
            "zus",
            "ksiegowa"
        };
        public void FV()
        {
            int i = 1;
            List<Item> Items = new List<Item>();
            if ((bool)orangeFV.IsChecked) { Items.Add(new Item() { Name = orangeLab.Content.ToString(), Id = i }); i++; }
            if ((bool)leasingFV.IsChecked) { Items.Add(new Item() { Name = leasingLab.Content.ToString(), Id = i }); i++; }
            if ((bool)gapFV.IsChecked) { Items.Add(new Item() { Name = gapLab.Content.ToString(), Id = i }); i++; }
            if ((bool)wwsiFV.IsChecked) { Items.Add(new Item() { Name = wwsiLab.Content.ToString(), Id = i }); i++; }
            if ((bool)orlenFV.IsChecked) { Items.Add(new Item() { Name = orlenLab.Content.ToString(), Id = i }); i++; }
            if ((bool)softwareplantFV.IsChecked) { Items.Add(new Item() { Name = softwareplantLab.Content.ToString(), Id = i }); i++; }
            if ((bool)tutloFV.IsChecked) { Items.Add(new Item() { Name = tutloLab.Content.ToString(), Id = i }); i++; }
            if ((bool)zusFV.IsChecked) { Items.Add(new Item() { Name = zusLab.Content.ToString(), Id = i }); i++; }
            if ((bool)ksiegowaFV.IsChecked) { Items.Add(new Item() { Name = ksiegowaLab.Content.ToString(), Id = i }); }

            data.ItemsSource = Items;
        }
        public void LabelOfPaymentMonth()
        {
            DateTime today = DateTime.Today;
            string monthAsString = today.Month < 10 ? "0" + (today.Month).ToString() : (today.Month).ToString();
            string yearAsString = today.Year.ToString();
            thisMonth.Content = yearAsString + "-" + monthAsString;
        }
        private void SumUpVoid()
        {
            float.TryParse(orangeCash.Text, out float orange);
            float.TryParse(leasingCash.Text, out float leasing);
            float.TryParse(gapCash.Text, out float gap);
            float.TryParse(wwsiCash.Text, out float wwsi);
            float.TryParse(orlenCash.Text, out float orlen);
            float.TryParse(softwareplantCash.Text, out float softwareplant);
            float.TryParse(tutloCash.Text, out float tutlo);
            float.TryParse(zusCash.Text, out float zus);
            float.TryParse(ksiegowaCash.Text, out float ksiegowa);
            float.TryParse(telefonyCash.Text, out float telefony);
            float.TryParse(kredytCash.Text, out float kredyt);
            float.TryParse(innogyCash.Text, out float innogy);
            float.TryParse(czynszCash.Text, out float czynsz);
            float.TryParse(pakietyCash.Text, out float pakiety);
            float.TryParse(zlobekCash.Text, out float zlobek);

            float sum = orange + leasing + gap + wwsi + orlen + softwareplant + tutlo + zus + ksiegowa + telefony + kredyt + innogy + czynsz + pakiety + zlobek;
            string sumString = string.Format("{0:0.00}", sum);
            sumTextBlock.Text = sumString;
        }
        private void ReadData()
        {
            DateTime now = DateTime.Now;
            string monthAsString = (now.Month - 1) < 10 ? "0" + (now.Month - 1).ToString() : (now.Month - 1).ToString();
            string yearAsString = now.Year.ToString();
            if (monthAsString == "00")
            {
                monthAsString = "12";
                yearAsString = (now.Year - 1).ToString();
            }
            string sourceName = yearAsString + "-" + monthAsString + ".txt";
            List<string> lines = new List<string>();
            using (StreamReader sr = File.OpenText(sourceName))
            {
                string l = "";
                while ((l = sr.ReadLine()) != null)
                {
                    lines.Add(l);
                }
            }
            int i = 0;
            if (string.IsNullOrEmpty(orangeCash.Text)) { orangeCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(leasingCash.Text)) { leasingCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(gapCash.Text)) { gapCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(wwsiCash.Text)) { wwsiCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(orlenCash.Text)) { orlenCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(softwareplantCash.Text)) { softwareplantCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(tutloCash.Text)) { tutloCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(zusCash.Text)) { zusCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(ksiegowaCash.Text)) { ksiegowaCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(telefonyCash.Text)) { telefonyCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(kredytCash.Text)) { kredytCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(innogyCash.Text)) { innogyCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(czynszCash.Text)) { czynszCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(pakietyCash.Text)) { pakietyCash.Text = lines[i]; }
            i++;
            if (string.IsNullOrEmpty(zlobekCash.Text)) { zlobekCash.Text = lines[i]; }
            SumUpVoid();
        }
        private void SaveResults()
        {
            ((Storyboard)Resources["animacja"]).Begin();
            DateTime now = DateTime.Now;
            string monthAsString = now.Month < 10 ? "0" + now.Month.ToString() : now.Month.ToString();
            string dayAsString = now.Day < 10 ? "0" + now.Day.ToString() : now.Day.ToString();
            string fileName = now.Year + "-" + monthAsString + ".txt";
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(orangeCash.Text);
                sw.WriteLine(leasingCash.Text);
                sw.WriteLine(gapCash.Text);
                sw.WriteLine(wwsiCash.Text);
                sw.WriteLine(orlenCash.Text);
                sw.WriteLine(softwareplantCash.Text);
                sw.WriteLine(tutloCash.Text);
                sw.WriteLine(zusCash.Text);
                sw.WriteLine(ksiegowaCash.Text);
                sw.WriteLine(telefonyCash.Text);
                sw.WriteLine(kredytCash.Text);
                sw.WriteLine(innogyCash.Text);
                sw.WriteLine(czynszCash.Text);
                sw.WriteLine(pakietyCash.Text);
                sw.WriteLine(zlobekCash.Text);
            }
        }

        private void orangeFV_Click(object sender, RoutedEventArgs e)
        {
            FV();
        }
        public int first = 0;
        private void orangeCash_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (first > 14) { SumUpVoid(); }
            first++;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveResults();
        }

        private void orangeCash_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }
        private void orangeCash_LostFocus(object sender, RoutedEventArgs e)
        {
            ReadData();
        }
        private void orangeCheck_Click(object sender, RoutedEventArgs e)
        {
            string name = ((CheckBox)sender).Name.Replace("Check", "");
            object test;
            if (((CheckBox)sender).IsChecked == true)
            {
                var bc = new BrushConverter();

                test = main.FindName(name + "Grid");
                ((Grid)test).Background = (Brush)bc.ConvertFrom("#FFF6426D");

                test = main.FindName(name + "Cash");
                ((TextBox)test).Background = (Brush)bc.ConvertFrom("#FFF6426D");
            }
            else
            {
                var bc = new BrushConverter();

                test = main.FindName(name + "Grid");
                ((Grid)test).Background = null;

                test = main.FindName(name + "Cash");
                ((TextBox)test).Background = (Brush)bc.ConvertFrom("#FF05F56D");
            }
        }

        private void orangeLab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string name = ((Label)sender).Name.Replace("Lab", "");
            object test;

            test = main.FindName(name + "Check");

            if(((CheckBox)test).IsChecked == false)
            {
                ((CheckBox)test).IsChecked = true;

                var bc = new BrushConverter();

                test = main.FindName(name + "Grid");
                ((Grid)test).Background = (Brush)bc.ConvertFrom("#FFF6426D");

                test = main.FindName(name + "Cash");
                ((TextBox)test).Background = (Brush)bc.ConvertFrom("#FFF6426D");
            }
            else
            {
                ((CheckBox)test).IsChecked = false;
                
                var bc = new BrushConverter();

                test = main.FindName(name + "Grid");
                ((Grid)test).Background = null;

                test = main.FindName(name + "Cash");
                ((TextBox)test).Background = (Brush)bc.ConvertFrom("#FF05F56D");
            }
            
        }
    }
}
