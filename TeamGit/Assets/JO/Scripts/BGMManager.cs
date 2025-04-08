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
            audioSource = gameObject.AddComponent<AudioSource>();  // ���ο� AudioSource �߰�
            audioSource.loop = true;  // ���� �ݺ�
            audioSource.playOnAwake = false; // �ڵ� ��� �� �ǰ� ����

            // �� �ε� �ø��� ȣ��Ǵ� �̺�Ʈ�� �Լ� ����
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ���� �ε�� ������ ȣ��Ǵ� �Լ�
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Lobby")  // �κ� �� �̸��� Ȯ��
        {
            PlayLobbyMusic();
        }
        else if (scene.name == "GameSceneName") // ���� �� �̸��� Ȯ��
        {
            PlayGameMusic();
        }
    }

    public void PlayLobbyMusic()
    {
        PlayMusic(lobbyMusic);  // �κ� ������ ���
    }

    public void PlayGameMusic()
    {
        PlayMusic(gameMusic);   // ���� ������ ���
    }

    private void PlayMusic(AudioClip clip)
    {
        // �̹� ���� ������ ����ǰ� ������ �ߺ� ������� �ʵ���
        if (audioSource.clip == clip && audioSource.isPlaying) return;

        audioSource.Stop();  // ���� ������ ����
        audioSource.clip = clip;
        audioSource.Play();  // �� ���� ���
    }

    private void OnDestroy()
    {
        // �� �ε� �̺�Ʈ�� ����
        SceneManager.sceneLoaded -= OnSceneLoaded; //�κ� ����� ���� �ȵƴµ� �̰� ������ ����
    }
}
