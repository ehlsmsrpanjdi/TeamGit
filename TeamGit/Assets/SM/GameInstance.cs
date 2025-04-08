using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{

    public static GameInstance Instance = null; //싱글톤 인스턴스

    public string PlayLevel;
    public string LobbyLevel;

    public float gameVolume = 1.0f; //게임 볼륨

    public float GameVolume
    {
        get { return gameVolume; }
        set
        {
            gameVolume = value;
            AudioListener.volume = gameVolume; //게임 볼륨 설정
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (GameInstance.Instance == null)
        {
            GameInstance.Instance = this;
            DontDestroyOnLoad(this.gameObject); //씬 전환 시 오브젝트 유지
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene(PlayLevel); //게임 씬 로드
    }

    public void BackToLobby()
    {
        SceneManager.LoadScene(LobbyLevel); //로비 씬 로드
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
