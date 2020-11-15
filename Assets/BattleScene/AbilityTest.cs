using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityTest : Ability
{
    [SerializeField]
    int damage;

    public override void ApplyEffects(ICharacter caster, ICharacter target)
    {
        target.ApplyDamage(damage);
    }
}
