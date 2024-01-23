namespace MedicalBot
{
    internal class Patient
    {
        #region fields
        string name;
        int age;
        string gender;
        string medicalHistory;
        string symptomCode;
        string prescription;
        #endregion

        #region Properties
        // name
        internal string GetName()
        {
            return this.name;
        }
        internal bool SetName(string name, out string errorMessage)
        {
            bool isValid;

            if (name == null || name.Length == 0)
            {
                isValid = false;
                errorMessage = "Patient name cannot be empty.";
                return isValid;
            }
            else if (name.Length <= 1)
            {
                isValid = false;
                errorMessage = "Patient name should at least contain two characters.";
                return isValid;
            }
            else
            {
                isValid = true;
                this.name = name;
                errorMessage = "";
                return isValid;
            }


        }

        // age field
        internal int GetAge()
        {
            return this.age;
        }
        internal bool SetAge(int age, out string errorMessage)
        {
            bool isValid;
            // Check if age is negative
            if (age <= 0)
            {
                isValid = false;
                errorMessage = "Age cannot be negative.";
                return isValid;
            }
            else if (age > 100)
            {
                isValid = false;
                errorMessage = "Age cannot be greater than 100 years.";
                return isValid;
            }
            else
            {
                isValid = true;
                this.age = age;
                errorMessage = "";
                return isValid;
            }
        }
        // Gender
        internal string GetGender()
        {
            return this.gender;
        }
        internal bool SetGender(string gender, out string errorMessage)
        {
            bool isValid;
            if (gender.Equals("Male") || gender.Equals("Female") || gender.Equals("Other"))
            {
                isValid = true;
                this.gender = gender;
                errorMessage = "";
                return isValid;
            }
            else
            {
                isValid = false;
                errorMessage = "Gender should be a Male, Female, or Other.";
                return isValid;
            }
        }
        // medicalHistory 
        internal string GetMedicalHistory()
        {
            return this.medicalHistory;
        }
        internal void SetMedicalHistory(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }
        internal void SetSymptomCode(string symptomCode, out string errorMessage)
        {
            if (symptomCode == "S1" || symptomCode == "s1" ||
                symptomCode == "S2" || symptomCode == "s2" ||
                symptomCode == "S3" || symptomCode == "s3")
            {
                errorMessage = "";
                this.symptomCode = symptomCode;
            }
            else
            {
                errorMessage = "Invalid symptom code entered.";
            }
        }
        internal string GetSymptoms()
        {
            if (this.symptomCode == "S1" || this.symptomCode == "s1")
            {
                return "Headache";
            }
            else if (this.symptomCode == "S2" || this.symptomCode == "s2")
            {
                return "Skin rashes";
            }
            else if (this.symptomCode == "S3" || this.symptomCode == "s3")
            {
                return "Dizziness";
            }
            else
            {
                return "Unknown";
            }
        }
        // prescription
        internal string GetPrescription()
        {
            return this.prescription;
        }
        internal void SetPrescription(string prescription)
        {
            this.prescription = prescription;
        }
        #endregion
    }
}


