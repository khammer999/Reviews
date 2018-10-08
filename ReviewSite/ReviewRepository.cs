using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class ReviewRepository
    {

       


        //instantiate 3 reviews and put into dictionary

        Review reviewOne = new Review() { Id = 123, Title = "War And Peace" };
        Review reviewTwo = new Review() { Id = 456, Title = "Confederates In The Attic" };
        Review reviewThree = new Review() { Id = 789, Title = "Hunt For Red Oktober" };

        Dictionary<int, Review> allReviews; //= new Dictionary<int, Review>();      
          
        //allReviews.Add(1,reviewOne);




     





        public Review FindById(int id)
        {
            return allReviews[id]; //or id-1?  
        }

        public Dictionary<int,Review> GetAll() //method returns dictionary of all reviews
        {
            return allReviews;

        }





    }
}
