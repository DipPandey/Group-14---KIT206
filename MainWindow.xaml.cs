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

namespace Assignment_2_Redo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string STAFF_LIST_KEY = "staffList";
        private Boss boss;

        public MainWindow()
        {
            InitializeComponent();

            //During step 2 it is necessary to hard code some values for the ListBox
            //sampleListBox.Items.Add("one");
            //sampleListBox.Items.Add("two");
            //sampleListBox.Items.Add("three");

            //Part of task 3.4 (yes, horribly long, but most of this won't change between different resources)
            // See App.xaml for an alternative way of declaring the Boss resource in two stages that would allow
            // this code to be simplified (as we could refer to the Boss object directly).
            boss = (Boss)(Application.Current.FindResource(STAFF_LIST_KEY) as ObjectDataProvider).ObjectInstance;
        }

        private void sampleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                //After Task 4 done, this is not really needed
                //MessageBox.Show("The selected item is: " + e.AddedItems[0]);
                //Part of task 4
                DetailsPanel.DataContext = e.AddedItems[0];
            }
        }

        private void sampleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The text entered is: " + sampleTextBox.Text);
        }

        private void sampleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                sampleButton_Click(sender, e);
            }
        }

        //Part of task 3.4
        private void btnDeleteOne_Click(object sender, RoutedEventArgs e)
        {

            DetailsPanel.DataContext = new { Name = "Fred", SkillCount = 5 };


            if (boss.VisibleWorkers.Count > 0)
            {
                Employee theRemoved = boss.VisibleWorkers[0]; //this is just to keep the GUI tidy (after Task 4 implemented)
                boss.VisibleWorkers.RemoveAt(0); //the actual removal step
                //completing keeping the GUI tidy (something similar may be required in the assignment)
                if (DetailsPanel.DataContext == theRemoved)
                {
                    DetailsPanel.DataContext = null;
                }
            }
        }
    }
}
