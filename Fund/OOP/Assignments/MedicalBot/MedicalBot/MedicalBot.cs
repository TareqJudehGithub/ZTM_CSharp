namespace MedicalBot
{
    internal class MedicalBot
    {
        #region Constants
        const string BotName = "Bob";
        #endregion

        #region Methods
        internal static string GetBotName()
        {
            return BotName;
        }

        internal void PrescribeMedication(Patient patient)
        {
            /*
             * This method takes the output from Patient class GetPrescription method, and describe the proper
             * medicine and dosage.
             */

            string symptom = patient.GetSymptoms();
            string medicalHistory = patient.GetMedicalHistory();

            switch (symptom)
            {
                case "Headache":
                    patient.SetPrescription("ibuprofen");
                    break;
                case "Skin rashes":
                    patient.SetPrescription("diphenhydramine");
                    break;
                case "Dizziness":

                    if (medicalHistory == "Diabetes")
                    {
                        patient.SetPrescription("metformin");
                    }
                    else
                    {
                        patient.SetPrescription("dimenhydrinate");
                    }
                    break;
                default:
                    patient.SetPrescription("N/A");
                    break;
            }

            string GetDosage(string medicineName)
            {

                /*
                 * This function takes the medicine name as an input, and based on the patient age
                 * returns the proper dosage as an output.
                 */
                medicineName = patient.GetPrescription();
                int patientAge = patient.GetAge();
                string dosage = string.Empty;

                // ibuprofen
                if (medicineName.Equals("ibuprofen"))
                {
                    if (patientAge < 18)
                    {
                        dosage = "400 mg";
                    }
                    else
                    {
                        dosage = "800 mg";
                    }
                }
                // diphenhydramine
                else if (medicineName.Equals("diphenhydramine"))
                {
                    if (patientAge < 18)
                    {
                        dosage = "50 mg";
                    }
                    else
                    {
                        dosage = "300 mg";
                    }
                }
                // dimenhydrinate
                else if (medicineName.Equals("dimenhydrinate"))
                {
                    if (patientAge < 18)
                    {
                        dosage = "50 mg";
                    }
                    else
                    {
                        dosage = "500 mg";
                    }
                }
                else if (medicineName.Equals("metformin"))
                {
                    dosage = "500 mg";
                }
                return dosage;
            }
            // PrescribeMedication output
            string medicine = patient.GetPrescription();
            Console.WriteLine($"{medicine} {GetDosage(medicine)}");
        }
        #endregion
    }
}
