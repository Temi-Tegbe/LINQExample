using System;
using LINQExample;

namespace LINQExample
{
    class Program
    {

        public static FellowQueries fellowQueries = new FellowQueries();

        static void Main(string[] args)
    
        {
        //fellowQueries.GetFellowsSortedByLastNameExpression();
        //    fellowQueries.GetFellowsSortedByLastNameMethod();
            //fellowQueries.GetFellowsBornFrom2005InDescendingOrder();
            //fellowQueries.GetFellowsBornFrom2005InDescendingOrderMethod();
            //fellowQueries.GetFellowsNeitherMaleNorFemale();
            //fellowQueries.GetFellowsNeitherMaleNorFemaleMethod();
            fellowQueries.GetFellowsGroupedByTrack();
            //fellowQueries.GetFellowsGroupedByTrackMethod();
            }


        


            

    }
    }
