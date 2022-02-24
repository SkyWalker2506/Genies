using System.Collections;
using Helpers;
using UnityEngine;

public class SkinnedMeshMaterialColorController : MonoBehaviour
{
    [SerializeField]SkinnedMeshRenderer skinnedMeshRenderer;

    public void SetMaterialColorToRandomColor()
    {
        SetMaterialColor(ColorHelper.GetRandomColor());
    }

    void SetMaterialColor(Color color)
    {
        skinnedMeshRenderer.material.SetColor("_Color", color);
    }
}
