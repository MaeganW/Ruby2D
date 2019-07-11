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
        [Test]
        public void test_content_manager_class_methods()
        {
            var cm = new ContentManager();
            var num = 99;
            
            Assert.AreEqual(cm.Increment(num), 100);
        }
    }
}
