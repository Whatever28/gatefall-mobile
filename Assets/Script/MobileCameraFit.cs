using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MobileCameraFit : MonoBehaviour
{
    void OnPreCull()
    {
        if(Screen.height>0) GetComponent<Camera>().orthographicSize=Mathf.Max(6f,10f*Screen.height/Screen.width);
    }
}
