using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;

public class LoadText : MonoBehaviour
{
    string text01 = "";
    StringBuilder text02;
    string fileName;
    string[] strs;

    void Start()
    {
        // TextAsset txt = Resources.Load("test01") as TextAsset;
        fileName = "G:\\Vampire\\GitHubProjects\\testUnityProjectInGitHubDesktop\\text02.txt";
        text02 = new StringBuilder();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            TextAsset txt = Resources.Load("text/test01") as TextAsset;
            text01 = txt.text;
            ShowTextMessage(text01);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ReadFile(fileName);
            ShowTextMessage(text02.ToString());
        }
    }

    void ShowTextMessage(string msg)
    {
        Debug.Log("message is: " + msg);
    }

    void ReadFile(string fileName)
    {
        text02.Clear();
        strs = File.ReadAllLines(fileName);
        for(int i = 0;i < strs.Length; ++i)
        {
            text02.Append(strs[i]);
            text02.Append("\n");
        }
    }
}
