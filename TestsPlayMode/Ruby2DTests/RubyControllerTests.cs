using System;
using System.Collections;
using Managers;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Tests
{
    public class RubyControllerTests
    {
        [Test]
        public void test_ruby_ctrl_uses_injected_cm()
        {
            var cm = new ContentManager();
            var num = 99;
            
            Assert.AreEqual(cm.Increment(num), 100);
        }
    }
}