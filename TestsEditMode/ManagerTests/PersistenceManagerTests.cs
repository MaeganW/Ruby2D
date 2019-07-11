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
        private PersistenceManager pm = new PersistenceManager();
        
        [Test]
        public void test_persistence_manager_class_methods()
        {
            var num = 99;
            
            Assert.AreEqual(pm.Increment(num), 100);
        }

        [Test]
        public void test_persistence_manager_uses_instantiated_cm()
        {
            var num = 99;
            
            Assert.AreEqual(pm.InstantiatedCMIncrement(num), 100);
        }

        [Test]
        public void test_persistence_manager_uses_instantiated_global_cds()
        {
            var num = 99;
            
            Assert.AreEqual(pm.InstantiatedGlobalCDSIncrement(num), 100);
        }
    }
}
