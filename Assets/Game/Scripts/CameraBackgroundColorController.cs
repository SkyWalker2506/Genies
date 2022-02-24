using UnityEngine;
using Helpers;

public class CameraBackgroundColorController : MonoBehaviour
{
    public void SetMainCameraBackgroundColorToRandomColor()
    {
        SetCameraBackgroundColorToRandomColor(Camera.main);
    }

    void SetCameraBackgroundColorToRandomColor(Camera camera)
    {
        SetCameraBackgroundColor(camera, ColorHelper.GetRandomColor());
    }

    void SetCameraBackgroundColor(Camera camera,Color color)
    {
        camera.backgroundColor = color;
    }
}