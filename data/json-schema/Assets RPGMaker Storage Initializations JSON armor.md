# JSON schema: Assets RPGMaker Storage Initializations JSON armor

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['basic', 'memo', 'parameters', 'traits']
    * 😁 `basic` property
        * required - ['animationId', 'armorTypeId', 'canSell', 'description', 'equipmentTypeId', 'iconId', 'id', 'name', 'price', 'sell', 'switchItem']
        * 😁 `animationId` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `armorTypeId` property
            * examples:
                >```
                >[
                >    "0",
                >    "1",
                >    "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
                >    "ef649a06-d430-49b8-a81d-6c73d26afb02",
                >    "b4bcd669-5923-47e4-aef2-791a6256ce89"
                >]
                >```
        * 😁 `canSell` property
            * examples:
                >```
                >[
                >    1,
                >    0
                >]
                >```
        * 😁 `description` property
            * examples:
                >```
                >[
                >    "",
                >    "[Common] Clothes made with highly breathable fabric.",
                >    "[Large Shield] A large wooden shield reinforced with leather.",
                >    "[Large Shield] A rather ordinary large wooden shield."
                >]
                >```
        * 😁 `equipmentTypeId` property
            * examples:
                >```
                >[
                >    "0",
                >    "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
                >    "7832ae68-aecc-4724-8765-e8e04e3cb64f"
                >]
                >```
        * 😁 `iconId` property
            * examples:
                >```
                >[
                >    "IconSet_000",
                >    "IconSet_135",
                >    "IconSet_137",
                >    "IconSet_139",
                >    "IconSet_129",
                >    "IconSet_128"
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "51ec1c98-b2b3-49bc-b488-fc945381eaa0",
                >    "2f1bced4-122a-4ee2-98fa-bd80f381036d",
                >    "22f5f3b0-c9cd-44b4-9dac-e96244a0feb0"
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "-----Armor",
                >    "Linen Clothing",
                >    "Sage's Robe",
                >    "-----Shields",
                >    "Buckler",
                >    "Wooden Shield"
                >]
                >```
        * 😁 `price` property
            * examples:
                >```
                >[
                >    0,
                >    115,
                >    220
                >]
                >```
        * 😁 `sell` property
            * examples:
                >```
                >[
                >    0,
                >    69,
                >    132
                >]
                >```
        * 😁 `switchItem` property
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
            >        "animationId": "",
            >        "armorTypeId": "0",
            >        "canSell": 1,
            >        "description": "",
            >        "equipmentTypeId": "0",
            >        "iconId": "IconSet_000",
            >        "id": "51ec1c98-b2b3-49bc-b488-fc945381eaa0",
            >        "name": "-----Armor",
            >        "price": 0,
            >        "sell": 0,
            >        "switchItem": 0
            >    },
            >    {
            >        "animationId": "",
            >        "armorTypeId": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
            >        "canSell": 0,
            >        "description": "[Large Shield] A large wooden shield reinforced with leather.",
            >        "equipmentTypeId": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
            >        "iconId": "IconSet_128",
            >        "id": "61edc1cf-0b24-4a1e-a835-6e0f7929da4b",
            >        "name": "Leather Shield",
            >        "price": 241,
            >        "sell": 144,
            >        "switchItem": 0
            >    },
            >    {
            >        "animationId": "",
            >        "armorTypeId": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
            >        "canSell": 0,
            >        "description": "[Large Shield] A rather ordinary large wooden shield.",
            >        "equipmentTypeId": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
            >        "iconId": "IconSet_128",
            >        "id": "22f5f3b0-c9cd-44b4-9dac-e96244a0feb0",
            >        "name": "Wooden Shield",
            >        "price": 467,
            >        "sell": 280,
            >        "switchItem": 0
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
    * 😁 `parameters` property
        * 😁 `parameters` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    0,
                >    1,
                >    23
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        0,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0
            >    ],
            >    [
            >        15,
            >        0,
            >        0,
            >        103,
            >        0,
            >        6,
            >        0,
            >        0,
            >        0
            >    ],
            >    [
            >        20,
            >        0,
            >        0,
            >        133,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0
            >    ],
            >    [
            >        4,
            >        0,
            >        0,
            >        36,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0
            >    ],
            >    [
            >        6,
            >        0,
            >        0,
            >        48,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0
            >    ]
            >]
            >```
    * 😁 `traits` property
        * 😁 `traits` array - default: None
            * default - ```None```
            * required - ['categoryId', 'effectId', 'traitsId', 'value']
            * 😁 `categoryId` property
                * examples:
                    >```
                    >[
                    >    2,
                    >    1
                    >]
                    >```
            * 😁 `effectId` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    3
                    >]
                    >```
            * 😁 `traitsId` property
                * examples:
                    >```
                    >[
                    >    2,
                    >    1
                    >]
                    >```
            * 😁 `value` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    100
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "categoryId": 2,
                >        "effectId": 1,
                >        "traitsId": 2,
                >        "value": 0
                >    },
                >    {
                >        "categoryId": 1,
                >        "effectId": 3,
                >        "traitsId": 1,
                >        "value": 100
                >    },
                >    {
                >        "categoryId": 2,
                >        "effectId": 1,
                >        "traitsId": 2,
                >        "value": 0
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [],
            >    [
            >        {
            >            "categoryId": 2,
            >            "effectId": 1,
            >            "traitsId": 2,
            >            "value": 0
            >        }
            >    ],
            >    [
            >        {
            >            "categoryId": 2,
            >            "effectId": 1,
            >            "traitsId": 2,
            >            "value": 0
            >        },
            >        {
            >            "categoryId": 1,
            >            "effectId": 3,
            >            "traitsId": 1,
            >            "value": 100
            >        }
            >    ],
            >    [
            >        {
            >            "categoryId": 2,
            >            "effectId": 1,
            >            "traitsId": 2,
            >            "value": 0
            >        }
            >    ],
            >    [
            >        {
            >            "categoryId": 2,
            >            "effectId": 1,
            >            "traitsId": 2,
            >            "value": 0
            >        }
            >    ]
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "basic": {
        >            "animationId": "",
        >            "armorTypeId": "0",
        >            "canSell": 1,
        >            "description": "",
        >            "equipmentTypeId": "0",
        >            "iconId": "IconSet_000",
        >            "id": "51ec1c98-b2b3-49bc-b488-fc945381eaa0",
        >            "name": "-----Armor",
        >            "price": 0,
        >            "sell": 0,
        >            "switchItem": 0
        >        },
        >        "memo": "",
        >        "parameters": [
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": []
        >    },
        >    {
        >        "basic": {
        >            "animationId": "",
        >            "armorTypeId": "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
        >            "canSell": 0,
        >            "description": "[Light] Clothes commonly found in desert regions.",
        >            "equipmentTypeId": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
        >            "iconId": "IconSet_135",
        >            "id": "1e25ae15-8f1d-442c-8e47-3d2953acf0ac",
        >            "name": "Desert Vest",
        >            "price": 11029,
        >            "sell": 6617,
        >            "switchItem": 0
        >        },
        >        "memo": "",
        >        "parameters": [
        >            20,
        >            0,
        >            0,
        >            175,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 2,
        >                "effectId": 1,
        >                "traitsId": 2,
        >                "value": 0
        >            },
        >            {
        >                "categoryId": 1,
        >                "effectId": 3,
        >                "traitsId": 1,
        >                "value": 100
        >            }
        >        ]
        >    },
        >    {
        >        "basic": {
        >            "animationId": "",
        >            "armorTypeId": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
        >            "canSell": 0,
        >            "description": "[Large Shield] A large wooden shield reinforced with leather.",
        >            "equipmentTypeId": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
        >            "iconId": "IconSet_128",
        >            "id": "61edc1cf-0b24-4a1e-a835-6e0f7929da4b",
        >            "name": "Leather Shield",
        >            "price": 241,
        >            "sell": 144,
        >            "switchItem": 0
        >        },
        >        "memo": "",
        >        "parameters": [
        >            4,
        >            0,
        >            0,
        >            36,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 2,
        >                "effectId": 1,
        >                "traitsId": 2,
        >                "value": 0
        >            }
        >        ]
        >    },
        >    {
        >        "basic": {
        >            "animationId": "",
        >            "armorTypeId": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
        >            "canSell": 0,
        >            "description": "[Large Shield] A rather ordinary large wooden shield.",
        >            "equipmentTypeId": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
        >            "iconId": "IconSet_128",
        >            "id": "22f5f3b0-c9cd-44b4-9dac-e96244a0feb0",
        >            "name": "Wooden Shield",
        >            "price": 467,
        >            "sell": 280,
        >            "switchItem": 0
        >        },
        >        "memo": "",
        >        "parameters": [
        >            6,
        >            0,
        >            0,
        >            48,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 2,
        >                "effectId": 1,
        >                "traitsId": 2,
        >                "value": 0
        >            }
        >        ]
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "basic": {
    >                "animationId": "",
    >                "armorTypeId": "0",
    >                "canSell": 1,
    >                "description": "",
    >                "equipmentTypeId": "0",
    >                "iconId": "IconSet_000",
    >                "id": "51ec1c98-b2b3-49bc-b488-fc945381eaa0",
    >                "name": "-----Armor",
    >                "price": 0,
    >                "sell": 0,
    >                "switchItem": 0
    >            },
    >            "memo": "",
    >            "parameters": [
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0
    >            ],
    >            "traits": []
    >        },
    >        {
    >            "basic": {
    >                "animationId": "",
    >                "armorTypeId": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
    >                "canSell": 0,
    >                "description": "[Large Shield] A large wooden shield reinforced with leather.",
    >                "equipmentTypeId": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
    >                "iconId": "IconSet_128",
    >                "id": "61edc1cf-0b24-4a1e-a835-6e0f7929da4b",
    >                "name": "Leather Shield",
    >                "price": 241,
    >                "sell": 144,
    >                "switchItem": 0
    >            },
    >            "memo": "",
    >            "parameters": [
    >                4,
    >                0,
    >                0,
    >                36,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0
    >            ],
    >            "traits": [
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 1,
    >                    "traitsId": 2,
    >                    "value": 0
    >                }
    >            ]
    >        },
    >        {
    >            "basic": {
    >                "animationId": "",
    >                "armorTypeId": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
    >                "canSell": 0,
    >                "description": "[Large Shield] A rather ordinary large wooden shield.",
    >                "equipmentTypeId": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
    >                "iconId": "IconSet_128",
    >                "id": "22f5f3b0-c9cd-44b4-9dac-e96244a0feb0",
    >                "name": "Wooden Shield",
    >                "price": 467,
    >                "sell": 280,
    >                "switchItem": 0
    >            },
    >            "memo": "",
    >            "parameters": [
    >                6,
    >                0,
    >                0,
    >                48,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0
    >            ],
    >            "traits": [
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 1,
    >                    "traitsId": 2,
    >                    "value": 0
    >                }
    >            ]
    >        }
    >    ]
    >]
    >```
