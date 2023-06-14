# JSON schema: Assets RPGMaker Storage Character JSON characterActor

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['basic', 'charaType', 'element', 'equips', 'image', 'initialLevel', 'maxLevel', 'name', 'nickname', 'profile', 'traits', 'uuId']
    * 😁 `basic` property
        * required - ['classId', 'initialLevel', 'maxLevel', 'memo', 'name', 'profile', 'secondName']
        * 😁 `classId` property
            * examples:
                >```
                >[
                >    "39450ee1-598b-4a2e-b249-b615cd2a2ea5",
                >    "",
                >    "87138fce-4a1a-4bda-bc31-7b8cd9243957",
                >    "6058ef9d-cd0e-4ef2-b962-3841cf8a5dca"
                >]
                >```
        * 😁 `initialLevel` property
            * examples:
                >```
                >[
                >    1,
                >    4,
                >    7
                >]
                >```
        * 😁 `maxLevel` property
            * examples:
                >```
                >[
                >    99
                >]
                >```
        * 😁 `memo` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "Craft",
                >    "Miguel",
                >    "Persephe"
                >]
                >```
        * 😁 `profile` property
            * examples:
                >```
                >[
                >    "A young boy hailing from the Frontier Town, Starterton. He dreams of becoming a Royal Knight in the Capital.",
                >    "",
                >    "A healer with a serious demeanor who bears no association to any temple. He's participating in the Combat Tournament in the Royal Capital.",
                >    "An eccentric woman who finds more interest in assisting humans than her own kind."
                >]
                >```
        * 😁 `secondName` property
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
            >        "classId": "39450ee1-598b-4a2e-b249-b615cd2a2ea5",
            >        "initialLevel": 1,
            >        "maxLevel": 99,
            >        "memo": "",
            >        "name": "Craft",
            >        "profile": "A young boy hailing from the Frontier Town, Starterton. He dreams of becoming a Royal Knight in the Capital.",
            >        "secondName": ""
            >    },
            >    {
            >        "classId": "",
            >        "initialLevel": 1,
            >        "maxLevel": 99,
            >        "memo": "",
            >        "name": "Gryff",
            >        "profile": "",
            >        "secondName": ""
            >    },
            >    {
            >        "classId": "",
            >        "initialLevel": 1,
            >        "maxLevel": 99,
            >        "memo": "",
            >        "name": "Rashad",
            >        "profile": "",
            >        "secondName": ""
            >    },
            >    {
            >        "classId": "6058ef9d-cd0e-4ef2-b962-3841cf8a5dca",
            >        "initialLevel": 1,
            >        "maxLevel": 99,
            >        "memo": "",
            >        "name": "Ehrhardt",
            >        "profile": "A man who looks upon the changes affecting the world with worry, waiting for the time to come.",
            >        "secondName": ""
            >    },
            >    {
            >        "classId": "6058ef9d-cd0e-4ef2-b962-3841cf8a5dca",
            >        "initialLevel": 1,
            >        "maxLevel": 99,
            >        "memo": "",
            >        "name": "Persephe",
            >        "profile": "An eccentric woman who finds more interest in assisting humans than her own kind.",
            >        "secondName": ""
            >    }
            >]
            >```
    * 😁 `charaType` property
        * examples:
            >```
            >[
            >    1,
            >    2
            >]
            >```
    * 😁 `element` property
        * examples:
            >```
            >[
            >    0,
            >    8,
            >    3
            >]
            >```
    * 😁 `equips` property
        * 😁 `equips` array - default: None
            * default - ```None```
            * required - ['type', 'value']
            * 😁 `type` property
                * examples:
                    >```
                    >[
                    >    "48254f68-178f-448e-98fd-60a0bb616a28",
                    >    "7832ae68-aecc-4724-8765-e8e04e3cb64f",
                    >    ""
                    >]
                    >```
            * 😁 `value` property
                * examples:
                    >```
                    >[
                    >    "661cb624-e856-494e-94b8-0e41064e90b0",
                    >    "",
                    >    "0",
                    >    "ffd9dd7d-00ed-4835-9545-3cc098401895"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "type": "48254f68-178f-448e-98fd-60a0bb616a28",
                >        "value": "661cb624-e856-494e-94b8-0e41064e90b0"
                >    },
                >    {
                >        "type": "",
                >        "value": "0"
                >    },
                >    {
                >        "type": "",
                >        "value": "0"
                >    },
                >    {
                >        "type": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
                >        "value": "3a226a2f-6a3b-430c-917c-7bd7750e4612"
                >    },
                >    {
                >        "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
                >        "value": ""
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "type": "",
            >            "value": "0"
            >        }
            >    ],
            >    [
            >        {
            >            "type": "",
            >            "value": "0"
            >        }
            >    ],
            >    [
            >        {
            >            "type": "48254f68-178f-448e-98fd-60a0bb616a28",
            >            "value": "3b43e5d9-721a-4beb-82e9-be48c2240f74"
            >        },
            >        {
            >            "type": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
            >            "value": "3a226a2f-6a3b-430c-917c-7bd7750e4612"
            >        },
            >        {
            >            "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
            >            "value": ""
            >        }
            >    ],
            >    [
            >        {
            >            "type": "48254f68-178f-448e-98fd-60a0bb616a28",
            >            "value": "3b43e5d9-721a-4beb-82e9-be48c2240f74"
            >        },
            >        {
            >            "type": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
            >            "value": "3a226a2f-6a3b-430c-917c-7bd7750e4612"
            >        },
            >        {
            >            "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
            >            "value": ""
            >        }
            >    ]
            >]
            >```
    * 😁 `image` property
        * required - ['adv', 'battler', 'character', 'face']
        * 😁 `adv` property
            * examples:
                >```
                >[
                >    "charaupperbody_001_Actor",
                >    "charaupperbody_003_Actor",
                >    "charaupperbody_024_Actor"
                >]
                >```
        * 😁 `battler` property
            * examples:
                >```
                >[
                >    "e7c8511c-dda2-4812-9ddb-03a8674ce085",
                >    "c1ecd373-0b09-4299-ab11-e320903e0c87",
                >    "ee879f35-3bde-4755-a7ce-30e821fa15dd"
                >]
                >```
        * 😁 `character` property
            * examples:
                >```
                >[
                >    "78a965c8-7400-432e-a17f-93432f6b9ff5",
                >    "60cc7e88-f27a-4608-9152-06ca3704de2a",
                >    "f60a361e-6bac-4e57-9ace-6aeea03fd059"
                >]
                >```
        * 😁 `face` property
            * examples:
                >```
                >[
                >    "charaface_001_Actor",
                >    "charaface_003_Actor",
                >    "charaface_024_Actor"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "adv": "charaupperbody_001_Actor",
            >        "battler": "e7c8511c-dda2-4812-9ddb-03a8674ce085",
            >        "character": "78a965c8-7400-432e-a17f-93432f6b9ff5",
            >        "face": "charaface_001_Actor"
            >    },
            >    {
            >        "adv": "charaupperbody_023_Actor",
            >        "battler": "f53a5c9d-a1c6-46b3-9d38-44ac630efc72",
            >        "character": "66b79abf-8335-4d95-aab1-4ffa68670474",
            >        "face": "charaface_023_Actor"
            >    },
            >    {
            >        "adv": "charaupperbody_024_Actor",
            >        "battler": "ee879f35-3bde-4755-a7ce-30e821fa15dd",
            >        "character": "f60a361e-6bac-4e57-9ace-6aeea03fd059",
            >        "face": "charaface_024_Actor"
            >    }
            >]
            >```
    * 😁 `initialLevel` property
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `maxLevel` property
        * examples:
            >```
            >[
            >    99
            >]
            >```
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "\u30af\u30e9\u30d5\u30c8",
            >    "\u30df\u30b2\u30eb",
            >    "\u30b7\u30e3\u30ed\u30f3",
            >    "\u30eb\u30fc\u30b7\u30a3",
            >    "\u30b8\u30fc\u30af\u30cf\u30eb\u30c8",
            >    "\u30c6\u30a3\u30a2",
            >    "\u30b4\u30fc\u30b7\u30e5",
            >    "\u30ea\u30b5\u30fc\u30ca",
            >    ""
            >]
            >```
    * 😁 `nickname` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `profile` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `traits` property
        * 😁 `traits` array - default: None
            * default - ```None```
        * examples:
            >```
            >[
            >    [],
            >    [],
            >    []
            >]
            >```
    * 😁 `uuId` property
        * examples:
            >```
            >[
            >    "a8230358-b349-4687-aaf9-e3ccb8d55479",
            >    "25542bfa-c069-4b3c-87e3-d2cc02b4fa37",
            >    "631ba9c0-ae29-45bc-a934-1068a64b7e02"
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "basic": {
        >            "classId": "39450ee1-598b-4a2e-b249-b615cd2a2ea5",
        >            "initialLevel": 1,
        >            "maxLevel": 99,
        >            "memo": "",
        >            "name": "Craft",
        >            "profile": "A young boy hailing from the Frontier Town, Starterton. He dreams of becoming a Royal Knight in the Capital.",
        >            "secondName": ""
        >        },
        >        "charaType": 1,
        >        "element": 0,
        >        "equips": [
        >            {
        >                "type": "48254f68-178f-448e-98fd-60a0bb616a28",
        >                "value": "661cb624-e856-494e-94b8-0e41064e90b0"
        >            },
        >            {
        >                "type": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
        >                "value": ""
        >            },
        >            {
        >                "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
        >                "value": ""
        >            }
        >        ],
        >        "image": {
        >            "adv": "charaupperbody_001_Actor",
        >            "battler": "e7c8511c-dda2-4812-9ddb-03a8674ce085",
        >            "character": "78a965c8-7400-432e-a17f-93432f6b9ff5",
        >            "face": "charaface_001_Actor"
        >        },
        >        "initialLevel": 1,
        >        "maxLevel": 99,
        >        "name": "\u30af\u30e9\u30d5\u30c8",
        >        "nickname": "",
        >        "profile": "",
        >        "traits": [],
        >        "uuId": "a8230358-b349-4687-aaf9-e3ccb8d55479"
        >    },
        >    {
        >        "basic": {
        >            "classId": "6058ef9d-cd0e-4ef2-b962-3841cf8a5dca",
        >            "initialLevel": 1,
        >            "maxLevel": 99,
        >            "memo": "",
        >            "name": "Ehrhardt",
        >            "profile": "A man who looks upon the changes affecting the world with worry, waiting for the time to come.",
        >            "secondName": ""
        >        },
        >        "charaType": 1,
        >        "element": 0,
        >        "equips": [
        >            {
        >                "type": "48254f68-178f-448e-98fd-60a0bb616a28",
        >                "value": "3b43e5d9-721a-4beb-82e9-be48c2240f74"
        >            },
        >            {
        >                "type": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
        >                "value": ""
        >            },
        >            {
        >                "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
        >                "value": ""
        >            }
        >        ],
        >        "image": {
        >            "adv": "charaupperbody_023_Actor",
        >            "battler": "f53a5c9d-a1c6-46b3-9d38-44ac630efc72",
        >            "character": "66b79abf-8335-4d95-aab1-4ffa68670474",
        >            "face": "charaface_023_Actor"
        >        },
        >        "initialLevel": 1,
        >        "maxLevel": 99,
        >        "name": "",
        >        "nickname": "",
        >        "profile": "",
        >        "traits": [],
        >        "uuId": "d59e358a-ff44-4245-ad7f-3d8bfdcc32d4"
        >    },
        >    {
        >        "basic": {
        >            "classId": "6058ef9d-cd0e-4ef2-b962-3841cf8a5dca",
        >            "initialLevel": 1,
        >            "maxLevel": 99,
        >            "memo": "",
        >            "name": "Persephe",
        >            "profile": "An eccentric woman who finds more interest in assisting humans than her own kind.",
        >            "secondName": ""
        >        },
        >        "charaType": 1,
        >        "element": 0,
        >        "equips": [
        >            {
        >                "type": "48254f68-178f-448e-98fd-60a0bb616a28",
        >                "value": "3b43e5d9-721a-4beb-82e9-be48c2240f74"
        >            },
        >            {
        >                "type": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
        >                "value": ""
        >            },
        >            {
        >                "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
        >                "value": ""
        >            }
        >        ],
        >        "image": {
        >            "adv": "charaupperbody_024_Actor",
        >            "battler": "ee879f35-3bde-4755-a7ce-30e821fa15dd",
        >            "character": "f60a361e-6bac-4e57-9ace-6aeea03fd059",
        >            "face": "charaface_024_Actor"
        >        },
        >        "initialLevel": 1,
        >        "maxLevel": 99,
        >        "name": "",
        >        "nickname": "",
        >        "profile": "",
        >        "traits": [],
        >        "uuId": "631ba9c0-ae29-45bc-a934-1068a64b7e02"
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "basic": {
    >                "classId": "39450ee1-598b-4a2e-b249-b615cd2a2ea5",
    >                "initialLevel": 1,
    >                "maxLevel": 99,
    >                "memo": "",
    >                "name": "Craft",
    >                "profile": "A young boy hailing from the Frontier Town, Starterton. He dreams of becoming a Royal Knight in the Capital.",
    >                "secondName": ""
    >            },
    >            "charaType": 1,
    >            "element": 0,
    >            "equips": [
    >                {
    >                    "type": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                    "value": "661cb624-e856-494e-94b8-0e41064e90b0"
    >                },
    >                {
    >                    "type": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
    >                    "value": ""
    >                },
    >                {
    >                    "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
    >                    "value": ""
    >                }
    >            ],
    >            "image": {
    >                "adv": "charaupperbody_001_Actor",
    >                "battler": "e7c8511c-dda2-4812-9ddb-03a8674ce085",
    >                "character": "78a965c8-7400-432e-a17f-93432f6b9ff5",
    >                "face": "charaface_001_Actor"
    >            },
    >            "initialLevel": 1,
    >            "maxLevel": 99,
    >            "name": "\u30af\u30e9\u30d5\u30c8",
    >            "nickname": "",
    >            "profile": "",
    >            "traits": [],
    >            "uuId": "a8230358-b349-4687-aaf9-e3ccb8d55479"
    >        },
    >        {
    >            "basic": {
    >                "classId": "e3912a26-0c3c-44c9-9454-5cb91c0aa689",
    >                "initialLevel": 1,
    >                "maxLevel": 99,
    >                "memo": "",
    >                "name": "Celio",
    >                "profile": "An esteemed student at the Magic School in the Academy City, Hardengere.",
    >                "secondName": ""
    >            },
    >            "charaType": 1,
    >            "element": 0,
    >            "equips": [
    >                {
    >                    "type": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                    "value": "3b43e5d9-721a-4beb-82e9-be48c2240f74"
    >                },
    >                {
    >                    "type": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
    >                    "value": ""
    >                },
    >                {
    >                    "type": "312419fb-bc20-44b4-bb2b-0c28c7c3a987",
    >                    "value": ""
    >                },
    >                {
    >                    "type": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
    >                    "value": "3a226a2f-6a3b-430c-917c-7bd7750e4612"
    >                },
    >                {
    >                    "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
    >                    "value": ""
    >                }
    >            ],
    >            "image": {
    >                "adv": "charaupperbody_005_Actor",
    >                "battler": "d3a6de19-dfce-45b1-aa5f-bd48c4c59431",
    >                "character": "352c7990-8acf-4037-a0f6-c19d05583f10",
    >                "face": "charaface_005_Actor"
    >            },
    >            "initialLevel": 1,
    >            "maxLevel": 99,
    >            "name": "\u30c6\u30a3\u30a2",
    >            "nickname": "",
    >            "profile": "",
    >            "traits": [],
    >            "uuId": "dfe5c39c-aae8-4f10-bc26-59cb8b4627a7"
    >        },
    >        {
    >            "basic": {
    >                "classId": "6058ef9d-cd0e-4ef2-b962-3841cf8a5dca",
    >                "initialLevel": 1,
    >                "maxLevel": 99,
    >                "memo": "",
    >                "name": "Persephe",
    >                "profile": "An eccentric woman who finds more interest in assisting humans than her own kind.",
    >                "secondName": ""
    >            },
    >            "charaType": 1,
    >            "element": 0,
    >            "equips": [
    >                {
    >                    "type": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                    "value": "3b43e5d9-721a-4beb-82e9-be48c2240f74"
    >                },
    >                {
    >                    "type": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
    >                    "value": "3a226a2f-6a3b-430c-917c-7bd7750e4612"
    >                },
    >                {
    >                    "type": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
    >                    "value": ""
    >                }
    >            ],
    >            "image": {
    >                "adv": "charaupperbody_024_Actor",
    >                "battler": "ee879f35-3bde-4755-a7ce-30e821fa15dd",
    >                "character": "f60a361e-6bac-4e57-9ace-6aeea03fd059",
    >                "face": "charaface_024_Actor"
    >            },
    >            "initialLevel": 1,
    >            "maxLevel": 99,
    >            "name": "",
    >            "nickname": "",
    >            "profile": "",
    >            "traits": [],
    >            "uuId": "631ba9c0-ae29-45bc-a934-1068a64b7e02"
    >        }
    >    ]
    >]
    >```
