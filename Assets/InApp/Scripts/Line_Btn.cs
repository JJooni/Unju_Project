using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Btn : MonoBehaviour
{
    public GameObject Form;
    public Animator ani;


    public void Btn()
    {
        Form.SetActive(true);
    }

    public void Exit_Btn()
    {
        ani.SetTrigger("Off");
        StartCoroutine(Off());
    }

    IEnumerator Off()
    {
        yield return new WaitForSeconds(0.2f);
        Form.SetActive(false);
    }
}
