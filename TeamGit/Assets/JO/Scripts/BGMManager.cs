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
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.loop = true;
            audioSource.playOnAwake = false;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayLobbyMusic()
    {
        PlayMusic(lobbyMusic);
    }

    public void PlayGameMusic()
    {
        PlayMusic(gameMusic);
    }

    private void PlayMusic(AudioClip clip)
    {
        if (audioSource.clip == clip) return; // 같은 음악이면 무시
        audioSource.clip = clip;
        audioSource.Play();
    }
}
