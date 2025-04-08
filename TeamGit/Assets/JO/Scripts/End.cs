using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    public Button EndTxt;  // End 버튼 참조

    // Start is called before the first frame update
    void Start()
    {
        if (EndTxt != null)
        {
            EndTxt.onClick.AddListener(OnClickEnd);  // End 버튼 클릭 시 호출되는 메서드
        }
    }

    // End 버튼 클릭 시 호출되는 메서드
    void OnClickEnd()
    {
        GameInstance.Instance.BackToLobby();  // 로비로 돌아가는 메서드 호출
    }
}
