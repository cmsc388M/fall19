using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPortal : MonoBehaviour
{
    [SerializeField]
    private LevelSwitcher levelSwitcher;

    [SerializeField]
    private float turnRate = 3f;


    public void OnCollisionEnter(Collision col) {
        if (col.transform.tag == "Player") {
            levelSwitcher.GoToGameOver();
        }
    }

    public void Update() {
        transform.Rotate(0, turnRate * Time.deltaTime, 0);
    }

}
