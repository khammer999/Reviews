using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewRepositoryTests
    {


        [Fact]
        public void GetAll_Returns_3_Reviews()
        {
            var underTest = new ReviewRepository();
            var result = underTest.GetAll();

            Assert.Equal(3,result.Count);
        }

        [Fact]
        public void Get_Id_Returns_Id_Field()
        {
            var underTest = new ReviewRepository();
            var result = underTest.FindById(1);

            Assert.Equal("War And Peace", result.Title);

        }



    }
}
