# JSON schema: Assets RPGMaker Storage Item JSON item

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['basic', 'memo', 'targetEffect', 'userEffect']
    * 😁 `basic` property
        * required - ['canSell', 'canUseTiming', 'consumable', 'description', 'iconId', 'id', 'itemType', 'name', 'price', 'sell', 'switchItem']
        * 😁 `canSell` property
            * examples:
                >```
                >[
                >    1,
                >    0
                >]
                >```
        * 😁 `canUseTiming` property
            * examples:
                >```
                >[
                >    3,
                >    0
                >]
                >```
        * 😁 `consumable` property
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
                >    "0",
                >    "Recover from an enemy's Charm.",
                >    "Recovers 300 HP."
                >]
                >```
        * 😁 `iconId` property
            * examples:
                >```
                >[
                >    "IconSet_000",
                >    "IconSet_176"
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "db56b1eb-5c6e-42a3-915f-c2ec4d9c7290",
                >    "386dbcf2-1202-44f0-8a11-4a2a4c071fa8",
                >    "28faadbb-61b2-4485-8644-c021c3cb1265"
                >]
                >```
        * 😁 `itemType` property
            * examples:
                >```
                >[
                >    0,
                >    1
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "-----Reserve",
                >    "De-Charm",
                >    "-----Recovery Items",
                >    "Potion"
                >]
                >```
        * 😁 `price` property
            * examples:
                >```
                >[
                >    0,
                >    150,
                >    30
                >]
                >```
        * 😁 `sell` property
            * examples:
                >```
                >[
                >    0,
                >    75,
                >    15
                >]
                >```
        * 😁 `switchItem` property
            * examples:
                >```
                >[
                >    1,
                >    0
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "canSell": 1,
            >        "canUseTiming": 3,
            >        "consumable": 1,
            >        "description": "0",
            >        "iconId": "IconSet_000",
            >        "id": "db56b1eb-5c6e-42a3-915f-c2ec4d9c7290",
            >        "itemType": 0,
            >        "name": "-----Reserve",
            >        "price": 0,
            >        "sell": 0,
            >        "switchItem": 1
            >    },
            >    {
            >        "canSell": 0,
            >        "canUseTiming": 0,
            >        "consumable": 0,
            >        "description": "Recovers 300 HP.",
            >        "iconId": "IconSet_176",
            >        "id": "cd8fab08-5b93-4d99-afb2-1ce3c114b68e",
            >        "itemType": 1,
            >        "name": "Potion",
            >        "price": 30,
            >        "sell": 15,
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
    * 😁 `targetEffect` property
        * required - ['activate', 'damage', 'heal', 'otherEffects', 'randomNumber', 'targetRange', 'targetStatus', 'targetTeam', 'targetUser']
        * 😁 `activate` property
            * required - ['animationId', 'continuousNumber', 'correctionSpeed', 'getTp', 'hitType', 'successRate']
            * 😁 `animationId` property
                * examples:
                    >```
                    >[
                    >    "0",
                    >    "b238e665-2a0a-4ac9-aad4-cb38e90f55b3"
                    >]
                    >```
            * 😁 `continuousNumber` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1
                    >]
                    >```
            * 😁 `correctionSpeed` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `getTp` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `hitType` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `successRate` property
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
                >        "animationId": "0",
                >        "continuousNumber": 0,
                >        "correctionSpeed": 0,
                >        "getTp": 0,
                >        "hitType": 1,
                >        "successRate": 0
                >    },
                >    {
                >        "animationId": "b238e665-2a0a-4ac9-aad4-cb38e90f55b3",
                >        "continuousNumber": 1,
                >        "correctionSpeed": 0,
                >        "getTp": 0,
                >        "hitType": 0,
                >        "successRate": 100
                >    }
                >]
                >```
        * 😁 `damage` property
            * required - ['critical', 'damageType', 'distribute', 'distributeEnabled', 'elements', 'max', 'maxEnabled', 'min', 'minEnabled', 'value']
            * 😁 `critical` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1
                    >]
                    >```
            * 😁 `damageType` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `distribute` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `distributeEnabled` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `elements` property
                * 😁 `elements` array - default: None
                    * default - ```None```
                * examples:
                    >```
                    >[
                    >    [],
                    >    [],
                    >    [],
                    >    []
                    >]
                    >```
            * 😁 `max` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `maxEnabled` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `min` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `minEnabled` property
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
                    >    ""
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "critical": 0,
                >        "damageType": 0,
                >        "distribute": 0,
                >        "distributeEnabled": 0,
                >        "elements": [],
                >        "max": 0,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": ""
                >    },
                >    {
                >        "critical": 1,
                >        "damageType": 0,
                >        "distribute": 0,
                >        "distributeEnabled": 0,
                >        "elements": [],
                >        "max": 0,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": ""
                >    }
                >]
                >```
        * 😁 `heal` property
            * required - ['hp', 'mp', 'tp']
            * 😁 `hp` property
                * required - ['calc', 'enabled', 'fix', 'perMax']
                * 😁 `calc` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    1,
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    "0"
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": "0"
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": "0"
                        >    }
                        >]
                        >```
                * 😁 `enabled` property
                    * examples:
                        >```
                        >[
                        >    0,
                        >    1
                        >]
                        >```
                * 😁 `fix` property
                    * required - ['enabled', 'value']
                    * 😁 `enabled` property
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
                            >    0,
                            >    300
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "value": 300
                        >    }
                        >]
                        >```
                * 😁 `perMax` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "calc": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": "0"
                    >        },
                    >        "enabled": 1,
                    >        "fix": {
                    >            "enabled": 1,
                    >            "value": 300
                    >        },
                    >        "perMax": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": 0
                    >        }
                    >    }
                    >]
                    >```
            * 😁 `mp` property
                * required - ['calc', 'enabled', 'fix', 'perMax']
                * 😁 `calc` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    "0"
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": "0"
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": "0"
                        >    }
                        >]
                        >```
                * 😁 `enabled` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `fix` property
                    * required - ['enabled', 'value']
                    * 😁 `enabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * 😁 `perMax` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "calc": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 1,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": "0"
                    >        },
                    >        "enabled": 0,
                    >        "fix": {
                    >            "enabled": 0,
                    >            "value": 0
                    >        },
                    >        "perMax": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": 0
                    >        }
                    >    }
                    >]
                    >```
            * 😁 `tp` property
                * required - ['calc', 'enabled', 'fix', 'perMax']
                * 😁 `calc` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    "0"
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": "0"
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": "0"
                        >    }
                        >]
                        >```
                * 😁 `enabled` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `fix` property
                    * required - ['enabled', 'value']
                    * 😁 `enabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * 😁 `perMax` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "calc": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 1,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": "0"
                    >        },
                    >        "enabled": 0,
                    >        "fix": {
                    >            "enabled": 0,
                    >            "value": 0
                    >        },
                    >        "perMax": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": 0
                    >        }
                    >    }
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "hp": {
                >            "calc": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": "0"
                >            },
                >            "enabled": 1,
                >            "fix": {
                >                "enabled": 1,
                >                "value": 300
                >            },
                >            "perMax": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": 0
                >            }
                >        },
                >        "mp": {
                >            "calc": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 1,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": "0"
                >            },
                >            "enabled": 0,
                >            "fix": {
                >                "enabled": 0,
                >                "value": 0
                >            },
                >            "perMax": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": 0
                >            }
                >        },
                >        "tp": {
                >            "calc": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 1,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": "0"
                >            },
                >            "enabled": 0,
                >            "fix": {
                >                "enabled": 0,
                >                "value": 0
                >            },
                >            "perMax": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": 0
                >            }
                >        }
                >    }
                >]
                >```
        * 😁 `otherEffects` property
            * 😁 `otherEffects` array - default: None
                * default - ```None```
                * required - ['categoryId', 'effectId', 'traitsId', 'value']
                * 😁 `categoryId` property
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `effectId` property
                    * examples:
                        >```
                        >[
                        >    8
                        >]
                        >```
                * 😁 `traitsId` property
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `value` property
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
                    >        "categoryId": 1,
                    >        "effectId": 8,
                    >        "traitsId": 1,
                    >        "value": 100
                    >    }
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        {
                >            "categoryId": 1,
                >            "effectId": 8,
                >            "traitsId": 1,
                >            "value": 100
                >        }
                >    ],
                >    []
                >]
                >```
        * 😁 `randomNumber` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetRange` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetStatus` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetTeam` property
            * examples:
                >```
                >[
                >    0,
                >    2
                >]
                >```
        * 😁 `targetUser` property
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
            >        "activate": {
            >            "animationId": "0",
            >            "continuousNumber": 0,
            >            "correctionSpeed": 0,
            >            "getTp": 0,
            >            "hitType": 1,
            >            "successRate": 0
            >        },
            >        "damage": {
            >            "critical": 0,
            >            "damageType": 0,
            >            "distribute": 0,
            >            "distributeEnabled": 0,
            >            "elements": [],
            >            "max": 0,
            >            "maxEnabled": 0,
            >            "min": 0,
            >            "minEnabled": 0,
            >            "value": ""
            >        },
            >        "heal": {
            >            "hp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": "0"
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "mp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": "0"
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "tp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": "0"
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            }
            >        },
            >        "otherEffects": [],
            >        "randomNumber": 0,
            >        "targetRange": 0,
            >        "targetStatus": 0,
            >        "targetTeam": 0,
            >        "targetUser": 0
            >    },
            >    {
            >        "activate": {
            >            "animationId": "b238e665-2a0a-4ac9-aad4-cb38e90f55b3",
            >            "continuousNumber": 1,
            >            "correctionSpeed": 0,
            >            "getTp": 0,
            >            "hitType": 0,
            >            "successRate": 100
            >        },
            >        "damage": {
            >            "critical": 1,
            >            "damageType": 0,
            >            "distribute": 0,
            >            "distributeEnabled": 0,
            >            "elements": [],
            >            "max": 0,
            >            "maxEnabled": 0,
            >            "min": 0,
            >            "minEnabled": 0,
            >            "value": ""
            >        },
            >        "heal": {
            >            "hp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": "0"
            >                },
            >                "enabled": 1,
            >                "fix": {
            >                    "enabled": 1,
            >                    "value": 300
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "mp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": "0"
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "tp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": "0"
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            }
            >        },
            >        "otherEffects": [],
            >        "randomNumber": 0,
            >        "targetRange": 0,
            >        "targetStatus": 0,
            >        "targetTeam": 2,
            >        "targetUser": 0
            >    }
            >]
            >```
    * 😁 `userEffect` property
        * required - ['activate', 'damage', 'heal', 'otherEffects', 'randomNumber', 'targetRange', 'targetStatus', 'targetTeam', 'targetUser']
        * 😁 `activate` property
            * required - ['animationId', 'continuousNumber', 'correctionSpeed', 'getTp', 'hitType', 'successRate']
            * 😁 `animationId` property
                * examples:
                    >```
                    >[
                    >    ""
                    >]
                    >```
            * 😁 `continuousNumber` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `correctionSpeed` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `getTp` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `hitType` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `successRate` property
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
                >        "continuousNumber": 0,
                >        "correctionSpeed": 0,
                >        "getTp": 0,
                >        "hitType": 0,
                >        "successRate": 0
                >    },
                >    {
                >        "animationId": "",
                >        "continuousNumber": 0,
                >        "correctionSpeed": 0,
                >        "getTp": 0,
                >        "hitType": 0,
                >        "successRate": 0
                >    }
                >]
                >```
        * 😁 `damage` property
            * required - ['critical', 'damageType', 'distribute', 'distributeEnabled', 'elements', 'max', 'maxEnabled', 'min', 'minEnabled', 'value']
            * 😁 `critical` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1
                    >]
                    >```
            * 😁 `damageType` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `distribute` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `distributeEnabled` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `elements` property
                * 😁 `elements` array - default: None
                    * default - ```None```
                * examples:
                    >```
                    >[
                    >    [],
                    >    [],
                    >    [],
                    >    []
                    >]
                    >```
            * 😁 `max` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `maxEnabled` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `min` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `minEnabled` property
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
                    >    ""
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "critical": 0,
                >        "damageType": 0,
                >        "distribute": 0,
                >        "distributeEnabled": 0,
                >        "elements": [],
                >        "max": 0,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": ""
                >    },
                >    {
                >        "critical": 1,
                >        "damageType": 0,
                >        "distribute": 0,
                >        "distributeEnabled": 0,
                >        "elements": [],
                >        "max": 0,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": ""
                >    }
                >]
                >```
        * 😁 `heal` property
            * required - ['hp', 'mp', 'tp']
            * 😁 `hp` property
                * required - ['calc', 'enabled', 'fix', 'perMax']
                * 😁 `calc` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    ""
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": ""
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": ""
                        >    }
                        >]
                        >```
                * 😁 `enabled` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `fix` property
                    * required - ['enabled', 'value']
                    * 😁 `enabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * 😁 `perMax` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "calc": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 1,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": ""
                    >        },
                    >        "enabled": 0,
                    >        "fix": {
                    >            "enabled": 0,
                    >            "value": 0
                    >        },
                    >        "perMax": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": 0
                    >        }
                    >    }
                    >]
                    >```
            * 😁 `mp` property
                * required - ['calc', 'enabled', 'fix', 'perMax']
                * 😁 `calc` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    ""
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": ""
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": ""
                        >    }
                        >]
                        >```
                * 😁 `enabled` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `fix` property
                    * required - ['enabled', 'value']
                    * 😁 `enabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * 😁 `perMax` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "calc": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 1,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": ""
                    >        },
                    >        "enabled": 0,
                    >        "fix": {
                    >            "enabled": 0,
                    >            "value": 0
                    >        },
                    >        "perMax": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": 0
                    >        }
                    >    }
                    >]
                    >```
            * 😁 `tp` property
                * required - ['calc', 'enabled', 'fix', 'perMax']
                * 😁 `calc` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    ""
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": ""
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 1,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": ""
                        >    }
                        >]
                        >```
                * 😁 `enabled` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `fix` property
                    * required - ['enabled', 'value']
                    * 😁 `enabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * 😁 `perMax` property
                    * required - ['distribute', 'distributeEnabled', 'enabled', 'max', 'maxEnabled', 'value']
                    * 😁 `distribute` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `distributeEnabled` property
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
                            >    0
                            >]
                            >```
                    * 😁 `max` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `maxEnabled` property
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
                            >    0
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    },
                        >    {
                        >        "distribute": 0,
                        >        "distributeEnabled": 0,
                        >        "enabled": 0,
                        >        "max": 0,
                        >        "maxEnabled": 0,
                        >        "value": 0
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "calc": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 1,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": ""
                    >        },
                    >        "enabled": 0,
                    >        "fix": {
                    >            "enabled": 0,
                    >            "value": 0
                    >        },
                    >        "perMax": {
                    >            "distribute": 0,
                    >            "distributeEnabled": 0,
                    >            "enabled": 0,
                    >            "max": 0,
                    >            "maxEnabled": 0,
                    >            "value": 0
                    >        }
                    >    }
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "hp": {
                >            "calc": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 1,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": ""
                >            },
                >            "enabled": 0,
                >            "fix": {
                >                "enabled": 0,
                >                "value": 0
                >            },
                >            "perMax": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": 0
                >            }
                >        },
                >        "mp": {
                >            "calc": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 1,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": ""
                >            },
                >            "enabled": 0,
                >            "fix": {
                >                "enabled": 0,
                >                "value": 0
                >            },
                >            "perMax": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": 0
                >            }
                >        },
                >        "tp": {
                >            "calc": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 1,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": ""
                >            },
                >            "enabled": 0,
                >            "fix": {
                >                "enabled": 0,
                >                "value": 0
                >            },
                >            "perMax": {
                >                "distribute": 0,
                >                "distributeEnabled": 0,
                >                "enabled": 0,
                >                "max": 0,
                >                "maxEnabled": 0,
                >                "value": 0
                >            }
                >        }
                >    }
                >]
                >```
        * 😁 `otherEffects` property
            * 😁 `otherEffects` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    [],
                >    [],
                >    [],
                >    []
                >]
                >```
        * 😁 `randomNumber` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetRange` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetStatus` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetTeam` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `targetUser` property
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
            >        "activate": {
            >            "animationId": "",
            >            "continuousNumber": 0,
            >            "correctionSpeed": 0,
            >            "getTp": 0,
            >            "hitType": 0,
            >            "successRate": 0
            >        },
            >        "damage": {
            >            "critical": 0,
            >            "damageType": 0,
            >            "distribute": 0,
            >            "distributeEnabled": 0,
            >            "elements": [],
            >            "max": 0,
            >            "maxEnabled": 0,
            >            "min": 0,
            >            "minEnabled": 0,
            >            "value": ""
            >        },
            >        "heal": {
            >            "hp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": ""
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "mp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": ""
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "tp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": ""
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            }
            >        },
            >        "otherEffects": [],
            >        "randomNumber": 0,
            >        "targetRange": 0,
            >        "targetStatus": 0,
            >        "targetTeam": 0,
            >        "targetUser": 0
            >    },
            >    {
            >        "activate": {
            >            "animationId": "",
            >            "continuousNumber": 0,
            >            "correctionSpeed": 0,
            >            "getTp": 0,
            >            "hitType": 0,
            >            "successRate": 0
            >        },
            >        "damage": {
            >            "critical": 1,
            >            "damageType": 0,
            >            "distribute": 0,
            >            "distributeEnabled": 0,
            >            "elements": [],
            >            "max": 0,
            >            "maxEnabled": 0,
            >            "min": 0,
            >            "minEnabled": 0,
            >            "value": ""
            >        },
            >        "heal": {
            >            "hp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": ""
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "mp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": ""
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            },
            >            "tp": {
            >                "calc": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 1,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": ""
            >                },
            >                "enabled": 0,
            >                "fix": {
            >                    "enabled": 0,
            >                    "value": 0
            >                },
            >                "perMax": {
            >                    "distribute": 0,
            >                    "distributeEnabled": 0,
            >                    "enabled": 0,
            >                    "max": 0,
            >                    "maxEnabled": 0,
            >                    "value": 0
            >                }
            >            }
            >        },
            >        "otherEffects": [],
            >        "randomNumber": 0,
            >        "targetRange": 0,
            >        "targetStatus": 0,
            >        "targetTeam": 0,
            >        "targetUser": 0
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "basic": {
        >            "canSell": 0,
        >            "canUseTiming": 0,
        >            "consumable": 0,
        >            "description": "Recovers 300 HP.",
        >            "iconId": "IconSet_176",
        >            "id": "cd8fab08-5b93-4d99-afb2-1ce3c114b68e",
        >            "itemType": 1,
        >            "name": "Potion",
        >            "price": 30,
        >            "sell": 15,
        >            "switchItem": 0
        >        },
        >        "memo": "",
        >        "targetEffect": {
        >            "activate": {
        >                "animationId": "b238e665-2a0a-4ac9-aad4-cb38e90f55b3",
        >                "continuousNumber": 1,
        >                "correctionSpeed": 0,
        >                "getTp": 0,
        >                "hitType": 0,
        >                "successRate": 100
        >            },
        >            "damage": {
        >                "critical": 1,
        >                "damageType": 0,
        >                "distribute": 0,
        >                "distributeEnabled": 0,
        >                "elements": [],
        >                "max": 0,
        >                "maxEnabled": 0,
        >                "min": 0,
        >                "minEnabled": 0,
        >                "value": ""
        >            },
        >            "heal": {
        >                "hp": {
        >                    "calc": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": "0"
        >                    },
        >                    "enabled": 1,
        >                    "fix": {
        >                        "enabled": 1,
        >                        "value": 300
        >                    },
        >                    "perMax": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": 0
        >                    }
        >                },
        >                "mp": {
        >                    "calc": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 1,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": "0"
        >                    },
        >                    "enabled": 0,
        >                    "fix": {
        >                        "enabled": 0,
        >                        "value": 0
        >                    },
        >                    "perMax": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": 0
        >                    }
        >                },
        >                "tp": {
        >                    "calc": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 1,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": "0"
        >                    },
        >                    "enabled": 0,
        >                    "fix": {
        >                        "enabled": 0,
        >                        "value": 0
        >                    },
        >                    "perMax": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": 0
        >                    }
        >                }
        >            },
        >            "otherEffects": [],
        >            "randomNumber": 0,
        >            "targetRange": 0,
        >            "targetStatus": 0,
        >            "targetTeam": 2,
        >            "targetUser": 0
        >        },
        >        "userEffect": {
        >            "activate": {
        >                "animationId": "",
        >                "continuousNumber": 0,
        >                "correctionSpeed": 0,
        >                "getTp": 0,
        >                "hitType": 0,
        >                "successRate": 0
        >            },
        >            "damage": {
        >                "critical": 1,
        >                "damageType": 0,
        >                "distribute": 0,
        >                "distributeEnabled": 0,
        >                "elements": [],
        >                "max": 0,
        >                "maxEnabled": 0,
        >                "min": 0,
        >                "minEnabled": 0,
        >                "value": ""
        >            },
        >            "heal": {
        >                "hp": {
        >                    "calc": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 1,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": ""
        >                    },
        >                    "enabled": 0,
        >                    "fix": {
        >                        "enabled": 0,
        >                        "value": 0
        >                    },
        >                    "perMax": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": 0
        >                    }
        >                },
        >                "mp": {
        >                    "calc": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 1,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": ""
        >                    },
        >                    "enabled": 0,
        >                    "fix": {
        >                        "enabled": 0,
        >                        "value": 0
        >                    },
        >                    "perMax": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": 0
        >                    }
        >                },
        >                "tp": {
        >                    "calc": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 1,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": ""
        >                    },
        >                    "enabled": 0,
        >                    "fix": {
        >                        "enabled": 0,
        >                        "value": 0
        >                    },
        >                    "perMax": {
        >                        "distribute": 0,
        >                        "distributeEnabled": 0,
        >                        "enabled": 0,
        >                        "max": 0,
        >                        "maxEnabled": 0,
        >                        "value": 0
        >                    }
        >                }
        >            },
        >            "otherEffects": [],
        >            "randomNumber": 0,
        >            "targetRange": 0,
        >            "targetStatus": 0,
        >            "targetTeam": 0,
        >            "targetUser": 0
        >        }
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "basic": {
    >                "canSell": 0,
    >                "canUseTiming": 0,
    >                "consumable": 0,
    >                "description": "Recovers 300 HP.",
    >                "iconId": "IconSet_176",
    >                "id": "cd8fab08-5b93-4d99-afb2-1ce3c114b68e",
    >                "itemType": 1,
    >                "name": "Potion",
    >                "price": 30,
    >                "sell": 15,
    >                "switchItem": 0
    >            },
    >            "memo": "",
    >            "targetEffect": {
    >                "activate": {
    >                    "animationId": "b238e665-2a0a-4ac9-aad4-cb38e90f55b3",
    >                    "continuousNumber": 1,
    >                    "correctionSpeed": 0,
    >                    "getTp": 0,
    >                    "hitType": 0,
    >                    "successRate": 100
    >                },
    >                "damage": {
    >                    "critical": 1,
    >                    "damageType": 0,
    >                    "distribute": 0,
    >                    "distributeEnabled": 0,
    >                    "elements": [],
    >                    "max": 0,
    >                    "maxEnabled": 0,
    >                    "min": 0,
    >                    "minEnabled": 0,
    >                    "value": ""
    >                },
    >                "heal": {
    >                    "hp": {
    >                        "calc": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": "0"
    >                        },
    >                        "enabled": 1,
    >                        "fix": {
    >                            "enabled": 1,
    >                            "value": 300
    >                        },
    >                        "perMax": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": 0
    >                        }
    >                    },
    >                    "mp": {
    >                        "calc": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 1,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": "0"
    >                        },
    >                        "enabled": 0,
    >                        "fix": {
    >                            "enabled": 0,
    >                            "value": 0
    >                        },
    >                        "perMax": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": 0
    >                        }
    >                    },
    >                    "tp": {
    >                        "calc": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 1,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": "0"
    >                        },
    >                        "enabled": 0,
    >                        "fix": {
    >                            "enabled": 0,
    >                            "value": 0
    >                        },
    >                        "perMax": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": 0
    >                        }
    >                    }
    >                },
    >                "otherEffects": [],
    >                "randomNumber": 0,
    >                "targetRange": 0,
    >                "targetStatus": 0,
    >                "targetTeam": 2,
    >                "targetUser": 0
    >            },
    >            "userEffect": {
    >                "activate": {
    >                    "animationId": "",
    >                    "continuousNumber": 0,
    >                    "correctionSpeed": 0,
    >                    "getTp": 0,
    >                    "hitType": 0,
    >                    "successRate": 0
    >                },
    >                "damage": {
    >                    "critical": 1,
    >                    "damageType": 0,
    >                    "distribute": 0,
    >                    "distributeEnabled": 0,
    >                    "elements": [],
    >                    "max": 0,
    >                    "maxEnabled": 0,
    >                    "min": 0,
    >                    "minEnabled": 0,
    >                    "value": ""
    >                },
    >                "heal": {
    >                    "hp": {
    >                        "calc": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 1,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": ""
    >                        },
    >                        "enabled": 0,
    >                        "fix": {
    >                            "enabled": 0,
    >                            "value": 0
    >                        },
    >                        "perMax": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": 0
    >                        }
    >                    },
    >                    "mp": {
    >                        "calc": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 1,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": ""
    >                        },
    >                        "enabled": 0,
    >                        "fix": {
    >                            "enabled": 0,
    >                            "value": 0
    >                        },
    >                        "perMax": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": 0
    >                        }
    >                    },
    >                    "tp": {
    >                        "calc": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 1,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": ""
    >                        },
    >                        "enabled": 0,
    >                        "fix": {
    >                            "enabled": 0,
    >                            "value": 0
    >                        },
    >                        "perMax": {
    >                            "distribute": 0,
    >                            "distributeEnabled": 0,
    >                            "enabled": 0,
    >                            "max": 0,
    >                            "maxEnabled": 0,
    >                            "value": 0
    >                        }
    >                    }
    >                },
    >                "otherEffects": [],
    >                "randomNumber": 0,
    >                "targetRange": 0,
    >                "targetStatus": 0,
    >                "targetTeam": 0,
    >                "targetUser": 0
    >            }
    >        }
    >    ]
    >]
    >```
