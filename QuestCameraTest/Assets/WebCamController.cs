using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamController : MonoBehaviour {

    int width = 1920;
    int height = 1080;
    int fps = 60;
    WebCamTexture webcamTexture;

    void Start () {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, this.width, this.height, this.fps);
        GetComponent<Renderer> ().material.mainTexture = webcamTexture;
        webcamTexture.Play();


    }
    /*
    void Update() {
        var width = Screen.width;
        var height = Screen.height;
        var tex = new Texture2D(width, height, TextureFormat.RGB24, false);

        //yield return new WaitForEndOfFrame();

        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);

        tex.Apply();
        //pngBytes = tex.EncodeToPNG();
    }*/
}