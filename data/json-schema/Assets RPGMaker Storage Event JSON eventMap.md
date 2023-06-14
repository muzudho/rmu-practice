# JSON schema: Assets RPGMaker Storage Event JSON eventMap

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['eventId', 'mapId', 'name', 'note', 'pages', 'temporaryErase', 'x', 'y']
    * 😁 `eventId` property
        * examples:
            >```
            >[
            >    "5dc8a1ed-165e-4bb3-9bb2-9395d3a4b1f1",
            >    "86a24972-475a-46b0-94d3-3a9bd7ecc6ab",
            >    "9dae72c9-71b3-4222-bd4a-a93f56cefb78",
            >    "7c5396ea-5c71-4cf2-b155-1c7d0cfdbaa0",
            >    "b19192db-573b-436b-a546-97ec78347a5d",
            >    "73f59c16-1bac-4fc0-bfc7-732b737a14b7",
            >    "fd5678c0-f06b-4718-9d49-833693a256d8",
            >    "e30ce17c-27b5-4ee4-8939-d74aa00fd9bc",
            >    "3174e810-5938-4dbd-951e-166368945b1b",
            >    "30a7987e-35c5-4b73-a269-117380b26c1f",
            >    "8085c485-ed38-4ca2-aec0-80901122ee73",
            >    "eeaefa90-eb45-4119-be54-a65d43f5e8bc",
            >    "81c9591c-b538-441e-8336-be0935374973",
            >    "d8e6552b-e526-4db5-b6cf-7ea8321e6d2c"
            >]
            >```
    * 😁 `mapId` property
        * examples:
            >```
            >[
            >    "00146731-7002-48e1-8f11-4fd0e75ebd5c",
            >    "00b34276-2c8a-4599-b325-4bc607ba5f5e",
            >    "00cdb601-1a28-40e8-a15c-b28a5792c88c"
            >]
            >```
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "Hero's Bed",
            >    "Home 2 \u2192 Frontier Town",
            >    "Barrel",
            >    "Jar",
            >    "Opening",
            >    "Jar w/ Item",
            >    "Father",
            >    "Shelf w/ Item",
            >    "Home 3 \u2192 Port City",
            >    "Barrel w/ Item",
            >    "Town Resident"
            >]
            >```
    * 😁 `note` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `pages` property
        * 😁 `pages` array - default: None
            * default - ```None```
            * required - ['chapterId', 'condition', 'eventTrigger', 'image', 'move', 'page', 'priority', 'sectionId', 'walk']
            * 😁 `chapterId` property
                * examples:
                    >```
                    >[
                    >    ""
                    >]
                    >```
            * 😁 `condition` property
                * required - ['actor', 'image', 'item', 'selfSwitch', 'switchItem', 'switchOne', 'switchTwo', 'variables']
                * 😁 `actor` property
                    * required - ['actorId', 'enabled']
                    * 😁 `actorId` property
                        * examples:
                            >```
                            >[
                            >    ""
                            >]
                            >```
                    * 😁 `enabled` property
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
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    },
                        >    {
                        >        "actorId": "",
                        >        "enabled": 0
                        >    }
                        >]
                        >```
                * 😁 `image` property
                    * required - ['enabled', 'imageName']
                    * 😁 `enabled` property
                        * examples:
                            >```
                            >[
                            >    1
                            >]
                            >```
                    * 😁 `imageName` property
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
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "imageName": ""
                        >    }
                        >]
                        >```
                * 😁 `item` property
                    * required - ['enabled', 'itemId']
                    * 😁 `enabled` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `itemId` property
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
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "itemId": ""
                        >    }
                        >]
                        >```
                * 😁 `selfSwitch` property
                    * required - ['enabled', 'selfSwitch']
                    * 😁 `enabled` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `selfSwitch` property
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
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "selfSwitch": ""
                        >    }
                        >]
                        >```
                * 😁 `switchItem` property
                    * required - ['enabled', 'switchItemId']
                    * 😁 `enabled` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `switchItemId` property
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
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchItemId": ""
                        >    }
                        >]
                        >```
                * 😁 `switchOne` property
                    * required - ['enabled', 'switchId']
                    * 😁 `enabled` property
                        * examples:
                            >```
                            >[
                            >    0,
                            >    1
                            >]
                            >```
                    * 😁 `switchId` property
                        * examples:
                            >```
                            >[
                            >    "",
                            >    "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
                            >]
                            >```
                    * examples:
                        >```
                        >[
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 1,
                        >        "switchId": "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    }
                        >]
                        >```
                * 😁 `switchTwo` property
                    * required - ['enabled', 'switchId']
                    * 😁 `enabled` property
                        * examples:
                            >```
                            >[
                            >    0
                            >]
                            >```
                    * 😁 `switchId` property
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
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "switchId": ""
                        >    }
                        >]
                        >```
                * 😁 `variables` property
                    * required - ['enabled', 'value', 'variableId']
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
                    * 😁 `variableId` property
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
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    },
                        >    {
                        >        "enabled": 0,
                        >        "value": 0,
                        >        "variableId": ""
                        >    }
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 1,
                    >            "switchId": "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    },
                    >    {
                    >        "actor": {
                    >            "actorId": "",
                    >            "enabled": 0
                    >        },
                    >        "image": {
                    >            "enabled": 1,
                    >            "imageName": ""
                    >        },
                    >        "item": {
                    >            "enabled": 0,
                    >            "itemId": ""
                    >        },
                    >        "selfSwitch": {
                    >            "enabled": 0,
                    >            "selfSwitch": ""
                    >        },
                    >        "switchItem": {
                    >            "enabled": 0,
                    >            "switchItemId": ""
                    >        },
                    >        "switchOne": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "switchTwo": {
                    >            "enabled": 0,
                    >            "switchId": ""
                    >        },
                    >        "variables": {
                    >            "enabled": 0,
                    >            "value": 0,
                    >            "variableId": ""
                    >        }
                    >    }
                    >]
                    >```
            * 😁 `eventTrigger` property
                * examples:
                    >```
                    >[
                    >    0,
                    >    1,
                    >    3
                    >]
                    >```
            * 😁 `image` property
                * required - ['direction', 'faceName', 'name', 'pictureName', 'sdName']
                * 😁 `direction` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `faceName` property
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
                        >    ""
                        >]
                        >```
                * 😁 `pictureName` property
                    * examples:
                        >```
                        >[
                        >    ""
                        >]
                        >```
                * 😁 `sdName` property
                    * examples:
                        >```
                        >[
                        >    "",
                        >    "3fe077e3-8857-4da4-8feb-31e2640ea8f1",
                        >    "a97eaf15-1e27-45c9-b9f5-6ecccdb4b5f3"
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": "3fe077e3-8857-4da4-8feb-31e2640ea8f1"
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": "a97eaf15-1e27-45c9-b9f5-6ecccdb4b5f3"
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "faceName": "",
                    >        "name": "",
                    >        "pictureName": "",
                    >        "sdName": ""
                    >    }
                    >]
                    >```
            * 😁 `move` property
                * required - ['frequency', 'moveType', 'repeat', 'route', 'skip', 'speed']
                * 😁 `frequency` property
                    * examples:
                        >```
                        >[
                        >    2
                        >]
                        >```
                * 😁 `moveType` property
                    * examples:
                        >```
                        >[
                        >    0,
                        >    1
                        >]
                        >```
                * 😁 `repeat` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `route` property
                    * 😁 `route` array - default: None
                        * default - ```None```
                    * examples:
                        >```
                        >[
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    [],
                        >    []
                        >]
                        >```
                * 😁 `skip` property
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * 😁 `speed` property
                    * examples:
                        >```
                        >[
                        >    3
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 1,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    },
                    >    {
                    >        "frequency": 2,
                    >        "moveType": 0,
                    >        "repeat": 0,
                    >        "route": [],
                    >        "skip": 0,
                    >        "speed": 3
                    >    }
                    >]
                    >```
            * 😁 `page` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `priority` property
                * examples:
                    >```
                    >[
                    >    1,
                    >    0
                    >]
                    >```
            * 😁 `sectionId` property
                * examples:
                    >```
                    >[
                    >    ""
                    >]
                    >```
            * 😁 `walk` property
                * required - ['direction', 'directionFix', 'stepping', 'through', 'walking']
                * 😁 `direction` property
                    * examples:
                        >```
                        >[
                        >    4,
                        >    0
                        >]
                        >```
                * 😁 `directionFix` property
                    * examples:
                        >```
                        >[
                        >    1,
                        >    4,
                        >    0
                        >]
                        >```
                * 😁 `stepping` property
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `through` property
                    * examples:
                        >```
                        >[
                        >    1
                        >]
                        >```
                * 😁 `walking` property
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
                    >        "direction": 4,
                    >        "directionFix": 1,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 4,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 4,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 4,
                    >        "directionFix": 1,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 4,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 4,
                    >        "directionFix": 0,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 0
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 4,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 4,
                    >        "directionFix": 0,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 4,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 4,
                    >        "directionFix": 1,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 4,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 0
                    >    },
                    >    {
                    >        "direction": 4,
                    >        "directionFix": 1,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    },
                    >    {
                    >        "direction": 0,
                    >        "directionFix": 0,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 0
                    >    },
                    >    {
                    >        "direction": 4,
                    >        "directionFix": 1,
                    >        "stepping": 1,
                    >        "through": 1,
                    >        "walking": 1
                    >    }
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 1,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 1,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 0,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 4,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 4,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 1,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 4,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 1,
                >                "switchId": "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 3,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 0,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 0,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 0
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 4,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": "3fe077e3-8857-4da4-8feb-31e2640ea8f1"
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 0,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 4,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 1,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 1,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 0,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 4,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 0
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 1,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": "a97eaf15-1e27-45c9-b9f5-6ecccdb4b5f3"
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 1,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 0,
                >            "directionFix": 0,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 0
                >        }
                >    },
                >    {
                >        "chapterId": "",
                >        "condition": {
                >            "actor": {
                >                "actorId": "",
                >                "enabled": 0
                >            },
                >            "image": {
                >                "enabled": 1,
                >                "imageName": ""
                >            },
                >            "item": {
                >                "enabled": 0,
                >                "itemId": ""
                >            },
                >            "selfSwitch": {
                >                "enabled": 0,
                >                "selfSwitch": ""
                >            },
                >            "switchItem": {
                >                "enabled": 0,
                >                "switchItemId": ""
                >            },
                >            "switchOne": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "switchTwo": {
                >                "enabled": 0,
                >                "switchId": ""
                >            },
                >            "variables": {
                >                "enabled": 0,
                >                "value": 0,
                >                "variableId": ""
                >            }
                >        },
                >        "eventTrigger": 0,
                >        "image": {
                >            "direction": 0,
                >            "faceName": "",
                >            "name": "",
                >            "pictureName": "",
                >            "sdName": ""
                >        },
                >        "move": {
                >            "frequency": 2,
                >            "moveType": 0,
                >            "repeat": 0,
                >            "route": [],
                >            "skip": 0,
                >            "speed": 3
                >        },
                >        "page": 0,
                >        "priority": 1,
                >        "sectionId": "",
                >        "walk": {
                >            "direction": 4,
                >            "directionFix": 1,
                >            "stepping": 1,
                >            "through": 1,
                >            "walking": 1
                >        }
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 1,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 1,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 0,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 4,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 4,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 1,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 4,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 1,
            >                    "switchId": "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 3,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 0,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 0,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 0
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 4,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": "3fe077e3-8857-4da4-8feb-31e2640ea8f1"
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 0,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 4,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 1,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 1,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 0,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 4,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 0
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 1,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": "a97eaf15-1e27-45c9-b9f5-6ecccdb4b5f3"
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 1,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 0,
            >                "directionFix": 0,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 0
            >            }
            >        }
            >    ],
            >    [
            >        {
            >            "chapterId": "",
            >            "condition": {
            >                "actor": {
            >                    "actorId": "",
            >                    "enabled": 0
            >                },
            >                "image": {
            >                    "enabled": 1,
            >                    "imageName": ""
            >                },
            >                "item": {
            >                    "enabled": 0,
            >                    "itemId": ""
            >                },
            >                "selfSwitch": {
            >                    "enabled": 0,
            >                    "selfSwitch": ""
            >                },
            >                "switchItem": {
            >                    "enabled": 0,
            >                    "switchItemId": ""
            >                },
            >                "switchOne": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "switchTwo": {
            >                    "enabled": 0,
            >                    "switchId": ""
            >                },
            >                "variables": {
            >                    "enabled": 0,
            >                    "value": 0,
            >                    "variableId": ""
            >                }
            >            },
            >            "eventTrigger": 0,
            >            "image": {
            >                "direction": 0,
            >                "faceName": "",
            >                "name": "",
            >                "pictureName": "",
            >                "sdName": ""
            >            },
            >            "move": {
            >                "frequency": 2,
            >                "moveType": 0,
            >                "repeat": 0,
            >                "route": [],
            >                "skip": 0,
            >                "speed": 3
            >            },
            >            "page": 0,
            >            "priority": 1,
            >            "sectionId": "",
            >            "walk": {
            >                "direction": 4,
            >                "directionFix": 1,
            >                "stepping": 1,
            >                "through": 1,
            >                "walking": 1
            >            }
            >        }
            >    ]
            >]
            >```
    * 😁 `temporaryErase` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `x` property
        * examples:
            >```
            >[
            >    12,
            >    6,
            >    9,
            >    14,
            >    13,
            >    17,
            >    11,
            >    10,
            >    5
            >]
            >```
    * 😁 `y` property
        * examples:
            >```
            >[
            >    5,
            >    11,
            >    4,
            >    10,
            >    6,
            >    14,
            >    8
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "eventId": "5dc8a1ed-165e-4bb3-9bb2-9395d3a4b1f1",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Hero's Bed",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 1,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 12,
        >        "y": 5
        >    },
        >    {
        >        "eventId": "86a24972-475a-46b0-94d3-3a9bd7ecc6ab",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Home 2 \u2192 Frontier Town",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 1,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 0,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 4,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 6,
        >        "y": 11
        >    },
        >    {
        >        "eventId": "9dae72c9-71b3-4222-bd4a-a93f56cefb78",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Barrel",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 4,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 9,
        >        "y": 4
        >    },
        >    {
        >        "eventId": "7c5396ea-5c71-4cf2-b155-1c7d0cfdbaa0",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Hero's Bed",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 1,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 14,
        >        "y": 5
        >    },
        >    {
        >        "eventId": "b19192db-573b-436b-a546-97ec78347a5d",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Jar",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 4,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 13,
        >        "y": 10
        >    },
        >    {
        >        "eventId": "73f59c16-1bac-4fc0-bfc7-732b737a14b7",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Opening",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 1,
        >                        "switchId": "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 3,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 0,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 0,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 0
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 17,
        >        "y": 4
        >    },
        >    {
        >        "eventId": "fd5678c0-f06b-4718-9d49-833693a256d8",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Jar w/ Item",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 4,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 13,
        >        "y": 11
        >    },
        >    {
        >        "eventId": "e30ce17c-27b5-4ee4-8939-d74aa00fd9bc",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Father",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": "3fe077e3-8857-4da4-8feb-31e2640ea8f1"
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 0,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 6,
        >        "y": 6
        >    },
        >    {
        >        "eventId": "3174e810-5938-4dbd-951e-166368945b1b",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Jar",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 4,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 14,
        >        "y": 11
        >    },
        >    {
        >        "eventId": "30a7987e-35c5-4b73-a269-117380b26c1f",
        >        "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
        >        "name": "Shelf w/ Item",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 1,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 11,
        >        "y": 10
        >    },
        >    {
        >        "eventId": "8085c485-ed38-4ca2-aec0-80901122ee73",
        >        "mapId": "00b34276-2c8a-4599-b325-4bc607ba5f5e",
        >        "name": "Home 3 \u2192 Port City",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 1,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 0,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 4,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 0
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 10,
        >        "y": 14
        >    },
        >    {
        >        "eventId": "eeaefa90-eb45-4119-be54-a65d43f5e8bc",
        >        "mapId": "00b34276-2c8a-4599-b325-4bc607ba5f5e",
        >        "name": "Barrel w/ Item",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 1,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 13,
        >        "y": 5
        >    },
        >    {
        >        "eventId": "81c9591c-b538-441e-8336-be0935374973",
        >        "mapId": "00b34276-2c8a-4599-b325-4bc607ba5f5e",
        >        "name": "Town Resident",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": "a97eaf15-1e27-45c9-b9f5-6ecccdb4b5f3"
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 1,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 0,
        >                    "directionFix": 0,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 0
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 5,
        >        "y": 8
        >    },
        >    {
        >        "eventId": "d8e6552b-e526-4db5-b6cf-7ea8321e6d2c",
        >        "mapId": "00cdb601-1a28-40e8-a15c-b28a5792c88c",
        >        "name": "Shelf w/ Item",
        >        "note": "",
        >        "pages": [
        >            {
        >                "chapterId": "",
        >                "condition": {
        >                    "actor": {
        >                        "actorId": "",
        >                        "enabled": 0
        >                    },
        >                    "image": {
        >                        "enabled": 1,
        >                        "imageName": ""
        >                    },
        >                    "item": {
        >                        "enabled": 0,
        >                        "itemId": ""
        >                    },
        >                    "selfSwitch": {
        >                        "enabled": 0,
        >                        "selfSwitch": ""
        >                    },
        >                    "switchItem": {
        >                        "enabled": 0,
        >                        "switchItemId": ""
        >                    },
        >                    "switchOne": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "switchTwo": {
        >                        "enabled": 0,
        >                        "switchId": ""
        >                    },
        >                    "variables": {
        >                        "enabled": 0,
        >                        "value": 0,
        >                        "variableId": ""
        >                    }
        >                },
        >                "eventTrigger": 0,
        >                "image": {
        >                    "direction": 0,
        >                    "faceName": "",
        >                    "name": "",
        >                    "pictureName": "",
        >                    "sdName": ""
        >                },
        >                "move": {
        >                    "frequency": 2,
        >                    "moveType": 0,
        >                    "repeat": 0,
        >                    "route": [],
        >                    "skip": 0,
        >                    "speed": 3
        >                },
        >                "page": 0,
        >                "priority": 1,
        >                "sectionId": "",
        >                "walk": {
        >                    "direction": 4,
        >                    "directionFix": 1,
        >                    "stepping": 1,
        >                    "through": 1,
        >                    "walking": 1
        >                }
        >            }
        >        ],
        >        "temporaryErase": 0,
        >        "x": 10,
        >        "y": 5
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "eventId": "5dc8a1ed-165e-4bb3-9bb2-9395d3a4b1f1",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Hero's Bed",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 1,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 12,
    >            "y": 5
    >        },
    >        {
    >            "eventId": "86a24972-475a-46b0-94d3-3a9bd7ecc6ab",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Home 2 \u2192 Frontier Town",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 1,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 0,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 4,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 6,
    >            "y": 11
    >        },
    >        {
    >            "eventId": "9dae72c9-71b3-4222-bd4a-a93f56cefb78",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Barrel",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 4,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 9,
    >            "y": 4
    >        },
    >        {
    >            "eventId": "7c5396ea-5c71-4cf2-b155-1c7d0cfdbaa0",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Hero's Bed",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 1,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 14,
    >            "y": 5
    >        },
    >        {
    >            "eventId": "b19192db-573b-436b-a546-97ec78347a5d",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Jar",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 4,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 13,
    >            "y": 10
    >        },
    >        {
    >            "eventId": "73f59c16-1bac-4fc0-bfc7-732b737a14b7",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Opening",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 1,
    >                            "switchId": "0ca79ab1-c22a-4749-ab9e-6f6004387c1b"
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 3,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 0,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 0,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 0
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 17,
    >            "y": 4
    >        },
    >        {
    >            "eventId": "fd5678c0-f06b-4718-9d49-833693a256d8",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Jar w/ Item",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 4,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 13,
    >            "y": 11
    >        },
    >        {
    >            "eventId": "e30ce17c-27b5-4ee4-8939-d74aa00fd9bc",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Father",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": "3fe077e3-8857-4da4-8feb-31e2640ea8f1"
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 0,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 6,
    >            "y": 6
    >        },
    >        {
    >            "eventId": "3174e810-5938-4dbd-951e-166368945b1b",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Jar",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 4,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 14,
    >            "y": 11
    >        },
    >        {
    >            "eventId": "30a7987e-35c5-4b73-a269-117380b26c1f",
    >            "mapId": "00146731-7002-48e1-8f11-4fd0e75ebd5c",
    >            "name": "Shelf w/ Item",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 1,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 11,
    >            "y": 10
    >        },
    >        {
    >            "eventId": "8085c485-ed38-4ca2-aec0-80901122ee73",
    >            "mapId": "00b34276-2c8a-4599-b325-4bc607ba5f5e",
    >            "name": "Home 3 \u2192 Port City",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 1,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 0,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 4,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 0
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 10,
    >            "y": 14
    >        },
    >        {
    >            "eventId": "eeaefa90-eb45-4119-be54-a65d43f5e8bc",
    >            "mapId": "00b34276-2c8a-4599-b325-4bc607ba5f5e",
    >            "name": "Barrel w/ Item",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 1,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 13,
    >            "y": 5
    >        },
    >        {
    >            "eventId": "81c9591c-b538-441e-8336-be0935374973",
    >            "mapId": "00b34276-2c8a-4599-b325-4bc607ba5f5e",
    >            "name": "Town Resident",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": "a97eaf15-1e27-45c9-b9f5-6ecccdb4b5f3"
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 1,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 0,
    >                        "directionFix": 0,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 0
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 5,
    >            "y": 8
    >        },
    >        {
    >            "eventId": "d8e6552b-e526-4db5-b6cf-7ea8321e6d2c",
    >            "mapId": "00cdb601-1a28-40e8-a15c-b28a5792c88c",
    >            "name": "Shelf w/ Item",
    >            "note": "",
    >            "pages": [
    >                {
    >                    "chapterId": "",
    >                    "condition": {
    >                        "actor": {
    >                            "actorId": "",
    >                            "enabled": 0
    >                        },
    >                        "image": {
    >                            "enabled": 1,
    >                            "imageName": ""
    >                        },
    >                        "item": {
    >                            "enabled": 0,
    >                            "itemId": ""
    >                        },
    >                        "selfSwitch": {
    >                            "enabled": 0,
    >                            "selfSwitch": ""
    >                        },
    >                        "switchItem": {
    >                            "enabled": 0,
    >                            "switchItemId": ""
    >                        },
    >                        "switchOne": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "switchTwo": {
    >                            "enabled": 0,
    >                            "switchId": ""
    >                        },
    >                        "variables": {
    >                            "enabled": 0,
    >                            "value": 0,
    >                            "variableId": ""
    >                        }
    >                    },
    >                    "eventTrigger": 0,
    >                    "image": {
    >                        "direction": 0,
    >                        "faceName": "",
    >                        "name": "",
    >                        "pictureName": "",
    >                        "sdName": ""
    >                    },
    >                    "move": {
    >                        "frequency": 2,
    >                        "moveType": 0,
    >                        "repeat": 0,
    >                        "route": [],
    >                        "skip": 0,
    >                        "speed": 3
    >                    },
    >                    "page": 0,
    >                    "priority": 1,
    >                    "sectionId": "",
    >                    "walk": {
    >                        "direction": 4,
    >                        "directionFix": 1,
    >                        "stepping": 1,
    >                        "through": 1,
    >                        "walking": 1
    >                    }
    >                }
    >            ],
    >            "temporaryErase": 0,
    >            "x": 10,
    >            "y": 5
    >        }
    >    ]
    >]
    >```
