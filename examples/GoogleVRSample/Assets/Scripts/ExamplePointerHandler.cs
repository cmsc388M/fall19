using UnityEngine;
using UnityEngine.EventSystems;

//This class implements the pointerEvent interfaces, which means that it can respond to when pointers interact with it
public class ExamplePointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.blue;
    }

    //This event happens when the pointer enters the object, similar to oncollisionenter
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {
        Debug.Log("Enter");
        meshRenderer.material.color = Color.red;
    }

    //This event happens when the pointer exits the object, similar to oncollisionexit
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {
        Debug.Log("Exit");
        meshRenderer.material.color = Color.blue;
    }

    //This event happens when the pointer is touching the object and the click button is initially pressed
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {
        Debug.Log("Down");
        meshRenderer.material.color = Color.green;

        Debug.Log("Pointer is currently at: " + eventData.pointerPressRaycast.worldPosition.ToString());
    }

    //This event happens when the pointer is touching the object and the click button is released
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {
        Debug.Log("Released");
        meshRenderer.material.color = Color.yellow;
    }
}