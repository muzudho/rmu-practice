# JSON schema: Assets RPGMaker Storage Word JSON words

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['basicStatus', 'commands', 'messages', 'status', 'runtimeShop']
* 😁 `basicStatus` property
    ■key: default
    * required - ['exp', 'expShort', 'hp', 'hpShort', 'level', 'levelShort', 'money', 'mp', 'mpShort', 'tp', 'tpShort']
    * 😁 `exp` property
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "\uff25\uff38\uff30"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "EXP"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "\uff28\uff30"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "HP"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Level"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "LV"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "G"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "\uff2d\uff30"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "MP"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "\uff34\uff30"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "TP"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
    ■key: default
    * required - ['alwaysDash', 'armor', 'attack', 'backTitle', 'battle', 'buy', 'equipment', 'equipment2', 'escape', 'gameEnd', 'guard', 'item', 'keyItem', 'menuContinue', 'newGame', 'option', 'pause', 'possessionNum', 'removeAll', 'save', 'saveCommand', 'sell', 'skill', 'sort', 'status', 'strongestEquipment', 'volumeBgm', 'volumeBgs', 'volumeMe', 'volumeSe', 'weapon']
    * 😁 `alwaysDash` property
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Always Dash"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Armor"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Attack"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "To Title"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Fight"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Buy"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Equipment"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Equipment"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Escape"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Exit Game"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Guard"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Items"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Key Item"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Continue"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "New Game"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Options"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Cancel"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "No.Held"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Unequip All"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Save"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Command Memory"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Sell"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Skills"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Fomation"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Status"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Optimize Equipment"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "GM Volume"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "BGS Volume"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "ME Volume"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "SE Volume"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Weapon"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
    ■key: default
    * required - ['actionFailure', 'actorDamage', 'actorDrain', 'actorGain', 'actorLoss', 'actorNoDamage', 'actorNoHit', 'actorRecovery', 'buffAdd', 'buffRemove', 'counterAttack', 'criticalToActor', 'criticalToEnemy', 'debuffAdd', 'defeat', 'emerge', 'enemyDamage', 'enemyDrain', 'enemyGain', 'enemyLoss', 'enemyNoDamage', 'enemyNoHit', 'enemyRecovery', 'escapeFailure', 'escapeStart', 'evasion', 'expNext', 'expTotal', 'file', 'levelUp', 'loadMessage', 'magicEvasion', 'magicReflection', 'obtainExp', 'obtainGold', 'obtainItem', 'obtainSkill', 'partyName', 'preemptive', 'saveMessage', 'substitute', 'surprise', 'useItem', 'victory']
    * 😁 `actionFailure` property
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "There was no effect on %1!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 took %2 damage!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 was drained of %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 gained %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 lost %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 took no damage!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Miss! %1 took no damage!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 recovered %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1's %2 returned to normal!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1's %2 returned to normal!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 counterattacked!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "A painful blow!!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "An excellent hit!!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1's %2 went down!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 was defeated."
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 emerged!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 took %2 damage!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 was drained of %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 gained %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 lost %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 took no damage!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Miss! %1 took no damage!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 recovered %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "However, it was unable to escape!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 has started to escape!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 evaded the attack!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "To Next %1"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Current %1"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "File"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 is now %2 %3!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Load which file?"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 nullified the magic!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 reflected the magic!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 %2 received!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1\\G found!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 found!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 learned!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1's Party"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 got the upper hand!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Save to which file?"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 protected %2!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 was surprised!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 uses %2!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "%1 was victorious!"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
    ■key: default
    * required - ['attack', 'evasion', 'guard', 'hit', 'luck', 'magic', 'magicGuard', 'maxHp', 'maxMp', 'speed']
    * 😁 `attack` property
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Attack"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Evasion Rate"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Defense"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Hit Rate"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Luck"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Magic Atk."
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Magic Def."
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Max HP"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Max MP"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Agility"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
    ■key: default
    * required - ['buy', 'sell', 'stop', 'item', 'weapon', 'armor', 'important', 'haveNumber']
    * 😁 `buy` property
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Buy"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Sell"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Stop"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Item"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Weapon"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Armor"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "Important"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
        ■key: default
        * required - ['enabled', 'initialValue', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `initialValue` property
            ■key: default
            * examples:
                >```
                >[
                >    "HaveNumber"
                >]
                >```
        * 😁 `value` property
            ■key: default
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
