# Contributing — Dungeon²

> Internal document for the Sullen Studio team.

---

## Branches

```
main        — always stable. Direct pushes are forbidden.
develop     — main working branch
feature/*   — new mechanic:     feature/essence-system
fix/*       — bug fix:          fix/turn-queue-crash
balance/*   — balance tweak:    balance/goblin-hp
data/*      — new data/assets:  data/enemy-scriptableobjects
docs/*      — documentation:    docs/update-architecture
```

Always branch off `develop`, not `main`.

```bash
git checkout develop
git pull origin develop
git checkout -b feature/combat-system
```

---

## Commit Convention

Format: `type(DNG-N): description`

```
feat(DNG-3): add EventBus
fix(DNG-7): fix health component null reference
balance(DNG-12): reduce goblin hp from 40 to 35
data(DNG-15): add 5 new enemy ScriptableObjects
refactor(DNG-9): extract StatFormulas to separate class
test(DNG-11): add combat system unit tests
docs(DNG-2): update architecture folder structure
chore(DNG-1): init Unity 6 project
```

DNG-N number comes from GitHub Issues.

---

## Pull Requests

1. Open a PR from your branch into `develop`
2. PR title = commit message format
3. Describe what you did and what to review
4. Assign reviewer — @azamxvit

Direct pushes to `main` are forbidden.

---

## Code Standards — C#

```csharp
// Classes and methods — PascalCase
public class CombatSystem { }
public void TakeDamage(int amount) { }

// Variables — camelCase
private int currentHp;

// Properties — PascalCase
public int CurrentHp => currentHp;

// Constants — UPPER_SNAKE_CASE
public const int MAX_PARTY_SIZE = 4;

// Events — OnPascalCase
public event Action<int, int> OnHealthChanged;

// SerializeField — no underscore prefix
[SerializeField] private HealthComponent health;
```

One script = one responsibility.
Class over 200 lines — split it.
`GetComponent()` inside `Update()` — forbidden.

---

## Bugs and Tasks

All bugs and tasks go through GitHub Issues.

- Bug → label `bug` + steps to reproduce
- Task → label `feature` or `content`
- Priority: `priority: high / medium / low`

---

## QA (Mansur)

Testing happens at the end of each phase.
Bug reports are created as GitHub Issues with label `bug`.
Critical bugs (crash, data loss) — label `priority: high`, fix immediately.