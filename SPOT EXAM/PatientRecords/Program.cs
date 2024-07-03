using System;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.DataAnnotations;

namespace PatientRecords
{
    

    public class Patient
    {
        private int patientId;
        private string patientName;
        private int age;
        private int doctorId;

        public int PatientId
        {
            get
            {
                return patientId;
            }
            set
            {
                if (value <= 0)
                    throw new ValidationException("Patient id must be greater");
                patientId = value;
            }
        }

        public string PatientName
        {
            get { return patientName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ValidationException("Patieint name not null");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ValidationException("Age not null");
                age = value;
            }
        }
        public int DoctorId
        {
            get { return doctorId; }
            set
            { doctorId = value; }
        }
        public override string ToString()
        {
            return $"PatientId:{PatientId}, PatientName:{PatientName}, Age:{Age}, DoctorId:{DoctorId}";
        }
    }

    public class Doctor
    {
        private int doctorId;
        private string doctorName;

        public int DoctorId
        {
            get { return doctorId; }
            set
            {
                if (value <= 0)
                    throw new ValidationException("Id not null");
                doctorId = value;
            }
        }

        public string DoctorName
        {
            get { return doctorName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ValidationException("Doctor Name not null");
                doctorName = value;
            }
        }
        public override string ToString()
        {
            return $"DoctorId:{DoctorId}, DoctorName:{DoctorName}";
        }
    }

    public class TestCode
    {
        public static List<Patient>patients= new List<Patient>();
        public static List<Doctor>doctors= new List<Doctor>();

        public static void initiateRecords()
        {
            doctors.Add(new Doctor { DoctorId=1,DoctorName="Dr. Bhavesh"});
            doctors.Add(new Doctor { DoctorId = 2, DoctorName = "Dr. Manoj Sir" });
            doctors.Add(new Doctor { DoctorId = 3, DoctorName = "Dr. Shweta Mam" });
            doctors.Add(new Doctor { DoctorId = 4, DoctorName = "Dr. Malkeet Sir" });
            doctors.Add(new Doctor { DoctorId = 5, DoctorName = "Dr. Aditya Sir" });

            patients.Add(new Patient {PatientId=1,PatientName="Ayush",Age=26,DoctorId=3 });
            patients.Add(new Patient { PatientId = 2, PatientName = "Ayesha", Age = 26, DoctorId = 1 });
            patients.Add(new Patient { PatientId = 3, PatientName = "Ashwin", Age = 42, DoctorId = 2 });
            patients.Add(new Patient { PatientId = 4, PatientName = "Chinmay", Age = 25, DoctorId = 1 });
            patients.Add(new Patient { PatientId = 5, PatientName = "Ashish", Age = 41, DoctorId = 4 });
            patients.Add(new Patient { PatientId = 6, PatientName = "Aryan", Age = 23, DoctorId = 5 });
            patients.Add(new Patient { PatientId = 7, PatientName = "Bhavesh", Age = 27, DoctorId = 3 });
            patients.Add(new Patient { PatientId = 8, PatientName = "Buddhabhushan", Age = 25, DoctorId = 2 });
            patients.Add(new Patient { PatientId = 9, PatientName = "Bhagyashree", Age = 23, DoctorId = 4 });
            patients.Add(new Patient { PatientId = 10, PatientName = "Aniket", Age = 25, DoctorId = 1 });
        }

        static void Main()
        {
            //a
            initiateRecords();

            //b
            Console.WriteLine("Select All Patients");
            var allPatients = from p in patients select p;
            foreach (var patient in allPatients)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine();

            //c
            //var patientIdName = from p in patients select

            //d
            Console.WriteLine("Patients age Greater than 40");
            var patient40 = from p in patients where p.Age > 40 select p;
            foreach (var patient in patient40)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine();

            //e
            Console.WriteLine("Patient age between 20 and 30");
            var patientage20_30 = from p in patients where p.Age >= 20 && p.Age <= 30 select p;
            foreach (var patient in patientage20_30)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine();

            //f
            Console.WriteLine("Patient Id and Name in descending order");
            var patientDecending = from p in patients orderby p.PatientName descending select p;
            foreach (var patient in patientDecending)
            {
                Console.WriteLine(patient);
            }

            //g

            Console.WriteLine();

            //h
            Console.WriteLine("Join in the pateint and doctors");
            var joinPatientAndDoctor = from p in patients
                                       join d in doctors on p.DoctorId equals d.DoctorId
                                       select p;
            foreach (var patient in joinPatientAndDoctor)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine();
            //i
            Console.WriteLine("Join doctors and patients");
            var doctorOnly = from d in doctors
                             join p in patients on d.DoctorId equals p.DoctorId
                             select d;
            foreach (var patient in patientage20_30)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine();

            //k
            Console.WriteLine("join and select few properties");
            var propertiesDoctorAndPatient = from p in patients
                                             join d in doctors on p.DoctorId equals d.DoctorId
                                             select new { p.PatientName, p.Age, d.DoctorId };
            foreach (var patient in joinPatientAndDoctor)
            {
                Console.WriteLine($"PatientName:{patient.PatientName},PatientAge:{patient.Age}, Doctorname:{patient.DoctorId}");
            }
        }
    }
}
