# JSON schema: Assets RPGMaker Storage UI JSON ui

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['battleMenu', 'commonMenus', 'gameMenu', 'talkMenu']
* 😁 `battleMenu` property
    ■key: default
    * required - ['menuHp', 'menuMp', 'menuTp']
    * 😁 `menuHp` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
            ■key: default
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
            >        "enabled": 0
            >    }
            >]
            >```
    * 😁 `menuMp` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
            ■key: default
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
            >        "enabled": 0
            >    }
            >]
            >```
    * 😁 `menuTp` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
            ■key: default
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
            >        "enabled": 0
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "menuHp": {
        >            "enabled": 0
        >        },
        >        "menuTp": {
        >            "enabled": 0
        >        }
        >    }
        >]
        >```
* 😁 `commonMenus` property
    ■key: default
    * 😁 `commonMenus` array - default: None
        * default - ```None```
        ■key: default
        * required - ['backgroundImage', 'buttonFrameImage', 'buttonImage', 'buttonImageHighlight', 'characterType', 'id', 'menuFontSetting', 'windowBackgroundImage', 'windowFrameImage', 'windowFrameImageHighlight']
        * 😁 `backgroundImage` property
            ■key: default
            * required - ['color', 'image', 'type']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    254,
                        >    0
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        254,
                    >        254,
                    >        254,
                    >        0
                    >    ]
                    >]
                    >```
            * 😁 `image` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "UI_bg_01"
                    >]
                    >```
            * 😁 `type` property
                ■key: default
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
                >        "color": [
                >            254,
                >            254,
                >            254,
                >            0
                >        ],
                >        "image": "UI_bg_01",
                >        "type": 0
                >    }
                >]
                >```
        * 😁 `buttonFrameImage` property
            ■key: default
            * required - ['color', 'image', 'type']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        0,
                    >        0,
                    >        0,
                    >        0
                    >    ]
                    >]
                    >```
            * 😁 `image` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "UI_window_frame_01"
                    >]
                    >```
            * 😁 `type` property
                ■key: default
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
                >        "color": [
                >            0,
                >            0,
                >            0,
                >            0
                >        ],
                >        "image": "UI_window_frame_01",
                >        "type": 0
                >    }
                >]
                >```
        * 😁 `buttonImage` property
            ■key: default
            * required - ['color', 'image', 'type']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    0,
                        >    80
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        0,
                    >        0,
                    >        0,
                    >        80
                    >    ]
                    >]
                    >```
            * 😁 `image` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "UI_button_bg_01"
                    >]
                    >```
            * 😁 `type` property
                ■key: default
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
                >        "color": [
                >            0,
                >            0,
                >            0,
                >            80
                >        ],
                >        "image": "UI_button_bg_01",
                >        "type": 0
                >    }
                >]
                >```
        * 😁 `buttonImageHighlight` property
            ■key: default
            * 😁 `buttonImageHighlight` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    38,
                    >    175,
                    >    255,
                    >    83
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        38,
                >        175,
                >        255,
                >        83
                >    ]
                >]
                >```
        * 😁 `characterType` property
            ■key: default
            * examples:
                >```
                >[
                >    2
                >]
                >```
        * 😁 `id` property
            ■key: default
            * examples:
                >```
                >[
                >    "1"
                >]
                >```
        * 😁 `menuFontSetting` property
            ■key: default
            * required - ['color', 'font', 'size']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    255
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        255,
                    >        255,
                    >        255,
                    >        255
                    >    ]
                    >]
                    >```
            * 😁 `font` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "mplus-1m-regular"
                    >]
                    >```
            * 😁 `size` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    40
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "color": [
                >            255,
                >            255,
                >            255,
                >            255
                >        ],
                >        "font": "mplus-1m-regular",
                >        "size": 40
                >    }
                >]
                >```
        * 😁 `windowBackgroundImage` property
            ■key: default
            * required - ['color', 'image', 'type']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    0,
                        >    128
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        0,
                    >        0,
                    >        0,
                    >        128
                    >    ]
                    >]
                    >```
            * 😁 `image` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "UI_window_bg_01"
                    >]
                    >```
            * 😁 `type` property
                ■key: default
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
                >        "color": [
                >            0,
                >            0,
                >            0,
                >            128
                >        ],
                >        "image": "UI_window_bg_01",
                >        "type": 0
                >    }
                >]
                >```
        * 😁 `windowFrameImage` property
            ■key: default
            * required - ['color', 'image', 'type']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    245,
                        >    249,
                        >    252,
                        >    0
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        245,
                    >        249,
                    >        252,
                    >        0
                    >    ]
                    >]
                    >```
            * 😁 `image` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "UI_window_frame_02"
                    >]
                    >```
            * 😁 `type` property
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
                >        "color": [
                >            245,
                >            249,
                >            252,
                >            0
                >        ],
                >        "image": "UI_window_frame_02",
                >        "type": 1
                >    }
                >]
                >```
        * 😁 `windowFrameImageHighlight` property
            ■key: default
            * 😁 `windowFrameImageHighlight` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    234,
                    >    143,
                    >    199,
                    >    0
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        234,
                >        143,
                >        199,
                >        0
                >    ]
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "backgroundImage": {
            >            "color": [
            >                254,
            >                254,
            >                254,
            >                0
            >            ],
            >            "image": "UI_bg_01",
            >            "type": 0
            >        },
            >        "buttonFrameImage": {
            >            "color": [
            >                0,
            >                0,
            >                0,
            >                0
            >            ],
            >            "image": "UI_window_frame_01",
            >            "type": 0
            >        },
            >        "buttonImage": {
            >            "color": [
            >                0,
            >                0,
            >                0,
            >                80
            >            ],
            >            "image": "UI_button_bg_01",
            >            "type": 0
            >        },
            >        "buttonImageHighlight": [
            >            38,
            >            175,
            >            255,
            >            83
            >        ],
            >        "characterType": 2,
            >        "id": "1",
            >        "menuFontSetting": {
            >            "color": [
            >                255,
            >                255,
            >                255,
            >                255
            >            ],
            >            "font": "mplus-1m-regular",
            >            "size": 40
            >        },
            >        "windowBackgroundImage": {
            >            "color": [
            >                0,
            >                0,
            >                0,
            >                128
            >            ],
            >            "image": "UI_window_bg_01",
            >            "type": 0
            >        },
            >        "windowFrameImage": {
            >            "color": [
            >                245,
            >                249,
            >                252,
            >                0
            >            ],
            >            "image": "UI_window_frame_02",
            >            "type": 1
            >        },
            >        "windowFrameImageHighlight": [
            >            234,
            >            143,
            >            199,
            >            0
            >        ]
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "backgroundImage": {
        >                "color": [
        >                    254,
        >                    254,
        >                    254,
        >                    0
        >                ],
        >                "image": "UI_bg_01",
        >                "type": 0
        >            },
        >            "buttonFrameImage": {
        >                "color": [
        >                    0,
        >                    0,
        >                    0,
        >                    0
        >                ],
        >                "image": "UI_window_frame_01",
        >                "type": 0
        >            },
        >            "buttonImage": {
        >                "color": [
        >                    0,
        >                    0,
        >                    0,
        >                    80
        >                ],
        >                "image": "UI_button_bg_01",
        >                "type": 0
        >            },
        >            "buttonImageHighlight": [
        >                38,
        >                175,
        >                255,
        >                83
        >            ],
        >            "characterType": 2,
        >            "id": "1",
        >            "menuFontSetting": {
        >                "color": [
        >                    255,
        >                    255,
        >                    255,
        >                    255
        >                ],
        >                "font": "mplus-1m-regular",
        >                "size": 40
        >            },
        >            "windowBackgroundImage": {
        >                "color": [
        >                    0,
        >                    0,
        >                    0,
        >                    128
        >                ],
        >                "image": "UI_window_bg_01",
        >                "type": 0
        >            },
        >            "windowFrameImage": {
        >                "color": [
        >                    245,
        >                    249,
        >                    252,
        >                    0
        >                ],
        >                "image": "UI_window_frame_02",
        >                "type": 1
        >            },
        >            "windowFrameImageHighlight": [
        >                234,
        >                143,
        >                199,
        >                0
        >            ]
        >        }
        >    ]
        >]
        >```
* 😁 `gameMenu` property
    ■key: default
    * required - ['categoryArmor', 'categoryImportant', 'categoryItem', 'categoryWeapon', 'menuEquipment', 'menuFontSetting', 'menuGameEnd', 'menuItem', 'menuOption', 'menuSave', 'menuSkill', 'menuSort', 'menuStatus']
    * 😁 `categoryArmor` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `categoryImportant` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `categoryItem` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `categoryWeapon` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuEquipment` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuFontSetting` property
        ■key: default
        * required - ['color', 'font', 'size']
        * 😁 `color` property
            ■key: default
            * 😁 `color` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    100,
                    >    150,
                    >    200
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        100,
                >        150,
                >        200
                >    ]
                >]
                >```
        * 😁 `font` property
            ■key: default
            * examples:
                >```
                >[
                >    "AAA"
                >]
                >```
        * 😁 `size` property
            ■key: default
            * examples:
                >```
                >[
                >    16
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "color": [
            >            100,
            >            150,
            >            200
            >        ],
            >        "font": "AAA",
            >        "size": 16
            >    }
            >]
            >```
    * 😁 `menuGameEnd` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuItem` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuOption` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuSave` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuSkill` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuSort` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * 😁 `menuStatus` property
        ■key: default
        * required - ['enabled']
        * 😁 `enabled` property
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
            >        "enabled": 1
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "menuFontSetting": {
        >            "color": [
        >                100,
        >                150,
        >                200
        >            ],
        >            "font": "AAA",
        >            "size": 16
        >        },
        >        "menuStatus": {
        >            "enabled": 1
        >        }
        >    }
        >]
        >```
* 😁 `talkMenu` property
    ■key: default
    * required - ['characterMenu', 'itemSelectMenu', 'numberMenu', 'selectMenu']
    * 😁 `characterMenu` property
        ■key: default
        * required - ['characterEnabled', 'nameEnabled', 'nameFontSetting', 'talkFontSetting']
        * 😁 `characterEnabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `nameEnabled` property
            ■key: default
            * examples:
                >```
                >[
                >    1
                >]
                >```
        * 😁 `nameFontSetting` property
            ■key: default
            * required - ['color', 'font', 'size']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    255
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        255,
                    >        255,
                    >        255
                    >    ]
                    >]
                    >```
            * 😁 `font` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "002"
                    >]
                    >```
            * 😁 `size` property
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
                >        "color": [
                >            255,
                >            255,
                >            255
                >        ],
                >        "font": "002",
                >        "size": 100
                >    }
                >]
                >```
        * 😁 `talkFontSetting` property
            ■key: default
            * required - ['color', 'font', 'size']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    255
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        255,
                    >        255,
                    >        255
                    >    ]
                    >]
                    >```
            * 😁 `font` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "AAA"
                    >]
                    >```
            * 😁 `size` property
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
                >        "color": [
                >            255,
                >            255,
                >            255
                >        ],
                >        "font": "AAA",
                >        "size": 100
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "characterEnabled": 1,
            >        "nameEnabled": 1,
            >        "talkFontSetting": {
            >            "color": [
            >                255,
            >                255,
            >                255
            >            ],
            >            "font": "AAA",
            >            "size": 100
            >        }
            >    }
            >]
            >```
    * 😁 `itemSelectMenu` property
        ■key: default
        * required - ['menuFontSetting', 'positionItemWindow']
        * 😁 `menuFontSetting` property
            ■key: default
            * required - ['color', 'font', 'size']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        0,
                    >        0,
                    >        0
                    >    ]
                    >]
                    >```
            * 😁 `font` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "002"
                    >]
                    >```
            * 😁 `size` property
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
                >        "color": [
                >            0,
                >            0,
                >            0
                >        ],
                >        "font": "002",
                >        "size": 100
                >    }
                >]
                >```
        * 😁 `positionItemWindow` property
            ■key: default
            * examples:
                >```
                >[
                >    2
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "menuFontSetting": {
            >            "color": [
            >                0,
            >                0,
            >                0
            >            ],
            >            "font": "002",
            >            "size": 100
            >        },
            >        "positionItemWindow": 2
            >    }
            >]
            >```
    * 😁 `numberMenu` property
        ■key: default
        * required - ['menuFontSetting', 'numberEnabled', 'positionNumberWindow']
        * 😁 `menuFontSetting` property
            ■key: default
            * required - ['color', 'font', 'size']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    0
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        0,
                    >        0,
                    >        0
                    >    ]
                    >]
                    >```
            * 😁 `font` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "002"
                    >]
                    >```
            * 😁 `size` property
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
                >        "color": [
                >            0,
                >            0,
                >            0
                >        ],
                >        "font": "002",
                >        "size": 100
                >    }
                >]
                >```
        * 😁 `numberEnabled` property
            ■key: default
            * examples:
                >```
                >[
                >    0
                >]
                >```
        * 😁 `positionNumberWindow` property
            ■key: default
            * 😁 `positionNumberWindow` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        0,
                >        0
                >    ]
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "menuFontSetting": {
            >            "color": [
            >                0,
            >                0,
            >                0
            >            ],
            >            "font": "002",
            >            "size": 100
            >        },
            >        "numberEnabled": 0,
            >        "positionNumberWindow": [
            >            0,
            >            0
            >        ]
            >    }
            >]
            >```
    * 😁 `selectMenu` property
        ■key: default
        * required - ['menuFontSetting']
        * 😁 `menuFontSetting` property
            ■key: default
            * required - ['color', 'font', 'size']
            * 😁 `color` property
                ■key: default
                * 😁 `color` array - default: None
                    * default - ```None```
                    * examples:
                        >```
                        >[
                        >    246,
                        >    229
                        >]
                        >```
                * examples:
                    >```
                    >[
                    >    [
                    >        246,
                    >        229,
                    >        229
                    >    ]
                    >]
                    >```
            * 😁 `font` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    "002"
                    >]
                    >```
            * 😁 `size` property
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
                >        "color": [
                >            246,
                >            229,
                >            229
                >        ],
                >        "font": "002",
                >        "size": 100
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "menuFontSetting": {
            >            "color": [
            >                246,
            >                229,
            >                229
            >            ],
            >            "font": "002",
            >            "size": 100
            >        }
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "characterMenu": {
        >            "characterEnabled": 1,
        >            "nameEnabled": 1,
        >            "nameFontSetting": {
        >                "color": [
        >                    255,
        >                    255,
        >                    255
        >                ],
        >                "font": "002",
        >                "size": 100
        >            },
        >            "talkFontSetting": {
        >                "color": [
        >                    255,
        >                    255,
        >                    255
        >                ],
        >                "font": "AAA",
        >                "size": 100
        >            }
        >        },
        >        "numberMenu": {
        >            "menuFontSetting": {
        >                "color": [
        >                    0,
        >                    0,
        >                    0
        >                ],
        >                "font": "002",
        >                "size": 100
        >            },
        >            "numberEnabled": 0,
        >            "positionNumberWindow": [
        >                0,
        >                0
        >            ]
        >        },
        >        "selectMenu": {
        >            "menuFontSetting": {
        >                "color": [
        >                    246,
        >                    229,
        >                    229
        >                ],
        >                "font": "002",
        >                "size": 100
        >            }
        >        }
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    {
    >        "battleMenu": {
    >            "menuHp": {
    >                "enabled": 0
    >            },
    >            "menuTp": {
    >                "enabled": 0
    >            }
    >        },
    >        "commonMenus": [
    >            {
    >                "buttonImage": {
    >                    "color": [
    >                        0,
    >                        0,
    >                        0,
    >                        80
    >                    ],
    >                    "image": "UI_button_bg_01",
    >                    "type": 0
    >                },
    >                "buttonImageHighlight": [
    >                    38,
    >                    175,
    >                    255,
    >                    83
    >                ],
    >                "characterType": 2,
    >                "id": "1",
    >                "windowFrameImage": {
    >                    "color": [
    >                        245,
    >                        249,
    >                        252,
    >                        0
    >                    ],
    >                    "image": "UI_window_frame_02",
    >                    "type": 1
    >                },
    >                "windowFrameImageHighlight": [
    >                    234,
    >                    143,
    >                    199,
    >                    0
    >                ]
    >            }
    >        ],
    >        "gameMenu": {
    >            "menuEquipment": {
    >                "enabled": 1
    >            },
    >            "menuFontSetting": {
    >                "color": [
    >                    100,
    >                    150,
    >                    200
    >                ],
    >                "font": "AAA",
    >                "size": 16
    >            },
    >            "menuStatus": {
    >                "enabled": 1
    >            }
    >        },
    >        "talkMenu": {
    >            "characterMenu": {
    >                "characterEnabled": 1,
    >                "nameEnabled": 1,
    >                "nameFontSetting": {
    >                    "color": [
    >                        255,
    >                        255,
    >                        255
    >                    ],
    >                    "font": "002",
    >                    "size": 100
    >                },
    >                "talkFontSetting": {
    >                    "color": [
    >                        255,
    >                        255,
    >                        255
    >                    ],
    >                    "font": "AAA",
    >                    "size": 100
    >                }
    >            },
    >            "numberMenu": {
    >                "menuFontSetting": {
    >                    "color": [
    >                        0,
    >                        0,
    >                        0
    >                    ],
    >                    "font": "002",
    >                    "size": 100
    >                },
    >                "numberEnabled": 0,
    >                "positionNumberWindow": [
    >                    0,
    >                    0
    >                ]
    >            },
    >            "selectMenu": {
    >                "menuFontSetting": {
    >                    "color": [
    >                        246,
    >                        229,
    >                        229
    >                    ],
    >                    "font": "002",
    >                    "size": 100
    >                }
    >            }
    >        }
    >    }
    >]
    >```
