# JSON schema: Assets RPGMaker Storage Outline start

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    ■key: default
    * required - ['beforeStartId', 'deleted', 'description', 'nextStartId', 'position', 'startId', 'title']
    * 😁 `beforeStartId` property
        ■key: default
        * examples:
            >```
            >[
            >    0
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
    * 😁 `description` property
        ■key: default
        * examples:
            >```
            >[
            >    "\u30e9\u30c0\u30c9\u30fc\u30e0\uff5e\u30ac\u30e9\u30a4\u306e\u753a\n\u30e1\u30eb\u30ad\u30c9\n\u7adc\u738b\u306e\u767d"
            >]
            >```
    * 😁 `nextStartId` property
        ■key: default
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `position` property
        ■key: default
        * 😁 `position` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    56.571510314941406,
                >    44.000003814697266
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        56.571510314941406,
            >        44.000003814697266
            >    ]
            >]
            >```
    * 😁 `startId` property
        ■key: default
        * examples:
            >```
            >[
            >    "4514da87-c3d4-4ce3-bd2d-6113edaa4c84"
            >]
            >```
    * 😁 `title` property
        ■key: default
        * examples:
            >```
            >[
            >    "\u30c1\u30e3\u30d7\u30bf\u30fcA123"
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "beforeStartId": 0,
        >        "deleted": 0,
        >        "description": "\u30e9\u30c0\u30c9\u30fc\u30e0\uff5e\u30ac\u30e9\u30a4\u306e\u753a\n\u30e1\u30eb\u30ad\u30c9\n\u7adc\u738b\u306e\u767d",
        >        "nextStartId": 0,
        >        "position": [
        >            56.571510314941406,
        >            44.000003814697266
        >        ],
        >        "startId": "4514da87-c3d4-4ce3-bd2d-6113edaa4c84",
        >        "title": "\u30c1\u30e3\u30d7\u30bf\u30fcA123"
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "beforeStartId": 0,
    >            "deleted": 0,
    >            "description": "\u30e9\u30c0\u30c9\u30fc\u30e0\uff5e\u30ac\u30e9\u30a4\u306e\u753a\n\u30e1\u30eb\u30ad\u30c9\n\u7adc\u738b\u306e\u767d",
    >            "nextStartId": 0,
    >            "position": [
    >                56.571510314941406,
    >                44.000003814697266
    >            ],
    >            "startId": "4514da87-c3d4-4ce3-bd2d-6113edaa4c84",
    >            "title": "\u30c1\u30e3\u30d7\u30bf\u30fcA123"
    >        }
    >    ]
    >]
    >```
