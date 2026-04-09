// EntityData.cs
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dungeon2/EntityData")]
public class EntityData : ScriptableObject
{
    public string EntityName;
    public int MaxHp;
    public Dictionary<string, float> BaseStats = new()
    {
        { "strength",     10 },
        { "agility",      10 },
        { "intelligence", 10 },
        { "vitality",     10 },
        { "luck",          5 },
        { "speed",        10 }
    };
}
