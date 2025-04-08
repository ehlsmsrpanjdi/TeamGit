using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;

    public AudioClip lobbyMusic;
    public AudioClip gameMusic;

    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();  // 새로운 AudioSource 추가
            audioSource.loop = true;  // 음악 반복
            audioSource.playOnAwake = false; // 자동 재생 안 되게 설정

            // 씬 로딩 시마다 호출되는 이벤트에 함수 연결
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 씬이 로드될 때마다 호출되는 함수
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Lobby")  // 로비 씬 이름을 확인
        {
            PlayLobbyMusic();
        }
        else if (scene.name == "GameSceneName") // 게임 씬 이름을 확인
        {
            PlayGameMusic();
        }
    }

    public void PlayLobbyMusic()
    {
        PlayMusic(lobbyMusic);  // 로비 음악을 재생
    }

    public void PlayGameMusic()
    {
        PlayMusic(gameMusic);   // 게임 음악을 재생
    }

    private void PlayMusic(AudioClip clip)
    {
        // 이미 같은 음악이 재생되고 있으면 중복 재생하지 않도록
        if (audioSource.clip == clip && audioSource.isPlaying) return;

        audioSource.Stop();  // 기존 음악을 멈춤
        audioSource.clip = clip;
        audioSource.Play();  // 새 음악 재생
    }

    private void OnDestroy()
    {
        // 씬 로딩 이벤트를 해제
        SceneManager.sceneLoaded -= OnSceneLoaded; //로비 브금이 실행 안됐는데 이걸 넣으니 됐음
    }
}
