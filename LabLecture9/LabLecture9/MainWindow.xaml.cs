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
using System.Collections.ObjectModel;

namespace LabLecture9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] array;
        private ArrayGenerator generator;
        private ISuperSorter sorter;
        private int size;
        private int seed;
        private Sorters _currentSorter;
        public MainWindow()
        {
            InitializeComponent();
            sorter = new BubbleSorter();
        }

        enum Sorters
        {
            BUBBLE,
            SHELL,
            INSERTION,
            QUICK
        }

        private void CreateClick(object sender, RoutedEventArgs e)
        {
            size = int.Parse(textBoxSize.Text);
            seed = int.Parse(textBoxSeed.Text);
            generator = new ArrayGenerator(size, seed);
            array = generator.GenerateArray();
            updateListbox();
        }

        private void SortClick(object sender, RoutedEventArgs e)
        {
            switch (_currentSorter)
            {
                case Sorters.BUBBLE:
                {
                        sorter = new BubbleSorter();
                } break;
                    
                case Sorters.INSERTION:
                {
                    sorter = new InsertionSorter();
                } break;
                case Sorters.QUICK:
                {
                    
                } break;
                case Sorters.SHELL:
                {
                    
                } break; 
            }

            array = sorter.Sort(array);
            updateListbox();

        }

        private void updateListbox()
        {
            listBox.ItemsSource = null;
            listBox.ItemsSource = array;
        }

        private void BubbleChecked(object sender, RoutedEventArgs e)
        {
            _currentSorter = Sorters.BUBBLE;
        }

        private void InsertionChecked(object sender, RoutedEventArgs e)
        {
            _currentSorter = Sorters.INSERTION;
        }

        private void ShellChecked(object sender, RoutedEventArgs e)
        {
            _currentSorter = Sorters.SHELL;
        }

        private void QuickChecked(object sender, RoutedEventArgs e)
        {
            _currentSorter = Sorters.QUICK;
        }
    }
}
