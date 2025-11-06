using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");


            Hospital hospital = new Hospital();


            Console.WriteLine("--- Додавання лікарів ---");
            Doctor doctor1 = new Doctor(1, "Остап Буревій", "Хірург");
            Doctor doctor2 = new Doctor(2, "Микита Сокіл", "Терапевт");
            Doctor doctor3 = new Doctor(3, "Тарас Вовк", "Кардіолог");
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);
            hospital.AddDoctor(doctor3);
            Console.WriteLine();


            Console.WriteLine("--- Реєстрація пацієнтів ---");
            Patient patient1 = new Patient(1, "Олена Верба", 23);
            Patient patient2 = new Patient(2, "Данило Грім", 27);
            Patient patient3 = new Patient(3, "Марічка Зірка", 35);
            Patient patient4 = new Patient(4, "Іван Дуб", 64);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);
            hospital.RegisterPatient(patient4);
            Console.WriteLine();


            Console.WriteLine("--- Створення палат ---");
            HospitalRoom room1 = new HospitalRoom(105, 2);
            HospitalRoom room2 = new HospitalRoom(108, 1);
            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);
            Console.WriteLine();


            Console.WriteLine("--- Госпіталізація пацієнтів ---");
            hospital.HospitalizePatient(1, 105);
            hospital.HospitalizePatient(2, 105);
            hospital.HospitalizePatient(3, 105);
            hospital.HospitalizePatient(4, 108);
            hospital.HospitalizePatient(99, 105);
            Console.WriteLine();


            Console.WriteLine("--- Створення медичних записів ---");
            MedicalRecord record1 = new MedicalRecord(patient1, doctor1, DateTime.Now.AddDays(-3), "Проведено огляд, стан стабільний.");
            MedicalRecord record2 = new MedicalRecord(patient4, doctor2, DateTime.Now, "Призначено аналізи.");
            MedicalRecord record3 = new MedicalRecord(patient1, doctor3, DateTime.Now, "Консультація кардіолога.");
            hospital.AddMedicalRecord(record1);
            hospital.AddMedicalRecord(record2);
            hospital.AddMedicalRecord(record3);


            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());
        }
    }
}