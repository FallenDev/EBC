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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EBC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var objects_collection =
                (from line in File.ReadAllLines(@"C:\BuildingHP.xlsx").Skip(1)
                 let parts = line.Split(',')
                 select new
                 {
                     level = parts[0],
                     townHall = parts[1],
                     vault = parts[2],
                     goldMine = parts[3],
                     alchemy = parts[4],
                     reaper = parts[5],
                     sniper = parts[6],
                     airDefense = parts[7],
                     magicTower = parts[8],
                     ermah = parts[9],
                     mortor = parts[10],
                     cannon = parts[11],
                     sanctum = parts[12],
                     victoryStatue = parts[13],
                     bastion = parts[14]
                 }
            ).ToList();
        }

        // https://msdn.microsoft.com/en-us/library/b3k79a5x.aspx
        // https://stackoverflow.com/questions/20113452/how-to-bind-csv-file-to-a-drop-down-list
        private void ToList()
        {
            throw new NotImplementedException();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
