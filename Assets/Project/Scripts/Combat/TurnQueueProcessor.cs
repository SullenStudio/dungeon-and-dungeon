// TurnQueueProcessor.cs
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TurnQueueProcessor
{
    private List<Entity> turnQueue = new();
    private int currentIndex = 0;

    public void BuildQueue(List<Entity> combatants)
    {
        turnQueue = combatants
            .Where(e => e != null && e.Health.CurrentHp > 0)
            .OrderByDescending(e => e.Stats.GetStat("speed") + Random.Range(1, 21))
            .ToList();
        currentIndex = 0;
    }

    public Entity GetNext()
    {
        if (turnQueue.Count == 0) return null;

        // skip dead entities
        while (currentIndex < turnQueue.Count &&
               turnQueue[currentIndex].Health.CurrentHp <= 0)
        {
            currentIndex++;
        }

        if (currentIndex >= turnQueue.Count)
        {
            // new round
            currentIndex = 0;
            return GetNext();
        }

        Entity current = turnQueue[currentIndex];
        currentIndex++;
        EventBus.TriggerTurnStarted(current);
        return current;
    }

    public bool IsCombatOver(List<Entity> party, List<Entity> enemies)
    {
        bool partyDead = party.All(e => e.Health.CurrentHp <= 0);
        bool enemiesDead = enemies.All(e => e.Health.CurrentHp <= 0);
        return partyDead || enemiesDead;
    }
}
