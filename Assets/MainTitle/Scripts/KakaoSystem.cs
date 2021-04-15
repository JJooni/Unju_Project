using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakaoSystem : MonoBehaviour
{
    AndroidJavaObject ajo;
    // Start is called before the first frame update
    private void Start()
    {
        ajo = new AndroidJavaObject("com.DefaultCompany.UnjuMap.Ukakao");
    }

    public void login()
    {
        ajo.Call("KakaoLogin");
    }
}
