# JSON schema: Assets RPGMaker Storage Initializations JSON title

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['bgm', 'gameTitle', 'gameTitleCommon', 'gameTitleImage', 'gameTitleText', 'note', 'startMenu', 'titleBackgroundImage', 'titleFront']
* 😁 `bgm` property
    * required - ['name', 'pan', 'pitch', 'volume']
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "Title1"
            >]
            >```
    * 😁 `pan` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `pitch` property
        * examples:
            >```
            >[
            >    100
            >]
            >```
    * 😁 `volume` property
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
    * examples:
        >```
        >[
        >    "Unite Quest"
        >]
        >```
* 😁 `gameTitleCommon` property
    * required - ['gameTitleType', 'position']
    * 😁 `gameTitleType` property
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `position` property
        * 😁 `position` array - default: []
            * default - ```[]```
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
    * required - ['image', 'scale']
    * 😁 `image` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `scale` property
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
    * required - ['color', 'font', 'size']
    * 😁 `color` property
        * 😁 `color` array - default: []
            * default - ```[]```
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
        * examples:
            >```
            >[
            >    "mplus-1m-regular"
            >]
            >```
    * 😁 `size` property
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
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `startMenu` property
    * required - ['menuContinue', 'menuFontSetting', 'menuNewGame', 'menuOption', 'menuUiSetting']
    * 😁 `menuContinue` property
        * required - ['enabled', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    true
                >]
                >```
        * 😁 `value` property
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
        * required - ['color', 'font', 'size']
        * 😁 `color` property
            * 😁 `color` array - default: []
                * default - ```[]```
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
            * examples:
                >```
                >[
                >    "mplus-1m-regular"
                >]
                >```
        * 😁 `size` property
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
        * required - ['enabled', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    true
                >]
                >```
        * 😁 `value` property
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
        * required - ['enabled', 'value']
        * 😁 `enabled` property
            * examples:
                >```
                >[
                >    true
                >]
                >```
        * 😁 `value` property
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
        * required - ['color', 'frame', 'position', 'scale', 'window']
        * 😁 `color` property
            * 😁 `color` array - default: []
                * default - ```[]```
            * examples:
                >```
                >[
                >    []
                >]
                >```
        * 😁 `frame` property
            * examples:
                >```
                >[
                >    ""
                >]
                >```
        * 😁 `position` property
            * 😁 `position` array - default: []
                * default - ```[]```
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
            * examples:
                >```
                >[
                >    1.850000023841858
                >]
                >```
        * 😁 `window` property
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
    * examples:
        >```
        >[
        >    "titleBG_004"
        >]
        >```
* 😁 `titleFront` property
    * required - ['image', 'position', 'scale']
    * 😁 `image` property
        * examples:
            >```
            >[
            >    "titleFlame_001"
            >]
            >```
    * 😁 `position` property
        * 😁 `position` array - default: []
            * default - ```[]```
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
