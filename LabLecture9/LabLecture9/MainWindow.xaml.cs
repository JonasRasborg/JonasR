using System;
using System.Collections.Generic;
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

namespace LabLecture9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayGenerator generator;
        private IObservable<int[]> array;
        private ISuperSorter sorter;
        private int size;
        private int seed;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = array;
        }

        private void CreateClick(object sender, RoutedEventArgs e)
        {
            size = int.Parse(textBoxSize.Text);
            seed = int.Parse(textBoxSeed.Text);
            generator = new ArrayGenerator(size, seed);
            array = generator.GenerateArray();
        }

        private void SortClick(object sender, RoutedEventArgs e)
        {
            sorter = new BubbleSorter();
            array = sorter.Sort(array);
        }
    }
}
