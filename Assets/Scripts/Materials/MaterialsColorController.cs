using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsColorController : MonoBehaviour
{
    public Material mat;

    public void ChangeTextureMaterial1()
    {
        mat.SetColor("_Color", Color.red);
    }

    public void ChangeTextureMaterial2()
    {
        mat.SetColor("_Color", Color.blue);
    }
}
