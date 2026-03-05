using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public event Action<int, int> OnHealthChanged;
    public event Action OnDied;

    [SerializeField] private int maxHp = 100;
    private int currentHp;

    public int MaxHp => maxHp;
    public int CurrentHp => currentHp;

    private void Awake() => currentHp = maxHp;

    public void TakeDamage(int amount)
    {
        int old = currentHp;
        currentHp -= Mathf.Clamp(amount, 0, currentHp);
        OnHealthChanged?.Invoke(old, currentHp);
        if (currentHp <= 0) OnDied?.Invoke();
    }

    public void Heal(int amount)
    {
        int old = currentHp;
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        OnHealthChanged?.Invoke(old, currentHp);
    }
}