# JSON schema: Assets RPGMaker Storage AssetManage JSON assetsData

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['assetTypeId', 'id', 'imageSettings', 'name', 'sort', 'type', 'weaponTypeId']
    * 😁 `assetTypeId` property
        * examples:
            >```
            >[
            >    3,
            >    4,
            >    1,
            >    0,
            >    6
            >]
            >```
    * 😁 `id` property
        * examples:
            >```
            >[
            >    "0003c951-f75e-47d0-a8d1-b8fb82cae285",
            >    "0e2dec46-8444-49b9-a11d-a62bb4da08a0",
            >    "0ef70722-6c7b-40a4-b6c1-132f080b7a16"
            >]
            >```
    * 😁 `imageSettings` property
        * 😁 `imageSettings` array - default: None
            * default - ```None```
            * required - ['animationFrame', 'animationSpeed', 'path', 'sizeX', 'sizeY']
            * 😁 `animationFrame` property
                * examples:
                    >```
                    >[
                    >    6,
                    >    8,
                    >    3,
                    >    0
                    >]
                    >```
            * 😁 `animationSpeed` property
                * examples:
                    >```
                    >[
                    >    20,
                    >    30,
                    >    0,
                    >    40
                    >]
                    >```
            * 😁 `path` property
                * examples:
                    >```
                    >[
                    >    "017_Actor_move_forward_6.png",
                    >    "017_Actor_standard_delay_6.png",
                    >    "Chest_005_04.png"
                    >]
                    >```
            * 😁 `sizeX` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1920,
                    >    294,
                    >    98
                    >]
                    >```
            * 😁 `sizeY` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    200,
                    >    194,
                    >    98
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "animationFrame": 6,
                >        "animationSpeed": 20,
                >        "path": "017_Actor_move_forward_6.png",
                >        "sizeX": 0,
                >        "sizeY": 0
                >    },
                >    {
                >        "animationFrame": 6,
                >        "animationSpeed": 20,
                >        "path": "017_Actor_standard_delay_6.png",
                >        "sizeX": 0,
                >        "sizeY": 0
                >    },
                >    {
                >        "animationFrame": 0,
                >        "animationSpeed": 0,
                >        "path": "Chest_005_01.png",
                >        "sizeX": 0,
                >        "sizeY": 0
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "animationFrame": 0,
            >            "animationSpeed": 0,
            >            "path": "SlashSpecial1.asset",
            >            "sizeX": 0,
            >            "sizeY": 0
            >        }
            >    ],
            >    [
            >        {
            >            "animationFrame": 0,
            >            "animationSpeed": 0,
            >            "path": "WaterOne1.asset",
            >            "sizeX": 0,
            >            "sizeY": 0
            >        }
            >    ],
            >    [
            >        {
            >            "animationFrame": 0,
            >            "animationSpeed": 0,
            >            "path": "Chest_005_01.png",
            >            "sizeX": 98,
            >            "sizeY": 98
            >        },
            >        {
            >            "animationFrame": 0,
            >            "animationSpeed": 0,
            >            "path": "Chest_005_04.png",
            >            "sizeX": 98,
            >            "sizeY": 98
            >        },
            >        {
            >            "animationFrame": 0,
            >            "animationSpeed": 0,
            >            "path": "Chest_005_01.png",
            >            "sizeX": 0,
            >            "sizeY": 0
            >        }
            >    ]
            >]
            >```
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "Amazon (Male)",
            >    "Scythe",
            >    "Object 227"
            >]
            >```
    * 😁 `sort` property
        * examples:
            >```
            >[
            >    16,
            >    11,
            >    173,
            >    226,
            >    5,
            >    36,
            >    17,
            >    29,
            >    1,
            >    39,
            >    24,
            >    6,
            >    68,
            >    15,
            >    22,
            >    154,
            >    115,
            >    258,
            >    28,
            >    74,
            >    14,
            >    3,
            >    9,
            >    80,
            >    10
            >]
            >```
    * 😁 `type` property
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
            >    0,
            >    2
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "assetTypeId": 0,
        >        "id": "0c501359-b118-4133-8eea-9c24c42b287a",
        >        "imageSettings": [
        >            {
        >                "animationFrame": 3,
        >                "animationSpeed": 40,
        >                "path": "Vehicle_017.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            },
        >            {
        >                "animationFrame": 3,
        >                "animationSpeed": 40,
        >                "path": "Vehicle_020.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            },
        >            {
        >                "animationFrame": 3,
        >                "animationSpeed": 40,
        >                "path": "Vehicle_017.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            }
        >        ],
        >        "name": "Unicorn",
        >        "sort": 74,
        >        "type": 0,
        >        "weaponTypeId": 0
        >    },
        >    {
        >        "assetTypeId": 1,
        >        "id": "0ef70722-6c7b-40a4-b6c1-132f080b7a16",
        >        "imageSettings": [
        >            {
        >                "animationFrame": 0,
        >                "animationSpeed": 0,
        >                "path": "Chest_005_01.png",
        >                "sizeX": 98,
        >                "sizeY": 98
        >            },
        >            {
        >                "animationFrame": 0,
        >                "animationSpeed": 0,
        >                "path": "Chest_005_02.png",
        >                "sizeX": 98,
        >                "sizeY": 98
        >            },
        >            {
        >                "animationFrame": 0,
        >                "animationSpeed": 0,
        >                "path": "Chest_005_01.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            }
        >        ],
        >        "name": "Object 11",
        >        "sort": 10,
        >        "type": 0,
        >        "weaponTypeId": 0
        >    },
        >    {
        >        "assetTypeId": 3,
        >        "id": "01a22294-1de0-47a9-b0a2-8a210364bd1b",
        >        "imageSettings": [
        >            {
        >                "animationFrame": 6,
        >                "animationSpeed": 20,
        >                "path": "006_Actor_move_forward_6.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            },
        >            {
        >                "animationFrame": 6,
        >                "animationSpeed": 20,
        >                "path": "006_Actor_sleep_6.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            },
        >            {
        >                "animationFrame": 6,
        >                "animationSpeed": 20,
        >                "path": "006_Actor_dead_6.png",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            }
        >        ],
        >        "name": "Wizard (Female)",
        >        "sort": 5,
        >        "type": 0,
        >        "weaponTypeId": 0
        >    },
        >    {
        >        "assetTypeId": 4,
        >        "id": "0d66a0aa-baa6-4720-98d6-c21deea32b15",
        >        "imageSettings": [
        >            {
        >                "animationFrame": 8,
        >                "animationSpeed": 20,
        >                "path": "weapon_swing_004_8.png",
        >                "sizeX": 1920,
        >                "sizeY": 200
        >            }
        >        ],
        >        "name": "Axe",
        >        "sort": 3,
        >        "type": 0,
        >        "weaponTypeId": 0
        >    },
        >    {
        >        "assetTypeId": 6,
        >        "id": "0e2dec46-8444-49b9-a11d-a62bb4da08a0",
        >        "imageSettings": [
        >            {
        >                "animationFrame": 0,
        >                "animationSpeed": 0,
        >                "path": "WaterOne1.asset",
        >                "sizeX": 0,
        >                "sizeY": 0
        >            }
        >        ],
        >        "name": "Water/One 1",
        >        "sort": 80,
        >        "type": 0,
        >        "weaponTypeId": 0
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "assetTypeId": 0,
    >            "id": "0c501359-b118-4133-8eea-9c24c42b287a",
    >            "imageSettings": [
    >                {
    >                    "animationFrame": 3,
    >                    "animationSpeed": 40,
    >                    "path": "Vehicle_017.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                },
    >                {
    >                    "animationFrame": 3,
    >                    "animationSpeed": 40,
    >                    "path": "Vehicle_018.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                },
    >                {
    >                    "animationFrame": 3,
    >                    "animationSpeed": 40,
    >                    "path": "Vehicle_019.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                },
    >                {
    >                    "animationFrame": 3,
    >                    "animationSpeed": 40,
    >                    "path": "Vehicle_020.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                },
    >                {
    >                    "animationFrame": 3,
    >                    "animationSpeed": 40,
    >                    "path": "Vehicle_017.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                }
    >            ],
    >            "name": "Unicorn",
    >            "sort": 74,
    >            "type": 0,
    >            "weaponTypeId": 0
    >        },
    >        {
    >            "assetTypeId": 1,
    >            "id": "0ef70722-6c7b-40a4-b6c1-132f080b7a16",
    >            "imageSettings": [
    >                {
    >                    "animationFrame": 0,
    >                    "animationSpeed": 0,
    >                    "path": "Chest_005_01.png",
    >                    "sizeX": 98,
    >                    "sizeY": 98
    >                },
    >                {
    >                    "animationFrame": 0,
    >                    "animationSpeed": 0,
    >                    "path": "Chest_005_02.png",
    >                    "sizeX": 98,
    >                    "sizeY": 98
    >                },
    >                {
    >                    "animationFrame": 0,
    >                    "animationSpeed": 0,
    >                    "path": "Chest_005_03.png",
    >                    "sizeX": 98,
    >                    "sizeY": 98
    >                },
    >                {
    >                    "animationFrame": 0,
    >                    "animationSpeed": 0,
    >                    "path": "Chest_005_04.png",
    >                    "sizeX": 98,
    >                    "sizeY": 98
    >                },
    >                {
    >                    "animationFrame": 0,
    >                    "animationSpeed": 0,
    >                    "path": "Chest_005_01.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                }
    >            ],
    >            "name": "Object 11",
    >            "sort": 10,
    >            "type": 0,
    >            "weaponTypeId": 0
    >        },
    >        {
    >            "assetTypeId": 3,
    >            "id": "01a22294-1de0-47a9-b0a2-8a210364bd1b",
    >            "imageSettings": [
    >                {
    >                    "animationFrame": 6,
    >                    "animationSpeed": 20,
    >                    "path": "006_Actor_move_forward_6.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                },
    >                {
    >                    "animationFrame": 6,
    >                    "animationSpeed": 20,
    >                    "path": "006_Actor_standard_delay_6.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                },
    >                {
    >                    "animationFrame": 6,
    >                    "animationSpeed": 20,
    >                    "path": "006_Actor_dead_6.png",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                }
    >            ],
    >            "name": "Wizard (Female)",
    >            "sort": 5,
    >            "type": 0,
    >            "weaponTypeId": 0
    >        },
    >        {
    >            "assetTypeId": 4,
    >            "id": "0d66a0aa-baa6-4720-98d6-c21deea32b15",
    >            "imageSettings": [
    >                {
    >                    "animationFrame": 8,
    >                    "animationSpeed": 20,
    >                    "path": "weapon_swing_004_8.png",
    >                    "sizeX": 1920,
    >                    "sizeY": 200
    >                }
    >            ],
    >            "name": "Axe",
    >            "sort": 3,
    >            "type": 0,
    >            "weaponTypeId": 0
    >        },
    >        {
    >            "assetTypeId": 6,
    >            "id": "0e2dec46-8444-49b9-a11d-a62bb4da08a0",
    >            "imageSettings": [
    >                {
    >                    "animationFrame": 0,
    >                    "animationSpeed": 0,
    >                    "path": "WaterOne1.asset",
    >                    "sizeX": 0,
    >                    "sizeY": 0
    >                }
    >            ],
    >            "name": "Water/One 1",
    >            "sort": 80,
    >            "type": 0,
    >            "weaponTypeId": 0
    >        }
    >    ]
    >]
    >```
