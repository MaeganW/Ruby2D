using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Util;

namespace Tests
{
    public class PlayModeTests
    {
        [Test]
        [UnityPlatform(exclude = new[] {RuntimePlatform.WindowsEditor })]
        public void TestEditMode()
        {
            Assert.AreNotEqual(Application.platform, RuntimePlatform.WindowsEditor);
        }
        
        
        [Test]
        public void PlayModeTestsSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        
        [UnityTest]
        public IEnumerator PlayModeTestsWithEnumeratorPasses()
        {
            yield return null;
        }
        

        [Test]
        public void test_Util_Equivalent_in_play_mode()
        {
            string hello = "hello";
            Assert.IsTrue(hello.Equivalent("hello"));
        }
        
        
        [UnityTest]
        public IEnumerator GameObject_WithRigidBody_WillBeAffectedByPhysics()
        {
            var go = new GameObject();
            go.AddComponent<Rigidbody2D>();
            var originalPosition = go.transform.position.y;

            yield return new WaitForFixedUpdate();

            Assert.AreNotEqual(originalPosition, go.transform.position.y);
        }
        
        
    }
    
//    public class PlatformDefines : MonoBehaviour {
//        void Start () {
//
//    #if UNITY_EDITOR
//            Debug.Log("Unity Editor");
//    #endif
//        
//    #if UNITY_IOS
//          Debug.Log("Iphone");
//    #endif
//
//    #if UNITY_STANDALONE_OSX
//                Debug.Log("Stand Alone OSX");
//    #endif
//
//    #if UNITY_STANDALONE_WIN
//          Debug.Log("Stand Alone Windows");
//    #endif
//
//        }          
//    }
}
