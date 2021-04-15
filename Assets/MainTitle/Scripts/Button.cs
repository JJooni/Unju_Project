using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    enum SceneList
    {
        Guset = 0,
        Kakao,
        Google,
    }
    public void onClickedLoginButton(int idx)
    {
        switch(idx)
        {
            case (int)SceneList.Guset:
                SceneManager.LoadScene("InApp");
            break;
            case (int)SceneList.Google:
                Debug.Log("Google");
            break;
            case (int)SceneList.Kakao:
                Debug.Log("Kakao");
            break;
        }
    }
}
