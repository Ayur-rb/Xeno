using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class CardData
{
    public int id;
    public string name;
    public int hp;
    public int at;
    public CardData(int _id, string _name, int _hp, int _at)
    {
        id = _id;
        name = _name;
        hp = _hp;
        at = _at;
    }
}