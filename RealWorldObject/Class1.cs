using System;
using System.Collections.Generic;

namespace RealWorldObject
{
    class TraineeSoftwareDeveloper
    {
        // Private member variables
        private string name;
        private int experienceYears;             
        private List<string> knownLanguages;     
        private List<string> completedTasks;     
        private int productivity;                 
        private string project;                 

        // Constructor
        public TraineeSoftwareDeveloper(string name, string project)
        {
            this.name = name;
            this.experienceYears = 0; 
            knownLanguages = new List<string> { "C#" }; 
            completedTasks = new List<string>();
            productivity = 6; 
            this.project = project;
        }

        // Public method to learn C#
        public void LearnCSharp()
        {
            Console.WriteLine($"{name} is learning C#.");
            if (!knownLanguages.Contains("C#"))
            {
                knownLanguages.Add("C#");
                Console.WriteLine($"{name} has learned C#!");
            }
            else
            {
                Console.WriteLine($"{name} already knows C#!");
            }
            IncreaseProductivity();
        }

        // Public method to work on a specific task for the project
        public void WorkOnTask(string taskDescription)
        {
            Console.WriteLine($"{name} is working on the task: {taskDescription} for the {project} project.");
            completedTasks.Add($"Task: {taskDescription}");
            IncreaseProductivity();
        }

        // Public method to implement a feature (e.g., feature for Mobile Kiosk)
        public void ImplementFeature(string featureDescription)
        {
            Console.WriteLine($"{name} is implementing the feature: {featureDescription} for the {project}.");
            completedTasks.Add($"Implemented Feature: {featureDescription}");
            IncreaseProductivity();
        }

        // Public method to test the application
        public void TestApplication(string testDescription)
        {
            Console.WriteLine($"{name} is testing the feature: {testDescription} for the {project}.");
            completedTasks.Add($"Tested Feature: {testDescription}");
            IncreaseProductivity();
        }

        // Public method to present the project to seniors and Samsung
        public void PresentToSeniorsAndSamsung()
        {
            Console.WriteLine($"\n{name} is presenting the {project} app to her seniors and Samsung.");
            Console.WriteLine($"Presentation Details:");
            Console.WriteLine($"- App Name: {project}");
            Console.WriteLine($"- Key Features: Mobile payment, Queue skipping, User-friendly UI");
            Console.WriteLine($"- Project Objective: Help customers shop smart and avoid long queues.");
            Console.WriteLine("Demonstrating how the app works...\n");
            foreach (var task in completedTasks)
            {
                Console.WriteLine($"- {task}");
            }
            Console.WriteLine("\nThe presentation was a success!");
        }

        // Private method to increase productivity after each task
        private void IncreaseProductivity()
        {
            productivity += 1; // Each task increases productivity
            if (productivity > 10) productivity = 10; 
            Console.WriteLine($"Productivity increased! Current productivity: {productivity}/10");
        }

        // Public method to display trainee's details and tasks
        public void DisplayInfo()
        {
            Console.WriteLine($"\nTrainee Software Developer: {name}");
            Console.WriteLine($"Experience Years: {experienceYears}");
            Console.WriteLine("Known Languages: " + (knownLanguages.Count > 0 ? string.Join(", ", knownLanguages) : "No languages learned yet."));
            Console.WriteLine($"Productivity: {productivity}/10");
            Console.WriteLine($"Project: {project}");
            Console.WriteLine("\nCompleted Tasks:");
            foreach (var task in completedTasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }
}
