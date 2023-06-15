# JSON schema: Assets RPGMaker Storage Map JSON MapSample 0e73b46a-fbef-4cb7-b56a-b3aade29a47a

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['mapId', 'index', 'displayName', 'name', 'width', 'height', 'deleted', 'encounter', 'layers', 'scrollType', 'autoPlayBGM', 'bgmID', 'bgmState', 'autoPlayBgs', 'bgsID', 'bgsState', 'forbidDash', 'background', 'Parallax', 'memo']
* 😁 `mapId` property
    ■key: default
    * examples:
        >```
        >[
        >    "0e73b46a-fbef-4cb7-b56a-b3aade29a47a"
        >]
        >```
* 😁 `index` property
    ■key: default
    * examples:
        >```
        >[
        >    43
        >]
        >```
* 😁 `displayName` property
    ■key: default
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `name` property
    ■key: default
    * examples:
        >```
        >[
        >    "GrasslandRuins"
        >]
        >```
* 😁 `width` property
    ■key: default
    * examples:
        >```
        >[
        >    26
        >]
        >```
* 😁 `height` property
    ■key: default
    * examples:
        >```
        >[
        >    25
        >]
        >```
* 😁 `deleted` property
    ■key: default
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `encounter` property
    ■key: default
    * 😁 `encounter` array - default: None
        * default - ```None```
    * examples:
        >```
        >[
        >    []
        >]
        >```
* 😁 `layers` property
    ■key: default
    * 😁 `layers` array - default: None
        * default - ```None```
        * required - ['type', 'tileIdsOnPalette']
        * 😁 `type` property
            * examples:
                >```
                >[
                >    "DistantView",
                >    "Background",
                >    "BackgroundCollision"
                >]
                >```
        * 😁 `tileIdsOnPalette` property
            * 😁 `tileIdsOnPalette` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    [],
                >    [],
                >    []
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "type": "DistantView",
            >        "tileIdsOnPalette": []
            >    },
            >    {
            >        "type": "ForRoute",
            >        "tileIdsOnPalette": []
            >    },
            >    {
            >        "type": "Region",
            >        "tileIdsOnPalette": []
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "type": "DistantView",
        >            "tileIdsOnPalette": []
        >        },
        >        {
        >            "type": "ForRoute",
        >            "tileIdsOnPalette": []
        >        },
        >        {
        >            "type": "Region",
        >            "tileIdsOnPalette": []
        >        }
        >    ]
        >]
        >```
* 😁 `scrollType` property
    ■key: default
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `autoPlayBGM` property
    ■key: default
    * examples:
        >```
        >[
        >    false
        >]
        >```
* 😁 `bgmID` property
    ■key: default
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `bgmState` property
    ■key: default
    * required - ['pan', 'pitch', 'volume']
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
        >        "pan": 0,
        >        "pitch": 100,
        >        "volume": 90
        >    }
        >]
        >```
* 😁 `autoPlayBgs` property
    ■key: default
    * examples:
        >```
        >[
        >    false
        >]
        >```
* 😁 `bgsID` property
    ■key: default
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `bgsState` property
    ■key: default
    * required - ['pan', 'pitch', 'volume']
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
        >        "pan": 0,
        >        "pitch": 100,
        >        "volume": 90
        >    }
        >]
        >```
* 😁 `forbidDash` property
    ■key: default
    * examples:
        >```
        >[
        >    false
        >]
        >```
* 😁 `background` property
    ■key: default
    * required - ['imageName', 'imageZoomIndex', 'showInEditor']
    * 😁 `imageName` property
        ■key: default
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `imageZoomIndex` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `showInEditor` property
        ■key: default
        * examples:
            >```
            >[
            >    true
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "imageName": "",
        >        "imageZoomIndex": 0,
        >        "showInEditor": true
        >    }
        >]
        >```
* 😁 `Parallax` property
    ■key: default
    * required - ['loopX', 'loopY', 'name', 'show', 'sx', 'sy', 'zoom0', 'zoom2', 'zoom4']
    * 😁 `loopX` property
        ■key: default
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * 😁 `loopY` property
        ■key: default
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * 😁 `name` property
        ■key: default
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `show` property
        ■key: default
        * examples:
            >```
            >[
            >    true
            >]
            >```
    * 😁 `sx` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `sy` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `zoom0` property
        ■key: default
        * examples:
            >```
            >[
            >    true
            >]
            >```
    * 😁 `zoom2` property
        ■key: default
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * 😁 `zoom4` property
        ■key: default
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "loopX": false,
        >        "loopY": false,
        >        "name": "",
        >        "show": true,
        >        "sx": 0,
        >        "sy": 0,
        >        "zoom0": true,
        >        "zoom2": false,
        >        "zoom4": false
        >    }
        >]
        >```
* 😁 `memo` property
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
    >        "mapId": "0e73b46a-fbef-4cb7-b56a-b3aade29a47a",
    >        "index": 43,
    >        "displayName": "",
    >        "name": "GrasslandRuins",
    >        "width": 26,
    >        "height": 25,
    >        "deleted": 0,
    >        "encounter": [],
    >        "layers": [
    >            {
    >                "type": "DistantView",
    >                "tileIdsOnPalette": []
    >            },
    >            {
    >                "type": "ForRoute",
    >                "tileIdsOnPalette": []
    >            },
    >            {
    >                "type": "Region",
    >                "tileIdsOnPalette": []
    >            }
    >        ],
    >        "scrollType": 0,
    >        "autoPlayBGM": false,
    >        "bgmID": "",
    >        "bgmState": {
    >            "pan": 0,
    >            "pitch": 100,
    >            "volume": 90
    >        },
    >        "autoPlayBgs": false,
    >        "bgsID": "",
    >        "bgsState": {
    >            "pan": 0,
    >            "pitch": 100,
    >            "volume": 90
    >        },
    >        "forbidDash": false,
    >        "background": {
    >            "imageName": "",
    >            "imageZoomIndex": 0,
    >            "showInEditor": true
    >        },
    >        "Parallax": {
    >            "loopX": false,
    >            "loopY": false,
    >            "name": "",
    >            "show": true,
    >            "sx": 0,
    >            "sy": 0,
    >            "zoom0": true,
    >            "zoom2": false,
    >            "zoom4": false
    >        },
    >        "memo": ""
    >    }
    >]
    >```
