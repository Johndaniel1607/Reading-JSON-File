using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace TVLICT201.JSONReader.Windows.Typhoon
{
    /// <summary>
    /// Interaction logic for TyphoonWindow.xaml
    /// </summary>
    public partial class TyphoonWindow : Window
    {
        public TyphoonWindow()
        {
            InitializeComponent();
            Typhoon typhoon = new Typhoon();

            using (StreamReader r = new StreamReader("data\\typhoon.json"))
            {
                string json = r.ReadToEnd();
                typhoon = JsonConvert.DeserializeObject<Typhoon>(json);
            }
            lblTyphoonId.Content = "Id :" + typhoon.id;
            lblTyphoonName.Content = "Name :" + typhoon.name;
            lblTyphoonDate.Content = "Date :" + typhoon.date;
            lblTyphoonPressure.Content = "Pressure :" + typhoon.pressure;
            lblTyphoonWinds.Content = "Winds :" + typhoon.winds;
        }
    }
}
