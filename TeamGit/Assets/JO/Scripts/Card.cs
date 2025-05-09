using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx;

    public GameObject front;        //카드 앞면 이미지 오브젝트
    public GameObject back;         //카드 뒷면 이미지 오브젝트

    public Animator anim;           //카드 뒤집기 애니메이션

    public SpriteRenderer frontImage; //카드 앞면 이미지 스프라이트 렌더러

    AudioSource audioSource; //오디오 소스
    public AudioClip clip; //카드 뒤집기 소리


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //오디오 소스 컴포넌트 가져오기
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Setting(int number)
    {
        idx = number; //카드의 인덱스 설정
        frontImage.sprite = Resources.Load<Sprite>($"JO{idx}"); //카드 앞면 이미지 설정
    }

    public void OpenCard()
    {
       
        audioSource.PlayOneShot(clip); //카드 뒤집기 소리 재생
        anim.SetBool("Open", true); //카드 애니메이션 실행
        front.SetActive(true); //카드 앞면 활성화
        back.SetActive(false); //카드 뒷면 비활성화

        if (GameManager.Instance.firstCard == null)
        {
            GameManager.Instance.firstCard = this; //첫 번째 카드 설정
        }
        else
        {
            GameManager.Instance.secondCard = this; //두 번째 카드 설정
            GameManager.Instance.checkMatched(); //두번째 카드까지 열리면 매칭 확인
        }
    }

    public void DestroyCard() // 카드 파괴
    {
        Invoke("DestroyCardInvoke", 0.5f); //0.5초 후 카드 파괴
    }
    void DestroyCardInvoke()
    {
        Destroy(gameObject); //카드 오브젝트 파괴
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 0.5f); //0.5초 후 카드 닫기
    }

    public void CloseCardInvoke()
    {
        anim.SetBool("Open", false); //카드 애니메이션 실행
        front.SetActive(false); //카드 앞면 비활성화
        back.SetActive(true); //카드 뒷면 활성화
    }
}
