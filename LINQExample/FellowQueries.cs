using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LINQExample
{
   public class FellowQueries
    {
        // STEP 1: Establish the data source, a list of Fellow objects


        public IEnumerable<Fellow> fellows = new List<Fellow>()
        {
            new Fellow() { FirstNane = "Temiloluwa", LastName = "Tegbe", Track = "DotNet", Gender = "Male", DateOfBirth = new DateTime(1997, 12, 27 ) },

            new Fellow() { FirstNane = "Fatima", LastName = "Akanbi", Track = "Javascript", Gender = "Female", DateOfBirth = new DateTime(1800, 02, 02 ) },

            new Fellow() { FirstNane = "Babatunde", LastName = "Akerele", Track = "Javascript", Gender = "Male", DateOfBirth = new DateTime(2002, 09, 01 ) },

            new Fellow() { FirstNane = "Ebenezer", LastName = "Ogungbe", Track = "Javascript", Gender = "Female", DateOfBirth = new DateTime(2018, 6, 19 ) },

            new Fellow() { FirstNane = "Omolola", LastName = "Lawal", Track = "DotNet", Gender = "Female", DateOfBirth = new DateTime(1999, 10, 07 ) },

            new Fellow() { FirstNane = "Adeleke", LastName = "Adeyinde", Track = "DotNet", Gender = "non-binary", DateOfBirth = new DateTime(2005, 03, 15 ) },

            new Fellow() { FirstNane = "PsalmJoe", LastName = "Otoide", Track = "DevOps", Gender = "undisclosed", DateOfBirth = new DateTime(2010, 11, 13 ) },

            new Fellow() { FirstNane = "Abolaji", LastName = "Adebayo", Track = "DevOps", Gender = "Male", DateOfBirth = new DateTime(2005, 4, 15 ) },

            new Fellow() { FirstNane = "Solomon", LastName = "Akinola", Track = "Javascript", Gender = "Male", DateOfBirth = new DateTime(1978, 12, 25 ) },

            new Fellow() { FirstNane = "Hope", LastName = "Ndudim", Track = "DotNet", Gender = "Male", DateOfBirth = new DateTime(2002, 11, 29 ) },



        };
        // STEP 2: Write a bunch of queries using expression syntax. 

        //    1. Fetch all fellows sorted by last name.
        //    2. Fetch all fellows born in the year 2005 and later, sorted in descending order of date of birth.
        //    3. Fetch all fellows who are neither male nor female.
        //    4. Fetch all fellows born after 1995, and grouped by their respective tracks.
        //    5. Fetch all fellows grouped by track, AssemblyLoadEventHandler sorted in ascending order of their first name.

        // STEP 3: Repeat the above queries using method syntax. 

        //SETP 4: Execute the queries




        //    1. Fetch all fellows sorted by last name.

        public void GetFellowsSortedByLastNameExpression()
        {
            IEnumerable<Fellow> lastNameSortQuery = from fellow in fellows
                                                    orderby fellow.LastName descending
                                                    select fellow;

            Console.WriteLine("List of fellows, sorted by last name in descending order....... EXPRESSION SYNTAX");
            //Console.WriteLine("\n First Name \t Last Name \t Date of birth \t Gender \t Track");

            foreach(Fellow objFellow in lastNameSortQuery)
            {
                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");
            }

        }

        public void GetFellowsSortedByLastNameMethod()

        {
            IEnumerable<Fellow> lastNameSortQuery = fellows.OrderByDescending(f => f.LastName);

            Console.WriteLine("\n \nList of fellows, sorted by last name in descending order....... METHOD SYNTAX");

            foreach (Fellow objFellow in lastNameSortQuery)
            {
                
                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");
            }
        }


        //    2. Fetch all fellows born in the year 2005 and later, sorted in descending order of date of birth.

        public void GetFellowsBornFrom2005InDescendingOrder()
        {
            IEnumerable<Fellow> DOBSortQuery = from fellow in fellows
                                               where fellow.DateOfBirth.Year >= 2005
                                               orderby fellow.DateOfBirth descending
                                               select fellow;

            Console.WriteLine("List of fellows, born in 2005 and later, while sorted in descending order....... EXPRESSION SYNTAX");
            //Console.WriteLine("\n First Name \t Last Name \t Date of birth \t Gender \t Track");

            foreach (Fellow objFellow in DOBSortQuery)
            {
                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");
            }
        }


        public void GetFellowsBornFrom2005InDescendingOrderMethod()

        {
            IEnumerable<Fellow> DOBSortQuery = fellows
                .Where(f => f.DateOfBirth.Year >= 2005)
                .OrderByDescending(f => f.DateOfBirth);


            Console.WriteLine("\n \nList of fellows, born in 2005 and later, while sorted in descending order....... METHOD SYNTAX");

            foreach (Fellow objFellow in DOBSortQuery)
            {

                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");
            }
        }

        public void GetFellowsNeitherMaleNorFemale()
        {
            IEnumerable<Fellow> NeitherMaleNorFemaleFellow = from fellow in fellows
                                               where fellow.Gender != "Male" && fellow.Gender != "Female"
                                               select fellow;

            Console.WriteLine("List of fellows, neither male nor female....... EXPRESSION SYNTAX");
            //Console.WriteLine("\n First Name \t Last Name \t Date of birth \t Gender \t Track");

            foreach (Fellow objFellow in NeitherMaleNorFemaleFellow)
            {
                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");
            }
        }

        public void GetFellowsNeitherMaleNorFemaleMethod()

        {
            IEnumerable<Fellow> NeitherMaleNorFemaleFellow = fellows
                .Where(f => f.Gender != "Male" && f.Gender != "Female");
                


            Console.WriteLine("\n \nList of fellows, who are neither male nor female....... METHOD SYNTAX");

            foreach (Fellow objFellow in NeitherMaleNorFemaleFellow)
            {

                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");
            }
        }


        public void GetFellowsGroupedByTrack()
        {
            IEnumerable<IGrouping<string, Fellow>> GroupedByTrackQuery = from fellow in fellows
                                                                         where fellow.DateOfBirth.Year <= 1995 || fellow.DateOfBirth.Year >= 2004
                                                                         group fellow by fellow.Track;

            Console.WriteLine("\n \nList of fellows, who are born between 1995 and 2004....... EXPRESSION SYNTAX");

            foreach (var objGroup in GroupedByTrackQuery)
            {

                Console.WriteLine($"{objGroup.Key} : {objGroup.Count()}");
                Console.WriteLine(objGroup.Key.ToUpper());
                
                foreach(Fellow objFellow in objGroup)

                Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");

            }

        }


        
        public void GetFellowsGroupedByTrackMethod()

        {
            IEnumerable<IGrouping<string, Fellow>> GroupedByTrackQuery = fellows
                //.Where(f => f.DateOfBirth.Year <= 1995 || f.DateOfBirth.Year >= 2004)
                .GroupBy(f => f.Track);



            Console.WriteLine("\n \nList of fellows, who are born between 1995 and 2004....... EXPRESSION SYNTAX");

            foreach (var objGroup in GroupedByTrackQuery)
            {

                Console.WriteLine(objGroup.Key.ToUpper());

                foreach (Fellow objFellow in objGroup)

                    Console.WriteLine($"{objFellow.FirstNane} \t {objFellow.LastName} \t {objFellow.DateOfBirth.ToShortDateString()} \t {objFellow.Gender} \t {objFellow.Track}");

            }
        }
    }
}
