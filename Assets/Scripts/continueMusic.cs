using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] MusicObj = GameObject.FindGameObjectsWithTag("music");
        if( MusicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
