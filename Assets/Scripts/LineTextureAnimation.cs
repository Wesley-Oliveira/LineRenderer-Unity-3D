using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTextureAnimation : MonoBehaviour
{
    public float interval = 0.1f;
    public Texture[] textures;
    public Material lineMaterial;

    private float currentTime = 0f;
    private int currentTexture = 0;

    void Update()
    {
        if(textures != null && textures.Length > 0)
        {
            if (Time.time - currentTime > interval)
            {
                currentTexture++;

                if (currentTexture >= textures.Length)
                    currentTexture = 0;

                lineMaterial.SetTexture("_BaseMap", textures[currentTexture]);

                currentTime = Time.time;
            }
        }
    }
}
