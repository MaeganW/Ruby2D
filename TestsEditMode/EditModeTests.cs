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
    public class TestingGameBehaviors
    {
        
        // A Test behaves as an ordinary method
        [Test]
        public void HelloIsTrue()
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
        
        
        [Test]
        public void GameObject_CreatedWithGiven_WillHaveTheName()
        {
            var go = new GameObject("MyGameObject");
            Assert.AreEqual("MyGameObject", go.name);
        }

        [Test]
        public void test_string_equivalent()
        {
            string hello = "hello";
            Assert.IsTrue(hello.Equivalent("hello"));
        }

        [Test]
        public void test_manager_class_methods()
        {
            var cm = new ContentManager();
            var num = 99;
            
            Assert.AreEqual(cm.Increment(num), 100);
        }
        
        [Test]
        public void test_device_class_methods()
        {
            var cm = new ContentManager();
            var num = 99;
            
            Assert.AreEqual(cm.Increment(num), 100);
        }
        
        
//        [UnityTest]
//        public IEnumerator GameObject_WithRigidBody_WillBeAffectedByPhysics()
//        {
//            var go = new GameObject();
//            go.AddComponent<Rigidbody2D>();
//            var originalPosition = go.transform.position.y;
//
//            yield return new WaitForFixedUpdate();
//
//            Assert.AreNotEqual(originalPosition, go.transform.position.y);
//        }
        
        
//        [Test]
//        [UnityPlatform (RuntimePlatform.WindowsPlayer)]
//        public void TestPlayMode()
//        {
//            Assert.AreEqual(Application.platform, RuntimePlatform.WindowsPlayer);
//        }
//        
//
//        [Test]
//        [UnityPlatform(exclude = new[] {RuntimePlatform.WindowsEditor })]
//        public void TestEditMode()
//        {
//            Assert.AreNotEqual(Application.platform, RuntimePlatform.WindowsEditor);
//        }

    }
}
