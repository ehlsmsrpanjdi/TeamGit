using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private Button MyButton;
    // Start is called before the first frame update
    void Start()
    {
        MyButton = GetComponent<Button>();
        MyButton.onClick.AddListener(GameInstance.Instance.GameEnd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
