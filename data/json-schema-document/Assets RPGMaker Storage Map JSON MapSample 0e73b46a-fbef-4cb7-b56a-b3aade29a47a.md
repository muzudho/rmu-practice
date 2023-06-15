# JSON schema: Assets RPGMaker Storage Map JSON MapSample 0e73b46a-fbef-4cb7-b56a-b3aade29a47a

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['mapId', 'index', 'displayName', 'name', 'width', 'height', 'deleted', 'encounter', 'layers', 'scrollType', 'autoPlayBGM', 'bgmID', 'bgmState', 'autoPlayBgs', 'bgsID', 'bgsState', 'forbidDash', 'background', 'Parallax', 'memo']
* 😁 `mapId` property
    * examples:
        >```
        >[
        >    "0e73b46a-fbef-4cb7-b56a-b3aade29a47a"
        >]
        >```
* 😁 `index` property
    * examples:
        >```
        >[
        >    43
        >]
        >```
* 😁 `displayName` property
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
        >    "GrasslandRuins"
        >]
        >```
* 😁 `width` property
    * examples:
        >```
        >[
        >    26
        >]
        >```
* 😁 `height` property
    * examples:
        >```
        >[
        >    25
        >]
        >```
* 😁 `deleted` property
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `encounter` property
    * 😁 `encounter` array - default: []
        * default - ```[]```
    * examples:
        >```
        >[
        >    []
        >]
        >```
* 😁 `layers` property
    * 😁 `layers` array - default: []
        * default - ```[]```
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
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `autoPlayBGM` property
    * examples:
        >```
        >[
        >    false
        >]
        >```
* 😁 `bgmID` property
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `bgmState` property
    * required - ['pan', 'pitch', 'volume']
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
    * examples:
        >```
        >[
        >    false
        >]
        >```
* 😁 `bgsID` property
    * examples:
        >```
        >[
        >    ""
        >]
        >```
* 😁 `bgsState` property
    * required - ['pan', 'pitch', 'volume']
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
    * examples:
        >```
        >[
        >    false
        >]
        >```
* 😁 `background` property
    * required - ['imageName', 'imageZoomIndex', 'showInEditor']
    * 😁 `imageName` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `imageZoomIndex` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `showInEditor` property
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
    * required - ['loopX', 'loopY', 'name', 'show', 'sx', 'sy', 'zoom0', 'zoom2', 'zoom4']
    * 😁 `loopX` property
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * 😁 `loopY` property
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * 😁 `name` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `show` property
        * examples:
            >```
            >[
            >    true
            >]
            >```
    * 😁 `sx` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `sy` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `zoom0` property
        * examples:
            >```
            >[
            >    true
            >]
            >```
    * 😁 `zoom2` property
        * examples:
            >```
            >[
            >    false
            >]
            >```
    * 😁 `zoom4` property
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
