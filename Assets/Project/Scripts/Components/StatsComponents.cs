// StatsComponents.cs
using System;
using System.Collections.Generic;
using UnityEngine;

public class StatsComponent : MonoBehaviour
{
    public event Action<string, float, float> OnStatChanged;

    private Dictionary<string, float> baseStats = new()
    {
        { "strength",     10 },
        { "agility",      10 },
        { "intelligence", 10 },
        { "vitality",     10 },
        { "luck",          5 },
        { "speed",        10 }
    };

    private List<StatModifier> modifiers = new();

    public float GetStat(string statName)
    {
        float base_ = baseStats.GetValueOrDefault(statName, 0f);
        float bonus = 0f;
        foreach (var mod in modifiers)
            if (mod.Stat == statName)
                bonus += mod.IsFlat ? mod.Value : base_ * mod.Value;
        return base_ + bonus;
    }

    public void SetBaseStat(string statName, float value)
    {
        baseStats[statName] = value;
    }

    public void AddModifier(StatModifier modifier)
    {
        float old = GetStat(modifier.Stat);
        modifiers.Add(modifier);
        OnStatChanged?.Invoke(modifier.Stat, old, GetStat(modifier.Stat));
    }

    public void RemoveModifiersFromSource(string source)
    {
        modifiers.RemoveAll(m => m.Source == source);
    }
}