# JSON schema: Assets RPGMaker Storage Initializations JSON skillCustom

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['basic', 'memo', 'targetEffect', 'userEffect']
    * 😁 `basic` property
        * required - ['assumptionLevel', 'canUseTiming', 'costMp', 'costTp', 'description', 'id', 'message', 'name', 'requiredWTypeId1', 'requiredWTypeId2', 'skillType', 'iconId']
        * 😁 `assumptionLevel` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `canUseTiming` property
            * examples:
                >```
                >[
                >    1,
                >    0
                >]
                >```
        * 😁 `costMp` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `costTp` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `description` property
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
                >    "1",
                >    "2",
                >    "3"
                >]
                >```
        * 😁 `message` property
            * examples:
                >```
                >[
                >    "%1 attacks!",
                >    "%1 guards.",
                >    ""
                >]
                >```
        * 😁 `name` property
            * examples:
                >```
                >[
                >    "Attack",
                >    "Guard",
                >    "-----Enemy"
                >]
                >```
        * 😁 `requiredWTypeId1` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `requiredWTypeId2` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `skillType` property
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `iconId` property
            * examples:
                >```
                >[
                >    "IconSet_076",
                >    "IconSet_081",
                >    ""
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "assumptionLevel": 0,
            >        "canUseTiming": 1,
            >        "costMp": 0,
            >        "costTp": 0,
            >        "description": "",
            >        "id": "1",
            >        "message": "%1 attacks!",
            >        "name": "Attack",
            >        "requiredWTypeId1": 0,
            >        "requiredWTypeId2": 0,
            >        "skillType": 0,
            >        "iconId": "IconSet_076"
            >    },
            >    {
            >        "assumptionLevel": 0,
            >        "canUseTiming": 0,
            >        "costMp": 0,
            >        "costTp": 0,
            >        "description": "",
            >        "id": "3",
            >        "message": "",
            >        "name": "-----Enemy",
            >        "requiredWTypeId1": 0,
            >        "requiredWTypeId2": 0,
            >        "skillType": 0,
            >        "iconId": ""
            >    }
            >]
            >```
    * 😁 `memo` property
        * examples:
            >```
            >[
            >    "Skill #1 corresponds to the Attack command.",
            >    "Skill #2 corresponds to the Guard command.",
            >    ""
            >]
            >```
    * 😁 `targetEffect` property
        * required - ['activate', 'damage', 'heal', 'otherEffects', 'randomNumber', 'targetRange', 'targetStatus', 'targetTeam', 'targetUser']
        * 😁 `activate` property
            * required - ['animationId', 'continuousNumber', 'correctionSpeed', 'hitType', 'successRate']
            * 😁 `animationId` property
                * examples:
                    >```
                    >[
                    >    "111419c2-2152-4b18-901d-4465c6771d4f",
                    >    ""
                    >]
                    >```
            * 😁 `continuousNumber` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `correctionSpeed` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    2000,
                    >    100
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
                    >    100
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "animationId": "111419c2-2152-4b18-901d-4465c6771d4f",
                >        "continuousNumber": 1,
                >        "correctionSpeed": 0,
                >        "hitType": 0,
                >        "successRate": 100
                >    },
                >    {
                >        "animationId": "",
                >        "continuousNumber": 1,
                >        "correctionSpeed": 2000,
                >        "hitType": 0,
                >        "successRate": 100
                >    },
                >    {
                >        "animationId": "",
                >        "continuousNumber": 0,
                >        "correctionSpeed": 100,
                >        "hitType": 0,
                >        "successRate": 100
                >    }
                >]
                >```
        * 😁 `damage` property
            * required - ['attackType', 'autoguide', 'autoguideEnabled', 'critical', 'damageType', 'distribute', 'distributeEnabled', 'elements', 'max', 'maxEnabled', 'min', 'minEnabled', 'value']
            * 😁 `attackType` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `autoguide` property
                * required - ['aMag', 'bMag', 'calc', 'critical', 'distribute', 'distributeEnabled', 'fix', 'level', 'max', 'min', 'mp', 'targetRange']
                * 😁 `aMag` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `bMag` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `calc` property
                    * examples:
                        >```
                        >[
                        >    ""
                        >]
                        >```
                * 😁 `critical` property
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
                * 😁 `fix` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `level` property
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
                        >    0.0
                        >]
                        >```
                * 😁 `min` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `mp` property
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
                * examples:
                    >```
                    >[
                    >    {
                    >        "aMag": 0.0,
                    >        "bMag": 0.0,
                    >        "calc": "",
                    >        "critical": 0,
                    >        "distribute": 0,
                    >        "distributeEnabled": 0,
                    >        "fix": 0.0,
                    >        "level": 1,
                    >        "max": 0.0,
                    >        "min": 0.0,
                    >        "mp": 0,
                    >        "targetRange": 0
                    >    },
                    >    {
                    >        "aMag": 0.0,
                    >        "bMag": 0.0,
                    >        "calc": "",
                    >        "critical": 0,
                    >        "distribute": 0,
                    >        "distributeEnabled": 0,
                    >        "fix": 0.0,
                    >        "level": 1,
                    >        "max": 0.0,
                    >        "min": 0.0,
                    >        "mp": 0,
                    >        "targetRange": 0
                    >    }
                    >]
                    >```
            * 😁 `autoguideEnabled` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `critical` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `damageType` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `distribute` property
                * examples:
                    >```
                    >[
                    >    20,
                    >    0
                    >]
                    >```
            * 😁 `distributeEnabled` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `elements` property
                * 😁 `elements` array - default: None
                    * default - ```None```
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
                    >    [
                    >        1
                    >    ],
                    >    [
                    >        0
                    >    ],
                    >    [
                    >        0
                    >    ]
                    >]
                    >```
            * 😁 `max` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    100
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
                    >    "a.atk * 2 - b.def * 2",
                    >    "0",
                    >    "100"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "attackType": 0,
                >        "autoguide": {
                >            "aMag": 0.0,
                >            "bMag": 0.0,
                >            "calc": "",
                >            "critical": 0,
                >            "distribute": 0,
                >            "distributeEnabled": 0,
                >            "fix": 0.0,
                >            "level": 1,
                >            "max": 0.0,
                >            "min": 0.0,
                >            "mp": 0,
                >            "targetRange": 0
                >        },
                >        "autoguideEnabled": 0,
                >        "critical": 1,
                >        "damageType": 1,
                >        "distribute": 20,
                >        "distributeEnabled": 1,
                >        "elements": [
                >            1
                >        ],
                >        "max": 0,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": "a.atk * 2 - b.def * 2"
                >    },
                >    {
                >        "attackType": 0,
                >        "autoguide": {
                >            "aMag": 0.0,
                >            "bMag": 0.0,
                >            "calc": "",
                >            "critical": 0,
                >            "distribute": 0,
                >            "distributeEnabled": 0,
                >            "fix": 0.0,
                >            "level": 1,
                >            "max": 0.0,
                >            "min": 0.0,
                >            "mp": 0,
                >            "targetRange": 0
                >        },
                >        "autoguideEnabled": 0,
                >        "critical": 0,
                >        "damageType": 0,
                >        "distribute": 0,
                >        "distributeEnabled": 0,
                >        "elements": [
                >            0
                >        ],
                >        "max": 0,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": "0"
                >    },
                >    {
                >        "attackType": 0,
                >        "autoguide": {
                >            "aMag": 0.0,
                >            "bMag": 0.0,
                >            "calc": "",
                >            "critical": 0,
                >            "distribute": 0,
                >            "distributeEnabled": 0,
                >            "fix": 0.0,
                >            "level": 1,
                >            "max": 0.0,
                >            "min": 0.0,
                >            "mp": 0,
                >            "targetRange": 0
                >        },
                >        "autoguideEnabled": 0,
                >        "critical": 1,
                >        "damageType": 0,
                >        "distribute": 20,
                >        "distributeEnabled": 0,
                >        "elements": [
                >            0
                >        ],
                >        "max": 100,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": "100"
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
                    >    },
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
                    >    },
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
                    >    },
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
                    >    },
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
                    >    },
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
                >    1,
                >    0
                >]
                >```
        * 😁 `targetUser` property
            * examples:
                >```
                >[
                >    0,
                >    1
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "activate": {
            >            "animationId": "111419c2-2152-4b18-901d-4465c6771d4f",
            >            "continuousNumber": 1,
            >            "correctionSpeed": 0,
            >            "hitType": 0,
            >            "successRate": 100
            >        },
            >        "damage": {
            >            "attackType": 0,
            >            "autoguide": {
            >                "aMag": 0.0,
            >                "bMag": 0.0,
            >                "calc": "",
            >                "critical": 0,
            >                "distribute": 0,
            >                "distributeEnabled": 0,
            >                "fix": 0.0,
            >                "level": 1,
            >                "max": 0.0,
            >                "min": 0.0,
            >                "mp": 0,
            >                "targetRange": 0
            >            },
            >            "autoguideEnabled": 0,
            >            "critical": 1,
            >            "damageType": 1,
            >            "distribute": 20,
            >            "distributeEnabled": 1,
            >            "elements": [
            >                1
            >            ],
            >            "max": 0,
            >            "maxEnabled": 0,
            >            "min": 0,
            >            "minEnabled": 0,
            >            "value": "a.atk * 2 - b.def * 2"
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
            >        "targetTeam": 1,
            >        "targetUser": 0
            >    }
            >]
            >```
    * 😁 `userEffect` property
        * required - ['activate', 'damage', 'getTp', 'heal', 'otherEffects', 'randomNumber', 'targetRange', 'targetStatus', 'targetTeam']
        * 😁 `activate` property
            * required - ['animationId', 'continuousNumber', 'correctionSpeed', 'hitType', 'successRate']
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
                    >    100,
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
                    >    100,
                    >    0
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "animationId": "",
                >        "continuousNumber": 0,
                >        "correctionSpeed": 100,
                >        "hitType": 0,
                >        "successRate": 100
                >    },
                >    {
                >        "animationId": "",
                >        "continuousNumber": 0,
                >        "correctionSpeed": 100,
                >        "hitType": 0,
                >        "successRate": 100
                >    }
                >]
                >```
        * 😁 `damage` property
            * required - ['attackType', 'autoguide', 'autoguideEnabled', 'critical', 'damageType', 'distribute', 'distributeEnabled', 'elements', 'max', 'maxEnabled', 'min', 'minEnabled', 'value']
            * 😁 `attackType` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `autoguide` property
                * required - ['aMag', 'bMag', 'calc', 'critical', 'distribute', 'distributeEnabled', 'fix', 'level', 'max', 'min', 'mp', 'targetRange']
                * 😁 `aMag` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `bMag` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `calc` property
                    * examples:
                        >```
                        >[
                        >    ""
                        >]
                        >```
                * 😁 `critical` property
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
                * 😁 `fix` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `level` property
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
                        >    0.0
                        >]
                        >```
                * 😁 `min` property
                    * examples:
                        >```
                        >[
                        >    0.0
                        >]
                        >```
                * 😁 `mp` property
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
                * examples:
                    >```
                    >[
                    >    {
                    >        "aMag": 0.0,
                    >        "bMag": 0.0,
                    >        "calc": "",
                    >        "critical": 0,
                    >        "distribute": 0,
                    >        "distributeEnabled": 0,
                    >        "fix": 0.0,
                    >        "level": 1,
                    >        "max": 0.0,
                    >        "min": 0.0,
                    >        "mp": 0,
                    >        "targetRange": 0
                    >    },
                    >    {
                    >        "aMag": 0.0,
                    >        "bMag": 0.0,
                    >        "calc": "",
                    >        "critical": 0,
                    >        "distribute": 0,
                    >        "distributeEnabled": 0,
                    >        "fix": 0.0,
                    >        "level": 1,
                    >        "max": 0.0,
                    >        "min": 0.0,
                    >        "mp": 0,
                    >        "targetRange": 0
                    >    }
                    >]
                    >```
            * 😁 `autoguideEnabled` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
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
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `distribute` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    20
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
                        >    1
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        1
                    >    ],
                    >    [
                    >        1
                    >    ],
                    >    [
                    >        1
                    >    ]
                    >]
                    >```
            * 😁 `max` property
                * examples:
                    >```
                    >[
                    >    100,
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
                    >    "0",
                    >    "100"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "attackType": 0,
                >        "autoguide": {
                >            "aMag": 0.0,
                >            "bMag": 0.0,
                >            "calc": "",
                >            "critical": 0,
                >            "distribute": 0,
                >            "distributeEnabled": 0,
                >            "fix": 0.0,
                >            "level": 1,
                >            "max": 0.0,
                >            "min": 0.0,
                >            "mp": 0,
                >            "targetRange": 0
                >        },
                >        "autoguideEnabled": 0,
                >        "critical": 0,
                >        "damageType": 1,
                >        "distribute": 0,
                >        "distributeEnabled": 0,
                >        "elements": [
                >            1
                >        ],
                >        "max": 100,
                >        "maxEnabled": 0,
                >        "min": 0,
                >        "minEnabled": 0,
                >        "value": "0"
                >    }
                >]
                >```
        * 😁 `getTp` property
            * examples:
                >```
                >[
                >    5,
                >    10,
                >    0
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
                ■key: default
                * required - ['categoryId', 'effectId', 'traitsId', 'value']
                * 😁 `categoryId` property
                    ■key: default
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `effectId` property
                    ■key: default
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `traitsId` property
                    ■key: default
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `value` property
                    ■key: default
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
                    >        "effectId": 1,
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
                >            "effectId": 1,
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
            >            "correctionSpeed": 100,
            >            "hitType": 0,
            >            "successRate": 100
            >        },
            >        "damage": {
            >            "attackType": 0,
            >            "autoguide": {
            >                "aMag": 0.0,
            >                "bMag": 0.0,
            >                "calc": "",
            >                "critical": 0,
            >                "distribute": 0,
            >                "distributeEnabled": 0,
            >                "fix": 0.0,
            >                "level": 1,
            >                "max": 0.0,
            >                "min": 0.0,
            >                "mp": 0,
            >                "targetRange": 0
            >            },
            >            "autoguideEnabled": 0,
            >            "critical": 0,
            >            "damageType": 1,
            >            "distribute": 0,
            >            "distributeEnabled": 0,
            >            "elements": [
            >                1
            >            ],
            >            "max": 100,
            >            "maxEnabled": 0,
            >            "min": 0,
            >            "minEnabled": 0,
            >            "value": "0"
            >        },
            >        "getTp": 5,
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
            >        "targetTeam": 0
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "basic": {
        >            "assumptionLevel": 0,
        >            "canUseTiming": 1,
        >            "costMp": 0,
        >            "costTp": 0,
        >            "description": "",
        >            "id": "2",
        >            "message": "%1 guards.",
        >            "name": "Guard",
        >            "requiredWTypeId1": 0,
        >            "requiredWTypeId2": 0,
        >            "skillType": 0,
        >            "iconId": "IconSet_081"
        >        },
        >        "memo": "Skill #2 corresponds to the Guard command.",
        >        "targetEffect": {
        >            "activate": {
        >                "animationId": "",
        >                "continuousNumber": 1,
        >                "correctionSpeed": 2000,
        >                "hitType": 0,
        >                "successRate": 100
        >            },
        >            "damage": {
        >                "attackType": 0,
        >                "autoguide": {
        >                    "aMag": 0.0,
        >                    "bMag": 0.0,
        >                    "calc": "",
        >                    "critical": 0,
        >                    "distribute": 0,
        >                    "distributeEnabled": 0,
        >                    "fix": 0.0,
        >                    "level": 1,
        >                    "max": 0.0,
        >                    "min": 0.0,
        >                    "mp": 0,
        >                    "targetRange": 0
        >                },
        >                "autoguideEnabled": 0,
        >                "critical": 0,
        >                "damageType": 0,
        >                "distribute": 0,
        >                "distributeEnabled": 0,
        >                "elements": [
        >                    0
        >                ],
        >                "max": 0,
        >                "maxEnabled": 0,
        >                "min": 0,
        >                "minEnabled": 0,
        >                "value": "0"
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
        >            "targetUser": 1
        >        },
        >        "userEffect": {
        >            "activate": {
        >                "animationId": "",
        >                "continuousNumber": 0,
        >                "correctionSpeed": 0,
        >                "hitType": 0,
        >                "successRate": 0
        >            },
        >            "damage": {
        >                "attackType": 0,
        >                "autoguide": {
        >                    "aMag": 0.0,
        >                    "bMag": 0.0,
        >                    "calc": "",
        >                    "critical": 0,
        >                    "distribute": 0,
        >                    "distributeEnabled": 0,
        >                    "fix": 0.0,
        >                    "level": 1,
        >                    "max": 0.0,
        >                    "min": 0.0,
        >                    "mp": 0,
        >                    "targetRange": 0
        >                },
        >                "autoguideEnabled": 0,
        >                "critical": 0,
        >                "damageType": 0,
        >                "distribute": 0,
        >                "distributeEnabled": 0,
        >                "elements": [
        >                    1
        >                ],
        >                "max": 0,
        >                "maxEnabled": 0,
        >                "min": 0,
        >                "minEnabled": 0,
        >                "value": "0"
        >            },
        >            "getTp": 10,
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
        >            "otherEffects": [
        >                {
        >                    "categoryId": 1,
        >                    "effectId": 1,
        >                    "traitsId": 1,
        >                    "value": 100
        >                }
        >            ],
        >            "randomNumber": 0,
        >            "targetRange": 0,
        >            "targetStatus": 0,
        >            "targetTeam": 0
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
    >                "assumptionLevel": 0,
    >                "canUseTiming": 1,
    >                "costMp": 0,
    >                "costTp": 0,
    >                "description": "",
    >                "id": "2",
    >                "message": "%1 guards.",
    >                "name": "Guard",
    >                "requiredWTypeId1": 0,
    >                "requiredWTypeId2": 0,
    >                "skillType": 0,
    >                "iconId": "IconSet_081"
    >            },
    >            "memo": "Skill #2 corresponds to the Guard command.",
    >            "targetEffect": {
    >                "activate": {
    >                    "animationId": "",
    >                    "continuousNumber": 1,
    >                    "correctionSpeed": 2000,
    >                    "hitType": 0,
    >                    "successRate": 100
    >                },
    >                "damage": {
    >                    "attackType": 0,
    >                    "autoguide": {
    >                        "aMag": 0.0,
    >                        "bMag": 0.0,
    >                        "calc": "",
    >                        "critical": 0,
    >                        "distribute": 0,
    >                        "distributeEnabled": 0,
    >                        "fix": 0.0,
    >                        "level": 1,
    >                        "max": 0.0,
    >                        "min": 0.0,
    >                        "mp": 0,
    >                        "targetRange": 0
    >                    },
    >                    "autoguideEnabled": 0,
    >                    "critical": 0,
    >                    "damageType": 0,
    >                    "distribute": 0,
    >                    "distributeEnabled": 0,
    >                    "elements": [
    >                        0
    >                    ],
    >                    "max": 0,
    >                    "maxEnabled": 0,
    >                    "min": 0,
    >                    "minEnabled": 0,
    >                    "value": "0"
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
    >                "targetUser": 1
    >            },
    >            "userEffect": {
    >                "activate": {
    >                    "animationId": "",
    >                    "continuousNumber": 0,
    >                    "correctionSpeed": 0,
    >                    "hitType": 0,
    >                    "successRate": 0
    >                },
    >                "damage": {
    >                    "attackType": 0,
    >                    "autoguide": {
    >                        "aMag": 0.0,
    >                        "bMag": 0.0,
    >                        "calc": "",
    >                        "critical": 0,
    >                        "distribute": 0,
    >                        "distributeEnabled": 0,
    >                        "fix": 0.0,
    >                        "level": 1,
    >                        "max": 0.0,
    >                        "min": 0.0,
    >                        "mp": 0,
    >                        "targetRange": 0
    >                    },
    >                    "autoguideEnabled": 0,
    >                    "critical": 0,
    >                    "damageType": 0,
    >                    "distribute": 0,
    >                    "distributeEnabled": 0,
    >                    "elements": [
    >                        1
    >                    ],
    >                    "max": 0,
    >                    "maxEnabled": 0,
    >                    "min": 0,
    >                    "minEnabled": 0,
    >                    "value": "0"
    >                },
    >                "getTp": 10,
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
    >                "otherEffects": [
    >                    {
    >                        "categoryId": 1,
    >                        "effectId": 1,
    >                        "traitsId": 1,
    >                        "value": 100
    >                    }
    >                ],
    >                "randomNumber": 0,
    >                "targetRange": 0,
    >                "targetStatus": 0,
    >                "targetTeam": 0
    >            }
    >        }
    >    ]
    >]
    >```
