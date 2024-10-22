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
using System.Runtime.CompilerServices;
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
    public sealed partial class NewWorkout : Page
    {
        static List<Workout> workouts = new List<Workout>();

        public NewWorkout()
        {
            this.InitializeComponent();

            if (workouts.Count == 0)
                noWorkouts.Visibility = Visibility.Visible;
            else
                noWorkouts.Visibility = Visibility.Collapsed;

        }

        private void createNew_Click(object sender, RoutedEventArgs e)
        {
            workouts.Add(new Workout());
            Button tb = new Button();
            tb.Content = "Workout Nr. " + workouts.Count;
            Workouts.Children.Add(tb);
            tb.Click += Tb_Click;
        }

        private void Tb_Click(object sender, RoutedEventArgs e)
        {
            if(((Button)sender).Content.ToString().Trim() == "Workout Nr. 1")
            {
                (Parent as Frame)?.Navigate(typeof(WorkoutView));
            }
        }
    }
}
