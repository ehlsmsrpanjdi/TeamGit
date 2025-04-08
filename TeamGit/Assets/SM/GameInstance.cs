using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{

    public static GameInstance Instance = null; //�̱��� �ν��Ͻ�

    public string PlayLevel;
    public string LobbyLevel;

    public float gameVolume = 1.0f; //���� ����

    public float GameVolume
    {
        get { return gameVolume; }
        set
        {
            gameVolume = value;
            AudioListener.volume = gameVolume; //���� ���� ����
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (GameInstance.Instance == null)
        {
            GameInstance.Instance = this;
            DontDestroyOnLoad(this.gameObject); //�� ��ȯ �� ������Ʈ ����
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene(PlayLevel); //���� �� �ε�
    }

    public void BackToLobby()
    {
        SceneManager.LoadScene(LobbyLevel); //�κ� �� �ε�
    }

    public void GameEnd()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {

    }
}
