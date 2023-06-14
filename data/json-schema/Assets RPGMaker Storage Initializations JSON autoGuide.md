# JSON schema: Assets RPGMaker Storage Initializations JSON autoGuide

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    ■key: default
    * required - ['id', 'baseParameterRatio', 'weaponRatio', 'armorRatio', 'delete']
    * 😁 `id` property
        ■key: default
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `baseParameterRatio` property
        ■key: default
        * 😁 `baseParameterRatio` array - default: None
            * default - ```None```
            ■key: default
            * required - ['maxHp', 'maxMp', 'attack', 'defense', 'magicAttack', 'magicDefense', 'speed', 'luck']
            * 😁 `maxHp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1.0
                    >]
                    >```
            * 😁 `maxMp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.6000000238418579
                    >]
                    >```
            * 😁 `attack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0625
                    >]
                    >```
            * 😁 `defense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.04500000178813934
                    >]
                    >```
            * 😁 `magicAttack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.05000000074505806
                    >]
                    >```
            * 😁 `magicDefense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.03999999910593033
                    >]
                    >```
            * 😁 `speed` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.05000000074505806
                    >]
                    >```
            * 😁 `luck` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.029999999329447746
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "maxHp": 1.0,
                >        "maxMp": 0.6000000238418579,
                >        "attack": 0.0625,
                >        "defense": 0.04500000178813934,
                >        "magicAttack": 0.05000000074505806,
                >        "magicDefense": 0.03999999910593033,
                >        "speed": 0.05000000074505806,
                >        "luck": 0.029999999329447746
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "maxHp": 1.0,
            >            "maxMp": 0.6000000238418579,
            >            "attack": 0.0625,
            >            "defense": 0.04500000178813934,
            >            "magicAttack": 0.05000000074505806,
            >            "magicDefense": 0.03999999910593033,
            >            "speed": 0.05000000074505806,
            >            "luck": 0.029999999329447746
            >        }
            >    ]
            >]
            >```
    * 😁 `weaponRatio` property
        ■key: default
        * 😁 `weaponRatio` array - default: None
            * default - ```None```
            ■key: default
            * required - ['maxHp', 'maxMp', 'attack', 'defense', 'magicAttack', 'magicDefense', 'speed', 'luck']
            * 😁 `maxHp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `maxMp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `attack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.6000000238418579
                    >]
                    >```
            * 😁 `defense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `magicAttack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `magicDefense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `speed` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `luck` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "maxHp": 0.0,
                >        "maxMp": 0.0,
                >        "attack": 0.6000000238418579,
                >        "defense": 0.0,
                >        "magicAttack": 0.0,
                >        "magicDefense": 0.0,
                >        "speed": 0.0,
                >        "luck": 0.0
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "maxHp": 0.0,
            >            "maxMp": 0.0,
            >            "attack": 0.6000000238418579,
            >            "defense": 0.0,
            >            "magicAttack": 0.0,
            >            "magicDefense": 0.0,
            >            "speed": 0.0,
            >            "luck": 0.0
            >        }
            >    ]
            >]
            >```
    * 😁 `armorRatio` property
        ■key: default
        * 😁 `armorRatio` array - default: None
            * default - ```None```
            ■key: default
            * required - ['maxHp', 'maxMp', 'attack', 'defense', 'magicAttack', 'magicDefense', 'speed', 'luck']
            * 😁 `maxHp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `maxMp` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `attack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `defense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.4000000059604645
                    >]
                    >```
            * 😁 `magicAttack` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `magicDefense` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `speed` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `luck` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "maxHp": 0.0,
                >        "maxMp": 0.0,
                >        "attack": 0.0,
                >        "defense": 0.4000000059604645,
                >        "magicAttack": 0.0,
                >        "magicDefense": 0.0,
                >        "speed": 0.0,
                >        "luck": 0.0
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "maxHp": 0.0,
            >            "maxMp": 0.0,
            >            "attack": 0.0,
            >            "defense": 0.4000000059604645,
            >            "magicAttack": 0.0,
            >            "magicDefense": 0.0,
            >            "speed": 0.0,
            >            "luck": 0.0
            >        }
            >    ]
            >]
            >```
    * 😁 `delete` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "id": "",
        >        "baseParameterRatio": [
        >            {
        >                "maxHp": 1.0,
        >                "maxMp": 0.6000000238418579,
        >                "attack": 0.0625,
        >                "defense": 0.04500000178813934,
        >                "magicAttack": 0.05000000074505806,
        >                "magicDefense": 0.03999999910593033,
        >                "speed": 0.05000000074505806,
        >                "luck": 0.029999999329447746
        >            }
        >        ],
        >        "weaponRatio": [
        >            {
        >                "maxHp": 0.0,
        >                "maxMp": 0.0,
        >                "attack": 0.6000000238418579,
        >                "defense": 0.0,
        >                "magicAttack": 0.0,
        >                "magicDefense": 0.0,
        >                "speed": 0.0,
        >                "luck": 0.0
        >            }
        >        ],
        >        "armorRatio": [
        >            {
        >                "maxHp": 0.0,
        >                "maxMp": 0.0,
        >                "attack": 0.0,
        >                "defense": 0.4000000059604645,
        >                "magicAttack": 0.0,
        >                "magicDefense": 0.0,
        >                "speed": 0.0,
        >                "luck": 0.0
        >            }
        >        ],
        >        "delete": 0
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "id": "",
    >            "baseParameterRatio": [
    >                {
    >                    "maxHp": 1.0,
    >                    "maxMp": 0.6000000238418579,
    >                    "attack": 0.0625,
    >                    "defense": 0.04500000178813934,
    >                    "magicAttack": 0.05000000074505806,
    >                    "magicDefense": 0.03999999910593033,
    >                    "speed": 0.05000000074505806,
    >                    "luck": 0.029999999329447746
    >                }
    >            ],
    >            "weaponRatio": [
    >                {
    >                    "maxHp": 0.0,
    >                    "maxMp": 0.0,
    >                    "attack": 0.6000000238418579,
    >                    "defense": 0.0,
    >                    "magicAttack": 0.0,
    >                    "magicDefense": 0.0,
    >                    "speed": 0.0,
    >                    "luck": 0.0
    >                }
    >            ],
    >            "armorRatio": [
    >                {
    >                    "maxHp": 0.0,
    >                    "maxMp": 0.0,
    >                    "attack": 0.0,
    >                    "defense": 0.4000000059604645,
    >                    "magicAttack": 0.0,
    >                    "magicDefense": 0.0,
    >                    "speed": 0.0,
    >                    "luck": 0.0
    >                }
    >            ],
    >            "delete": 0
    >        }
    >    ]
    >]
    >```
