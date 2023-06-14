# JSON schema: Assets RPGMaker Storage Initializations JSON system

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
■key: required, type(value): <class 'list'>
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
