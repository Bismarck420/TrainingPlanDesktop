using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlanDesktop
{
    internal class Workout
    {
        public static int workoutCount;

        public List<Exercise> exercises;
        public string name;
        public string description;

        public Workout() 
        {

        }

        public Workout(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void AddExercises(List<Exercise> exercises)
        {
            this.exercises = exercises;

        }

        public void OpenWorkout()
        {

        }

        public void CloseWorkout()
        {

        }

        public void EditWorkout()
        {

        }

        public void DeleteWorkout()
        {

        }

        public void SaveWorkout()
        {

        }
    }
}
