// StatFormulas.cs
using UnityEngine;

// Статические формулы баланса
// Все числа игры считаются здесь — не разбросаны по коду
// Джиги если хотите изменить баланс — меняете только этот файл
public static class StatFormulas
{
    // Сопротивление уменьшает урон. Кап — 75%, иначе враги станут бессмертными
    public static int ApplyResistance(int rawDamage, float resistance)
    {
        float capped = Mathf.Min(resistance, 0.75f);
        return Mathf.RoundToInt(rawDamage * (1f - capped));
    }

    // Максимальный HP растёт быстрее урона — чтобы бои не заканчивались за 1 ход
    public static int CalcMaxHp(int vitality, int floor)
        => 50 + vitality * 8 + floor * 5;

    // Враги слабее на первых этажах, экспоненциально сильнее после 5-го
    public static int CalcEnemyStat(int baseStat, int floor)
        => floor <= 5
            ? Mathf.RoundToInt(baseStat * (1f + floor * 0.15f))
            : Mathf.RoundToInt(baseStat * Mathf.Pow(1.12f, floor));
}
