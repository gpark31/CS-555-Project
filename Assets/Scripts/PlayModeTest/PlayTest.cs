using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;


public class PlayTest
{
    [UnityTest]
    public IEnumerator PlayTestWithEnumeratorPasses(){

        //Assert.AreEqual(SceneManager.GetSceneByName("MainPage"), true);
        yield return null;
    }
}
