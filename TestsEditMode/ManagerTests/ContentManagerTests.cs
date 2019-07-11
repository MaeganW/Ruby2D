using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Managers;

namespace Tests
{
    public class ContentManagerTests
    {
        private ContentManager cm = new ContentManager();
        
        [Test]
        public void test_content_manager_class_methods()
        {
            var num = 99;
            
            Assert.AreEqual(cm.Increment(num), 100);
        }
        
        [Test]
        public void test_content_manager_uses_singleton_pm()
        {
            var num = 99;
            
            Assert.AreEqual(cm.SingletonPMIncrement(num), 100);
        }
        
        [Test]
        public void test_content_manager_uses_instantiated_global_cds()
        {
            var num = 99;
            
            Assert.AreEqual(cm.InstantiatedGlobalCDSIncrement(num), 100);
        }
    }
}
