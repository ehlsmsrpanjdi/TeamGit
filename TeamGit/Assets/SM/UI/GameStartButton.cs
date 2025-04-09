using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Button MyButton;
    // Start is called before the first frame update
    void Start()
    {
        MyButton = GetComponent<Button>();
        MyButton.onClick.AddListener(GameInstance.Instance.GameStart);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
