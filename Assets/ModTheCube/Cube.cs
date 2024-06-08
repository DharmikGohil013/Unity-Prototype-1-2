using UnityEngine;

public class Cube : MonoBehaviour
{
    // Public variables to control cube behavior from Unity Editor
    public Vector3 initialPosition = new Vector3(3, 4, 1);
    public Vector3 scaleMultiplier = Vector3.one * 1.3f;
    public float rotationSpeed = 10.0f;
    public Color materialColor = new Color(0.5f, 1.0f, 0.3f, 0.4f);

    public MeshRenderer Renderer;

    void Start()
    {
        // Setting initial position and scale
        transform.position = initialPosition;
        transform.localScale = scaleMultiplier;

        // Check if Renderer is assigned
        if (Renderer != null)
        {
            // Accessing the material of the Renderer
            Material material = Renderer.material;

            // Changing the color of the material
            material.color = materialColor;
        }
        else
        {
            Debug.LogError("Renderer not assigned to the Cube script.");
        }
    }

    void Update()
    {
        // Rotating the cube around its x-axis
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
