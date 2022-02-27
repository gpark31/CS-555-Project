using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


    
public class NewTestScript{
    
    // A Test behaves as an ordinary method
    [Test]
    public static void Test()
    {
        Assert.AreEqual(1, 1);
       // Assert.AreEqual(SceneManager.GetSceneByName("MainPage"), true);

    }
}
