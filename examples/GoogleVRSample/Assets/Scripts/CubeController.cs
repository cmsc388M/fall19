using UnityEngine;

// This class defines public methods for changing the cube's color,
// which are then called by the event triggers.
public class CubeController : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        MakeCubeBlue();
    }

    public void MakeCubeRed()
    {
        meshRenderer.material.color = Color.red;
    }

    public void MakeCubeBlue()
    {
        meshRenderer.material.color = Color.blue;
    }

    public void MakeCubeGreen()
    {
        meshRenderer.material.color = Color.green;
    }
    public void MakeCubeYellow()
    {
        meshRenderer.material.color = Color.yellow;
    }

    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play();
    }
}