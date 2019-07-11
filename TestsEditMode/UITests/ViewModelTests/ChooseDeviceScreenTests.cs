using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ChooseDeviceScreenTests
    {
        [Test]
        public void test_cds_class_methods()
        {
            ChooseDeviceScreen cds = new ChooseDeviceScreen();
            int num = 99;
            
            Assert.AreEqual(cds.Increment(num), 100);
        }
    }
}
