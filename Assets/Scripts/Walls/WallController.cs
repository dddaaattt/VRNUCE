using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    public Material mat1;
    public Material mat2;

    private Renderer myRenderer;

    public bool isTransparent;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        SetGazedAt(false);
        isTransparent = false;
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (mat1 != null && mat2 != null)
        {
            if (isTransparent)
            {
                gazedAt = false;
            }
            myRenderer.material = gazedAt ? mat2 : mat1;
            isTransparent = !isTransparent;
            return;
        }

    }

    public void SetTransparent()
    {
        //gameObject.GetComponent<Renderer>().material.color.a = 0.5f;
        if (!isTransparent)
            myRenderer.material.color = new Color(1, 1, 1, 0);
        else
            myRenderer.material.color = new Color(1, 1, 1, 1);
        isTransparent = !isTransparent;
    }
}
