using System.Collections;
using System.IO;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour
{

    //private int shotIndex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        string name = "Screenshot_S-Troupe_FunRun" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        //PC 
        //byte[] bytes = texture.EncodeToPNG();

        //Destroy(texture);
        //File.WriteAllBytes(Application.dataPath + "/../" + name, bytes);

        NativeGallery.SaveImageToGallery(texture, "S-Troupe-App", name);
    }

    public void GetScreenshot()
    {
        StartCoroutine("Screenshot");
    }
}