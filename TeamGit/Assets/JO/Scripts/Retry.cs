using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Retry : MonoBehaviour
{
    public Button RetryButton;


    // Start is called before the first frame update
    void Start()
    {
        RetryButton.onClick.AddListener(OnClickRetry);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnClickRetry()
    {
        GameInstance.Instance.GameStart();
    }
}
