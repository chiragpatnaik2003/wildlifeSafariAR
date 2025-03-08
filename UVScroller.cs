using UnityEngine;

public class UVScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Speed of the waterfall animation
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>(); // Get the Renderer component
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed; // Calculate the offset
        rend.material.SetTextureOffset("Watertex", new Vector2(0, offset)); // Scroll the texture
    }
}