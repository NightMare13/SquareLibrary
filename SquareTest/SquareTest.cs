using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SquareLibrary;

namespace SquareTest
{
    public class SquareTest
    {
        [Test]
        public void GetSquareForRightTriangle_3cathetA4cathetB_6Returned()
        {
            var res = Square.GetSquareForRightTriangle(3, 4, 5);

            Assert.AreEqual(6,res);
        }

        [Test]
        public void GetSquareForCircle_radiusIs5_between78and79returned()
        {
            var res = Square.GetSquareForCircle(5);

            Assert.AreEqual(78.5, res,0.1);
        }
    }
}
