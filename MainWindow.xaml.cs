using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TrainingPlanDesktop
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            rootFrame.Navigate(typeof(WorkoutView));  // Starte mit Seite 1

        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

            if (((NavigationViewItem)NavView.SelectedItem).Content.ToString() == "Homepage")
            {
                rootFrame.Navigate(typeof(Homepage));
            }
            else if(((NavigationViewItem)NavView.SelectedItem).Content.ToString() == "Workouts")
            {
                rootFrame.Navigate(typeof(NewWorkout));
            }
            else if(((NavigationViewItem)NavView.SelectedItem).Content.ToString() == "Exercises")
            {
                rootFrame.Navigate(typeof(Exercises));
            }
        }
    }
}
