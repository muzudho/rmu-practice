# JSON schema: Assets RPGMaker Storage Initializations JSON weaponTest

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['basic', 'parameters', 'traits', 'memo', 'deleted']
    * 😁 `basic` property
        * required - ['id', 'name', 'description', 'equipmentTypeId', 'weaponTypeId', 'price', 'sell', 'canSell', 'switchItem']
        * 😁 `id` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `description` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `equipmentTypeId` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `weaponTypeId` property
            * examples:
                >```
                >[
                >    2
                >]
                >```
        * 😁 `price` property
            * examples:
                >```
                >[
                >    500
                >]
                >```
        * 😁 `sell` property
            * examples:
                >```
                >[
                >    50
                >]
                >```
        * 😁 `canSell` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `switchItem` property
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
        * 😁 `parameters` array - default: []
            * default - ```[]```
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
        * required - ['physics', 'hitRate']
        * 😁 `physics` property
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `hitRate` property
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
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `deleted` property
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
