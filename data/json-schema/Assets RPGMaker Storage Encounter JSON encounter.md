# JSON schema: Assets RPGMaker Storage Encounter JSON encounter

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['backImage1', 'backImage2', 'bgm', 'deleted', 'enabled', 'enemyList', 'enemyMax', 'lowestHighestLevel', 'mapId', 'minimumAssumedLevel', 'name', 'region', 'step', 'troopList', 'troopPer']
    * 😁 `backImage1` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `backImage2` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `bgm` property
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `pan` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            * examples:
                >```
                >[
                >    90
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "name": "",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    },
            >    {
            >        "name": "",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    },
            >    {
            >        "name": "",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `deleted` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `enabled` property
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `enemyList` property
        * 😁 `enemyList` array - default: None
            * default - ```None```
        * examples:
            >```
            >[
            >    [],
            >    [],
            >    []
            >]
            >```
    * 😁 `enemyMax` property
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `lowestHighestLevel` property
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `mapId` property
        * examples:
            >```
            >[
            >    "8a1d06ec-2133-4cce-b60c-e9ddb63dc0db",
            >    "3c143147-f7a0-4bab-ad00-236e85bd6fc5",
            >    "9cb34751-55a4-4030-a8cd-fc8599f0e56a"
            >]
            >```
    * 😁 `minimumAssumedLevel` property
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
            >    "#0006",
            >    "#0007",
            >    "#0008"
            >]
            >```
    * 😁 `region` property
        * examples:
            >```
            >[
            >    0,
            >    2,
            >    1,
            >    13,
            >    3,
            >    11,
            >    5,
            >    9,
            >    7,
            >    4,
            >    6
            >]
            >```
    * 😁 `step` property
        * examples:
            >```
            >[
            >    30
            >]
            >```
    * 😁 `troopList` property
        * 😁 `troopList` array - default: None
            * default - ```None```
            * required - ['troopId', 'weight']
            * 😁 `troopId` property
                * examples:
                    >```
                    >[
                    >    "8db87180-464d-41e2-92be-919ea6eb6e36",
                    >    "4a948a6e-2e11-41ae-8891-8af79a1d1a13",
                    >    "fda01580-6e3d-4846-8352-2069edea8416"
                    >]
                    >```
            * 😁 `weight` property
                * examples:
                    >```
                    >[
                    >    60,
                    >    20,
                    >    10,
                    >    70,
                    >    40,
                    >    5,
                    >    30,
                    >    15,
                    >    9,
                    >    25,
                    >    50
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "troopId": "8db87180-464d-41e2-92be-919ea6eb6e36",
                >        "weight": 60
                >    },
                >    {
                >        "troopId": "4a948a6e-2e11-41ae-8891-8af79a1d1a13",
                >        "weight": 20
                >    },
                >    {
                >        "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
                >        "weight": 10
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [],
            >    [
            >        {
            >            "troopId": "8db87180-464d-41e2-92be-919ea6eb6e36",
            >            "weight": 60
            >        },
            >        {
            >            "troopId": "da7ccba3-7c51-40a8-ba2a-8eef1fc7effb",
            >            "weight": 20
            >        },
            >        {
            >            "troopId": "f1c7de7c-8f8d-49c3-845d-78c6626934a0",
            >            "weight": 60
            >        },
            >        {
            >            "troopId": "72fdf75a-5383-4c87-af7b-8f6c8b978612",
            >            "weight": 20
            >        },
            >        {
            >            "troopId": "5e752ee7-03a2-4d6b-95a3-8a9319acfcfa",
            >            "weight": 10
            >        }
            >    ],
            >    [
            >        {
            >            "troopId": "945efff8-8253-4400-9a89-160b8d5ebfd3",
            >            "weight": 70
            >        },
            >        {
            >            "troopId": "4a948a6e-2e11-41ae-8891-8af79a1d1a13",
            >            "weight": 20
            >        },
            >        {
            >            "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
            >            "weight": 10
            >        }
            >    ],
            >    [
            >        {
            >            "troopId": "945efff8-8253-4400-9a89-160b8d5ebfd3",
            >            "weight": 70
            >        },
            >        {
            >            "troopId": "4a948a6e-2e11-41ae-8891-8af79a1d1a13",
            >            "weight": 20
            >        },
            >        {
            >            "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
            >            "weight": 10
            >        }
            >    ]
            >]
            >```
    * 😁 `troopPer` property
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
        >        "backImage1": "",
        >        "backImage2": "",
        >        "bgm": {
        >            "name": "",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "deleted": 0,
        >        "enabled": 1,
        >        "enemyList": [],
        >        "enemyMax": 1,
        >        "lowestHighestLevel": 1,
        >        "mapId": "8a1d06ec-2133-4cce-b60c-e9ddb63dc0db",
        >        "minimumAssumedLevel": 1,
        >        "name": "#0006",
        >        "region": 0,
        >        "step": 30,
        >        "troopList": [],
        >        "troopPer": 1
        >    },
        >    {
        >        "backImage1": "",
        >        "backImage2": "",
        >        "bgm": {
        >            "name": "",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "deleted": 0,
        >        "enabled": 1,
        >        "enemyList": [],
        >        "enemyMax": 1,
        >        "lowestHighestLevel": 1,
        >        "mapId": "3c143147-f7a0-4bab-ad00-236e85bd6fc5",
        >        "minimumAssumedLevel": 1,
        >        "name": "#0034",
        >        "region": 4,
        >        "step": 30,
        >        "troopList": [
        >            {
        >                "troopId": "945efff8-8253-4400-9a89-160b8d5ebfd3",
        >                "weight": 70
        >            },
        >            {
        >                "troopId": "4a948a6e-2e11-41ae-8891-8af79a1d1a13",
        >                "weight": 20
        >            },
        >            {
        >                "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
        >                "weight": 10
        >            }
        >        ],
        >        "troopPer": 1
        >    },
        >    {
        >        "backImage1": "",
        >        "backImage2": "",
        >        "bgm": {
        >            "name": "",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "deleted": 0,
        >        "enabled": 1,
        >        "enemyList": [],
        >        "enemyMax": 1,
        >        "lowestHighestLevel": 1,
        >        "mapId": "9cb34751-55a4-4030-a8cd-fc8599f0e56a",
        >        "minimumAssumedLevel": 1,
        >        "name": "#0035",
        >        "region": 4,
        >        "step": 30,
        >        "troopList": [
        >            {
        >                "troopId": "945efff8-8253-4400-9a89-160b8d5ebfd3",
        >                "weight": 70
        >            },
        >            {
        >                "troopId": "f6fc0b98-c9f5-4406-90ff-ed7d2c98f508",
        >                "weight": 60
        >            },
        >            {
        >                "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
        >                "weight": 10
        >            }
        >        ],
        >        "troopPer": 1
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "backImage1": "",
    >            "backImage2": "",
    >            "bgm": {
    >                "name": "",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "deleted": 0,
    >            "enabled": 1,
    >            "enemyList": [],
    >            "enemyMax": 1,
    >            "lowestHighestLevel": 1,
    >            "mapId": "8a1d06ec-2133-4cce-b60c-e9ddb63dc0db",
    >            "minimumAssumedLevel": 1,
    >            "name": "#0006",
    >            "region": 0,
    >            "step": 30,
    >            "troopList": [],
    >            "troopPer": 1
    >        },
    >        {
    >            "backImage1": "",
    >            "backImage2": "",
    >            "bgm": {
    >                "name": "",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "deleted": 0,
    >            "enabled": 1,
    >            "enemyList": [],
    >            "enemyMax": 1,
    >            "lowestHighestLevel": 1,
    >            "mapId": "3c143147-f7a0-4bab-ad00-236e85bd6fc5",
    >            "minimumAssumedLevel": 1,
    >            "name": "#0034",
    >            "region": 4,
    >            "step": 30,
    >            "troopList": [
    >                {
    >                    "troopId": "945efff8-8253-4400-9a89-160b8d5ebfd3",
    >                    "weight": 70
    >                },
    >                {
    >                    "troopId": "4a948a6e-2e11-41ae-8891-8af79a1d1a13",
    >                    "weight": 20
    >                },
    >                {
    >                    "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
    >                    "weight": 10
    >                }
    >            ],
    >            "troopPer": 1
    >        },
    >        {
    >            "backImage1": "",
    >            "backImage2": "",
    >            "bgm": {
    >                "name": "",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "deleted": 0,
    >            "enabled": 1,
    >            "enemyList": [],
    >            "enemyMax": 1,
    >            "lowestHighestLevel": 1,
    >            "mapId": "9cb34751-55a4-4030-a8cd-fc8599f0e56a",
    >            "minimumAssumedLevel": 1,
    >            "name": "#0035",
    >            "region": 4,
    >            "step": 30,
    >            "troopList": [
    >                {
    >                    "troopId": "945efff8-8253-4400-9a89-160b8d5ebfd3",
    >                    "weight": 70
    >                },
    >                {
    >                    "troopId": "f6fc0b98-c9f5-4406-90ff-ed7d2c98f508",
    >                    "weight": 60
    >                },
    >                {
    >                    "troopId": "fda01580-6e3d-4846-8352-2069edea8416",
    >                    "weight": 10
    >                }
    >            ],
    >            "troopPer": 1
    >        }
    >    ]
    >]
    >```
