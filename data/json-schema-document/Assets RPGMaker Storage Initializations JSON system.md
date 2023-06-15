# JSON schema: Assets RPGMaker Storage Initializations JSON system

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['armorTypes', 'battleScene', 'bgm', 'displaySize', 'DisplaySize', 'elements', 'equipTypes', 'initialParty', 'isController', 'optionSetting', 'skillTypes', 'soundSetting', 'uiPatternId', 'weaponTypes']
* 😁 `armorTypes` property
    ■key: default
    * 😁 `armorTypes` array - default: None
        * default - ```None```
        * required - ['delete', 'id', 'name']
        * 😁 `delete` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "1",
                >    "b4bcd669-5923-47e4-aef2-791a6256ce89",
                >    "5d44ec7b-6494-4e4c-b18f-b552a8500fd6",
                >    "ef649a06-d430-49b8-a81d-6c73d26afb02"
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "General Armor",
                >    "Magic Armor",
                >    "Light Armor"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "delete": 0,
            >        "id": "1",
            >        "name": "General Armor"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
            >        "name": "Large Shield"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "delete": 0,
        >            "id": "1",
        >            "name": "General Armor"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
        >            "name": "Large Shield"
        >        }
        >    ]
        >]
        >```
* 😁 `battleScene` property
    ■key: default
    * required - ['frontEnemyPositionY', 'frontMiddleStartFlag', 'sideActorSpace', 'sideEnemyInclined', 'sidePartyInclined', 'sidePartyPosition', 'viewType']
    * 😁 `frontEnemyPositionY` property
        ■key: default
        * examples:
            >```
            >[
            >    670
            >]
            >```
    * 😁 `frontMiddleStartFlag` property
        ■key: default
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `sideActorSpace` property
        ■key: default
        * examples:
            >```
            >[
            >    2
            >]
            >```
    * 😁 `sideEnemyInclined` property
        ■key: default
        * examples:
            >```
            >[
            >    10
            >]
            >```
    * 😁 `sidePartyInclined` property
        ■key: default
        * examples:
            >```
            >[
            >    -5
            >]
            >```
    * 😁 `sidePartyPosition` property
        ■key: default
        * 😁 `sidePartyPosition` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    1400,
                >    450
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        1400,
            >        450
            >    ]
            >]
            >```
    * 😁 `viewType` property
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
        >        "frontEnemyPositionY": 670,
        >        "frontMiddleStartFlag": 1,
        >        "sideActorSpace": 2,
        >        "sideEnemyInclined": 10,
        >        "sidePartyInclined": -5,
        >        "sidePartyPosition": [
        >            1400,
        >            450
        >        ],
        >        "viewType": 1
        >    }
        >]
        >```
* 😁 `bgm` property
    ■key: default
    * required - ['battleBgm', 'defeatMe', 'gameOverMe', 'title', 'victoryMe']
    * 😁 `battleBgm` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "U_Battle_01.wav"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "U_Battle_01.wav",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `defeatMe` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Gameover1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Gameover1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `gameOverMe` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Gameover1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Gameover1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `title` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "U_Theme_01.wav"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "U_Theme_01.wav",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `victoryMe` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Victory1.ogg"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Victory1.ogg",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "battleBgm": {
        >            "name": "U_Battle_01.wav",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "defeatMe": {
        >            "name": "Gameover1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "gameOverMe": {
        >            "name": "Gameover1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "title": {
        >            "name": "U_Theme_01.wav",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "victoryMe": {
        >            "name": "Victory1.ogg",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        }
        >    }
        >]
        >```
* 😁 `displaySize` property
    ■key: default
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `DisplaySize` property
    ■key: default
    * 😁 `DisplaySize` array - default: None
        * default - ```None```
        * required - ['x', 'y']
        * 😁 `x` property
            * examples:
                >```
                >[
                >    1920,
                >    1280
                >]
                >```
        * 😁 `y` property
            * examples:
                >```
                >[
                >    1080,
                >    720
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "x": 1920,
            >        "y": 1080
            >    },
            >    {
            >        "x": 1280,
            >        "y": 720
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "x": 1920,
        >            "y": 1080
        >        },
        >        {
        >            "x": 1280,
        >            "y": 720
        >        }
        >    ]
        >]
        >```
* 😁 `elements` property
    ■key: default
    * 😁 `elements` array - default: None
        * default - ```None```
        * required - ['advantageous', 'delete', 'disadvantage', 'icon', 'id', 'sameElement', 'value']
        * 😁 `advantageous` property
            * 😁 `advantageous` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    [],
                >    [],
                >    []
                >]
                >```
        * 😁 `delete` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `disadvantage` property
            * 😁 `disadvantage` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    [],
                >    [],
                >    []
                >]
                >```
        * 😁 `icon` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "6dd648fd-fe18-4003-8927-bb6d7e88c755",
                >    "264f7c01-9663-4e8e-829c-0c0d3a16d69b",
                >    "cb6aa753-ef01-4a07-8eb9-7c59ea3f4cd4"
                >]
                >```
        * 😁 `sameElement` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "None",
                >    "Standard Attack",
                >    "Physical"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "advantageous": [],
            >        "delete": 0,
            >        "disadvantage": [],
            >        "icon": "",
            >        "id": "6dd648fd-fe18-4003-8927-bb6d7e88c755",
            >        "sameElement": 0,
            >        "value": "None"
            >    },
            >    {
            >        "advantageous": [],
            >        "delete": 0,
            >        "disadvantage": [],
            >        "icon": "",
            >        "id": "264f7c01-9663-4e8e-829c-0c0d3a16d69b",
            >        "sameElement": 0,
            >        "value": "Light"
            >    },
            >    {
            >        "advantageous": [],
            >        "delete": 0,
            >        "disadvantage": [],
            >        "icon": "",
            >        "id": "cb6aa753-ef01-4a07-8eb9-7c59ea3f4cd4",
            >        "sameElement": 0,
            >        "value": "Darkness"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "advantageous": [],
        >            "delete": 0,
        >            "disadvantage": [],
        >            "icon": "",
        >            "id": "6dd648fd-fe18-4003-8927-bb6d7e88c755",
        >            "sameElement": 0,
        >            "value": "None"
        >        },
        >        {
        >            "advantageous": [],
        >            "delete": 0,
        >            "disadvantage": [],
        >            "icon": "",
        >            "id": "264f7c01-9663-4e8e-829c-0c0d3a16d69b",
        >            "sameElement": 0,
        >            "value": "Light"
        >        },
        >        {
        >            "advantageous": [],
        >            "delete": 0,
        >            "disadvantage": [],
        >            "icon": "",
        >            "id": "cb6aa753-ef01-4a07-8eb9-7c59ea3f4cd4",
        >            "sameElement": 0,
        >            "value": "Darkness"
        >        }
        >    ]
        >]
        >```
* 😁 `equipTypes` property
    ■key: default
    * 😁 `equipTypes` array - default: None
        * default - ```None```
        * required - ['delete', 'id', 'name']
        * 😁 `delete` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "48254f68-178f-448e-98fd-60a0bb616a28",
                >    "7832ae68-aecc-4724-8765-e8e04e3cb64f",
                >    "312419fb-bc20-44b4-bb2b-0c28c7c3a987",
                >    "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
                >    "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4"
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "Weapon",
                >    "Shield",
                >    "Head",
                >    "Body",
                >    "Equipment Item"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "delete": 0,
            >        "id": "48254f68-178f-448e-98fd-60a0bb616a28",
            >        "name": "Weapon"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
            >        "name": "Shield"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "312419fb-bc20-44b4-bb2b-0c28c7c3a987",
            >        "name": "Head"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
            >        "name": "Body"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
            >        "name": "Equipment Item"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "delete": 0,
        >            "id": "48254f68-178f-448e-98fd-60a0bb616a28",
        >            "name": "Weapon"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
        >            "name": "Shield"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "312419fb-bc20-44b4-bb2b-0c28c7c3a987",
        >            "name": "Head"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
        >            "name": "Body"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
        >            "name": "Equipment Item"
        >        }
        >    ]
        >]
        >```
* 😁 `initialParty` property
    ■key: default
    * required - ['party', 'partyMax', 'startMap']
    * 😁 `party` property
        ■key: default
        * 😁 `party` array - default: None
            * default - ```None```
            ■key: default
            * examples:
                >```
                >[
                >    "a8230358-b349-4687-aaf9-e3ccb8d55479"
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        "a8230358-b349-4687-aaf9-e3ccb8d55479"
            >    ]
            >]
            >```
    * 😁 `partyMax` property
        ■key: default
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `startMap` property
        ■key: default
        * required - ['mapId', 'position']
        * 😁 `mapId` property
            ■key: default
            * examples:
                >```
                >[
                >    "227cd9d6-e13b-4a86-80b3-bdd6d67ba0d9"
                >]
                >```
        * 😁 `position` property
            ■key: default
            * 😁 `position` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    6,
                    >    -5
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        6,
                >        -5
                >    ]
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "mapId": "227cd9d6-e13b-4a86-80b3-bdd6d67ba0d9",
            >        "position": [
            >            6,
            >            -5
            >        ]
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "party": [
        >            "a8230358-b349-4687-aaf9-e3ccb8d55479"
        >        ],
        >        "partyMax": 1,
        >        "startMap": {
        >            "mapId": "227cd9d6-e13b-4a86-80b3-bdd6d67ba0d9",
        >            "position": [
        >                6,
        >                -5
        >            ]
        >        }
        >    }
        >]
        >```
* 😁 `isController` property
    ■key: default
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `optionSetting` property
    ■key: default
    * required - ['enabledAutoSave', 'locale', 'optDisplayTp', 'optExtraExp', 'optFloorDeath', 'optFollowers', 'optSlipDeath', 'optTransparent', 'showKeyItemNum', 'windowTone']
    * 😁 `enabledAutoSave` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `locale` property
        ■key: default
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `optDisplayTp` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `optExtraExp` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `optFloorDeath` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `optFollowers` property
        ■key: default
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `optSlipDeath` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `optTransparent` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `showKeyItemNum` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `windowTone` property
        ■key: default
        * 😁 `windowTone` array - default: None
            * default - ```None```
        * examples:
            >```
            >[
            >    []
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "enabledAutoSave": 0,
        >        "locale": "",
        >        "optDisplayTp": 0,
        >        "optExtraExp": 0,
        >        "optFloorDeath": 0,
        >        "optFollowers": 1,
        >        "optSlipDeath": 0,
        >        "optTransparent": 0,
        >        "showKeyItemNum": 0,
        >        "windowTone": []
        >    }
        >]
        >```
* 😁 `skillTypes` property
    ■key: default
    * 😁 `skillTypes` array - default: None
        * default - ```None```
        * required - ['delete', 'id', 'motion', 'value']
        * 😁 `delete` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "7955b088-df05-461c-b2e3-7d9dfc3941f6",
                >    "64183358-c72f-4190-b42c-4ba9b373282c",
                >    "16b91790-cb8f-4a38-a663-d3a4fe2a4614"
                >]
                >```
        * 😁 `motion` property
            * examples:
                >```
                >[
                >    0,
                >    1
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "None",
                >    "Magic",
                >    "Special"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "delete": 0,
            >        "id": "7955b088-df05-461c-b2e3-7d9dfc3941f6",
            >        "motion": 0,
            >        "value": "None"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "16b91790-cb8f-4a38-a663-d3a4fe2a4614",
            >        "motion": 0,
            >        "value": "Special"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "delete": 0,
        >            "id": "7955b088-df05-461c-b2e3-7d9dfc3941f6",
        >            "motion": 0,
        >            "value": "None"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "16b91790-cb8f-4a38-a663-d3a4fe2a4614",
        >            "motion": 0,
        >            "value": "Special"
        >        }
        >    ]
        >]
        >```
* 😁 `soundSetting` property
    ■key: default
    * required - ['actorDamage', 'actorDied', 'battleStart', 'bossCollapse1', 'bossCollapse2', 'buzzer', 'cancel', 'cursor', 'enemyAttack', 'enemyCollapse', 'enemyDamage', 'equip', 'escape', 'evasion', 'load', 'magicEvasion', 'magicReflection', 'miss', 'ok', 'recovery', 'save', 'shop', 'useItem', 'useSkill']
    * 😁 `actorDamage` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Damage5"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Damage5",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `actorDied` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Collapse4"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Collapse4",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `battleStart` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Battle1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Battle1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `bossCollapse1` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Collapse2"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Collapse2",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `bossCollapse2` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Collapse3"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Collapse3",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `buzzer` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Buzzer1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Buzzer1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `cancel` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Cancel2"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    109
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Cancel2",
            >        "pan": 0,
            >        "pitch": 109,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `cursor` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Cursor3"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Cursor3",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `enemyAttack` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Attack3"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Attack3",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `enemyCollapse` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Collapse1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Collapse1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `enemyDamage` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Damage4"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Damage4",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `equip` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Equip1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Equip1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `escape` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Run"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Run",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `evasion` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Evasion1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Evasion1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `load` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Load2"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Load2",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `magicEvasion` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Evasion2"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Evasion2",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `magicReflection` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Reflection"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Reflection",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `miss` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Miss"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Miss",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `ok` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Decision2"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Decision2",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `recovery` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Recovery"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Recovery",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `save` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Save2"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Save2",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `shop` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Shop1"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Shop1",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `useItem` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Item3"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Item3",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * 😁 `useSkill` property
        ■key: default
        * required - ['name', 'pan', 'pitch', 'volume']
        * 😁 `name` property
            ■key: default
            * examples:
                >```
                >[
                >    "Item3"
                >]
                >```
        * 😁 `pan` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `pitch` property
            ■key: default
            * examples:
                >```
                >[
                >    100
                >]
                >```
        * 😁 `volume` property
            ■key: default
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
            >        "name": "Item3",
            >        "pan": 0,
            >        "pitch": 100,
            >        "volume": 90
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "actorDamage": {
        >            "name": "Damage5",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "actorDied": {
        >            "name": "Collapse4",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "battleStart": {
        >            "name": "Battle1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "bossCollapse1": {
        >            "name": "Collapse2",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "bossCollapse2": {
        >            "name": "Collapse3",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "buzzer": {
        >            "name": "Buzzer1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "cancel": {
        >            "name": "Cancel2",
        >            "pan": 0,
        >            "pitch": 109,
        >            "volume": 90
        >        },
        >        "cursor": {
        >            "name": "Cursor3",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "enemyAttack": {
        >            "name": "Attack3",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "enemyCollapse": {
        >            "name": "Collapse1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "enemyDamage": {
        >            "name": "Damage4",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "equip": {
        >            "name": "Equip1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "escape": {
        >            "name": "Run",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "evasion": {
        >            "name": "Evasion1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "load": {
        >            "name": "Load2",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "magicEvasion": {
        >            "name": "Evasion2",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "magicReflection": {
        >            "name": "Reflection",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "miss": {
        >            "name": "Miss",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "ok": {
        >            "name": "Decision2",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "recovery": {
        >            "name": "Recovery",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "save": {
        >            "name": "Save2",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "shop": {
        >            "name": "Shop1",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "useItem": {
        >            "name": "Item3",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        },
        >        "useSkill": {
        >            "name": "Item3",
        >            "pan": 0,
        >            "pitch": 100,
        >            "volume": 90
        >        }
        >    }
        >]
        >```
* 😁 `uiPatternId` property
    ■key: default
    * examples:
        >```
        >[
        >    "4"
        >]
        >```
* 😁 `weaponTypes` property
    ■key: default
    * 😁 `weaponTypes` array - default: None
        * default - ```None```
        * required - ['delete', 'id', 'image', 'motionId', 'value']
        * 😁 `delete` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "57d8fa5d-f169-47e1-8bb1-4241de04756b",
                >    "3ef5ff5a-778a-473e-aef3-13096bc5e9ac",
                >    "56c3b34b-eb79-4a15-b9f5-d693a9d5a0be"
                >]
                >```
        * 😁 `image` property
            * examples:
                >```
                >[
                >    "c9b1d31b-72bb-45d6-a771-1119f4325c5b",
                >    "c1d68d6d-f6ea-449a-a8c7-38217ca36a1e",
                >    "be343f14-c25a-4d47-ba73-dbacf22478e2"
                >]
                >```
        * 😁 `motionId` property
            * examples:
                >```
                >[
                >    0,
                >    1,
                >    2
                >]
                >```
        * 😁 `value` property
            * examples:
                >```
                >[
                >    "Unarmed (Nothing)",
                >    "Sword",
                >    "Greatsword"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "delete": 0,
            >        "id": "57d8fa5d-f169-47e1-8bb1-4241de04756b",
            >        "image": "c9b1d31b-72bb-45d6-a771-1119f4325c5b",
            >        "motionId": 0,
            >        "value": "Unarmed (Nothing)"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "3ef5ff5a-778a-473e-aef3-13096bc5e9ac",
            >        "image": "c1d68d6d-f6ea-449a-a8c7-38217ca36a1e",
            >        "motionId": 2,
            >        "value": "Shortbow"
            >    },
            >    {
            >        "delete": 0,
            >        "id": "56c3b34b-eb79-4a15-b9f5-d693a9d5a0be",
            >        "image": "be343f14-c25a-4d47-ba73-dbacf22478e2",
            >        "motionId": 2,
            >        "value": "Musket"
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "delete": 0,
        >            "id": "57d8fa5d-f169-47e1-8bb1-4241de04756b",
        >            "image": "c9b1d31b-72bb-45d6-a771-1119f4325c5b",
        >            "motionId": 0,
        >            "value": "Unarmed (Nothing)"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "3ef5ff5a-778a-473e-aef3-13096bc5e9ac",
        >            "image": "c1d68d6d-f6ea-449a-a8c7-38217ca36a1e",
        >            "motionId": 2,
        >            "value": "Shortbow"
        >        },
        >        {
        >            "delete": 0,
        >            "id": "56c3b34b-eb79-4a15-b9f5-d693a9d5a0be",
        >            "image": "be343f14-c25a-4d47-ba73-dbacf22478e2",
        >            "motionId": 2,
        >            "value": "Musket"
        >        }
        >    ]
        >]
        >```
* examples:
    >```
    >[
    >    {
    >        "armorTypes": [
    >            {
    >                "delete": 0,
    >                "id": "1",
    >                "name": "General Armor"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "c01b25d3-bdb5-4c23-a375-dcfdc05abad6",
    >                "name": "Small Shield"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "1bd115d3-72d1-40d6-a6c8-aa8d49c0d594",
    >                "name": "Large Shield"
    >            }
    >        ],
    >        "battleScene": {
    >            "frontEnemyPositionY": 670,
    >            "frontMiddleStartFlag": 1,
    >            "sideActorSpace": 2,
    >            "sideEnemyInclined": 10,
    >            "sidePartyInclined": -5,
    >            "sidePartyPosition": [
    >                1400,
    >                450
    >            ],
    >            "viewType": 1
    >        },
    >        "bgm": {
    >            "battleBgm": {
    >                "name": "U_Battle_01.wav",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "defeatMe": {
    >                "name": "Gameover1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "gameOverMe": {
    >                "name": "Gameover1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "title": {
    >                "name": "U_Theme_01.wav",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "victoryMe": {
    >                "name": "Victory1.ogg",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            }
    >        },
    >        "displaySize": 0,
    >        "DisplaySize": [
    >            {
    >                "x": 1920,
    >                "y": 1080
    >            },
    >            {
    >                "x": 1280,
    >                "y": 720
    >            }
    >        ],
    >        "elements": [
    >            {
    >                "advantageous": [],
    >                "delete": 0,
    >                "disadvantage": [],
    >                "icon": "",
    >                "id": "6dd648fd-fe18-4003-8927-bb6d7e88c755",
    >                "sameElement": 0,
    >                "value": "None"
    >            },
    >            {
    >                "advantageous": [],
    >                "delete": 0,
    >                "disadvantage": [],
    >                "icon": "",
    >                "id": "264f7c01-9663-4e8e-829c-0c0d3a16d69b",
    >                "sameElement": 0,
    >                "value": "Light"
    >            },
    >            {
    >                "advantageous": [],
    >                "delete": 0,
    >                "disadvantage": [],
    >                "icon": "",
    >                "id": "cb6aa753-ef01-4a07-8eb9-7c59ea3f4cd4",
    >                "sameElement": 0,
    >                "value": "Darkness"
    >            }
    >        ],
    >        "equipTypes": [
    >            {
    >                "delete": 0,
    >                "id": "48254f68-178f-448e-98fd-60a0bb616a28",
    >                "name": "Weapon"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "7832ae68-aecc-4724-8765-e8e04e3cb64f",
    >                "name": "Shield"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "312419fb-bc20-44b4-bb2b-0c28c7c3a987",
    >                "name": "Head"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "c557c358-d63e-4992-b7a2-f8dadd9eeb71",
    >                "name": "Body"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "5ae4faaf-5561-4420-9eb6-81b6b1d3eeb4",
    >                "name": "Equipment Item"
    >            }
    >        ],
    >        "initialParty": {
    >            "party": [
    >                "a8230358-b349-4687-aaf9-e3ccb8d55479"
    >            ],
    >            "partyMax": 1,
    >            "startMap": {
    >                "mapId": "227cd9d6-e13b-4a86-80b3-bdd6d67ba0d9",
    >                "position": [
    >                    6,
    >                    -5
    >                ]
    >            }
    >        },
    >        "isController": 0,
    >        "optionSetting": {
    >            "enabledAutoSave": 0,
    >            "locale": "",
    >            "optDisplayTp": 0,
    >            "optExtraExp": 0,
    >            "optFloorDeath": 0,
    >            "optFollowers": 1,
    >            "optSlipDeath": 0,
    >            "optTransparent": 0,
    >            "showKeyItemNum": 0,
    >            "windowTone": []
    >        },
    >        "skillTypes": [
    >            {
    >                "delete": 0,
    >                "id": "7955b088-df05-461c-b2e3-7d9dfc3941f6",
    >                "motion": 0,
    >                "value": "None"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "64183358-c72f-4190-b42c-4ba9b373282c",
    >                "motion": 1,
    >                "value": "Magic"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "16b91790-cb8f-4a38-a663-d3a4fe2a4614",
    >                "motion": 0,
    >                "value": "Special"
    >            }
    >        ],
    >        "soundSetting": {
    >            "actorDamage": {
    >                "name": "Damage5",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "actorDied": {
    >                "name": "Collapse4",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "battleStart": {
    >                "name": "Battle1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "bossCollapse1": {
    >                "name": "Collapse2",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "bossCollapse2": {
    >                "name": "Collapse3",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "buzzer": {
    >                "name": "Buzzer1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "cancel": {
    >                "name": "Cancel2",
    >                "pan": 0,
    >                "pitch": 109,
    >                "volume": 90
    >            },
    >            "cursor": {
    >                "name": "Cursor3",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "enemyAttack": {
    >                "name": "Attack3",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "enemyCollapse": {
    >                "name": "Collapse1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "enemyDamage": {
    >                "name": "Damage4",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "equip": {
    >                "name": "Equip1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "escape": {
    >                "name": "Run",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "evasion": {
    >                "name": "Evasion1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "load": {
    >                "name": "Load2",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "magicEvasion": {
    >                "name": "Evasion2",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "magicReflection": {
    >                "name": "Reflection",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "miss": {
    >                "name": "Miss",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "ok": {
    >                "name": "Decision2",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "recovery": {
    >                "name": "Recovery",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "save": {
    >                "name": "Save2",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "shop": {
    >                "name": "Shop1",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "useItem": {
    >                "name": "Item3",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            },
    >            "useSkill": {
    >                "name": "Item3",
    >                "pan": 0,
    >                "pitch": 100,
    >                "volume": 90
    >            }
    >        },
    >        "uiPatternId": "4",
    >        "weaponTypes": [
    >            {
    >                "delete": 0,
    >                "id": "57d8fa5d-f169-47e1-8bb1-4241de04756b",
    >                "image": "c9b1d31b-72bb-45d6-a771-1119f4325c5b",
    >                "motionId": 0,
    >                "value": "Unarmed (Nothing)"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "3ef5ff5a-778a-473e-aef3-13096bc5e9ac",
    >                "image": "c1d68d6d-f6ea-449a-a8c7-38217ca36a1e",
    >                "motionId": 2,
    >                "value": "Shortbow"
    >            },
    >            {
    >                "delete": 0,
    >                "id": "56c3b34b-eb79-4a15-b9f5-d693a9d5a0be",
    >                "image": "be343f14-c25a-4d47-ba73-dbacf22478e2",
    >                "motionId": 2,
    >                "value": "Musket"
    >            }
    >        ]
    >    }
    >]
    >```
