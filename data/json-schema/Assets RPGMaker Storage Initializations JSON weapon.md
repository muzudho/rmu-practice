# JSON schema: Assets RPGMaker Storage Initializations JSON weapon

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['basic', 'memo', 'parameters', 'traits']
    * 😁 `basic` property
        * required - ['animationId', 'canSell', 'description', 'equipmentTypeId', 'iconId', 'id', 'name', 'price', 'sell', 'switchItem', 'weaponTypeId']
        * 😁 `animationId` property
            * examples:
                >```
                >[
                >    "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
                >    "5a4e5e29-5f55-408e-b17d-d69c9ee0e43b"
                >]
                >```
        * 😁 `canSell` property
            * examples:
                >```
                >[
                >    0,
                >    1
                >]
                >```
        * 😁 `description` property
            * examples:
                >```
                >[
                >    "[Sword] A light and wieldy sword with a short blade.",
                >    "[Sword] A sword with a long, razor-sharp blade that's well-suited for combat.",
                >    "[Axe] A battle axe made of dragonstooth."
                >]
                >```
        * 😁 `equipmentTypeId` property
            * examples:
                >```
                >[
                >    "48254f68-178f-448e-98fd-60a0bb616a28"
                >]
                >```
        * 😁 `iconId` property
            * examples:
                >```
                >[
                >    "IconSet_097",
                >    "IconSet_101",
                >    "IconSet_098"
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "661cb624-e856-494e-94b8-0e41064e90b0",
                >    "88790220-72d8-4b34-95ec-947af47a5e22",
                >    "937258c9-c5f5-48ca-9a4d-ebc65c55a429"
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "Shortsword",
                >    "Longsword",
                >    "Dragon Axe"
                >]
                >```
        * 😁 `price` property
            * examples:
                >```
                >[
                >    280,
                >    530,
                >    999
                >]
                >```
        * 😁 `sell` property
            * examples:
                >```
                >[
                >    168,
                >    318,
                >    599
                >]
                >```
        * 😁 `switchItem` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `weaponTypeId` property
            * examples:
                >```
                >[
                >    "94e410c8-ecd3-4c9e-a844-c978fc6e21f2",
                >    "159ea6ce-ea6b-43f8-9521-6fc800565100",
                >    "608a2682-8841-4e0d-8e6b-752bfb8d9027"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
            >        "canSell": 0,
            >        "description": "[Sword] A light and wieldy sword with a short blade.",
            >        "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
            >        "iconId": "IconSet_097",
            >        "id": "661cb624-e856-494e-94b8-0e41064e90b0",
            >        "name": "Shortsword",
            >        "price": 280,
            >        "sell": 168,
            >        "switchItem": 0,
            >        "weaponTypeId": "94e410c8-ecd3-4c9e-a844-c978fc6e21f2"
            >    },
            >    {
            >        "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
            >        "canSell": 0,
            >        "description": "[Axe] A battle axe bearing a mythril blade.",
            >        "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
            >        "iconId": "IconSet_099",
            >        "id": "379b6433-199f-46b4-a0c8-d34e1a98ff72",
            >        "name": "Mythril Axe",
            >        "price": 4500,
            >        "sell": 2250,
            >        "switchItem": 0,
            >        "weaponTypeId": "7b0de0fe-7cea-4f68-a89e-4dfb403b1017"
            >    },
            >    {
            >        "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
            >        "canSell": 0,
            >        "description": "[Axe] A battle axe made of dragonstooth.",
            >        "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
            >        "iconId": "IconSet_099",
            >        "id": "937258c9-c5f5-48ca-9a4d-ebc65c55a429",
            >        "name": "Dragon Axe",
            >        "price": 9600,
            >        "sell": 4800,
            >        "switchItem": 0,
            >        "weaponTypeId": "7b0de0fe-7cea-4f68-a89e-4dfb403b1017"
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
                >    1,
                >    0,
                >    56
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        1,
            >        0,
            >        56,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0
            >    ],
            >    [
            >        3,
            >        0,
            >        94,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0,
            >        0
            >    ],
            >    [
            >        0,
            >        0,
            >        45,
            >        0,
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
                    >    3,
                    >    2
                    >]
                    >```
            * 😁 `effectId` property
                * examples:
                    >```
                    >[
                    >    2,
                    >    0,
                    >    8
                    >]
                    >```
            * 😁 `traitsId` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    2,
                    >    4
                    >]
                    >```
            * 😁 `value` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1000,
                    >    2,
                    >    50
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "categoryId": 3,
                >        "effectId": 2,
                >        "traitsId": 1,
                >        "value": 0
                >    },
                >    {
                >        "categoryId": 3,
                >        "effectId": 2,
                >        "traitsId": 1,
                >        "value": 0
                >    },
                >    {
                >        "categoryId": 2,
                >        "effectId": 0,
                >        "traitsId": 2,
                >        "value": 0
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "categoryId": 3,
            >            "effectId": 2,
            >            "traitsId": 1,
            >            "value": 0
            >        },
            >        {
            >            "categoryId": 2,
            >            "effectId": 0,
            >            "traitsId": 2,
            >            "value": 0
            >        }
            >    ],
            >    [
            >        {
            >            "categoryId": 3,
            >            "effectId": 2,
            >            "traitsId": 1,
            >            "value": 0
            >        },
            >        {
            >            "categoryId": 2,
            >            "effectId": 0,
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
        >            "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
        >            "canSell": 0,
        >            "description": "[Sword] A light and wieldy sword with a short blade.",
        >            "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
        >            "iconId": "IconSet_097",
        >            "id": "661cb624-e856-494e-94b8-0e41064e90b0",
        >            "name": "Shortsword",
        >            "price": 280,
        >            "sell": 168,
        >            "switchItem": 0,
        >            "weaponTypeId": "94e410c8-ecd3-4c9e-a844-c978fc6e21f2"
        >        },
        >        "memo": "",
        >        "parameters": [
        >            1,
        >            0,
        >            56,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 3,
        >                "effectId": 2,
        >                "traitsId": 1,
        >                "value": 0
        >            },
        >            {
        >                "categoryId": 2,
        >                "effectId": 0,
        >                "traitsId": 2,
        >                "value": 0
        >            }
        >        ]
        >    },
        >    {
        >        "basic": {
        >            "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
        >            "canSell": 0,
        >            "description": "[Axe] A battle axe bearing a mythril blade.",
        >            "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
        >            "iconId": "IconSet_099",
        >            "id": "379b6433-199f-46b4-a0c8-d34e1a98ff72",
        >            "name": "Mythril Axe",
        >            "price": 4500,
        >            "sell": 2250,
        >            "switchItem": 0,
        >            "weaponTypeId": "7b0de0fe-7cea-4f68-a89e-4dfb403b1017"
        >        },
        >        "memo": "",
        >        "parameters": [
        >            0,
        >            0,
        >            32,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 3,
        >                "effectId": 2,
        >                "traitsId": 1,
        >                "value": 0
        >            },
        >            {
        >                "categoryId": 2,
        >                "effectId": 0,
        >                "traitsId": 2,
        >                "value": 0
        >            }
        >        ]
        >    },
        >    {
        >        "basic": {
        >            "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
        >            "canSell": 0,
        >            "description": "[Axe] A battle axe made of dragonstooth.",
        >            "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
        >            "iconId": "IconSet_099",
        >            "id": "937258c9-c5f5-48ca-9a4d-ebc65c55a429",
        >            "name": "Dragon Axe",
        >            "price": 9600,
        >            "sell": 4800,
        >            "switchItem": 0,
        >            "weaponTypeId": "7b0de0fe-7cea-4f68-a89e-4dfb403b1017"
        >        },
        >        "memo": "",
        >        "parameters": [
        >            0,
        >            0,
        >            45,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0,
        >            0
        >        ],
        >        "traits": [
        >            {
        >                "categoryId": 3,
        >                "effectId": 2,
        >                "traitsId": 1,
        >                "value": 0
        >            },
        >            {
        >                "categoryId": 2,
        >                "effectId": 0,
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
    >                "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
    >                "canSell": 0,
    >                "description": "[Sword] A light and wieldy sword with a short blade.",
    >                "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                "iconId": "IconSet_097",
    >                "id": "661cb624-e856-494e-94b8-0e41064e90b0",
    >                "name": "Shortsword",
    >                "price": 280,
    >                "sell": 168,
    >                "switchItem": 0,
    >                "weaponTypeId": "94e410c8-ecd3-4c9e-a844-c978fc6e21f2"
    >            },
    >            "memo": "",
    >            "parameters": [
    >                1,
    >                0,
    >                56,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0
    >            ],
    >            "traits": [
    >                {
    >                    "categoryId": 3,
    >                    "effectId": 2,
    >                    "traitsId": 1,
    >                    "value": 0
    >                },
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 0,
    >                    "traitsId": 2,
    >                    "value": 0
    >                }
    >            ]
    >        },
    >        {
    >            "basic": {
    >                "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
    >                "canSell": 0,
    >                "description": "[Axe] A battle axe bearing a mythril blade.",
    >                "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                "iconId": "IconSet_099",
    >                "id": "379b6433-199f-46b4-a0c8-d34e1a98ff72",
    >                "name": "Mythril Axe",
    >                "price": 4500,
    >                "sell": 2250,
    >                "switchItem": 0,
    >                "weaponTypeId": "7b0de0fe-7cea-4f68-a89e-4dfb403b1017"
    >            },
    >            "memo": "",
    >            "parameters": [
    >                0,
    >                0,
    >                32,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0
    >            ],
    >            "traits": [
    >                {
    >                    "categoryId": 3,
    >                    "effectId": 2,
    >                    "traitsId": 1,
    >                    "value": 0
    >                },
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 0,
    >                    "traitsId": 2,
    >                    "value": 0
    >                }
    >            ]
    >        },
    >        {
    >            "basic": {
    >                "animationId": "3f2d2acb-5b0e-44e1-9808-3e5eacf6f74d",
    >                "canSell": 0,
    >                "description": "[Axe] A battle axe made of dragonstooth.",
    >                "equipmentTypeId": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                "iconId": "IconSet_099",
    >                "id": "937258c9-c5f5-48ca-9a4d-ebc65c55a429",
    >                "name": "Dragon Axe",
    >                "price": 9600,
    >                "sell": 4800,
    >                "switchItem": 0,
    >                "weaponTypeId": "7b0de0fe-7cea-4f68-a89e-4dfb403b1017"
    >            },
    >            "memo": "",
    >            "parameters": [
    >                0,
    >                0,
    >                45,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0,
    >                0
    >            ],
    >            "traits": [
    >                {
    >                    "categoryId": 3,
    >                    "effectId": 2,
    >                    "traitsId": 1,
    >                    "value": 0
    >                },
    >                {
    >                    "categoryId": 2,
    >                    "effectId": 0,
    >                    "traitsId": 2,
    >                    "value": 0
    >                }
    >            ]
    >        }
    >    ]
    >]
    >```
