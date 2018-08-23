using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum PhotoFrom
{
    Album,
    Camera,
}

public abstract class ImagePicker
{

    Action<string> TextureCreatedCallback;

    protected abstract void ShowAlbum();

    protected abstract void ShowCamera();

    public void GetTexture(PhotoFrom type, Action<string> callback)
    {

    }

}
