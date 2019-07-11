using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using Managers;
using UnityEngine;

namespace Tests
{
    public class BaseSceneManagerTests
    {
        private BaseSceneManager bsm = new BaseSceneManager();
        
        [Test]
        public void test_base_scene_manager_uses_injected_pm()
        {
            var num = 99;
            
            Assert.AreEqual(bsm.InjectedPMIncrement(num), 100);
        }
        
        [Test]
        public void test_base_scene_manager_uses_singleton_pm()
        {
            var num = 99;
            
            Assert.AreEqual(bsm.SingletonPMIncrement(num), 100);
        }
    }
}