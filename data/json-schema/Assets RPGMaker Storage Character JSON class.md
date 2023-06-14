# JSON schema: Assets RPGMaker Storage Character JSON class

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    ■key: default
    * required - ['abilityAdd', 'abilityScore', 'abilitySp', 'armorTypes', 'autoGuide', 'baseHpMaxValue', 'basic', 'clearLevel', 'element', 'expGainIncreaseValue', 'expScore', 'id', 'maxLevel', 'parameter', 'skillTypes', 'traits', 'weaponTypes']
    * 😁 `abilityAdd` property
        ■key: default
        * required - ['criticalRate', 'evasionRate', 'hitRate']
        * 😁 `criticalRate` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `evasionRate` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `hitRate` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "criticalRate": 1,
            >        "evasionRate": 1,
            >        "hitRate": 1
            >    }
            >]
            >```
    * 😁 `abilityScore` property
        ■key: default
        * required - ['attack', 'defense', 'luck', 'magicAttack', 'magicDefense', 'maxHp', 'maxMp', 'speed']
        * 😁 `attack` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    2250
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    102
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 2250,
                >        "paramOne": 102,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `defense` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1380
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    63
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 1380,
                >        "paramOne": 63,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `luck` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    770
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    35
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 770,
                >        "paramOne": 35,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `magicAttack` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    985
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    45
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 985,
                >        "paramOne": 45,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `magicDefense` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1000
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    50
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 1000,
                >        "paramOne": 50,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `maxHp` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    4250
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    235
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 4250,
                >        "paramOne": 235,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `maxMp` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    900
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    54
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 900,
                >        "paramOne": 54,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * 😁 `speed` property
            ■key: default
            * required - ['enabled', 'growType', 'paramMax', 'paramOne', 'paramPeakLv']
            * 😁 `enabled` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `growType` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `paramMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1420
                    >]
                    >```
            * 😁 `paramOne` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    64
                    >]
                    >```
            * 😁 `paramPeakLv` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "enabled": 0,
                >        "growType": 0,
                >        "paramMax": 1420,
                >        "paramOne": 64,
                >        "paramPeakLv": 60
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "attack": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 2250,
            >            "paramOne": 102,
            >            "paramPeakLv": 60
            >        },
            >        "defense": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 1380,
            >            "paramOne": 63,
            >            "paramPeakLv": 60
            >        },
            >        "luck": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 770,
            >            "paramOne": 35,
            >            "paramPeakLv": 60
            >        },
            >        "magicAttack": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 985,
            >            "paramOne": 45,
            >            "paramPeakLv": 60
            >        },
            >        "magicDefense": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 1000,
            >            "paramOne": 50,
            >            "paramPeakLv": 60
            >        },
            >        "maxHp": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 4250,
            >            "paramOne": 235,
            >            "paramPeakLv": 60
            >        },
            >        "maxMp": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 900,
            >            "paramOne": 54,
            >            "paramPeakLv": 60
            >        },
            >        "speed": {
            >            "enabled": 0,
            >            "growType": 0,
            >            "paramMax": 1420,
            >            "paramOne": 64,
            >            "paramPeakLv": 60
            >        }
            >    }
            >]
            >```
    * 😁 `abilitySp` property
        ■key: default
        * required - ['targetedRate']
        * 😁 `targetedRate` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "targetedRate": 100
            >    }
            >]
            >```
    * 😁 `armorTypes` property
        ■key: default
        * 😁 `armorTypes` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    "1",
                >    "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
                >    "c01b25d3-bdb5-4c23-a375-dcfdc05abad6",
                >    "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594"
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        "1",
            >        "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
            >        "c01b25d3-bdb5-4c23-a375-dcfdc05abad6",
            >        "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594"
            >    ]
            >]
            >```
    * 😁 `autoGuide` property
        ■key: default
        * required - ['attack', 'defense', 'luck', 'magicAttack', 'magicDefense', 'maxHp', 'maxMp', 'speed']
        * 😁 `attack` property
            ■key: default
            * examples:
                >```
                >[
                >    8
                >]
                >```
        * 😁 `defense` property
            ■key: default
            * examples:
                >```
                >[
                >    6
                >]
                >```
        * 😁 `luck` property
            ■key: default
            * examples:
                >```
                >[
                >    5
                >]
                >```
        * 😁 `magicAttack` property
            ■key: default
            * examples:
                >```
                >[
                >    4
                >]
                >```
        * 😁 `magicDefense` property
            ■key: default
            * examples:
                >```
                >[
                >    4
                >]
                >```
        * 😁 `maxHp` property
            ■key: default
            * examples:
                >```
                >[
                >    2
                >]
                >```
        * 😁 `maxMp` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `speed` property
            ■key: default
            * examples:
                >```
                >[
                >    3
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "attack": 8,
            >        "defense": 6,
            >        "luck": 5,
            >        "magicAttack": 4,
            >        "magicDefense": 4,
            >        "maxHp": 2,
            >        "maxMp": 0,
            >        "speed": 3
            >    }
            >]
            >```
    * 😁 `baseHpMaxValue` property
        ■key: default
        * examples:
            >```
            >[
            >    5000
            >]
            >```
    * 😁 `basic` property
        ■key: default
        * required - ['abilityEnabled', 'expMax', 'hpMax', 'id', 'level', 'maxLevel', 'name']
        * 😁 `abilityEnabled` property
            ■key: default
            * required - ['luck', 'magicAttack', 'magicDefense', 'mp', 'speed', 'tp']
            * 😁 `luck` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `magicAttack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `magicDefense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `mp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `speed` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `tp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "luck": 1,
                >        "magicAttack": 1,
                >        "magicDefense": 1,
                >        "mp": 1,
                >        "speed": 1,
                >        "tp": 1
                >    }
                >]
                >```
        * 😁 `expMax` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `hpMax` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `id` property
            ■key: default
            * examples:
                >```
                >[
                >    "ce89f973-6ed6-41fc-99d7-e3ca5fc1ce8c"
                >]
                >```
        * 😁 `level` property
            ■key: default
            * required - ['levelGameClear', 'levelMax']
            * 😁 `levelGameClear` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `levelMax` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    99
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "levelGameClear": 1,
                >        "levelMax": 99
                >    }
                >]
                >```
        * 😁 `maxLevel` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Hero"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "abilityEnabled": {
            >            "luck": 1,
            >            "magicAttack": 1,
            >            "magicDefense": 1,
            >            "mp": 1,
            >            "speed": 1,
            >            "tp": 1
            >        },
            >        "expMax": 1,
            >        "hpMax": 1,
            >        "id": "ce89f973-6ed6-41fc-99d7-e3ca5fc1ce8c",
            >        "level": {
            >            "levelGameClear": 1,
            >            "levelMax": 99
            >        },
            >        "maxLevel": 1,
            >        "name": "Hero"
            >    }
            >]
            >```
    * 😁 `clearLevel` property
        ■key: default
        * examples:
            >```
            >[
            >    60
            >]
            >```
    * 😁 `element` property
        ■key: default
        * examples:
            >```
            >[
            >    "0"
            >]
            >```
    * 😁 `expGainIncreaseValue` property
        ■key: default
        * examples:
            >```
            >[
            >    1000000
            >]
            >```
    * 😁 `expScore` property
        ■key: default
        * required - ['growType', 'increaseValueA', 'increaseValueB']
        * 😁 `growType` property
            ■key: default
            * examples:
                >```
                >[
                >    10
                >]
                >```
        * 😁 `increaseValueA` property
            ■key: default
            * examples:
                >```
                >[
                >    10
                >]
                >```
        * 😁 `increaseValueB` property
            ■key: default
            * examples:
                >```
                >[
                >    10
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "growType": 10,
            >        "increaseValueA": 10,
            >        "increaseValueB": 10
            >    }
            >]
            >```
    * 😁 `id` property
        ■key: default
        * examples:
            >```
            >[
            >    "39450ee1-598b-4a2e-b249-b615cd2a2ea5"
            >]
            >```
    * 😁 `maxLevel` property
        ■key: default
        * examples:
            >```
            >[
            >    99
            >]
            >```
    * 😁 `parameter` property
        ■key: default
        * required - ['attack', 'defense', 'luck', 'magicAttack', 'magicDefense', 'maxHp', 'maxMp', 'speed']
        * 😁 `attack` property
            ■key: default
            * 😁 `attack` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    102,
                    >    132,
                    >    163,
                    >    2241,
                    >    2250
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        102,
                >        132,
                >        163,
                >        2241,
                >        2250
                >    ]
                >]
                >```
        * 😁 `defense` property
            ■key: default
            * 😁 `defense` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    1380
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        1380
                >    ]
                >]
                >```
        * 😁 `luck` property
            ■key: default
            * 😁 `luck` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    35,
                    >    45,
                    >    731,
                    >    734,
                    >    767,
                    >    770
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        35,
                >        45,
                >        731,
                >        734,
                >        767,
                >        770
                >    ]
                >]
                >```
        * 😁 `magicAttack` property
            ■key: default
            * 😁 `magicAttack` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    45,
                    >    58,
                    >    676,
                    >    981,
                    >    985
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        45,
                >        58,
                >        676,
                >        981,
                >        985
                >    ]
                >]
                >```
        * 😁 `magicDefense` property
            ■key: default
            * 😁 `magicDefense` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    50,
                    >    63,
                    >    992,
                    >    996,
                    >    1000
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        50,
                >        63,
                >        992,
                >        996,
                >        1000
                >    ]
                >]
                >```
        * 😁 `maxHp` property
            ■key: default
            * 😁 `maxHp` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    235,
                    >    292,
                    >    4217,
                    >    4233,
                    >    4250
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        235,
                >        292,
                >        4217,
                >        4233,
                >        4250
                >    ]
                >]
                >```
        * 😁 `maxMp` property
            ■key: default
            * 😁 `maxMp` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    54,
                    >    66,
                    >    893,
                    >    896,
                    >    900
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        54,
                >        66,
                >        893,
                >        896,
                >        900
                >    ]
                >]
                >```
        * 😁 `speed` property
            ■key: default
            * 😁 `speed` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0,
                    >    64,
                    >    83,
                    >    102,
                    >    122,
                    >    1414,
                    >    1420
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        64,
                >        83,
                >        102,
                >        122,
                >        1414,
                >        1420
                >    ]
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "attack": [
            >            0,
            >            102,
            >            132,
            >            163,
            >            2241,
            >            2250
            >        ],
            >        "defense": [
            >            0,
            >            1380
            >        ],
            >        "luck": [
            >            0,
            >            35,
            >            45,
            >            731,
            >            734,
            >            767,
            >            770
            >        ],
            >        "magicAttack": [
            >            0,
            >            45,
            >            58,
            >            676,
            >            981,
            >            985
            >        ],
            >        "magicDefense": [
            >            0,
            >            50,
            >            63,
            >            992,
            >            996,
            >            1000
            >        ],
            >        "maxHp": [
            >            0,
            >            235,
            >            292,
            >            4217,
            >            4233,
            >            4250
            >        ],
            >        "maxMp": [
            >            0,
            >            54,
            >            66,
            >            893,
            >            896,
            >            900
            >        ],
            >        "speed": [
            >            0,
            >            64,
            >            83,
            >            102,
            >            122,
            >            1414,
            >            1420
            >        ]
            >    }
            >]
            >```
    * 😁 `skillTypes` property
        ■key: default
        * 😁 `skillTypes` array - default: None
            * default - ```None```
            * required - ['level', 'skillId']
            * 😁 `level` property
                * examples:
                    >```
                    >[
                    >    2,
                    >    3,
                    >    5,
                    >    8,
                    >    15,
                    >    25,
                    >    20
                    >]
                    >```
            * 😁 `skillId` property
                * examples:
                    >```
                    >[
                    >    "cbc13df7-48ab-4d6c-a562-72a852dc53a4",
                    >    "cee38191-44ae-48ad-bec1-6da93173f7b8",
                    >    "211533bc-abec-4654-9ebd-c101f9a332d8",
                    >    "3719f506-a496-4d2d-9bce-915c6df1c245",
                    >    "41d170d1-bf79-43e8-a845-b5e65502f1d0",
                    >    "670f16f6-159c-4cc6-95b2-5342a02e35b9",
                    >    "96c34a79-01df-4c91-9566-d978c44e6a82"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "level": 2,
                >        "skillId": "cbc13df7-48ab-4d6c-a562-72a852dc53a4"
                >    },
                >    {
                >        "level": 3,
                >        "skillId": "cee38191-44ae-48ad-bec1-6da93173f7b8"
                >    },
                >    {
                >        "level": 5,
                >        "skillId": "211533bc-abec-4654-9ebd-c101f9a332d8"
                >    },
                >    {
                >        "level": 8,
                >        "skillId": "3719f506-a496-4d2d-9bce-915c6df1c245"
                >    },
                >    {
                >        "level": 15,
                >        "skillId": "41d170d1-bf79-43e8-a845-b5e65502f1d0"
                >    },
                >    {
                >        "level": 25,
                >        "skillId": "670f16f6-159c-4cc6-95b2-5342a02e35b9"
                >    },
                >    {
                >        "level": 20,
                >        "skillId": "96c34a79-01df-4c91-9566-d978c44e6a82"
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "level": 2,
            >            "skillId": "cbc13df7-48ab-4d6c-a562-72a852dc53a4"
            >        },
            >        {
            >            "level": 3,
            >            "skillId": "cee38191-44ae-48ad-bec1-6da93173f7b8"
            >        },
            >        {
            >            "level": 5,
            >            "skillId": "211533bc-abec-4654-9ebd-c101f9a332d8"
            >        },
            >        {
            >            "level": 8,
            >            "skillId": "3719f506-a496-4d2d-9bce-915c6df1c245"
            >        },
            >        {
            >            "level": 15,
            >            "skillId": "41d170d1-bf79-43e8-a845-b5e65502f1d0"
            >        },
            >        {
            >            "level": 25,
            >            "skillId": "670f16f6-159c-4cc6-95b2-5342a02e35b9"
            >        },
            >        {
            >            "level": 20,
            >            "skillId": "96c34a79-01df-4c91-9566-d978c44e6a82"
            >        }
            >    ]
            >]
            >```
    * 😁 `traits` property
        ■key: default
        * 😁 `traits` array - default: None
            * default - ```None```
            * required - ['categoryId', 'effectId', 'traitsId', 'value']
            * 😁 `categoryId` property
                * examples:
                    >```
                    >[
                    >    2
                    >]
                    >```
            * 😁 `effectId` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1,
                    >    2
                    >]
                    >```
            * 😁 `traitsId` property
                * examples:
                    >```
                    >[
                    >    2,
                    >    3
                    >]
                    >```
            * 😁 `value` property
                * examples:
                    >```
                    >[
                    >    1000,
                    >    50,
                    >    60
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "categoryId": 2,
                >        "effectId": 0,
                >        "traitsId": 2,
                >        "value": 1000
                >    },
                >    {
                >        "categoryId": 2,
                >        "effectId": 1,
                >        "traitsId": 2,
                >        "value": 50
                >    },
                >    {
                >        "categoryId": 2,
                >        "effectId": 2,
                >        "traitsId": 2,
                >        "value": 60
                >    },
                >    {
                >        "categoryId": 2,
                >        "effectId": 0,
                >        "traitsId": 3,
                >        "value": 1000
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "categoryId": 2,
            >            "effectId": 0,
            >            "traitsId": 2,
            >            "value": 1000
            >        },
            >        {
            >            "categoryId": 2,
            >            "effectId": 1,
            >            "traitsId": 2,
            >            "value": 50
            >        },
            >        {
            >            "categoryId": 2,
            >            "effectId": 2,
            >            "traitsId": 2,
            >            "value": 60
            >        },
            >        {
            >            "categoryId": 2,
            >            "effectId": 0,
            >            "traitsId": 3,
            >            "value": 1000
            >        }
            >    ]
            >]
            >```
    * 😁 `weaponTypes` property
        ■key: default
        * 😁 `weaponTypes` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    "94e410c8-ecd3-4c9e-a844-c978fc6e21f2",
                >    "fe2c539e-10df-4d32-8103-b06ee37a157d",
                >    "bf7300f0-c155-492d-a171-6325d2677819"
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        "94e410c8-ecd3-4c9e-a844-c978fc6e21f2",
            >        "fe2c539e-10df-4d32-8103-b06ee37a157d",
            >        "bf7300f0-c155-492d-a171-6325d2677819"
            >    ]
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "abilityAdd": {
        >            "criticalRate": 1,
        >            "evasionRate": 1,
        >            "hitRate": 1
        >        },
        >        "abilityScore": {
        >            "attack": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 2250,
        >                "paramOne": 102,
        >                "paramPeakLv": 60
        >            },
        >            "defense": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 1380,
        >                "paramOne": 63,
        >                "paramPeakLv": 60
        >            },
        >            "luck": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 770,
        >                "paramOne": 35,
        >                "paramPeakLv": 60
        >            },
        >            "magicAttack": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 985,
        >                "paramOne": 45,
        >                "paramPeakLv": 60
        >            },
        >            "magicDefense": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 1000,
        >                "paramOne": 50,
        >                "paramPeakLv": 60
        >            },
        >            "maxHp": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 4250,
        >                "paramOne": 235,
        >                "paramPeakLv": 60
        >            },
        >            "maxMp": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 900,
        >                "paramOne": 54,
        >                "paramPeakLv": 60
        >            },
        >            "speed": {
        >                "enabled": 0,
        >                "growType": 0,
        >                "paramMax": 1420,
        >                "paramOne": 64,
        >                "paramPeakLv": 60
        >            }
        >        },
        >        "abilitySp": {
        >            "targetedRate": 100
        >        },
        >        "armorTypes": [
        >            "1",
        >            "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
        >            "c01b25d3-bdb5-4c23-a375-dcfdc05abad6",
        >            "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594"
        >        ],
        >        "autoGuide": {
        >            "attack": 8,
        >            "defense": 6,
        >            "luck": 5,
        >            "magicAttack": 4,
        >            "magicDefense": 4,
        >            "maxHp": 2,
        >            "maxMp": 0,
        >            "speed": 3
        >        },
        >        "baseHpMaxValue": 5000,
        >        "basic": {
        >            "abilityEnabled": {
        >                "luck": 1,
        >                "magicAttack": 1,
        >                "magicDefense": 1,
        >                "mp": 1,
        >                "speed": 1,
        >                "tp": 1
        >            },
        >            "expMax": 1,
        >            "hpMax": 1,
        >            "id": "ce89f973-6ed6-41fc-99d7-e3ca5fc1ce8c",
        >            "level": {
        >                "levelGameClear": 1,
        >                "levelMax": 99
        >            },
        >            "maxLevel": 1,
        >            "name": "Hero"
        >        },
        >        "clearLevel": 60,
        >        "element": "0",
        >        "expGainIncreaseValue": 1000000,
        >        "expScore": {
        >            "growType": 10,
        >            "increaseValueA": 10,
        >            "increaseValueB": 10
        >        },
        >        "id": "39450ee1-598b-4a2e-b249-b615cd2a2ea5",
        >        "maxLevel": 99,
        >        "parameter": {
        >            "attack": [
        >                0,
        >                102,
        >                132,
        >                163,
        >                2241,
        >                2250
        >            ],
        >            "defense": [
        >                0,
        >                1380
        >            ],
        >            "luck": [
        >                0,
        >                35,
        >                45,
        >                731,
        >                734,
        >                767,
        >                770
        >            ],
        >            "magicAttack": [
        >                0,
        >                45,
        >                58,
        >                676,
        >                981,
        >                985
        >            ],
        >            "magicDefense": [
        >                0,
        >                50,
        >                63,
        >                992,
        >                996,
        >                1000
        >            ],
        >            "maxHp": [
        >                0,
        >                235,
        >                292,
        >                4217,
        >                4233,
        >                4250
        >            ],
        >            "maxMp": [
        >                0,
        >                54,
        >                66,
        >                893,
        >                896,
        >                900
        >            ],
        >            "speed": [
        >                0,
        >                64,
        >                83,
        >                102,
        >                122,
        >                1414,
        >                1420
        >            ]
        >        },
        >        "skillTypes": [
        >            {
        >                "level": 2,
        >                "skillId": "cbc13df7-48ab-4d6c-a562-72a852dc53a4"
        >            },
        >            {
        >                "level": 3,
        >                "skillId": "cee38191-44ae-48ad-bec1-6da93173f7b8"
        >            },
        >            {
        >                "level": 5,
        >                "skillId": "211533bc-abec-4654-9ebd-c101f9a332d8"
        >            },
        >            {
        >                "level": 8,
        >                "skillId": "3719f506-a496-4d2d-9bce-915c6df1c245"
        >            },
        >            {
        >                "level": 15,
        >                "skillId": "41d170d1-bf79-43e8-a845-b5e65502f1d0"
        >            },
        >            {
        >                "level": 25,
        >                "skillId": "670f16f6-159c-4cc6-95b2-5342a02e35b9"
        >            },
        >            {
        >                "level": 20,
        >                "skillId": "96c34a79-01df-4c91-9566-d978c44e6a82"
        >            }
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 2,
        >                "effectId": 0,
        >                "traitsId": 2,
        >                "value": 1000
        >            },
        >            {
        >                "categoryId": 2,
        >                "effectId": 1,
        >                "traitsId": 2,
        >                "value": 50
        >            },
        >            {
        >                "categoryId": 2,
        >                "effectId": 2,
        >                "traitsId": 2,
        >                "value": 60
        >            },
        >            {
        >                "categoryId": 2,
        >                "effectId": 0,
        >                "traitsId": 3,
        >                "value": 1000
        >            }
        >        ],
        >        "weaponTypes": [
        >            "94e410c8-ecd3-4c9e-a844-c978fc6e21f2",
        >            "fe2c539e-10df-4d32-8103-b06ee37a157d",
        >            "bf7300f0-c155-492d-a171-6325d2677819"
        >        ]
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "abilityAdd": {
    >                "criticalRate": 1,
    >                "evasionRate": 1,
    >                "hitRate": 1
    >            },
    >            "abilityScore": {
    >                "attack": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 2250,
    >                    "paramOne": 102,
    >                    "paramPeakLv": 60
    >                },
    >                "defense": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 1380,
    >                    "paramOne": 63,
    >                    "paramPeakLv": 60
    >                },
    >                "luck": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 770,
    >                    "paramOne": 35,
    >                    "paramPeakLv": 60
    >                },
    >                "magicAttack": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 985,
    >                    "paramOne": 45,
    >                    "paramPeakLv": 60
    >                },
    >                "magicDefense": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 1000,
    >                    "paramOne": 50,
    >                    "paramPeakLv": 60
    >                },
    >                "maxHp": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 4250,
    >                    "paramOne": 235,
    >                    "paramPeakLv": 60
    >                },
    >                "maxMp": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 900,
    >                    "paramOne": 54,
    >                    "paramPeakLv": 60
    >                },
    >                "speed": {
    >                    "enabled": 0,
    >                    "growType": 0,
    >                    "paramMax": 1420,
    >                    "paramOne": 64,
    >                    "paramPeakLv": 60
    >                }
    >            },
    >            "abilitySp": {
    >                "targetedRate": 100
    >            },
    >            "armorTypes": [
    >                "1",
    >                "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
    >                "c01b25d3-bdb5-4c23-a375-dcfdc05abad6",
    >                "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594"
    >            ],
    >            "autoGuide": {
    >                "attack": 8,
    >                "defense": 6,
    >                "luck": 5,
    >                "magicAttack": 4,
    >                "magicDefense": 4,
    >                "maxHp": 2,
    >                "maxMp": 0,
    >                "speed": 3
    >            },
    >            "baseHpMaxValue": 5000,
    >            "basic": {
    >                "abilityEnabled": {
    >                    "luck": 1,
    >                    "magicAttack": 1,
    >                    "magicDefense": 1,
    >                    "mp": 1,
    >                    "speed": 1,
    >                    "tp": 1
    >                },
    >                "expMax": 1,
    >                "hpMax": 1,
    >                "id": "ce89f973-6ed6-41fc-99d7-e3ca5fc1ce8c",
    >                "level": {
    >                    "levelGameClear": 1,
    >                    "levelMax": 99
    >                },
    >                "maxLevel": 1,
    >                "name": "Hero"
    >            },
    >            "clearLevel": 60,
    >            "element": "0",
    >            "expGainIncreaseValue": 1000000,
    >            "expScore": {
    >                "growType": 10,
    >                "increaseValueA": 10,
    >                "increaseValueB": 10
    >            },
    >            "id": "39450ee1-598b-4a2e-b249-b615cd2a2ea5",
    >            "maxLevel": 99,
    >            "parameter": {
    >                "attack": [
    >                    0,
    >                    102,
    >                    132,
    >                    163,
    >                    2241,
    >                    2250
    >                ],
    >                "defense": [
    >                    0,
    >                    1380
    >                ],
    >                "luck": [
    >                    0,
    >                    35,
    >                    45,
    >                    731,
    >                    734,
    >                    767,
    >                    770
    >                ],
    >                "magicAttack": [
    >                    0,
    >                    45,
    >                    58,
    >                    676,
    >                    981,
    >                    985
    >                ],
    >                "magicDefense": [
    >                    0,
    >                    50,
    >                    63,
    >                    992,
    >                    996,
    >                    1000
    >                ],
    >                "maxHp": [
    >                    0,
    >                    235,
    >                    292,
    >                    4217,
    >                    4233,
    >                    4250
    >                ],
    >                "maxMp": [
    >                    0,
    >                    54,
    >                    66,
    >                    893,
    >                    896,
    >                    900
    >                ],
    >                "speed": [
    >                    0,
    >                    64,
    >                    83,
    >                    102,
    >                    122,
    >                    1414,
    >                    1420
    >                ]
    >            },
    >            "skillTypes": [
    >                {
    >                    "level": 2,
    >                    "skillId": "cbc13df7-48ab-4d6c-a562-72a852dc53a4"
    >                },
    >                {
    >                    "level": 3,
    >                    "skillId": "cee38191-44ae-48ad-bec1-6da93173f7b8"
    >                },
    >                {
    >                    "level": 5,
    >                    "skillId": "211533bc-abec-4654-9ebd-c101f9a332d8"
    >                },
    >                {
    >                    "level": 8,
    >                    "skillId": "3719f506-a496-4d2d-9bce-915c6df1c245"
    >                },
    >                {
    >                    "level": 15,
    >                    "skillId": "41d170d1-bf79-43e8-a845-b5e65502f1d0"
    >                },
    >                {
    >                    "level": 25,
    >                    "skillId": "670f16f6-159c-4cc6-95b2-5342a02e35b9"
    >                },
    >                {
    >                    "level": 20,
    >                    "skillId": "96c34a79-01df-4c91-9566-d978c44e6a82"
    >                }
    >            ],
    >            "traits": [
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 0,
    >                    "traitsId": 2,
    >                    "value": 1000
    >                },
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 1,
    >                    "traitsId": 2,
    >                    "value": 50
    >                },
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 2,
    >                    "traitsId": 2,
    >                    "value": 60
    >                },
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 0,
    >                    "traitsId": 3,
    >                    "value": 1000
    >                }
    >            ],
    >            "weaponTypes": [
    >                "94e410c8-ecd3-4c9e-a844-c978fc6e21f2",
    >                "fe2c539e-10df-4d32-8103-b06ee37a157d",
    >                "bf7300f0-c155-492d-a171-6325d2677819"
    >            ]
    >        }
    >    ]
    >]
    >```
