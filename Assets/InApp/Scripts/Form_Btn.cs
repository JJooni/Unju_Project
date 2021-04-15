using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Form_Btn : MonoBehaviour
{
    public Sprite on_Btn;
    public Sprite off_Btn;

    public void OnBtn()
    {
        if (gameObject.GetComponent<Image>().sprite == on_Btn)
        {
            gameObject.GetComponent<Image>().sprite = off_Btn;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = on_Btn;
        }
    }



}
