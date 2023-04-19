using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText; // Reference to the TextMeshProUGUI object

    private float deltaTime; // Time elapsed since last frame
    private float fps; // Frames per second

    void Update()
    {
        // Calculate the frames per second
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        fps = 1.0f / deltaTime;

        // Update the text mesh pro with the fps value
        fpsText.text = "FPS: " + Mathf.RoundToInt(fps).ToString();
    }
}