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
            var hello = "hello";
            
            Assert.AreEqual(pm.Concat(hello), "hello!");
        }

        [Test]
        public void test_persistence_manager_uses_content_manager()
        {
            var pm = new PersistenceManager();
            var num = 99;
            
            Assert.AreEqual(pm.CMIncrement(num), 100);
        }
    }
}
