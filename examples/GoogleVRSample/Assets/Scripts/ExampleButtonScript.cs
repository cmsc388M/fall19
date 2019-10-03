using UnityEngine;

public class ExampleButtonScript : MonoBehaviour
{
    public GameObject text;

    public void ToggleText() {
        text.SetActive(!text.activeInHierarchy);
    }
}