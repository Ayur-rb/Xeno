using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Player : MonoBehaviour
    {
       /* int hp = 100;
        public Deck deck;
        public Hand hand;
        public Field field;
        public Graveyard graveyard;

        public void OnDamage(int _at)
        {
            hp -= _at;
            if (hp <= 0)
            {
                hp = 0;
            }
            Debug.Log(hp);
        }
        public void Draw()
        {
            Card card = deck.Pull(0);
            hand.Add(card);
        }
        public void StandbyPhaseAction()
        {
            Card card = hand.Pull(0);
            field.Add(card);
        }
        public void BattlePhaseAction(Player _enemyPlayer)
        {
            Card card = SelectAttacker();
            if (card == null)
            {
                return;
            }
            if (_enemyPlayer.field.cardList.Count > 0)
            {
                Card enemyCard = SelectTarget(_enemyPlayer.field);
                card.Attack(enemyCard);
            }
            else
            {
                card.Attack(_enemyPlayer);
            }
        }
        public void CheckFieldCardHP()
        {
            for (int i = 0; i < field.cardList.Count; i++)
            {
                Card card = field.cardList[i];
                if (card.hp <= 0)
                {
                    SendGraveyard(card);
                }
            }
        }
        void SendGraveyard(Card _card)
        {
            field.Pull(_card);
            graveyard.Add(_card);
        }


        Card SelectAttacker()
        {
            return field.Get(0);
        }
        Card SelectTarget(Field _enemyField)
        {
            return _enemyField.Get(0);
        }
    }

}
*/



    public Deck deck;
    public Hand hand;
    public Field field;
    public Graveyard graveyard;

    public void Draw()
    {
        Card card = deck.Pull(0);
        hand.Add(card);
    }
    public void StandbyPhaseAction()
    {
        Card card = hand.Pull(0);
        field.Add(card);
    }

}

  