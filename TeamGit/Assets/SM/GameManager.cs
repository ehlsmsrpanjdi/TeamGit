using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public Card firstCard;
    public Card secondCard;

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
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void checkMatched()
    {
        //if (firstCard.index == secondCard.index)
        
            //firstCard.DestroyCard();
            //secondCard.DestroyCard();
        
        
       
            firstCard.CloseCard();
            secondCard.CloseCard();
       

        firstCard = null;
        secondCard = null;
    }
}
