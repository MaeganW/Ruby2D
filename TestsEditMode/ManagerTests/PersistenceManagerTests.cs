using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Managers;

namespace Tests
{
    public class PersistenceManagerTests
    {
        [Test]
        public void test_persistence_manager_class_methods()
        {
            var pm = new PersistenceManager();
            var num = 99;
            
            Assert.AreEqual(pm.Increment(num), 100);
        }

        [Test]
        public void test_persistence_manager_uses_instantiated_cm()
        {
            var pm = new PersistenceManager();
            var num = 99;
            
            Assert.AreEqual(pm.InstantiatedCMIncrement(num), 100);
        }
    }
}
