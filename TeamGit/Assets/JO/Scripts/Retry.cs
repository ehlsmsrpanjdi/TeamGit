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
        if (RetryButton == null)
        {
            Debug.LogError("RetryButton is not assigned!");
        }
        else
        {
            RetryButton.onClick.AddListener(OnClickRetry);
        }
    }

    void OnClickRetry()
    {
        GameInstance.Instance.GameStart();
    }
}
