using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;
using Util;
using Managers;

namespace Tests
{
    
    public class TypeTests
    {
        
        [Test]
        public void TrueIsTrue()
        {
            bool hello = true;
            
            Assert.AreEqual(hello, true);
        }
        

        [Test]
        public void MathIsReal()
        {
            Assert.AreEqual(4, 2+2);
            Assert.That(2+2, Is.EqualTo(4));
        }
        

        [Test]
        public void ArrayCanBeTested()
        {
            int[] array = new int[] {1, 2, 3};
            
            Assert.That(array, Has.Exactly(1).EqualTo(3));
            Assert.That(array, Has.Exactly(2).GreaterThan(1));
            Assert.That(array, Has.Exactly(3).LessThan(100));
        }
        
//        [Test]
//        [UnityPlatform (RuntimePlatform.WindowsPlayer)]
//        public void TestPlayMode()
//        {
//            Assert.AreEqual(Application.platform, RuntimePlatform.WindowsPlayer);
//        }
        
    }
}
