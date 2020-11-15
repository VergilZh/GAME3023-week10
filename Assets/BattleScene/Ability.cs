using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "ScriptableObjects/Ablilties", order = 1)]
public abstract class Ability : ScriptableObject
{
    public abstract void ApplyEffects(ICharacter caster, ICharacter target);
}
