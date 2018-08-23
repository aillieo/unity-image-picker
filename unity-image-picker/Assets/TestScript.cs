using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{

    public Image image;
    Texture texture;

    ImagePicker imagePicker;


    void Start()
    {
#if UNITY_ANDROID
        imagePicker = new ImagePickerAndroid();        
#elif UNITY_IPHONE
        imagePicker = new ImagePickeriOS();
#endif
    }

    void OnMessageTextureCreated(string str)
    {
        StartCoroutine(LoadTexture(str));
    }


    IEnumerator LoadTexture(string name)
    {
        string path = "file://" + Application.persistentDataPath + "/" + name;
        WWW www = new WWW(path);
        yield return www;
        texture = www.texture;
    }

    public void OnButtonAlbum()
    {
        if(imagePicker != null)
        {
            imagePicker.GetTexture(PhotoFrom.Album, OnMessageTextureCreated);
        }
    }

    public void OnButtonCamera()
    {
        if (imagePicker != null)
        {
            imagePicker.GetTexture(PhotoFrom.Camera, OnMessageTextureCreated);
        }
    }


}
