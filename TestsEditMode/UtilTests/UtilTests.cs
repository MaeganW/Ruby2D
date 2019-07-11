using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Util;

namespace Tests
{
    public class UtilTests
    {
        [Test]
        public void test_string_equivalent()
        {
            string hello = "hello";
            Assert.IsTrue(hello.Equivalent("hello"));
        }

    }
}
