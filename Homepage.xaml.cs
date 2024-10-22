using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TrainingPlanDesktop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Homepage : Page
    {
        public Homepage()
        {
            this.InitializeComponent();
        }

        #region ButtonHandlers
        public void AddWorkout(object sender, RoutedEventArgs e)
        {
            Button openWorkout = new Button();

            openWorkout.Width = 200;
            openWorkout.Height = 36;
            openWorkout.Content = "open Workout";
            openWorkout.Click += OpenWorkout_Click;

            MainPanel.Children.Add(openWorkout);
        }

        public void OpenWorkout_Click(object sender, RoutedEventArgs e)
        {
            Workout workout = new Workout();
            (Parent as Frame)?.Navigate(typeof(NewWorkout));
        }
        #endregion

        private void AddExercise(object sender, RoutedEventArgs e)
        {

        }
    }
}
