using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ICharacter : MonoBehaviour
{
    public int hp;
    public int hpMax;

    Ability[] abilities;

    public UnityEvent<int> onHealthModified;
    public UnityEvent onTurnBegins;
    public UnityEvent onTurnEnds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTurnBegins()
    {
        onTurnBegins.Invoke();
    }

    public void OnTurnEnds()
    {
        onTurnEnds.Invoke();
    }

    public void ApplyDamage(int baseDamage)
    {
        int damage = baseDamage;
        hp -= baseDamage;
        onHealthModified.Invoke(damage);
    }

    public void ApplyHealing(int baseDamage)
    {

    }

    public void PassTurn()
    {

    }
}
