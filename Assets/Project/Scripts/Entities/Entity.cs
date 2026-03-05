using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private HealthComponent health;
    [SerializeField] private StatsComponent stats;

    public HealthComponent Health => health;
    public StatsComponent Stats => stats;

    public virtual void Initialize(EntityData data)
    {
        // буду заполнять по мере разработки
    }
}