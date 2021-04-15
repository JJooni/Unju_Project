using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walk_Check : MonoBehaviour
{
    int Walk_Count;
    public Text walk_ui;
    float tick = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Walk_Count = 0;
        tick = 0f; ;
    }

    // Update is called once per frame
    void Update()
    {
        if ( (Input.acceleration.x >= 1.4f || Input.acceleration.z >= 1.6f) && tick > 0.4f)
        {
            Walk_Count++;
            tick = 0;
        }
        tick += Time.deltaTime;
        UI_CHECK();
    }

    void UI_CHECK()
    {
        walk_ui.text = "걸음 수 : " + Walk_Count;
    }
}
