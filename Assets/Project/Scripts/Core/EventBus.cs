using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus
{
    // Бой
    public static event Action<List<Entity>> OnCombatStarted;
    public static event Action<CombatResult> OnCombatEnded;
    public static event Action<Entity, Entity> OnEntityDied;
    public static event Action<Entity> OnTurnStarted;

    // Пати
    public static event Action<Entity> OnPartyMemberDied;
    public static event Action OnPartyWiped;

    // Вызовы
    public static void TriggerCombatStarted(List<Entity> c) => OnCombatStarted?.Invoke(c);
    public static void TriggerEntityDied(Entity e, Entity k) => OnEntityDied?.Invoke(e, k);
    public static void TriggerPartyWiped() => OnPartyWiped?.Invoke();
}