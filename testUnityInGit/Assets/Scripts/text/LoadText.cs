using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class LoadText : MonoBehaviour
{
    string text01 = "";

    void Start()
    {
        // TextAsset txt = Resources.Load("test01") as TextAsset;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            TextAsset txt = Resources.Load("test01") as TextAsset;
            text01 = txt.text;
            ShowTextMessage();
        }
    }

    void ShowTextMessage()
    {
        Debug.Log("text01 message is: " + text01);
    }
}
