using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Player[] playerList;
    DeckGenerator deckGenerater;
    enum Phase
    {
        INIT,
        DRAW,
        STANDBY,
        BATTLE,
        END,
    };

    Phase phase;
    void Start()
    {
        deckGenerater = GetComponent<DeckGenerator>();
        phase = Phase.INIT;
    }
    void Update()
    {
        switch (phase)
        {
            case Phase.INIT:
                InitPhase();
                break;
            case Phase.DRAW:
                DrawPhase();
                break;
            case Phase.STANDBY:
                StandbyPhase();
                break;
            case Phase.BATTLE:
                BattlePhase();
                break;
            case Phase.END:
                EndPhase();
                break;
        }
    }
    //CardData(int _id, string _name, int _hp, int _at){

    List<CardData> player1CardDataList = new List<CardData>(){
        new CardData(0 ,"name0", 2, 1),
        new CardData(1 ,"name1", 1, 2),
        new CardData(2 ,"name2", 2, 3),
        new CardData(3 ,"name3", 1, 1),
        new CardData(4 ,"name4", 3, 1),
    };
    List<CardData> player2CardDataList = new List<CardData>(){
        new CardData(0 ,"name0", 2, 1),
        new CardData(1 ,"name1", 1, 2),
        new CardData(2 ,"name2", 2, 3),
        new CardData(3 ,"name3", 1, 1),
        new CardData(4 ,"name4", 3, 1),
    };

    Player currentPlayer;
    Player waitPlayer;
    void InitPhase()
    {
        Debug.Log("InitPhase");
        // デッキの生成
        deckGenerater.Generate(player1CardDataList, playerList[0].deck);
        deckGenerater.Generate(player2CardDataList, playerList[1].deck);

        // 現在のプレイヤー
        currentPlayer = playerList[0];
        waitPlayer = playerList[1];

        phase = Phase.DRAW;
    }
    void DrawPhase()
    {
        Debug.Log("DrawPhase");
        // カードのドロー
        currentPlayer.Draw();
        phase = Phase.STANDBY;
    }
    void StandbyPhase()
    {
        Debug.Log("StandbyPhase");
        // 手札のカードを場に出す
        currentPlayer.StandbyPhaseAction();
        phase = Phase.BATTLE;
    }
    void BattlePhase()
    {
        Debug.Log("BattlePhase");
        phase = Phase.END;
    }
    void EndPhase()
    {
        Debug.Log("EndPhase");
        //phase = Phase.DRAW;
    }
}