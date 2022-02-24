using System.Collections;
using Helpers;
using UnityEngine;

public class MaterialColorController : MonoBehaviour
{
    [SerializeField]Material material;

    public void SetMaterialColorToRandomColor()
    {
        SetMaterialColor(ColorHelper.GetRandomColor());
    }

    void SetMaterialColor(Color color)
    {
        material.SetColor("_Color", color);
    }
}
