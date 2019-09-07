using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadSingleton : MonoBehaviour {

    private static DontDestroyOnLoadSingleton instance;

    void Awake() {
        if (instance == null) {
            DontDestroyOnLoad(gameObject);
            instance = this; 
        } else {
            Destroy(gameObject);
        }

        
    }

}
