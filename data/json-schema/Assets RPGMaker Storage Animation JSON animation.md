# JSON schema: C:\Users\むずでょ\Documents\GitHub\rpg-maker-unite-practice\data\json\Assets RPGMaker Storage Animation JSON animation.json

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['expansion', 'flashList', 'id', 'offset', 'particleId', 'particleName', 'particlePos', 'particleType', 'playSpeed', 'rotation', 'seList', 'targetImageName']
    * 😁 `expansion` property
        * examples:
            >```
            >[
            >    100,
            >    50,
            >    60
            >]
            >```
    * 😁 `flashList` property
        * 😁 `flashList` array - default: None
            * default - ```None```
            * required - ['color', 'flashId', 'flashType', 'frame', 'time']
            * 😁 `color` property
                * examples:
                    >```
                    >[
                    >    "255,255,255",
                    >    "255,119,102",
                    >    "255,136,51"
                    >]
                    >```
            * 😁 `flashId` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `flashType` property
                * examples:
                    >```
                    >[
                    >    1
                    >]
                    >```
            * 😁 `frame` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    90,
                    >    27
                    >]
                    >```
            * 😁 `time` property
                * examples:
                    >```
                    >[
                    >    30,
                    >    17,
                    >    40
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "color": "255,255,255",
                >        "flashId": 0,
                >        "flashType": 1,
                >        "frame": 1,
                >        "time": 30
                >    },
                >    {
                >        "color": "255,255,255",
                >        "flashId": 0,
                >        "flashType": 1,
                >        "frame": 2,
                >        "time": 30
                >    },
                >    {
                >        "color": "255,68,0",
                >        "flashId": 0,
                >        "flashType": 1,
                >        "frame": 30,
                >        "time": 40
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [],
            >    [
            >        {
            >            "color": "255,255,255",
            >            "flashId": 0,
            >            "flashType": 1,
            >            "frame": 1,
            >            "time": 30
            >        }
            >    ],
            >    [
            >        {
            >            "color": "255,255,255",
            >            "flashId": 0,
            >            "flashType": 1,
            >            "frame": 27,
            >            "time": 27
            >        },
            >        {
            >            "color": "255,255,255",
            >            "flashId": 0,
            >            "flashType": 1,
            >            "frame": 28,
            >            "time": 28
            >        },
            >        {
            >            "color": "255,255,255",
            >            "flashId": 0,
            >            "flashType": 1,
            >            "frame": 30,
            >            "time": 30
            >        }
            >    ]
            >]
            >```
    * 😁 `id` property
        * examples:
            >```
            >[
            >    "54b168ea-5141-48ed-9e42-4336ac58755c",
            >    "111419c2-2152-4b18-901d-4465c6771d4f",
            >    "5a4e5e29-5f55-408e-b17d-d69c9ee0e43b"
            >]
            >```
    * 😁 `offset` property
        * examples:
            >```
            >[
            >    "0;0"
            >]
            >```
    * 😁 `particleId` property
        * examples:
            >```
            >[
            >    "f6bad097-a340-4fe8-b90e-9676c577cfeb",
            >    "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
            >    "e53500c2-2138-406d-bd24-baa0506134b1"
            >]
            >```
    * 😁 `particleName` property
        * examples:
            >```
            >[
            >    "None",
            >    "Standard Attack",
            >    "Blunt/Physical"
            >]
            >```
    * 😁 `particlePos` property
        * examples:
            >```
            >[
            >    0,
            >    1
            >]
            >```
    * 😁 `particleType` property
        * examples:
            >```
            >[
            >    0,
            >    1,
            >    2
            >]
            >```
    * 😁 `playSpeed` property
        * examples:
            >```
            >[
            >    100
            >]
            >```
    * 😁 `rotation` property
        * examples:
            >```
            >[
            >    "0;0;0",
            >    "10;10;10"
            >]
            >```
    * 😁 `seList` property
        * 😁 `seList` array - default: None
            * default - ```None```
            * required - ['frame', 'seId', 'seName']
            * 😁 `frame` property
                * examples:
                    >```
                    >[
                    >    48,
                    >    8,
                    >    17
                    >]
                    >```
            * 😁 `seId` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `seName` property
                * examples:
                    >```
                    >[
                    >    "Blow1.ogg",
                    >    "Evasion2.ogg",
                    >    "",
                    >    "Water4.ogg"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "frame": 1,
                >        "seId": 0,
                >        "seName": "Blow1.ogg"
                >    },
                >    {
                >        "frame": 1,
                >        "seId": 0,
                >        "seName": "Evasion2.ogg"
                >    },
                >    {
                >        "frame": 17,
                >        "seId": 0,
                >        "seName": "Ice3.ogg"
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [],
            >    [
            >        {
            >            "frame": 1,
            >            "seId": 0,
            >            "seName": "Blow1.ogg"
            >        }
            >    ],
            >    [
            >        {
            >            "frame": 1,
            >            "seId": 0,
            >            "seName": "Sword4.ogg"
            >        },
            >        {
            >            "frame": 2,
            >            "seId": 0,
            >            "seName": "Slash2.ogg"
            >        },
            >        {
            >            "frame": 10,
            >            "seId": 0,
            >            "seName": "Slash1.ogg"
            >        },
            >        {
            >            "frame": 17,
            >            "seId": 0,
            >            "seName": "Ice3.ogg"
            >        }
            >    ]
            >]
            >```
    * 😁 `targetImageName` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "expansion": 100,
        >        "flashList": [],
        >        "id": "54b168ea-5141-48ed-9e42-4336ac58755c",
        >        "offset": "0;0",
        >        "particleId": "f6bad097-a340-4fe8-b90e-9676c577cfeb",
        >        "particleName": "None",
        >        "particlePos": 0,
        >        "particleType": 0,
        >        "playSpeed": 100,
        >        "rotation": "0;0;0",
        >        "seList": [],
        >        "targetImageName": ""
        >    },
        >    {
        >        "expansion": 80,
        >        "flashList": [
        >            {
        >                "color": "255,255,102",
        >                "flashId": 0,
        >                "flashType": 1,
        >                "frame": 1,
        >                "time": 60
        >            },
        >            {
        >                "color": "255,255,85",
        >                "flashId": 0,
        >                "flashType": 1,
        >                "frame": 4,
        >                "time": 60
        >            }
        >        ],
        >        "id": "9f23347e-5823-46b4-994e-25665f4cb0c0",
        >        "offset": "0;0",
        >        "particleId": "0ca59363-f5ff-4dd4-b20c-69734f8c74c0",
        >        "particleName": "Pierce/Thunder",
        >        "particlePos": 1,
        >        "particleType": 1,
        >        "playSpeed": 100,
        >        "rotation": "0;0;0",
        >        "seList": [
        >            {
        >                "frame": 1,
        >                "seId": 0,
        >                "seName": "Blow3.ogg"
        >            },
        >            {
        >                "frame": 1,
        >                "seId": 0,
        >                "seName": "Thunder3.ogg"
        >            },
        >            {
        >                "frame": 0,
        >                "seId": 0,
        >                "seName": ""
        >            }
        >        ],
        >        "targetImageName": ""
        >    },
        >    {
        >        "expansion": 120,
        >        "flashList": [
        >            {
        >                "color": "255,255,255",
        >                "flashId": 0,
        >                "flashType": 1,
        >                "frame": 1,
        >                "time": 17
        >            },
        >            {
        >                "color": "255,68,0",
        >                "flashId": 0,
        >                "flashType": 1,
        >                "frame": 30,
        >                "time": 40
        >            }
        >        ],
        >        "id": "8660a770-a992-4318-b23c-91e7a6f9c260",
        >        "offset": "0;0",
        >        "particleId": "1fba7dba-d99d-41da-902a-3c8d4c1520aa",
        >        "particleName": "Slash/Special 2",
        >        "particlePos": 1,
        >        "particleType": 2,
        >        "playSpeed": 100,
        >        "rotation": "0;0;0",
        >        "seList": [
        >            {
        >                "frame": 1,
        >                "seId": 0,
        >                "seName": "Sword4.ogg"
        >            },
        >            {
        >                "frame": 2,
        >                "seId": 0,
        >                "seName": "Slash2.ogg"
        >            },
        >            {
        >                "frame": 17,
        >                "seId": 0,
        >                "seName": "Ice3.ogg"
        >            }
        >        ],
        >        "targetImageName": ""
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "expansion": 100,
    >            "flashList": [],
    >            "id": "54b168ea-5141-48ed-9e42-4336ac58755c",
    >            "offset": "0;0",
    >            "particleId": "f6bad097-a340-4fe8-b90e-9676c577cfeb",
    >            "particleName": "None",
    >            "particlePos": 0,
    >            "particleType": 0,
    >            "playSpeed": 100,
    >            "rotation": "0;0;0",
    >            "seList": [],
    >            "targetImageName": ""
    >        },
    >        {
    >            "expansion": 60,
    >            "flashList": [
    >                {
    >                    "color": "255,255,255",
    >                    "flashId": 0,
    >                    "flashType": 1,
    >                    "frame": 2,
    >                    "time": 30
    >                }
    >            ],
    >            "id": "e7530c2a-a2f2-453e-a8a7-7ac5eddd6cff",
    >            "offset": "0;0",
    >            "particleId": "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
    >            "particleName": "Blunt/Effect",
    >            "particlePos": 1,
    >            "particleType": 1,
    >            "playSpeed": 100,
    >            "rotation": "0;0;0",
    >            "seList": [
    >                {
    >                    "frame": 1,
    >                    "seId": 0,
    >                    "seName": "Evasion2.ogg"
    >                },
    >                {
    >                    "frame": 2,
    >                    "seId": 0,
    >                    "seName": "Damage4.ogg"
    >                },
    >                {
    >                    "frame": 3,
    >                    "seId": 0,
    >                    "seName": "Powerup.ogg"
    >                }
    >            ],
    >            "targetImageName": ""
    >        },
    >        {
    >            "expansion": 120,
    >            "flashList": [
    >                {
    >                    "color": "255,255,255",
    >                    "flashId": 0,
    >                    "flashType": 1,
    >                    "frame": 1,
    >                    "time": 17
    >                },
    >                {
    >                    "color": "255,68,0",
    >                    "flashId": 0,
    >                    "flashType": 1,
    >                    "frame": 30,
    >                    "time": 40
    >                }
    >            ],
    >            "id": "8660a770-a992-4318-b23c-91e7a6f9c260",
    >            "offset": "0;0",
    >            "particleId": "1fba7dba-d99d-41da-902a-3c8d4c1520aa",
    >            "particleName": "Slash/Special 2",
    >            "particlePos": 1,
    >            "particleType": 2,
    >            "playSpeed": 100,
    >            "rotation": "0;0;0",
    >            "seList": [
    >                {
    >                    "frame": 1,
    >                    "seId": 0,
    >                    "seName": "Sword4.ogg"
    >                },
    >                {
    >                    "frame": 2,
    >                    "seId": 0,
    >                    "seName": "Slash2.ogg"
    >                },
    >                {
    >                    "frame": 10,
    >                    "seId": 0,
    >                    "seName": "Slash1.ogg"
    >                },
    >                {
    >                    "frame": 17,
    >                    "seId": 0,
    >                    "seName": "Ice3.ogg"
    >                }
    >            ],
    >            "targetImageName": ""
    >        }
    >    ]
    >]
    >```
