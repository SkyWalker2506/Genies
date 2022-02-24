using UnityEngine;
public class CameraBackgroundColorController : MonoBehaviour
{
    public void SetMainCameraBackgroundColorToRandomColor()
    {
        SetCameraBackgroundColorToRandomColor(Camera.main);
    }

    void SetCameraBackgroundColorToRandomColor(Camera camera)
    {
        var color = new Color(Random.value, Random.value, Random.value);
        SetCameraBackgroundColor(camera, color);
    }

    void SetCameraBackgroundColor(Camera camera,Color color)
    {
        camera.backgroundColor = color;
    }
}