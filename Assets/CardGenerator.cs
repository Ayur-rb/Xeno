using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardGenerator : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject[] Hands;
    public Sprite[] cardImages; 

    private void Start()
    {
        for (int i = 0; i < Hands.Length; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject cardObj = Instantiate(cardPrefab);
                int index = Random.Range(0, cardImages.Length);
                cardObj.GetComponent<Image>().sprite = cardImages[index];
                cardObj.transform.SetParent(Hands[i].transform, false);
            }
        }
    }

}
