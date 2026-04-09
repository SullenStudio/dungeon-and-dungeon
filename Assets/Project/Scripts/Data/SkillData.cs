// SkillData.cs
using System.Collections.Generic;
using UnityEngine;

// ScriptableObject — данные скилла.
// Создаётся через Assets > Create > Dungeon2 > SkillData
// Никакой логики — только данные.
[CreateAssetMenu(menuName = "Dungeon2/SkillData")]
public class SkillData : ScriptableObject
{
    [Header("Основное")]
    public string SkillId;          // уникальный ID: "fireball", "slash"
    public string SkillName;        // отображаемое имя
    public Sprite Icon;             // иконка в UI

    [Header("Урон")]
    public int BaseDamage;          // базовый урон без скейлинга
    public string ScalingStat = "strength"; // какой стат скейлит урон
    public float ScalingFactor = 1f;        // множитель скейлинга
    public string DamageType = "physical";  // physical / fire / magic / etc

    [Header("Стоимость и радиус")]
    public int MpCost;              // стоимость в MP
    public int Range = 1;           // радиус применения в клетках
    public int AreaOfEffect = 0;    // 0 = одна цель, >0 = AOE радиус
}
