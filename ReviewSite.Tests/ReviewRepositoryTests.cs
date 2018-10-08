using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewRepositoryTests
    {

        public void GetAll_Returns_3_Reviews()
        {
            var underTest = new ReviewRepository();
            var result = underTest.GetAll();

            Assert.Empty(result);
        }

        //[Fact]
        //public void Test1()
        //{


        //}



    }
}
