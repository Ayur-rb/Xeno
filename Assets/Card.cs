using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*public class Card : MonoBehaviour
{
    public Text hpText;
    public int hp;
    string name;
    int at;

    public void Load(CardData _cardData)
    {
        hp = _cardData.hp;
        hpText.text = hp.ToString();
        name = _cardData.name;
        at = _cardData.at;
    }
    public void OnDamage(int _at)
    {
        hp -= _at;
        if (hp <= 0)
        {
            hp = 0;
        }
        Debug.Log(hp);
    }

    public void Attack(Player _player)
    {
        _player.OnDamage(at);
    }
    public void Attack(Card _card)
    {
        _card.OnDamage(at);
    }
}
*/




public class Card : MonoBehaviour
{
    public Text hpText;
    int hp;
    string name;
    int at;

    public void Load(CardData _cardData)
    {
        hp = _cardData.hp;
        hpText.text = hp.ToString();
        name = _cardData.name;
        at = _cardData.at;
    }
}


