using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanel : MonoBehaviour
{

    public GameObject GamePanel;
    public GameObject SoundPanel;


    static public MainPanel instance = null;
    // Start is called before the first frame update

    private void Awake()
    {
        if (MainPanel.instance == null)
        {
            MainPanel.instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

    }

    public void OnClickGamePanel()
    {
        GamePanel.SetActive(true);
        SoundPanel.SetActive(false);
    }

    public void OnClickSoundPanel()
    {
        GamePanel.SetActive(false);
        SoundPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
