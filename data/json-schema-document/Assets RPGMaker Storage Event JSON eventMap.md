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
