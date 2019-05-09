using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Auto23
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Autod> auto = new ObservableCollection<Autod>();
        public ObservableCollection<Autod> Cars { get { return auto; } }

        public MainPage()
        {
            InitializeComponent();

            autoView.ItemsSource = auto;
            auto.Add(new Autod { Auto = "Audi", Mudel = "A4"});
            auto.Add(new Autod { Mudel = "A4" });
        }
    }

    

    public class Autod
    {
        public string Auto { get; set; }
        public string Mudel { get; set; }
    }
}
