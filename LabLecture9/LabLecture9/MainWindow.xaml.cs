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
        private int[] testArray;
        private int[] testArrayDone;
        private double _time;
        private Tuple<int[], double> tuple;
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
            updateListbox(listBox, array);
        }


        private void SortSwitch()
        {
            switch (_currentSorter)
            {
                case Sorters.BUBBLE:
                    {
                        sorter = new BubbleSorter();
                    }
                    break;

                case Sorters.INSERTION:
                    {
                        sorter = new InsertionSorter();
                    }
                    break;
                case Sorters.QUICK:
                    {
                        sorter = new QuickSorter();
                    }
                    break;
                case Sorters.SHELL:
                    {
                        sorter = new ShellSorter();
                    }
                    break;
            }
        }

        private void SortClick(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;

            SortSwitch();

            tuple = sorter.Sort(array);

            array = tuple.Item1;
            _time = tuple.Item2;
            
            updateListbox(listBox, array);

            labelTime.Content = _time + " " + "milliseconds";

            Cursor = Cursors.Arrow;
        }

        private void updateListbox(ListBox listbox, int[] _array)
        {
            listbox.ItemsSource = null;
            listbox.ItemsSource = _array;
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


        private void TestClick(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            SortTest();
            Cursor = Cursors.Arrow;
        }

        private void generateTestArray()
        {
            size = int.Parse(textBoxSizeTest.Text);
            seed = int.Parse(textBoxSeedTest.Text);

            generator = new ArrayGenerator(size, seed);

            testArray = generator.GenerateArray();
            updateListbox(listBox1, testArray);
        }

        private void SortTest()
        {
            generateTestArray();
            sorter = new BubbleSorter();
            tuple = sorter.Sort(testArray);

            testArray = tuple.Item1;
            _time = tuple.Item2;

            BubbleLabel.Content = "BubbleSorter: \t" + _time + " " + "milliseconds";


            generateTestArray();
            sorter = new InsertionSorter();
            tuple = sorter.Sort(testArray);

            testArray = tuple.Item1;
            _time = tuple.Item2;

            InsertionLabel.Content = "InsertionSorter: \t" + _time + " " + "milliseconds";


            generateTestArray();
            sorter = new ShellSorter();
            tuple = sorter.Sort(testArray);

            testArray = tuple.Item1;
            _time = tuple.Item2;

             ShellLabel.Content = "ShellSorter: \t" + _time + " " + "milliseconds";


            generateTestArray();
            sorter = new QuickSorter();
            tuple = sorter.Sort(testArray);

            testArray = tuple.Item1;
            _time = tuple.Item2;

            QuickLabel.Content = "QuickSorter: \t" + _time + " " + "milliseconds";

        }
    }
}
