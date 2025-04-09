using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class SettingButtons : MonoBehaviour
{
    // Start is called before the first frame update
    private Button MyButton;
    // Start is called before the first frame update
    void Start()
    {
        MyButton = GetComponent<Button>();
        if(MainPanel.instance == null)
        {
            int a = 0;
        }
        MyButton.onClick.AddListener(MainPanel.instance.OnClickSoundPanel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
