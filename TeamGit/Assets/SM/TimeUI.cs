using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text timeTxt;
    float time = 0.0f;

    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
    }
}
