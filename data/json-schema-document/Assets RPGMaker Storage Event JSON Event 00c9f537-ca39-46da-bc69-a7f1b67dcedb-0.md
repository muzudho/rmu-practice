# JSON schema: Assets RPGMaker Storage Event JSON Event 00c9f537-ca39-46da-bc69-a7f1b67dcedb-0

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['eventCommands', 'id', 'page', 'type']
* 😁 `eventCommands` property
    ■key: default
    * 😁 `eventCommands` array - default: None
        * default - ```None```
        * required - ['code', 'indent', 'parameters', 'route']
        * 😁 `code` property
            * examples:
                >```
                >[
                >    241,
                >    223,
                >    101,
                >    401,
                >    354,
                >    0
                >]
                >```
        * 😁 `indent` property
            * examples:
                >```
                >[
                >    0,
                >    1
                >]
                >```
        * 😁 `parameters` property
            * 😁 `parameters` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    "U_Theme_02.wav",
                    >    "90",
                    >    "100",
                    >    "0",
                    >    "60",
                    >    "1",
                    >    "2",
                    >    "",
                    >    "-1",
                    >    "And so Craft and his friends set out\non their journey, bearing the king's\nsecret orders!\nNow, the story of this adventure is\nyours to make!"
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        "U_Theme_02.wav",
                >        "90",
                >        "100",
                >        "0"
                >    ],
                >    [
                >        "0",
                >        "0",
                >        "0",
                >        "1",
                >        "1",
                >        "2",
                >        "",
                >        "",
                >        "",
                >        "1",
                >        "1",
                >        "0",
                >        "0",
                >        "-1",
                >        "",
                >        "",
                >        "",
                >        "",
                >        ""
                >    ],
                >    [
                >        "And so Craft and his friends set out\non their journey, bearing the king's\nsecret orders!\nNow, the story of this adventure is\nyours to make!",
                >        "0"
                >    ],
                >    []
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
                >    []
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "code": 241,
            >        "indent": 0,
            >        "parameters": [
            >            "U_Theme_02.wav",
            >            "90",
            >            "100",
            >            "0"
            >        ],
            >        "route": []
            >    },
            >    {
            >        "code": 101,
            >        "indent": 0,
            >        "parameters": [
            >            "0",
            >            "0",
            >            "0",
            >            "1",
            >            "1",
            >            "2",
            >            "",
            >            "",
            >            "",
            >            "1",
            >            "1",
            >            "0",
            >            "0",
            >            "-1",
            >            "",
            >            "",
            >            "",
            >            "",
            >            ""
            >        ],
            >        "route": []
            >    },
            >    {
            >        "code": 401,
            >        "indent": 1,
            >        "parameters": [
            >            "And so Craft and his friends set out\non their journey, bearing the king's\nsecret orders!\nNow, the story of this adventure is\nyours to make!",
            >            "0"
            >        ],
            >        "route": []
            >    },
            >    {
            >        "code": 0,
            >        "indent": 0,
            >        "parameters": [],
            >        "route": []
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "code": 241,
        >            "indent": 0,
        >            "parameters": [
        >                "U_Theme_02.wav",
        >                "90",
        >                "100",
        >                "0"
        >            ],
        >            "route": []
        >        },
        >        {
        >            "code": 101,
        >            "indent": 0,
        >            "parameters": [
        >                "0",
        >                "0",
        >                "0",
        >                "1",
        >                "1",
        >                "2",
        >                "",
        >                "",
        >                "",
        >                "1",
        >                "1",
        >                "0",
        >                "0",
        >                "-1",
        >                "",
        >                "",
        >                "",
        >                "",
        >                ""
        >            ],
        >            "route": []
        >        },
        >        {
        >            "code": 401,
        >            "indent": 1,
        >            "parameters": [
        >                "And so Craft and his friends set out\non their journey, bearing the king's\nsecret orders!\nNow, the story of this adventure is\nyours to make!",
        >                "0"
        >            ],
        >            "route": []
        >        },
        >        {
        >            "code": 0,
        >            "indent": 0,
        >            "parameters": [],
        >            "route": []
        >        }
        >    ]
        >]
        >```
* 😁 `id` property
    ■key: default
    * examples:
        >```
        >[
        >    "00c9f537-ca39-46da-bc69-a7f1b67dcedb"
        >]
        >```
* 😁 `page` property
    ■key: default
    * examples:
        >```
        >[
        >    0
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
    >        "eventCommands": [
    >            {
    >                "code": 241,
    >                "indent": 0,
    >                "parameters": [
    >                    "U_Theme_02.wav",
    >                    "90",
    >                    "100",
    >                    "0"
    >                ],
    >                "route": []
    >            },
    >            {
    >                "code": 101,
    >                "indent": 0,
    >                "parameters": [
    >                    "0",
    >                    "0",
    >                    "0",
    >                    "1",
    >                    "1",
    >                    "2",
    >                    "",
    >                    "",
    >                    "",
    >                    "1",
    >                    "1",
    >                    "0",
    >                    "0",
    >                    "-1",
    >                    "",
    >                    "",
    >                    "",
    >                    "",
    >                    ""
    >                ],
    >                "route": []
    >            },
    >            {
    >                "code": 401,
    >                "indent": 1,
    >                "parameters": [
    >                    "And so Craft and his friends set out\non their journey, bearing the king's\nsecret orders!\nNow, the story of this adventure is\nyours to make!",
    >                    "0"
    >                ],
    >                "route": []
    >            },
    >            {
    >                "code": 0,
    >                "indent": 0,
    >                "parameters": [],
    >                "route": []
    >            }
    >        ],
    >        "id": "00c9f537-ca39-46da-bc69-a7f1b67dcedb",
    >        "page": 0,
    >        "type": 0
    >    }
    >]
    >```
