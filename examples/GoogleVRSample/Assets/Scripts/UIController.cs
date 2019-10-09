using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject textObject;

    public void ToggleText() {
        textObject.SetActive(!textObject.activeInHierarchy);
    }
}