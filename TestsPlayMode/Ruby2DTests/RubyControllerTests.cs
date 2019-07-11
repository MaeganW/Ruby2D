using System;
using System.Collections;
using Managers;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine.TestTools.NUnitExtensions;

namespace Tests
{
    public class RubyControllerTests
    { 
        private RubyController rb = new RubyController();

//        private RubyController GetRubyMock()
//        {
//            return Substitute
//        }
        
        [Test]
        public void test_ruby_ctrl_class_methods()
        {
            var num = 99;
            
            Assert.AreEqual(rb.Increment(num), 100);
        }
        
        [Test]
        public void test_ruby_ctrl_uses_injected_cm()
        {
            var num = 99;
            
            Assert.AreEqual(rb.InjectedCMIncrement(num), 100);
        }
    }
}