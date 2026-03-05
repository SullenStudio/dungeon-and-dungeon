# ⚔️ Dungeon²

![Status](https://img.shields.io/badge/status-in_development-orange)
![Engine](https://img.shields.io/badge/engine-Unity_6-000000)
![Language](https://img.shields.io/badge/language-C%23-239120)
![Genre](https://img.shields.io/badge/genre-Roguelike_|_Turn--Based_|_Dungeon_Crawler-darkred)
![Platform](https://img.shields.io/badge/platform-PC_|_Web-lightgrey)

**Dungeon²** is a hardcore pixel-art dungeon crawler with turn-based tactical combat. Assemble your party, descend into ever-deeper dungeons, and survive waves of enemies, ambushes, and hostile NPCs — or die trying and start all over again.

> ⚠️ **Hardcore Warning:** Your party will die. Often. That's the point.

---

## 🎮 Core Features

- **Party System** — Assemble a randomized team of classes: Warrior, Knight, Archer, Mage, and more. Each run gives you a different combination to master.
- **Race & Gender Selection** — Customize each character's race and gender, each with unique base stats and passive traits.
- **Essence Drop System** — Defeated enemies have a chance to drop their Essence, which grants stat boosts, new skills, or powerful active abilities.
- **Skill Synergies** — Certain class combinations unlock hidden combo abilities. The right party composition changes everything.
- **Equipment & Loot** — Discover weapons, armor, and artifacts throughout the dungeon.
- **Multi-Floor Dungeon** — Descend through procedurally generated floors, each harder than the last. The dungeon never feels the same twice.
- **Dungeon Curses** — Each floor applies a global debuff to your entire party (darkness, bleeding, weakness...). Adapt or perish.
- **Random Events** — Hostile NPC groups, ambushes, merchants, and shrines await between floors.
- **Hardcore Roguelike Loop** — Permadeath. When your party is wiped, you restart from the beginning.

---

## 🛠 Tech Stack

| Layer | Technology |
| :--- | :--- |
| **Game Engine** | Unity 6 |
| **Language** | C# |
| **Art Style** | Pixel Art, Side-View Combat + Top-Down Dungeon |
| **Combat** | Turn-Based |
| **Testing** | Unity Test Framework (NUnit) |
| **Export Targets** | Windows, macOS, Linux, WebGL |

---

## 🏗 Project Structure

```
dungeon-and-dungeon/
│
├── Assets/
│   ├── _Project/
│   │   ├── Scripts/
│   │   │   ├── Core/               # GameManager, EventBus, SaveSystem...
│   │   │   ├── Components/         # HealthComponent, StatsComponent, AIComponent...
│   │   │   ├── Combat/             # TurnQueueProcessor, SkillResolver, ActionValidator...
│   │   │   ├── Generation/         # RoomGraph, RoomPlacer, CurseInjector...
│   │   │   ├── Entities/           # PartyMember, Enemy, NPC
│   │   │   ├── UI/                 # HUD, PartyPanel, CombatAnimationPlayer...
│   │   │   └── Utils/              # RNG, StatFormulas, DataLoader
│   │   │
│   │   ├── ScriptableObjects/      # Pure data — .asset files, no logic
│   │   │   ├── Classes/
│   │   │   ├── Races/
│   │   │   ├── Skills/
│   │   │   ├── Enemies/
│   │   │   ├── Essences/
│   │   │   ├── Items/
│   │   │   ├── Curses/
│   │   │   ├── Events/
│   │   │   └── LootTables/
│   │   │
│   │   ├── Prefabs/
│   │   │   ├── Entities/
│   │   │   ├── UI/
│   │   │   └── Dungeon/
│   │   │
│   │   └── Scenes/
│   │       ├── Boot.unity
│   │       ├── MainMenu.unity
│   │       ├── DungeonWorld.unity
│   │       └── Combat.unity
│   │
│   ├── Sprites/
│   ├── Tilesets/
│   ├── Audio/
│   └── Fonts/
│
├── Packages/
├── ProjectSettings/
├── Tests/
└── ARCHITECTURE/
```

---

## ⚙️ Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/azamxvit/dungeon-and-dungeon.git
   cd dungeon-and-dungeon
   ```

2. **Open in Unity**
   - Download and install [Unity Hub](https://unity.com/download)
   - Install **Unity 6** via Unity Hub
   - Open the project via `Open > Add project from disk`

3. **Run the game**
   - Open `Assets/_Project/Scenes/Boot.unity`
   - Press **Play** in the Unity Editor

---

## 🗺 Roadmap

**Milestone 0 — Foundation**
- [x] Core concept & game design
- [x] Architecture planning
- [ ] Project structure & core systems setup
- [ ] Entity + component system
- [ ] Basic 3-room dungeon (hardcoded)
- [ ] Basic turn-based combat (no skills)

**Milestone 1 — Playable Loop**
- [ ] Procedural dungeon generation
- [ ] 4 playable classes
- [ ] 20 skills
- [ ] Essence system (basic)
- [ ] Party assembly screen
- [ ] Web build → itch.io

**Milestone 2 — Content**
- [ ] 30+ enemy types
- [ ] 60+ skills & 40+ essences
- [ ] Random events & ambushes
- [ ] Curses system
- [ ] Save system
- [ ] Patreon early access build

**Milestone 3 — Polish → Steam Early Access**
- [ ] Sound & music
- [ ] Full UI polish
- [ ] Balance pass
- [ ] Meta progression

---

## 👥 Team — Sullen Studio

| Contributor | Role | GitHub |
| :--- | :--- | :--- |
| **Azamat** | Developer — Web & Game Engineer | [@azamxvit](https://github.com/azamxvit) |
| **Nurzhigit** | Level Designer & Artist | [@thzsqeze](https://github.com/thzsqeze) |
| **Mansur** | QA Engineer & Tester | [@QpErs1i](https://github.com/QpErs1i) |
| **Bakdaulet** | Sound Designer | [@Klshbv](https://github.com/Klshbv) |

---

## 📢 Follow the Development

- 🎮 **Patreon** — early builds, devlogs & exclusive content *(coming soon)*
- 🕹️ **itch.io** — free web builds *(coming soon)*

---

*Built with ❤️ and suffering by **Sullen Studio**. May your party survive at least two floors.*