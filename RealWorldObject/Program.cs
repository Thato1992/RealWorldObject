namespace RealWorldObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the TraineeSoftwareDeveloper class (Thato Lentsoane)
            // Working on the "Mobile Kiosk" project
            TraineeSoftwareDeveloper thato = new TraineeSoftwareDeveloper("Thato Lentsoane", "Mobile Kiosk");

            // Display initial info
            thato.DisplayInfo();

            // Thato learns C#
            thato.LearnCSharp();

            // Thato works on a task for the Mobile Kiosk project
            thato.WorkOnTask("Design the user interface for the Mobile Kiosk application.");

            // Thato implements a feature for the Mobile Kiosk project
            thato.ImplementFeature("Add payment integration to allow users to pay via the app.");

            // Thato tests the Mobile Kiosk application
            thato.TestApplication("Test payment gateway integration for Mobile Kiosk.");

            // Display updated info
            thato.DisplayInfo();

            // Thato presents the Mobile Kiosk app to seniors and Samsung
            thato.PresentToSeniorsAndSamsung();

            // Final info check
            thato.DisplayInfo();
        }
    }
}
