# JSON schema: Assets RPGMaker Storage Initializations JSON autoGuide

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['id', 'baseParameterRatio', 'weaponRatio', 'armorRatio', 'delete']
    * 😁 `id` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `baseParameterRatio` property
        * 😁 `baseParameterRatio` array - default: []
            * default - ```[]```
            * required - ['maxHp', 'maxMp', 'attack', 'defense', 'magicAttack', 'magicDefense', 'speed', 'luck']
            * 😁 `maxHp` property
                * examples:
                    >```
                    >[
                    >    1.0
                    >]
                    >```
            * 😁 `maxMp` property
                * examples:
                    >```
                    >[
                    >    0.6000000238418579
                    >]
                    >```
            * 😁 `attack` property
                * examples:
                    >```
                    >[
                    >    0.0625
                    >]
                    >```
            * 😁 `defense` property
                * examples:
                    >```
                    >[
                    >    0.04500000178813934
                    >]
                    >```
            * 😁 `magicAttack` property
                * examples:
                    >```
                    >[
                    >    0.05000000074505806
                    >]
                    >```
            * 😁 `magicDefense` property
                * examples:
                    >```
                    >[
                    >    0.03999999910593033
                    >]
                    >```
            * 😁 `speed` property
                * examples:
                    >```
                    >[
                    >    0.05000000074505806
                    >]
                    >```
            * 😁 `luck` property
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
        * 😁 `weaponRatio` array - default: []
            * default - ```[]```
            * required - ['maxHp', 'maxMp', 'attack', 'defense', 'magicAttack', 'magicDefense', 'speed', 'luck']
            * 😁 `maxHp` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `maxMp` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `attack` property
                * examples:
                    >```
                    >[
                    >    0.6000000238418579
                    >]
                    >```
            * 😁 `defense` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `magicAttack` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `magicDefense` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `speed` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `luck` property
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
        * 😁 `armorRatio` array - default: []
            * default - ```[]```
            * required - ['maxHp', 'maxMp', 'attack', 'defense', 'magicAttack', 'magicDefense', 'speed', 'luck']
            * 😁 `maxHp` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `maxMp` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `attack` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `defense` property
                * examples:
                    >```
                    >[
                    >    0.4000000059604645
                    >]
                    >```
            * 😁 `magicAttack` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `magicDefense` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `speed` property
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `luck` property
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
