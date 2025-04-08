using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    public Button EndTxt;  // End ��ư ����

    // Start is called before the first frame update
    void Start()
    {
        if (EndTxt != null)
        {
            EndTxt.onClick.AddListener(OnClickEnd);  // End ��ư Ŭ�� �� ȣ��Ǵ� �޼���
        }
    }

    // End ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    void OnClickEnd()
    {
        GameInstance.Instance.BackToLobby();  // �κ�� ���ư��� �޼��� ȣ��
    }
}
