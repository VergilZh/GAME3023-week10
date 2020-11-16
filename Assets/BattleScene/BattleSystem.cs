using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum Phase
{ 
    PlayerPhase,
    EnemyPhase
}

public class BattleSystem : MonoBehaviour
{
    [SerializeField]
    ICharacter[] characters = new ICharacter[2];
    [SerializeField]
    Phase Currentphase = Phase.PlayerPhase;
    [SerializeField]
    TMPro.TextMeshProUGUI CombatText;
    private void Start()
    {
        NextTurn();
    }
    private void Update()
    {
        
    }
    public void NextTurn()
    {
        characters[(int)Currentphase].OnTurnEnds();
        Currentphase = (Phase)(((int)Currentphase + 1)%2);
        characters[(int)Currentphase].OnTurnBegins();
        //StartCoroutine(AnimateTextLog(characters[(int)Currentphase].gameObject.name));
        StartCoroutine(AnimateTextLog(characters[(int)Currentphase].gameObject.name));
        Debug.Log("Turn passed");
    }

    IEnumerator AnimateTextLog(string message)
    {
        //CombatText.text = message;
        string currentText = "";
        for(int i = 0; i < message.Length; i++)
        {
            currentText += message[i];
            CombatText.text = currentText;
            yield return new WaitForSeconds(0.1f);
        }
    }

}
