using UnityEngine;
using System.Collections;
using System;

public class Test : MonoBehaviour
{
    public TextureFormat textureFormat;

    void Start()
    {
        var tex = new Texture2D(4, 1, textureFormat, false);
        tex.filterMode = FilterMode.Point;
        tex.wrapMode = TextureWrapMode.Clamp;

        Byte[] data = {
            0xff, 0, 0, 0,
            0, 0xff, 0, 0,
            0, 0, 0xff, 0,
            0, 0, 0, 0xff
        };

        tex.LoadRawTextureData(data);
        tex.Apply();

        GetComponent<Renderer>().material.mainTexture = tex;
    }
}
