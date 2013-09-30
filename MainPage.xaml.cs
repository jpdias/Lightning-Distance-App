using System;
using System.Diagnostics;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LightningDistance
{



    public partial class MainPage : PhoneApplicationPage
    {

        private static Boolean stop = true;
        private static Stopwatch stopwatch = new Stopwatch();
        LinkedList<String> distances = new LinkedList<String>();
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            time.Text = "Lightning";  
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

       
        private void Click_Click(object sender, RoutedEventArgs e)
        {
            Button source = (Button)sender;
            if (stop)
            {
                Dist.Text = "...";
                stop = false;
                stopwatch.Start();
                time.Text = "Thunder";  
            }
            else
            {

                stop = true;
                stopwatch.Stop();
                Dist.Text = Math.Round((float)((float)stopwatch.ElapsedMilliseconds / (float)1000.0) * 343.0,3) + " m";
                distances.AddFirst(Dist.Text);
                stopwatch.Reset();
                time.Text = "Lightning";
                lista.Items.Clear();
                for (int i = 0; i < 10 && i < distances.Count; i++)
                {
                    lista.Items.Add(distances.ElementAt(i));
                }
            }


        }
    }
}