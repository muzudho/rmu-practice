# JSON schema: Assets RPGMaker Storage AssetManager JSON Assets 0ada6636-f27d-4d74-9e0d-5b868d86ed2b

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['id', 'sort', 'name', 'type', 'weaponTypeId', 'assetTypeId', 'imageSettings']
* 😁 `id` property
    * examples:
        >```
        >[
        >    "0ada6636-f27d-4d74-9e0d-5b868d86ed2b"
        >]
        >```
* 😁 `sort` property
    * examples:
        >```
        >[
        >    154
        >]
        >```
* 😁 `name` property
    * examples:
        >```
        >[
        >    "Object 155"
        >]
        >```
* 😁 `type` property
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `weaponTypeId` property
    * examples:
        >```
        >[
        >    0
        >]
        >```
* 😁 `assetTypeId` property
    * examples:
        >```
        >[
        >    1
        >]
        >```
* 😁 `imageSettings` property
    * 😁 `imageSettings` array - default: []
        * default - ```[]```
        * required - ['path', 'sizeX', 'sizeY', 'animationFrame', 'animationSpeed']
        * 😁 `path` property
            * examples:
                >```
                >[
                >    "Other2_001.png"
                >]
                >```
        * 😁 `sizeX` property
            * examples:
                >```
                >[
                >    294
                >]
                >```
        * 😁 `sizeY` property
            * examples:
                >```
                >[
                >    194
                >]
                >```
        * 😁 `animationFrame` property
            * examples:
                >```
                >[
                >    3
                >]
                >```
        * 😁 `animationSpeed` property
            * examples:
                >```
                >[
                >    30
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "path": "Other2_001.png",
            >        "sizeX": 294,
            >        "sizeY": 194,
            >        "animationFrame": 3,
            >        "animationSpeed": 30
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "path": "Other2_001.png",
        >            "sizeX": 294,
        >            "sizeY": 194,
        >            "animationFrame": 3,
        >            "animationSpeed": 30
        >        }
        >    ]
        >]
        >```
* examples:
    >```
    >[
    >    {
    >        "id": "0ada6636-f27d-4d74-9e0d-5b868d86ed2b",
    >        "sort": 154,
    >        "name": "Object 155",
    >        "type": 0,
    >        "weaponTypeId": 0,
    >        "assetTypeId": 1,
    >        "imageSettings": [
    >            {
    >                "path": "Other2_001.png",
    >                "sizeX": 294,
    >                "sizeY": 194,
    >                "animationFrame": 3,
    >                "animationSpeed": 30
    >            },
    >            {
    >                "path": "Other2_001.png",
    >                "sizeX": 294,
    >                "sizeY": 194,
    >                "animationFrame": 3,
    >                "animationSpeed": 30
    >            }
    >        ]
    >    }
    >]
    >```
