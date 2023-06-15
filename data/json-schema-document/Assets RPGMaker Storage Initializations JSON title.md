# JSON schema: Assets RPGMaker Storage Initializations JSON title

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['bgm', 'gameTitle', 'gameTitleCommon', 'gameTitleImage', 'gameTitleText', 'note', 'startMenu', 'titleBackgroundImage', 'titleFront']
* 😁 `bgm` property
    ■key: default
    * required - ['name', 'pan', 'pitch', 'volume']
    * 😁 `name` property
        ■key: default
        * examples:
            >```
            >[
            >    "Title1"
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
            >    900
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "name": "Title1",
        >        "pan": 0,
        >        "pitch": 100,
        >        "volume": 900
        >    }
        >]
        >```
* 😁 `gameTitle` property
    ■key: default
    * examples:
        >```
        >[
        >    "Unite Quest"
        >]
        >```
* 😁 `gameTitleCommon` property
    ■key: default
    * required - ['gameTitleType', 'position']
    * 😁 `gameTitleType` property
        ■key: default
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `position` property
        ■key: default
        * 😁 `position` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    960,
                >    320
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        960,
            >        320
            >    ]
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "gameTitleType": 1,
        >        "position": [
        >            960,
        >            320
        >        ]
        >    }
        >]
        >```
* 😁 `gameTitleImage` property
    ■key: default
    * required - ['image', 'scale']
    * 😁 `image` property
        ■key: default
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `scale` property
        ■key: default
        * examples:
            >```
            >[
            >    100.0
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "image": "",
        >        "scale": 100.0
        >    }
        >]
        >```
* 😁 `gameTitleText` property
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
            >    "mplus-1m-regular"
            >]
            >```
    * 😁 `size` property
        ■key: default
        * examples:
            >```
            >[
            >    150
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
        >        "font": "mplus-1m-regular",
        >        "size": 150
        >    }
        >]
        >```
* 😁 `note` property
    ■key: default
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `startMenu` property
    ■key: default
    * required - ['menuContinue', 'menuFontSetting', 'menuNewGame', 'menuOption', 'menuUiSetting']
    * 😁 `menuContinue` property
        ■key: default
        * required - ['enabled', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    true
                >]
                >```
        * 😁 `value` property
            ■key: default
            * examples:
                >```
                >[
                >    "Continue"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": true,
            >        "value": "Continue"
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
                >    "mplus-1m-regular"
                >]
                >```
        * 😁 `size` property
            ■key: default
            * examples:
                >```
                >[
                >    45
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
            >        "font": "mplus-1m-regular",
            >        "size": 45
            >    }
            >]
            >```
    * 😁 `menuNewGame` property
        ■key: default
        * required - ['enabled', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    true
                >]
                >```
        * 😁 `value` property
            ■key: default
            * examples:
                >```
                >[
                >    "New Game"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": true,
            >        "value": "New Game"
            >    }
            >]
            >```
    * 😁 `menuOption` property
        ■key: default
        * required - ['enabled', 'value']
        * 😁 `enabled` property
            ■key: default
            * examples:
                >```
                >[
                >    true
                >]
                >```
        * 😁 `value` property
            ■key: default
            * examples:
                >```
                >[
                >    "Options"
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "enabled": true,
            >        "value": "Options"
            >    }
            >]
            >```
    * 😁 `menuUiSetting` property
        ■key: default
        * required - ['color', 'frame', 'position', 'scale', 'window']
        * 😁 `color` property
            ■key: default
            * 😁 `color` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    []
                >]
                >```
        * 😁 `frame` property
            ■key: default
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `position` property
            ■key: default
            * 😁 `position` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    960,
                    >    680,
                    >    0
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        960,
                >        680,
                >        0
                >    ]
                >]
                >```
        * 😁 `scale` property
            ■key: default
            * examples:
                >```
                >[
                >    1.850000023841858
                >]
                >```
        * 😁 `window` property
            ■key: default
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
            >        "color": [],
            >        "frame": "",
            >        "position": [
            >            960,
            >            680,
            >            0
            >        ],
            >        "scale": 1.850000023841858,
            >        "window": ""
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "menuContinue": {
        >            "enabled": true,
        >            "value": "Continue"
        >        },
        >        "menuFontSetting": {
        >            "color": [
        >                255,
        >                255,
        >                255
        >            ],
        >            "font": "mplus-1m-regular",
        >            "size": 45
        >        },
        >        "menuNewGame": {
        >            "enabled": true,
        >            "value": "New Game"
        >        },
        >        "menuOption": {
        >            "enabled": true,
        >            "value": "Options"
        >        },
        >        "menuUiSetting": {
        >            "color": [],
        >            "frame": "",
        >            "position": [
        >                960,
        >                680,
        >                0
        >            ],
        >            "scale": 1.850000023841858,
        >            "window": ""
        >        }
        >    }
        >]
        >```
* 😁 `titleBackgroundImage` property
    ■key: default
    * examples:
        >```
        >[
        >    "titleBG_004"
        >]
        >```
* 😁 `titleFront` property
    ■key: default
    * required - ['image', 'position', 'scale']
    * 😁 `image` property
        ■key: default
        * examples:
            >```
            >[
            >    "titleFlame_001"
            >]
            >```
    * 😁 `position` property
        ■key: default
        * 😁 `position` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    960,
                >    540
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        960,
            >        540
            >    ]
            >]
            >```
    * 😁 `scale` property
        ■key: default
        * examples:
            >```
            >[
            >    100.0
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "image": "titleFlame_001",
        >        "position": [
        >            960,
        >            540
        >        ],
        >        "scale": 100.0
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    {
    >        "bgm": {
    >            "name": "Title1",
    >            "pan": 0,
    >            "pitch": 100,
    >            "volume": 900
    >        },
    >        "gameTitle": "Unite Quest",
    >        "gameTitleCommon": {
    >            "gameTitleType": 1,
    >            "position": [
    >                960,
    >                320
    >            ]
    >        },
    >        "gameTitleImage": {
    >            "image": "",
    >            "scale": 100.0
    >        },
    >        "gameTitleText": {
    >            "color": [
    >                255,
    >                255,
    >                255
    >            ],
    >            "font": "mplus-1m-regular",
    >            "size": 150
    >        },
    >        "note": "",
    >        "startMenu": {
    >            "menuContinue": {
    >                "enabled": true,
    >                "value": "Continue"
    >            },
    >            "menuFontSetting": {
    >                "color": [
    >                    255,
    >                    255,
    >                    255
    >                ],
    >                "font": "mplus-1m-regular",
    >                "size": 45
    >            },
    >            "menuNewGame": {
    >                "enabled": true,
    >                "value": "New Game"
    >            },
    >            "menuOption": {
    >                "enabled": true,
    >                "value": "Options"
    >            },
    >            "menuUiSetting": {
    >                "color": [],
    >                "frame": "",
    >                "position": [
    >                    960,
    >                    680,
    >                    0
    >                ],
    >                "scale": 1.850000023841858,
    >                "window": ""
    >            }
    >        },
    >        "titleBackgroundImage": "titleBG_004",
    >        "titleFront": {
    >            "image": "titleFlame_001",
    >            "position": [
    >                960,
    >                540
    >            ],
    >            "scale": 100.0
    >        }
    >    }
    >]
    >```
