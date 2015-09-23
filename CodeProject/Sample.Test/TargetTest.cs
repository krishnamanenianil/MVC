using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class TargetTest
    {
        [Test]
        public void Test()
        {
            Target.DoSomething();
        }
    }
}