using UFindBL;

namespace UFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UFind!");
            List<University> universities = new List<University>();

            University top1university = new University
            {
                name = "Polytechnic University of the Philippines",
                location = "Binan, Laguna",
                type = "State University",
                courses = "BEED, BSA, BSBA-HRM, BSCpE, BSIE, BSIT, BSEDEN, BSEDSS, DCET, DICT"
            };

            University top2university = new University
            {
                name = "Saint Michael's College of Laguna",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BSBA, BSIT, BSP, BEED, BSN, BSCrim"
            };

            University top3university = new University
            {
                name = "University of Perpetual Help System Laguna",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BSN, BS-HRM, BSTM, BSA, BSBA, BSIT, BSP, BSBio, BSPharma, BEED"
            };

            //displaying method
            Console.WriteLine("\n-- Listed Universities --");
            DisplayUniversities(top1university);
            DisplayUniversities(top2university);
            DisplayUniversities(top3university);
            Console.WriteLine("-------------");

            List<University> universitiesname = new List<University>();

            universitiesname.Add(top1university);
            universitiesname.Add(top2university);
            universitiesname.Add(top3university);

            //sorting method
            static int CompareByName(University u1, University u2)
            {
                return u1.name.CompareTo(u2.name);
            }

            universitiesname.Sort(CompareByName);

            Console.WriteLine($"Sorted Universities by name:");

            foreach (University university in universitiesname)
            {
                Console.WriteLine($"\n{university.name}");
            }
            Console.WriteLine("-------------");

            //search method
            Console.WriteLine("Enter university type to search (Public/Private): ");
            string searchType = Console.ReadLine().ToLower();

            University foundUniversity = UFile.SearchUniversity(searchType);

            if (foundUniversity != null)
            {
                Console.WriteLine($"Found university of type '{searchType}':");
                Console.WriteLine(top1university);
            }
            else
            {
                Console.WriteLine("No university of that type found.");
            }

            static void DisplayUniversities(University university)
            {
                Console.WriteLine($"\n{university.name} ({university.location})");
                Console.WriteLine($"   - Type: {university.type}");
                Console.WriteLine($"   - Courses: {university.courses}");
            }
        }

    }
}

