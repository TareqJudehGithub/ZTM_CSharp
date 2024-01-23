namespace MedicalBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment: MedicalBot\n");

            // Instantiating the Patient class, creating an object.
            Patient patient = new Patient();
            MedicalBot bot = new MedicalBot();

            // Bot welcome message
            string botName = MedicalBot.GetBotName();
            Console.WriteLine($"Hi, I'm {botName}. I'm here to help you in your medication.");

            // Patient Details - entry:
            string errorMessage;
            string name;
            int age = default;
            string gender;
            string medicalHistory;
            string symptomCode;

            Console.WriteLine("Enter your (patient) details:");
            // Patient name input
            do
            {
                Console.Write("Enter Patient Name: ");
                name = Console.ReadLine();
                patient.SetName(name: name, out errorMessage);
                if (errorMessage.Length > 1) Console.WriteLine(errorMessage);
            }
            while (errorMessage.Length > 1);

            // Patient Age input
            do
            {
                string userInput = string.Empty;
                bool isInt = true;

                Console.Write("Enter Patient Age: ");
                userInput = Console.ReadLine();
                isInt = int.TryParse(userInput, out age);

                if (isInt)
                {
                    patient.SetAge(age: age, out errorMessage);
                    if (errorMessage.Length > 1) Console.WriteLine(errorMessage);
                }
                else
                {
                    errorMessage = ("Age should only be integer input.");
                    Console.WriteLine(errorMessage);
                }
            }
            while (errorMessage.Length > 1);

            // Patient gender input
            do
            {
                Console.Write("Enter Patient Gender: ");
                gender = Console.ReadLine();
                patient.SetGender(gender: gender, out errorMessage);
                if (errorMessage.Length > 1) Console.WriteLine(errorMessage);
            }
            while (errorMessage.Length > 1);

            // Patient medical history input
            Console.Write("Enter Medical History: ");
            medicalHistory = Console.ReadLine();
            patient.SetMedicalHistory(medicalHistory: medicalHistory);

            Console.Write(@$"
Welcome, {patient.GetName()}, {patient.GetAge()}.
Which of the following symptoms do you have:
S1. Headache
S2. Skin rashes
S3. Dizziness");

            Console.WriteLine("\n");

            // Patient symptoms code entry
            do
            {
                Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
                symptomCode = Console.ReadLine();
                patient.SetSymptomCode(symptomCode: symptomCode, out errorMessage);
                if (errorMessage.Length > 1) Console.WriteLine(errorMessage);
            }
            while (errorMessage.Length > 1);

            // Patient medicine prescription
            Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
            bot.PrescribeMedication(patient);

            Console.ReadKey();
        }
    }
}
