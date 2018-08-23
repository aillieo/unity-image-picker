using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePickerAndroid : ImagePicker
{

    protected override void ShowAlbum()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("TakePhoto", "album");
    }

    protected override void ShowCamera()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("TakePhoto", "camera");
    }

}
