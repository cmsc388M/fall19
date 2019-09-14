using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestThing : MonoBehaviour {
    public float constant_forward_movement = 1.1f;
    public float lateral_movement = 0.055f;
    public bool paused = false;
    public GameObject pause_menu;
    // Start is called before the first frame update
    void Start() {
        pause_menu = GameObject.Find("Pause_Menu");

        pause_menu.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (!paused) {
            transform.Translate(0, 0, constant_forward_movement * Time.deltaTime);
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Translate(lateral_movement, 0, 0);

            }
            if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.Translate(-lateral_movement, 0, 0);

            }
            if (Input.GetKeyDown(KeyCode.Escape)) {
                print("escape pressed");
                pause_menu.SetActive(true);
                paused = true;
                print("inner paused:" + paused); //this will print true
            }
            print("paused:" + paused); //this is not be affected by the Esc code like it should :(
        }

        if (paused && Input.GetKeyDown(KeyCode.Escape)) {
            pause_menu.SetActive(false);
            paused = false;
        }
    }

}