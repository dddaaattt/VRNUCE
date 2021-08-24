using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsController : MonoBehaviour
{
    //Set these Textures in the Inspector
    public Texture AdobeTexture1;
    public Texture NormalTexture1;

    public Texture AdobeTexture2;
    public Texture NormalTexture2;

    //public Texture AdobeTexture3;
    //public Texture NormalTexture3;

    public Material mat;
  
    public void ChangeTextureMaterial1()
    {
        mat.SetTexture("_MainTex", AdobeTexture1);
        mat.SetTexture("_BumpMap", NormalTexture1);
    }

    public void ChangeTextureMaterial2()
    {
        mat.SetTexture("_MainTex", AdobeTexture2);
        mat.SetTexture("_BumpMap", NormalTexture2);
    }
}
