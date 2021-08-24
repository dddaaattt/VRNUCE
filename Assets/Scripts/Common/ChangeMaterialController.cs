using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialController : MonoBehaviour
{
    public Material[] materials;
    private Renderer myRenderer;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        ChangeMaterial(0);
    }

    public void ChangeMaterial(int materialIndex)
    {
        myRenderer.material = materials[materialIndex];
    }
}
