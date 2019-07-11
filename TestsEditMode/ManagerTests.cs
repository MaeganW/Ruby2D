using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Managers;

namespace Tests
{
    public class ManagerTests
    {
        
        [Test]
        public void test_content_manager_class_methods()
        {
            var cm = new ContentManager();
            var num = 99;
            
            Assert.AreEqual(cm.Increment(num), 100);
        }
        
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

        [Test]
        public void test_base_scene_manager_class_methods()
        {
            var bsm = new BaseSceneManager();
            var num = 99;
            
            Assert.AreEqual(bsm.Increment(num), 100);
        }
        
        [Test]
        public void test_base_scene_manager_uses_injected_cm()
        {
            var bsm = new BaseSceneManager();
            var num = 99;
            
            Assert.AreEqual(bsm.InjectedCMIncrement(num), 100);
        }
        
        [Test]
        public void test_base_scene_manager_uses_injected_pm()
        {
            var bsm = new BaseSceneManager();
            var num = 99;
            
            Assert.AreEqual(bsm.InjectedPMIncrement(num), 100);
        }
        
        [Test]
        public void test_base_scene_manager_uses_singleton_pm()
        {
            var bsm = new BaseSceneManager();
            var num = 99;
            
            Assert.AreEqual(bsm.SingletonPMIncrement(num), 100);
        }
        
    }
}
