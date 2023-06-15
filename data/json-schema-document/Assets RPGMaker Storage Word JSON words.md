# JSON schema: Assets RPGMaker Storage Word JSON words

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['basicStatus', 'commands', 'messages', 'status', 'runtimeShop']
* 😁 `basicStatus` property
    * required - ['exp', 'expShort', 'hp', 'hpShort', 'level', 'levelShort', 'money', 'mp', 'mpShort', 'tp', 'tpShort']
    * 😁 `exp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "\uff25\uff38\uff30"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "\uff25\uff38\uff30"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "\uff25\uff38\uff30",
            >        "value": "\uff25\uff38\uff30"
            >    }
            >]
            >```
    * 😁 `expShort` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "EXP"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "EXP"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "EXP",
            >        "value": "EXP"
            >    }
            >]
            >```
    * 😁 `hp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "\uff28\uff30"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "\uff28\uff30"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "\uff28\uff30",
            >        "value": "\uff28\uff30"
            >    }
            >]
            >```
    * 😁 `hpShort` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "HP"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "HP"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "HP",
            >        "value": "HP"
            >    }
            >]
            >```
    * 😁 `level` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Level"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Level"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Level",
            >        "value": "Level"
            >    }
            >]
            >```
    * 😁 `levelShort` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "LV"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "LV"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "LV",
            >        "value": "LV"
            >    }
            >]
            >```
    * 😁 `money` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "G"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "G"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "G",
            >        "value": "G"
            >    }
            >]
            >```
    * 😁 `mp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "\uff2d\uff30"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "\uff2d\uff30"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "\uff2d\uff30",
            >        "value": "\uff2d\uff30"
            >    }
            >]
            >```
    * 😁 `mpShort` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "MP"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "MP"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "MP",
            >        "value": "MP"
            >    }
            >]
            >```
    * 😁 `tp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "\uff34\uff30"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "\uff34\uff30"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "\uff34\uff30",
            >        "value": "\uff34\uff30"
            >    }
            >]
            >```
    * 😁 `tpShort` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "TP"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "TP"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "TP",
            >        "value": "TP"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "exp": {
        >            "enabled": 1,
        >            "initialValue": "\uff25\uff38\uff30",
        >            "value": "\uff25\uff38\uff30"
        >        },
        >        "expShort": {
        >            "enabled": 1,
        >            "initialValue": "EXP",
        >            "value": "EXP"
        >        },
        >        "hp": {
        >            "enabled": 1,
        >            "initialValue": "\uff28\uff30",
        >            "value": "\uff28\uff30"
        >        },
        >        "hpShort": {
        >            "enabled": 1,
        >            "initialValue": "HP",
        >            "value": "HP"
        >        },
        >        "level": {
        >            "enabled": 1,
        >            "initialValue": "Level",
        >            "value": "Level"
        >        },
        >        "levelShort": {
        >            "enabled": 1,
        >            "initialValue": "LV",
        >            "value": "LV"
        >        },
        >        "money": {
        >            "enabled": 1,
        >            "initialValue": "G",
        >            "value": "G"
        >        },
        >        "mp": {
        >            "enabled": 1,
        >            "initialValue": "\uff2d\uff30",
        >            "value": "\uff2d\uff30"
        >        },
        >        "mpShort": {
        >            "enabled": 1,
        >            "initialValue": "MP",
        >            "value": "MP"
        >        },
        >        "tp": {
        >            "enabled": 1,
        >            "initialValue": "\uff34\uff30",
        >            "value": "\uff34\uff30"
        >        },
        >        "tpShort": {
        >            "enabled": 1,
        >            "initialValue": "TP",
        >            "value": "TP"
        >        }
        >    }
        >]
        >```
* 😁 `commands` property
    * required - ['alwaysDash', 'armor', 'attack', 'backTitle', 'battle', 'buy', 'equipment', 'equipment2', 'escape', 'gameEnd', 'guard', 'item', 'keyItem', 'menuContinue', 'newGame', 'option', 'pause', 'possessionNum', 'removeAll', 'save', 'saveCommand', 'sell', 'skill', 'sort', 'status', 'strongestEquipment', 'volumeBgm', 'volumeBgs', 'volumeMe', 'volumeSe', 'weapon']
    * 😁 `alwaysDash` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Always Dash"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Always Dash"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Always Dash",
            >        "value": "Always Dash"
            >    }
            >]
            >```
    * 😁 `armor` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Armor"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Armor"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Armor",
            >        "value": "Armor"
            >    }
            >]
            >```
    * 😁 `attack` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Attack"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Attack"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Attack",
            >        "value": "Attack"
            >    }
            >]
            >```
    * 😁 `backTitle` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "To Title"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "To Title"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "To Title",
            >        "value": "To Title"
            >    }
            >]
            >```
    * 😁 `battle` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Fight"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Fight"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Fight",
            >        "value": "Fight"
            >    }
            >]
            >```
    * 😁 `buy` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Buy"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Buy"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Buy",
            >        "value": "Buy"
            >    }
            >]
            >```
    * 😁 `equipment` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Equipment"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Equipment"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Equipment",
            >        "value": "Equipment"
            >    }
            >]
            >```
    * 😁 `equipment2` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Equipment"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Equipment"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Equipment",
            >        "value": "Equipment"
            >    }
            >]
            >```
    * 😁 `escape` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Escape"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Escape"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Escape",
            >        "value": "Escape"
            >    }
            >]
            >```
    * 😁 `gameEnd` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Exit Game"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Exit Game"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Exit Game",
            >        "value": "Exit Game"
            >    }
            >]
            >```
    * 😁 `guard` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Guard"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Guard"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Guard",
            >        "value": "Guard"
            >    }
            >]
            >```
    * 😁 `item` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Items"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Items"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Items",
            >        "value": "Items"
            >    }
            >]
            >```
    * 😁 `keyItem` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Key Item"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Key Item"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Key Item",
            >        "value": "Key Item"
            >    }
            >]
            >```
    * 😁 `menuContinue` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Continue"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Continue"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Continue",
            >        "value": "Continue"
            >    }
            >]
            >```
    * 😁 `newGame` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "New Game"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "New Game"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "New Game",
            >        "value": "New Game"
            >    }
            >]
            >```
    * 😁 `option` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Options"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Options"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Options",
            >        "value": "Options"
            >    }
            >]
            >```
    * 😁 `pause` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Cancel"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Cancel"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Cancel",
            >        "value": "Cancel"
            >    }
            >]
            >```
    * 😁 `possessionNum` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "No.Held"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "No. Held"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "No.Held",
            >        "value": "No. Held"
            >    }
            >]
            >```
    * 😁 `removeAll` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Unequip All"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Unequip All"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Unequip All",
            >        "value": "Unequip All"
            >    }
            >]
            >```
    * 😁 `save` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Save"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Save"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Save",
            >        "value": "Save"
            >    }
            >]
            >```
    * 😁 `saveCommand` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Command Memory"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Command Memory"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Command Memory",
            >        "value": "Command Memory"
            >    }
            >]
            >```
    * 😁 `sell` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Sell"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Sell"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Sell",
            >        "value": "Sell"
            >    }
            >]
            >```
    * 😁 `skill` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Skills"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Skills"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Skills",
            >        "value": "Skills"
            >    }
            >]
            >```
    * 😁 `sort` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Fomation"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Fomation"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Fomation",
            >        "value": "Fomation"
            >    }
            >]
            >```
    * 😁 `status` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Status"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Status"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Status",
            >        "value": "Status"
            >    }
            >]
            >```
    * 😁 `strongestEquipment` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Optimize Equipment"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Optimize Equipment"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Optimize Equipment",
            >        "value": "Optimize Equipment"
            >    }
            >]
            >```
    * 😁 `volumeBgm` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "GM Volume"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "BGM Volume"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "GM Volume",
            >        "value": "BGM Volume"
            >    }
            >]
            >```
    * 😁 `volumeBgs` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "BGS Volume"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "BGS Volume"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "BGS Volume",
            >        "value": "BGS Volume"
            >    }
            >]
            >```
    * 😁 `volumeMe` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "ME Volume"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "ME Volume"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "ME Volume",
            >        "value": "ME Volume"
            >    }
            >]
            >```
    * 😁 `volumeSe` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "SE Volume"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "SE Volume"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "SE Volume",
            >        "value": "SE Volume"
            >    }
            >]
            >```
    * 😁 `weapon` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Weapon"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Weapon"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Weapon",
            >        "value": "Weapon"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "alwaysDash": {
        >            "enabled": 1,
        >            "initialValue": "Always Dash",
        >            "value": "Always Dash"
        >        },
        >        "armor": {
        >            "enabled": 1,
        >            "initialValue": "Armor",
        >            "value": "Armor"
        >        },
        >        "attack": {
        >            "enabled": 1,
        >            "initialValue": "Attack",
        >            "value": "Attack"
        >        },
        >        "backTitle": {
        >            "enabled": 1,
        >            "initialValue": "To Title",
        >            "value": "To Title"
        >        },
        >        "battle": {
        >            "enabled": 1,
        >            "initialValue": "Fight",
        >            "value": "Fight"
        >        },
        >        "buy": {
        >            "enabled": 1,
        >            "initialValue": "Buy",
        >            "value": "Buy"
        >        },
        >        "equipment": {
        >            "enabled": 1,
        >            "initialValue": "Equipment",
        >            "value": "Equipment"
        >        },
        >        "equipment2": {
        >            "enabled": 1,
        >            "initialValue": "Equipment",
        >            "value": "Equipment"
        >        },
        >        "escape": {
        >            "enabled": 1,
        >            "initialValue": "Escape",
        >            "value": "Escape"
        >        },
        >        "gameEnd": {
        >            "enabled": 1,
        >            "initialValue": "Exit Game",
        >            "value": "Exit Game"
        >        },
        >        "guard": {
        >            "enabled": 1,
        >            "initialValue": "Guard",
        >            "value": "Guard"
        >        },
        >        "item": {
        >            "enabled": 1,
        >            "initialValue": "Items",
        >            "value": "Items"
        >        },
        >        "keyItem": {
        >            "enabled": 1,
        >            "initialValue": "Key Item",
        >            "value": "Key Item"
        >        },
        >        "menuContinue": {
        >            "enabled": 1,
        >            "initialValue": "Continue",
        >            "value": "Continue"
        >        },
        >        "newGame": {
        >            "enabled": 1,
        >            "initialValue": "New Game",
        >            "value": "New Game"
        >        },
        >        "option": {
        >            "enabled": 1,
        >            "initialValue": "Options",
        >            "value": "Options"
        >        },
        >        "pause": {
        >            "enabled": 1,
        >            "initialValue": "Cancel",
        >            "value": "Cancel"
        >        },
        >        "possessionNum": {
        >            "enabled": 1,
        >            "initialValue": "No.Held",
        >            "value": "No. Held"
        >        },
        >        "removeAll": {
        >            "enabled": 1,
        >            "initialValue": "Unequip All",
        >            "value": "Unequip All"
        >        },
        >        "save": {
        >            "enabled": 1,
        >            "initialValue": "Save",
        >            "value": "Save"
        >        },
        >        "saveCommand": {
        >            "enabled": 1,
        >            "initialValue": "Command Memory",
        >            "value": "Command Memory"
        >        },
        >        "sell": {
        >            "enabled": 1,
        >            "initialValue": "Sell",
        >            "value": "Sell"
        >        },
        >        "skill": {
        >            "enabled": 1,
        >            "initialValue": "Skills",
        >            "value": "Skills"
        >        },
        >        "sort": {
        >            "enabled": 1,
        >            "initialValue": "Fomation",
        >            "value": "Fomation"
        >        },
        >        "status": {
        >            "enabled": 1,
        >            "initialValue": "Status",
        >            "value": "Status"
        >        },
        >        "strongestEquipment": {
        >            "enabled": 1,
        >            "initialValue": "Optimize Equipment",
        >            "value": "Optimize Equipment"
        >        },
        >        "volumeBgm": {
        >            "enabled": 1,
        >            "initialValue": "GM Volume",
        >            "value": "BGM Volume"
        >        },
        >        "volumeBgs": {
        >            "enabled": 1,
        >            "initialValue": "BGS Volume",
        >            "value": "BGS Volume"
        >        },
        >        "volumeMe": {
        >            "enabled": 1,
        >            "initialValue": "ME Volume",
        >            "value": "ME Volume"
        >        },
        >        "volumeSe": {
        >            "enabled": 1,
        >            "initialValue": "SE Volume",
        >            "value": "SE Volume"
        >        },
        >        "weapon": {
        >            "enabled": 1,
        >            "initialValue": "Weapon",
        >            "value": "Weapon"
        >        }
        >    }
        >]
        >```
* 😁 `messages` property
    * required - ['actionFailure', 'actorDamage', 'actorDrain', 'actorGain', 'actorLoss', 'actorNoDamage', 'actorNoHit', 'actorRecovery', 'buffAdd', 'buffRemove', 'counterAttack', 'criticalToActor', 'criticalToEnemy', 'debuffAdd', 'defeat', 'emerge', 'enemyDamage', 'enemyDrain', 'enemyGain', 'enemyLoss', 'enemyNoDamage', 'enemyNoHit', 'enemyRecovery', 'escapeFailure', 'escapeStart', 'evasion', 'expNext', 'expTotal', 'file', 'levelUp', 'loadMessage', 'magicEvasion', 'magicReflection', 'obtainExp', 'obtainGold', 'obtainItem', 'obtainSkill', 'partyName', 'preemptive', 'saveMessage', 'substitute', 'surprise', 'useItem', 'victory']
    * 😁 `actionFailure` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "There was no effect on %1!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "There was no effect on %1!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "There was no effect on %1!",
            >        "value": "There was no effect on %1!"
            >    }
            >]
            >```
    * 😁 `actorDamage` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 took %2 damage!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 took %2 damage!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 took %2 damage!",
            >        "value": "%1 took %2 damage!"
            >    }
            >]
            >```
    * 😁 `actorDrain` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 was drained of %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 was drained of %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 was drained of %2 %3!",
            >        "value": "%1 was drained of %3 %2!"
            >    }
            >]
            >```
    * 😁 `actorGain` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 gained %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 gained %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 gained %2 %3!",
            >        "value": "%1 gained %3 %2!"
            >    }
            >]
            >```
    * 😁 `actorLoss` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 lost %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 lost %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 lost %2 %3!",
            >        "value": "%1 lost %3 %2!"
            >    }
            >]
            >```
    * 😁 `actorNoDamage` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 took no damage!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 took no damage!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 took no damage!",
            >        "value": "%1 took no damage!"
            >    }
            >]
            >```
    * 😁 `actorNoHit` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Miss! %1 took no damage!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Miss! %1 took no damage!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Miss! %1 took no damage!",
            >        "value": "Miss! %1 took no damage!"
            >    }
            >]
            >```
    * 😁 `actorRecovery` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 recovered %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 recovered %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 recovered %2 %3!",
            >        "value": "%1 recovered %3 %2!"
            >    }
            >]
            >```
    * 😁 `buffAdd` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1's %2 returned to normal!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1's %2 went up!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1's %2 returned to normal!",
            >        "value": "%1's %2 went up!"
            >    }
            >]
            >```
    * 😁 `buffRemove` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1's %2 returned to normal!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1's %2 returned to normal!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1's %2 returned to normal!",
            >        "value": "%1's %2 returned to normal!"
            >    }
            >]
            >```
    * 😁 `counterAttack` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 counterattacked!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 counterattacked!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 counterattacked!",
            >        "value": "%1 counterattacked!"
            >    }
            >]
            >```
    * 😁 `criticalToActor` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "A painful blow!!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "A painful blow!!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "A painful blow!!",
            >        "value": "A painful blow!!"
            >    }
            >]
            >```
    * 😁 `criticalToEnemy` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "An excellent hit!!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "An excellent hit!!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "An excellent hit!!",
            >        "value": "An excellent hit!!"
            >    }
            >]
            >```
    * 😁 `debuffAdd` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1's %2 went down!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1's %2 went down!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1's %2 went down!",
            >        "value": "%1's %2 went down!"
            >    }
            >]
            >```
    * 😁 `defeat` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 was defeated."
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 was defeated."
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 was defeated.",
            >        "value": "%1 was defeated."
            >    }
            >]
            >```
    * 😁 `emerge` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 emerged!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 emerged!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 emerged!",
            >        "value": "%1 emerged!"
            >    }
            >]
            >```
    * 😁 `enemyDamage` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 took %2 damage!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 took %2 damage!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 took %2 damage!",
            >        "value": "%1 took %2 damage!"
            >    }
            >]
            >```
    * 😁 `enemyDrain` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 was drained of %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 was drained of %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 was drained of %2 %3!",
            >        "value": "%1 was drained of %3 %2!"
            >    }
            >]
            >```
    * 😁 `enemyGain` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 gained %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 gained %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 gained %2 %3!",
            >        "value": "%1 gained %3 %2!"
            >    }
            >]
            >```
    * 😁 `enemyLoss` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 lost %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 lost %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 lost %2 %3!",
            >        "value": "%1 lost %3 %2!"
            >    }
            >]
            >```
    * 😁 `enemyNoDamage` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 took no damage!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 took no damage!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 took no damage!",
            >        "value": "%1 took no damage!"
            >    }
            >]
            >```
    * 😁 `enemyNoHit` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Miss! %1 took no damage!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Miss! %1 took no damage!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Miss! %1 took no damage!",
            >        "value": "Miss! %1 took no damage!"
            >    }
            >]
            >```
    * 😁 `enemyRecovery` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 recovered %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 recovered %3 %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 recovered %2 %3!",
            >        "value": "%1 recovered %3 %2!"
            >    }
            >]
            >```
    * 😁 `escapeFailure` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "However, it was unable to escape!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "However, it was unable to escape!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "However, it was unable to escape!",
            >        "value": "However, it was unable to escape!"
            >    }
            >]
            >```
    * 😁 `escapeStart` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 has started to escape!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 has started to escape!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 has started to escape!",
            >        "value": "%1 has started to escape!"
            >    }
            >]
            >```
    * 😁 `evasion` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 evaded the attack!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 evaded the attack!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 evaded the attack!",
            >        "value": "%1 evaded the attack!"
            >    }
            >]
            >```
    * 😁 `expNext` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "To Next %1"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "To Next %1"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "To Next %1",
            >        "value": "To Next %1"
            >    }
            >]
            >```
    * 😁 `expTotal` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Current %1"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Current %1"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Current %1",
            >        "value": "Current %1"
            >    }
            >]
            >```
    * 😁 `file` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "File"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "File"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "File",
            >        "value": "File"
            >    }
            >]
            >```
    * 😁 `levelUp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 is now %2 %3!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 is now %2 %3!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 is now %2 %3!",
            >        "value": "%1 is now %2 %3!"
            >    }
            >]
            >```
    * 😁 `loadMessage` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Load which file?"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Load which file?"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Load which file?",
            >        "value": "Load which file?"
            >    }
            >]
            >```
    * 😁 `magicEvasion` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 nullified the magic!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 nullified the magic!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 nullified the magic!",
            >        "value": "%1 nullified the magic!"
            >    }
            >]
            >```
    * 😁 `magicReflection` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 reflected the magic!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 reflected the magic!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 reflected the magic!",
            >        "value": "%1 reflected the magic!"
            >    }
            >]
            >```
    * 😁 `obtainExp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 %2 received!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 %2 received!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 %2 received!",
            >        "value": "%1 %2 received!"
            >    }
            >]
            >```
    * 😁 `obtainGold` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1\\G found!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1\\G found!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1\\G found!",
            >        "value": "%1\\G found!"
            >    }
            >]
            >```
    * 😁 `obtainItem` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 found!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 found!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 found!",
            >        "value": "%1 found!"
            >    }
            >]
            >```
    * 😁 `obtainSkill` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 learned!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 learned!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 learned!",
            >        "value": "%1 learned!"
            >    }
            >]
            >```
    * 😁 `partyName` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1's Party"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1's Party"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1's Party",
            >        "value": "%1's Party"
            >    }
            >]
            >```
    * 😁 `preemptive` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 got the upper hand!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 got the upper hand!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 got the upper hand!",
            >        "value": "%1 got the upper hand!"
            >    }
            >]
            >```
    * 😁 `saveMessage` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Save to which file?"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Save to which file?"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Save to which file?",
            >        "value": "Save to which file?"
            >    }
            >]
            >```
    * 😁 `substitute` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 protected %2!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 protected %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 protected %2!",
            >        "value": "%1 protected %2!"
            >    }
            >]
            >```
    * 😁 `surprise` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 was surprised!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 was surprised!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 was surprised!",
            >        "value": "%1 was surprised!"
            >    }
            >]
            >```
    * 😁 `useItem` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 uses %2!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 uses %2!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 uses %2!",
            >        "value": "%1 uses %2!"
            >    }
            >]
            >```
    * 😁 `victory` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "%1 was victorious!"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "%1 was victorious!"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "%1 was victorious!",
            >        "value": "%1 was victorious!"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "actionFailure": {
        >            "enabled": 1,
        >            "initialValue": "There was no effect on %1!",
        >            "value": "There was no effect on %1!"
        >        },
        >        "useItem": {
        >            "enabled": 1,
        >            "initialValue": "%1 uses %2!",
        >            "value": "%1 uses %2!"
        >        },
        >        "victory": {
        >            "enabled": 1,
        >            "initialValue": "%1 was victorious!",
        >            "value": "%1 was victorious!"
        >        }
        >    }
        >]
        >```
* 😁 `status` property
    * required - ['attack', 'evasion', 'guard', 'hit', 'luck', 'magic', 'magicGuard', 'maxHp', 'maxMp', 'speed']
    * 😁 `attack` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Attack"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Attack"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Attack",
            >        "value": "Attack"
            >    }
            >]
            >```
    * 😁 `evasion` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Evasion Rate"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Evasion Rate"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Evasion Rate",
            >        "value": "Evasion Rate"
            >    }
            >]
            >```
    * 😁 `guard` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Defense"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Defense"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Defense",
            >        "value": "Defense"
            >    }
            >]
            >```
    * 😁 `hit` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Hit Rate"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Hit Rate"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Hit Rate",
            >        "value": "Hit Rate"
            >    }
            >]
            >```
    * 😁 `luck` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Luck"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Luck"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Luck",
            >        "value": "Luck"
            >    }
            >]
            >```
    * 😁 `magic` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Magic Atk."
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Magic Atk."
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Magic Atk.",
            >        "value": "Magic Atk."
            >    }
            >]
            >```
    * 😁 `magicGuard` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Magic Def."
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Magic Def."
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Magic Def.",
            >        "value": "Magic Def."
            >    }
            >]
            >```
    * 😁 `maxHp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Max HP"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Max HP"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Max HP",
            >        "value": "Max HP"
            >    }
            >]
            >```
    * 😁 `maxMp` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Max MP"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Max MP"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Max MP",
            >        "value": "Max MP"
            >    }
            >]
            >```
    * 😁 `speed` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Agility"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Agility"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Agility",
            >        "value": "Agility"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "attack": {
        >            "enabled": 1,
        >            "initialValue": "Attack",
        >            "value": "Attack"
        >        },
        >        "maxMp": {
        >            "enabled": 1,
        >            "initialValue": "Max MP",
        >            "value": "Max MP"
        >        },
        >        "speed": {
        >            "enabled": 1,
        >            "initialValue": "Agility",
        >            "value": "Agility"
        >        }
        >    }
        >]
        >```
* 😁 `runtimeShop` property
    * required - ['buy', 'sell', 'stop', 'item', 'weapon', 'armor', 'important', 'haveNumber']
    * 😁 `buy` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Buy"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Buy"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Buy",
            >        "value": "Buy"
            >    }
            >]
            >```
    * 😁 `sell` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Sell"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Sell"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Sell",
            >        "value": "Sell"
            >    }
            >]
            >```
    * 😁 `stop` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Stop"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Stop"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Stop",
            >        "value": "Stop"
            >    }
            >]
            >```
    * 😁 `item` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Item"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Item"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Item",
            >        "value": "Item"
            >    }
            >]
            >```
    * 😁 `weapon` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Weapon"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Weapon"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Weapon",
            >        "value": "Weapon"
            >    }
            >]
            >```
    * 😁 `armor` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Armor"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Armor"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "Armor",
            >        "value": "Armor"
            >    }
            >]
            >```
    * 😁 `important` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "Important"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Important"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 0,
            >        "initialValue": "Important",
            >        "value": "Important"
            >    }
            >]
            >```
    * 😁 `haveNumber` property
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            * examples:
                >```
                >[
                >    "HaveNumber"
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "HaveNumber"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": 1,
            >        "initialValue": "HaveNumber",
            >        "value": "HaveNumber"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "buy": {
        >            "enabled": 1,
        >            "initialValue": "Buy",
        >            "value": "Buy"
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
    >            "haveNumber": {
    >                "enabled": 1,
    >                "initialValue": "HaveNumber",
    >                "value": "HaveNumber"
    >            }
    >        }
    >    }
    >]
    >```
