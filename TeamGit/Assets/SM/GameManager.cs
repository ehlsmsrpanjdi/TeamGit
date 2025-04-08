using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public Card firstCard;
    public Card secondCard;

    public GameObject RetryTxt;
    public GameObject EndTxt;


    public int cardCount = 0; //ī�� ����

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance == null)
        {
            GameManager.Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        Time.timeScale = 1.0f; //���� ���� �� �ð� ������ �ʱ�ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void checkMatched()
    {
        if (firstCard.idx == secondCard.idx)
        {
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2; //ī�� ���� ����
            if(cardCount == 0)
            {
                Time.timeScale = 0.0f; //���� ����
                RetryTxt.SetActive(true);
                EndTxt.SetActive(true);
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
        }

        firstCard = null;
        secondCard = null;
    }
}
