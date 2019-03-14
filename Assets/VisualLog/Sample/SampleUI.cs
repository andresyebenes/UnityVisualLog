using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleUI : MonoBehaviour
{
    public InputField messageInput;


    public void OnClickAddLog()
    {
        if (messageInput == null || string.IsNullOrEmpty(messageInput.text))
            return;

        VisualLog.instance.Log(messageInput.text);
        messageInput.text = "";
    }
}
