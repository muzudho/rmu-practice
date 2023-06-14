# JSON schema: Assets RPGMaker Storage Initializations JSON weaponTest

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    ■key: default
    * required - ['basic', 'parameters', 'traits', 'memo', 'deleted']
    * 😁 `basic` property
        ■key: default
        * required - ['id', 'name', 'description', 'equipmentTypeId', 'weaponTypeId', 'price', 'sell', 'canSell', 'switchItem']
        * 😁 `id` property
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
                >    ""
                >]
                >```
        * 😁 `description` property
            ■key: default
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `equipmentTypeId` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `weaponTypeId` property
            ■key: default
            * examples:
                >```
                >[
                >    2
                >]
                >```
        * 😁 `price` property
            ■key: default
            * examples:
                >```
                >[
                >    500
                >]
                >```
        * 😁 `sell` property
            ■key: default
            * examples:
                >```
                >[
                >    50
                >]
                >```
        * 😁 `canSell` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `switchItem` property
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
            >        "id": 1,
            >        "name": "",
            >        "description": "",
            >        "equipmentTypeId": 1,
            >        "weaponTypeId": 2,
            >        "price": 500,
            >        "sell": 50,
            >        "canSell": 1,
            >        "switchItem": 1
            >    }
            >]
            >```
    * 😁 `parameters` property
        ■key: default
        * 😁 `parameters` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        0,
            >        0
            >    ]
            >]
            >```
    * 😁 `traits` property
        ■key: default
        * required - ['physics', 'hitRate']
        * 😁 `physics` property
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
                >    100
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "physics": 1,
            >        "hitRate": 100
            >    }
            >]
            >```
    * 😁 `memo` property
        ■key: default
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `deleted` property
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
        >        "basic": {
        >            "id": 1,
        >            "name": "",
        >            "description": "",
        >            "equipmentTypeId": 1,
        >            "weaponTypeId": 2,
        >            "price": 500,
        >            "sell": 50,
        >            "canSell": 1,
        >            "switchItem": 1
        >        },
        >        "parameters": [
        >            0,
        >            0
        >        ],
        >        "traits": {
        >            "physics": 1,
        >            "hitRate": 100
        >        },
        >        "memo": "",
        >        "deleted": 0
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "basic": {
    >                "id": 1,
    >                "name": "",
    >                "description": "",
    >                "equipmentTypeId": 1,
    >                "weaponTypeId": 2,
    >                "price": 500,
    >                "sell": 50,
    >                "canSell": 1,
    >                "switchItem": 1
    >            },
    >            "parameters": [
    >                0,
    >                0
    >            ],
    >            "traits": {
    >                "physics": 1,
    >                "hitRate": 100
    >            },
    >            "memo": "",
    >            "deleted": 0
    >        }
    >    ]
    >]
    >```
