﻿# JSON schema: Assets RPGMaker Storage Word JSON words

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
■key: required, type(value): <class 'list'>
        * examples:
            >```
            >[
            >    {
            >        "buy": {
            >            "enabled": 1,
            >            "initialValue": "Buy",
            >            "value": "Buy"
            >        },
            >        "sell": {
            >            "enabled": 1,
            >            "initialValue": "Sell",
            >            "value": "Sell"
            >        },
            >        "stop": {
            >            "enabled": 1,
            >            "initialValue": "Stop",
            >            "value": "Stop"
            >        },
            >        "item": {
            >            "enabled": 1,
            >            "initialValue": "Item",
            >            "value": "Item"
            >        },
            >        "weapon": {
            >            "enabled": 1,
            >            "initialValue": "Weapon",
            >            "value": "Weapon"
            >        },
            >        "armor": {
            >            "enabled": 1,
            >            "initialValue": "Armor",
            >            "value": "Armor"
            >        },
            >        "important": {
            >            "enabled": 0,
            >            "initialValue": "Important",
            >            "value": "Important"
            >        },
            >        "haveNumber": {
            >            "enabled": 1,
            >            "initialValue": "HaveNumber",
            >            "value": "HaveNumber"
            >        }
            >    }
            >]
            >```
* examples:
    >```
    >[
    >    {
    >        "basicStatus": {
    >            "exp": {
    >                "enabled": 1,
    >                "initialValue": "\uff25\uff38\uff30",
    >                "value": "\uff25\uff38\uff30"
    >            },
    >            "expShort": {
    >                "enabled": 1,
    >                "initialValue": "EXP",
    >                "value": "EXP"
    >            },
    >            "hp": {
    >                "enabled": 1,
    >                "initialValue": "\uff28\uff30",
    >                "value": "\uff28\uff30"
    >            },
    >            "hpShort": {
    >                "enabled": 1,
    >                "initialValue": "HP",
    >                "value": "HP"
    >            },
    >            "level": {
    >                "enabled": 1,
    >                "initialValue": "Level",
    >                "value": "Level"
    >            },
    >            "levelShort": {
    >                "enabled": 1,
    >                "initialValue": "LV",
    >                "value": "LV"
    >            },
    >            "money": {
    >                "enabled": 1,
    >                "initialValue": "G",
    >                "value": "G"
    >            },
    >            "mp": {
    >                "enabled": 1,
    >                "initialValue": "\uff2d\uff30",
    >                "value": "\uff2d\uff30"
    >            },
    >            "mpShort": {
    >                "enabled": 1,
    >                "initialValue": "MP",
    >                "value": "MP"
    >            },
    >            "tp": {
    >                "enabled": 1,
    >                "initialValue": "\uff34\uff30",
    >                "value": "\uff34\uff30"
    >            },
    >            "tpShort": {
    >                "enabled": 1,
    >                "initialValue": "TP",
    >                "value": "TP"
    >            }
    >        },
    >        "commands": {
    >            "alwaysDash": {
    >                "enabled": 1,
    >                "initialValue": "Always Dash",
    >                "value": "Always Dash"
    >            },
    >            "armor": {
    >                "enabled": 1,
    >                "initialValue": "Armor",
    >                "value": "Armor"
    >            },
    >            "attack": {
    >                "enabled": 1,
    >                "initialValue": "Attack",
    >                "value": "Attack"
    >            },
    >            "backTitle": {
    >                "enabled": 1,
    >                "initialValue": "To Title",
    >                "value": "To Title"
    >            },
    >            "battle": {
    >                "enabled": 1,
    >                "initialValue": "Fight",
    >                "value": "Fight"
    >            },
    >            "buy": {
    >                "enabled": 1,
    >                "initialValue": "Buy",
    >                "value": "Buy"
    >            },
    >            "equipment": {
    >                "enabled": 1,
    >                "initialValue": "Equipment",
    >                "value": "Equipment"
    >            },
    >            "equipment2": {
    >                "enabled": 1,
    >                "initialValue": "Equipment",
    >                "value": "Equipment"
    >            },
    >            "escape": {
    >                "enabled": 1,
    >                "initialValue": "Escape",
    >                "value": "Escape"
    >            },
    >            "gameEnd": {
    >                "enabled": 1,
    >                "initialValue": "Exit Game",
    >                "value": "Exit Game"
    >            },
    >            "guard": {
    >                "enabled": 1,
    >                "initialValue": "Guard",
    >                "value": "Guard"
    >            },
    >            "item": {
    >                "enabled": 1,
    >                "initialValue": "Items",
    >                "value": "Items"
    >            },
    >            "keyItem": {
    >                "enabled": 1,
    >                "initialValue": "Key Item",
    >                "value": "Key Item"
    >            },
    >            "menuContinue": {
    >                "enabled": 1,
    >                "initialValue": "Continue",
    >                "value": "Continue"
    >            },
    >            "newGame": {
    >                "enabled": 1,
    >                "initialValue": "New Game",
    >                "value": "New Game"
    >            },
    >            "option": {
    >                "enabled": 1,
    >                "initialValue": "Options",
    >                "value": "Options"
    >            },
    >            "pause": {
    >                "enabled": 1,
    >                "initialValue": "Cancel",
    >                "value": "Cancel"
    >            },
    >            "possessionNum": {
    >                "enabled": 1,
    >                "initialValue": "No.Held",
    >                "value": "No. Held"
    >            },
    >            "removeAll": {
    >                "enabled": 1,
    >                "initialValue": "Unequip All",
    >                "value": "Unequip All"
    >            },
    >            "save": {
    >                "enabled": 1,
    >                "initialValue": "Save",
    >                "value": "Save"
    >            },
    >            "saveCommand": {
    >                "enabled": 1,
    >                "initialValue": "Command Memory",
    >                "value": "Command Memory"
    >            },
    >            "sell": {
    >                "enabled": 1,
    >                "initialValue": "Sell",
    >                "value": "Sell"
    >            },
    >            "skill": {
    >                "enabled": 1,
    >                "initialValue": "Skills",
    >                "value": "Skills"
    >            },
    >            "sort": {
    >                "enabled": 1,
    >                "initialValue": "Fomation",
    >                "value": "Fomation"
    >            },
    >            "status": {
    >                "enabled": 1,
    >                "initialValue": "Status",
    >                "value": "Status"
    >            },
    >            "strongestEquipment": {
    >                "enabled": 1,
    >                "initialValue": "Optimize Equipment",
    >                "value": "Optimize Equipment"
    >            },
    >            "volumeBgm": {
    >                "enabled": 1,
    >                "initialValue": "GM Volume",
    >                "value": "BGM Volume"
    >            },
    >            "volumeBgs": {
    >                "enabled": 1,
    >                "initialValue": "BGS Volume",
    >                "value": "BGS Volume"
    >            },
    >            "volumeMe": {
    >                "enabled": 1,
    >                "initialValue": "ME Volume",
    >                "value": "ME Volume"
    >            },
    >            "volumeSe": {
    >                "enabled": 1,
    >                "initialValue": "SE Volume",
    >                "value": "SE Volume"
    >            },
    >            "weapon": {
    >                "enabled": 1,
    >                "initialValue": "Weapon",
    >                "value": "Weapon"
    >            }
    >        },
    >        "messages": {
    >            "actionFailure": {
    >                "enabled": 1,
    >                "initialValue": "There was no effect on %1!",
    >                "value": "There was no effect on %1!"
    >            },
    >            "actorDamage": {
    >                "enabled": 1,
    >                "initialValue": "%1 took %2 damage!",
    >                "value": "%1 took %2 damage!"
    >            },
    >            "actorDrain": {
    >                "enabled": 1,
    >                "initialValue": "%1 was drained of %2 %3!",
    >                "value": "%1 was drained of %3 %2!"
    >            },
    >            "actorGain": {
    >                "enabled": 1,
    >                "initialValue": "%1 gained %2 %3!",
    >                "value": "%1 gained %3 %2!"
    >            },
    >            "actorLoss": {
    >                "enabled": 1,
    >                "initialValue": "%1 lost %2 %3!",
    >                "value": "%1 lost %3 %2!"
    >            },
    >            "actorNoDamage": {
    >                "enabled": 1,
    >                "initialValue": "%1 took no damage!",
    >                "value": "%1 took no damage!"
    >            },
    >            "actorNoHit": {
    >                "enabled": 1,
    >                "initialValue": "Miss! %1 took no damage!",
    >                "value": "Miss! %1 took no damage!"
    >            },
    >            "actorRecovery": {
    >                "enabled": 1,
    >                "initialValue": "%1 recovered %2 %3!",
    >                "value": "%1 recovered %3 %2!"
    >            },
    >            "buffAdd": {
    >                "enabled": 1,
    >                "initialValue": "%1's %2 returned to normal!",
    >                "value": "%1's %2 went up!"
    >            },
    >            "buffRemove": {
    >                "enabled": 1,
    >                "initialValue": "%1's %2 returned to normal!",
    >                "value": "%1's %2 returned to normal!"
    >            },
    >            "counterAttack": {
    >                "enabled": 1,
    >                "initialValue": "%1 counterattacked!",
    >                "value": "%1 counterattacked!"
    >            },
    >            "criticalToActor": {
    >                "enabled": 1,
    >                "initialValue": "A painful blow!!",
    >                "value": "A painful blow!!"
    >            },
    >            "criticalToEnemy": {
    >                "enabled": 1,
    >                "initialValue": "An excellent hit!!",
    >                "value": "An excellent hit!!"
    >            },
    >            "debuffAdd": {
    >                "enabled": 1,
    >                "initialValue": "%1's %2 went down!",
    >                "value": "%1's %2 went down!"
    >            },
    >            "defeat": {
    >                "enabled": 1,
    >                "initialValue": "%1 was defeated.",
    >                "value": "%1 was defeated."
    >            },
    >            "emerge": {
    >                "enabled": 1,
    >                "initialValue": "%1 emerged!",
    >                "value": "%1 emerged!"
    >            },
    >            "enemyDamage": {
    >                "enabled": 1,
    >                "initialValue": "%1 took %2 damage!",
    >                "value": "%1 took %2 damage!"
    >            },
    >            "enemyDrain": {
    >                "enabled": 1,
    >                "initialValue": "%1 was drained of %2 %3!",
    >                "value": "%1 was drained of %3 %2!"
    >            },
    >            "enemyGain": {
    >                "enabled": 1,
    >                "initialValue": "%1 gained %2 %3!",
    >                "value": "%1 gained %3 %2!"
    >            },
    >            "enemyLoss": {
    >                "enabled": 1,
    >                "initialValue": "%1 lost %2 %3!",
    >                "value": "%1 lost %3 %2!"
    >            },
    >            "enemyNoDamage": {
    >                "enabled": 1,
    >                "initialValue": "%1 took no damage!",
    >                "value": "%1 took no damage!"
    >            },
    >            "enemyNoHit": {
    >                "enabled": 1,
    >                "initialValue": "Miss! %1 took no damage!",
    >                "value": "Miss! %1 took no damage!"
    >            },
    >            "enemyRecovery": {
    >                "enabled": 1,
    >                "initialValue": "%1 recovered %2 %3!",
    >                "value": "%1 recovered %3 %2!"
    >            },
    >            "escapeFailure": {
    >                "enabled": 1,
    >                "initialValue": "However, it was unable to escape!",
    >                "value": "However, it was unable to escape!"
    >            },
    >            "escapeStart": {
    >                "enabled": 1,
    >                "initialValue": "%1 has started to escape!",
    >                "value": "%1 has started to escape!"
    >            },
    >            "evasion": {
    >                "enabled": 1,
    >                "initialValue": "%1 evaded the attack!",
    >                "value": "%1 evaded the attack!"
    >            },
    >            "expNext": {
    >                "enabled": 1,
    >                "initialValue": "To Next %1",
    >                "value": "To Next %1"
    >            },
    >            "expTotal": {
    >                "enabled": 1,
    >                "initialValue": "Current %1",
    >                "value": "Current %1"
    >            },
    >            "file": {
    >                "enabled": 1,
    >                "initialValue": "File",
    >                "value": "File"
    >            },
    >            "levelUp": {
    >                "enabled": 1,
    >                "initialValue": "%1 is now %2 %3!",
    >                "value": "%1 is now %2 %3!"
    >            },
    >            "loadMessage": {
    >                "enabled": 1,
    >                "initialValue": "Load which file?",
    >                "value": "Load which file?"
    >            },
    >            "magicEvasion": {
    >                "enabled": 1,
    >                "initialValue": "%1 nullified the magic!",
    >                "value": "%1 nullified the magic!"
    >            },
    >            "magicReflection": {
    >                "enabled": 1,
    >                "initialValue": "%1 reflected the magic!",
    >                "value": "%1 reflected the magic!"
    >            },
    >            "obtainExp": {
    >                "enabled": 1,
    >                "initialValue": "%1 %2 received!",
    >                "value": "%1 %2 received!"
    >            },
    >            "obtainGold": {
    >                "enabled": 1,
    >                "initialValue": "%1\\G found!",
    >                "value": "%1\\G found!"
    >            },
    >            "obtainItem": {
    >                "enabled": 1,
    >                "initialValue": "%1 found!",
    >                "value": "%1 found!"
    >            },
    >            "obtainSkill": {
    >                "enabled": 1,
    >                "initialValue": "%1 learned!",
    >                "value": "%1 learned!"
    >            },
    >            "partyName": {
    >                "enabled": 1,
    >                "initialValue": "%1's Party",
    >                "value": "%1's Party"
    >            },
    >            "preemptive": {
    >                "enabled": 1,
    >                "initialValue": "%1 got the upper hand!",
    >                "value": "%1 got the upper hand!"
    >            },
    >            "saveMessage": {
    >                "enabled": 1,
    >                "initialValue": "Save to which file?",
    >                "value": "Save to which file?"
    >            },
    >            "substitute": {
    >                "enabled": 1,
    >                "initialValue": "%1 protected %2!",
    >                "value": "%1 protected %2!"
    >            },
    >            "surprise": {
    >                "enabled": 1,
    >                "initialValue": "%1 was surprised!",
    >                "value": "%1 was surprised!"
    >            },
    >            "useItem": {
    >                "enabled": 1,
    >                "initialValue": "%1 uses %2!",
    >                "value": "%1 uses %2!"
    >            },
    >            "victory": {
    >                "enabled": 1,
    >                "initialValue": "%1 was victorious!",
    >                "value": "%1 was victorious!"
    >            }
    >        },
    >        "status": {
    >            "attack": {
    >                "enabled": 1,
    >                "initialValue": "Attack",
    >                "value": "Attack"
    >            },
    >            "evasion": {
    >                "enabled": 1,
    >                "initialValue": "Evasion Rate",
    >                "value": "Evasion Rate"
    >            },
    >            "guard": {
    >                "enabled": 1,
    >                "initialValue": "Defense",
    >                "value": "Defense"
    >            },
    >            "hit": {
    >                "enabled": 1,
    >                "initialValue": "Hit Rate",
    >                "value": "Hit Rate"
    >            },
    >            "luck": {
    >                "enabled": 1,
    >                "initialValue": "Luck",
    >                "value": "Luck"
    >            },
    >            "magic": {
    >                "enabled": 1,
    >                "initialValue": "Magic Atk.",
    >                "value": "Magic Atk."
    >            },
    >            "magicGuard": {
    >                "enabled": 1,
    >                "initialValue": "Magic Def.",
    >                "value": "Magic Def."
    >            },
    >            "maxHp": {
    >                "enabled": 1,
    >                "initialValue": "Max HP",
    >                "value": "Max HP"
    >            },
    >            "maxMp": {
    >                "enabled": 1,
    >                "initialValue": "Max MP",
    >                "value": "Max MP"
    >            },
    >            "speed": {
    >                "enabled": 1,
    >                "initialValue": "Agility",
    >                "value": "Agility"
    >            }
    >        },
    >        "runtimeShop": {
    >            "buy": {
    >                "enabled": 1,
    >                "initialValue": "Buy",
    >                "value": "Buy"
    >            },
    >            "sell": {
    >                "enabled": 1,
    >                "initialValue": "Sell",
    >                "value": "Sell"
    >            },
    >            "stop": {
    >                "enabled": 1,
    >                "initialValue": "Stop",
    >                "value": "Stop"
    >            },
    >            "item": {
    >                "enabled": 1,
    >                "initialValue": "Item",
    >                "value": "Item"
    >            },
    >            "weapon": {
    >                "enabled": 1,
    >                "initialValue": "Weapon",
    >                "value": "Weapon"
    >            },
    >            "armor": {
    >                "enabled": 1,
    >                "initialValue": "Armor",
    >                "value": "Armor"
    >            },
    >            "important": {
    >                "enabled": 0,
    >                "initialValue": "Important",
    >                "value": "Important"
    >            },
    >            "haveNumber": {
    >                "enabled": 1,
    >                "initialValue": "HaveNumber",
    >                "value": "HaveNumber"
    >            }
    >        }
    >    }
    >]
    >```
