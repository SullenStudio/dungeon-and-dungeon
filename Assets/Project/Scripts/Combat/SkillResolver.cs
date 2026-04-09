// SkillResolver.cs
using System.Collections.Generic;
using UnityEngine;

// Отвечает за расчёт результата применения скилла
// Чистый C# класс — не MonoBehaviour, не знает про Unity сцену
// Получает данные → считает → возвращает результат
public class SkillResolver
{
    // Результат одного удара по одной цели
    public class ActionResult
    {
        public Entity Target;
        public int Damage;       // итоговый урон после всех расчётов
        public bool IsCrit;      // был ли критический удар
        public string DamageType;
    }

    // Главный метод — применяет скилл и возвращает список результатов
    public List<ActionResult> Resolve(SkillData skill, Entity caster, List<Entity> targets)
    {
        var results = new List<ActionResult>();

        foreach (var target in targets)
        {
            bool isCrit = RollCrit(caster);
            int damage = CalculateDamage(skill, caster, target, isCrit);

            results.Add(new ActionResult
            {
                Target = target,
                Damage = damage,
                IsCrit = isCrit,
                DamageType = skill.DamageType
            });
        }

        return results;
    }

    // Считает итоговый урон: база + скейлинг стата + сопротивление цели + крит
    private int CalculateDamage(SkillData skill, Entity caster, Entity target, bool isCrit)
    {
        // базовый урон + скейлинг от стата кастера
        float raw = skill.BaseDamage
                  + caster.Stats.GetStat(skill.ScalingStat) * skill.ScalingFactor;

        // сопротивление цели (кап 75% в StatFormulas)
        float resistance = target.Stats.GetStat(skill.DamageType + "_resistance");
        int damage = StatFormulas.ApplyResistance(Mathf.RoundToInt(raw), resistance);

        // крит умножает итоговый урон на 1.5
        if (isCrit) damage = Mathf.RoundToInt(damage * 1.5f);

        return Mathf.Max(damage, 1); // минимум 1 урон всегда
    }

    // Бросает кубик на крит. Шанс = 5% + luck * 0.5%
    private bool RollCrit(Entity caster)
    {
        float luck = caster.Stats.GetStat("luck");
        float critChance = 0.05f + luck * 0.005f;
        return Random.value < critChance;
    }
}
