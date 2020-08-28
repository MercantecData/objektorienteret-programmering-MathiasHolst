using System;
using SkoleSystem;
using System.Collections.Generic;
using System.Linq;

namespace SkoleSystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oprettet en skole
            School sportCollege = new School("Sport College");

            //Her laver vi et helt hold med underviser, elever, et kursus og det lokale de skal bruge
            Course fodbold = new Course("Fodbold I", 307);
            Employee ansat1 = new Employee("Søren", 26, true, fodbold);
            fodbold.Teacher = ansat1; 
            Student elev1 = new Student("Kim", 17, ansat1, fodbold);
            Student elev2 = new Student("John", 19, ansat1, fodbold);

            //Vi opretter endnu et hold med underviser, elever, et kursus og angiver det lokale de skal bruge
            Course basketball = new Course("BasketBall II", 309);
            Employee ansat2 = new Employee("Michael", 37, true, basketball);
            basketball.Teacher = ansat2;
            Student elev3 = new Student("Brian", 27, ansat2, basketball);
            Student elev4 = new Student("Jan", 23, ansat2, basketball);

            //Her bliver de forskellige rum på skolen oprettet
            Room rum307 = new Room(307, true, fodbold);
            Room rum309 = new Room(309, true, basketball);
            Room rum311 = new Room(311, false);

            //Tilføjer rummet til kurserne
            fodbold.RoomNum = rum307.RoomNum;
            basketball.RoomNum = rum309.RoomNum;

            //Nedenstående viser hvordan en underviser bliver meldt på et hold
            sportCollege.addEmployee(ansat1);
            sportCollege.addEmployee(ansat2);

            //Dette bruges til at tilføje en elev til elevlisten
            sportCollege.addStudent(basketball, elev3);
            sportCollege.addStudent(basketball, elev4);

            //Printer lister ud med elever og undervisere
            fodbold.elevListe();
            basketball.elevListe();
            sportCollege.ansatteListe();

            //Fjerner en elev fra fodbold og derefter printer listen ud igen
            sportCollege.removeStudent(fodbold, elev2);
            fodbold.elevListe();

            //Fjerner et kursus fra skolen
            sportCollege.removeCourse(basketball);
            Console.WriteLine($"{basketball.Name} = null");

            //Tilføjer et kursus til skolen
            Course baseball = new Course("baseball", rum311.RoomNum, ansat1);
        }
    }
}
