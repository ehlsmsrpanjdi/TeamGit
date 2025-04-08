using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx;

    public GameObject front;        //ī�� �ո� �̹��� ������Ʈ
    public GameObject back;         //ī�� �޸� �̹��� ������Ʈ

    public Animator anim;           //ī�� ������ �ִϸ��̼�

    public SpriteRenderer frontImage; //ī�� �ո� �̹��� ��������Ʈ ������


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Setting(int number)
    {
        idx = number; //ī���� �ε��� ����
        frontImage.sprite = Resources.Load<Sprite>("Card/" + number); //ī�� �ո� �̹��� ����
    }

    public void OpenCard()
    {
        anim.SetBool("Open", true); //ī�� �ִϸ��̼� ����
        front.SetActive(true); //ī�� �ո� Ȱ��ȭ
        back.SetActive(false); //ī�� �޸� ��Ȱ��ȭ

        if (GameManager.Instance.firstCard == null)
        {
            GameManager.Instance.firstCard = this; //ù ��° ī�� ����
        }
        else
        {
            GameManager.Instance.secondCard = this; //�� ��° ī�� ����
            //gamemanager.instance.matched(); //�ι�° ī����� ������ ��Ī Ȯ��
        }
    }

    public void DestroyCard() // ī�� �ı�
    {
        Invoke("DestroyCardInvoke", 0.5f); //0.5�� �� ī�� �ı�
    }
    void DestroyCardInvoke()
    {
        Destroy(gameObject); //ī�� ������Ʈ �ı�
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 0.5f); //0.5�� �� ī�� �ݱ�
    }

    public void CloseCardInvoke()
    {
        anim.SetBool("Open", false); //ī�� �ִϸ��̼� ����
        front.SetActive(false); //ī�� �ո� ��Ȱ��ȭ
        back.SetActive(true); //ī�� �޸� Ȱ��ȭ
    }
}
