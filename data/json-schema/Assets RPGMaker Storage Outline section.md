# JSON schema: Assets RPGMaker Storage Outline section

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['chapterId', 'clearFlag', 'deleted', 'description', 'image', 'mapIds', 'memo', 'position', 'sectionId', 'startFlag', 'title']
    * 😁 `chapterId` property
        * examples:
            >```
            >[
            >    "5859b122-61b3-9a58-b886-2483b495803b",
            >    "57d4ee27-186c-4151-ac87-51bb3fce2a6e",
            >    "97d95bab-e352-4cf8-aa64-189f54cb886c"
            >]
            >```
    * 😁 `clearFlag` property
        * 😁 `clearFlag` array - default: None
            * default - ```None```
        * examples:
            >```
            >[
            >    [],
            >    [],
            >    []
            >]
            >```
    * 😁 `deleted` property
        * examples:
            >```
            >[
            >    0
            >]
            >```
    * 😁 `description` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `image` property
        * examples:
            >```
            >[
            >    ""
            >]
            >```
    * 😁 `mapIds` property
        * 😁 `mapIds` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    "65ff8a91-3d15-48bf-b4e7-f8d109d3f6da",
                >    "00146731-7002-48e1-8f11-4fd0e75ebd5c",
                >    "60ec34cd-a305-4c3d-8b55-e69f5944a5ef"
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        "65ff8a91-3d15-48bf-b4e7-f8d109d3f6da"
            >    ],
            >    [
            >        "00146731-7002-48e1-8f11-4fd0e75ebd5c"
            >    ],
            >    [
            >        "60ec34cd-a305-4c3d-8b55-e69f5944a5ef"
            >    ]
            >]
            >```
    * 😁 `memo` property
        * examples:
            >```
            >[
            >    "\t",
            >    ""
            >]
            >```
    * 😁 `position` property
        * 😁 `position` array - default: None
            * default - ```None```
            * examples:
                >```
                >[
                >    382.00018310546875,
                >    388.5712585449219,
                >    382.28570556640625
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        382.00018310546875,
            >        388.5712585449219
            >    ],
            >    [
            >        2985.142822265625,
            >        380.5714111328125
            >    ],
            >    [
            >        2985.142578125,
            >        717.7142944335938
            >    ]
            >]
            >```
    * 😁 `sectionId` property
        * examples:
            >```
            >[
            >    "413c26da-944f-4996-9347-bce0f4f7796e",
            >    "e57ac778-4da4-4c21-8f14-24d7d585bc86",
            >    "386eb0df-8d58-478c-a461-6be7450673d9"
            >]
            >```
    * 😁 `startFlag` property
        * 😁 `startFlag` array - default: None
            * default - ```None```
        * examples:
            >```
            >[
            >    [],
            >    [],
            >    []
            >]
            >```
    * 😁 `title` property
        * examples:
            >```
            >[
            >    "Trying one's ability",
            >    "Finals game of a tournament",
            >    "King of Bretagne"
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "chapterId": "5859b122-61b3-9a58-b886-2483b495803b",
        >        "clearFlag": [],
        >        "deleted": 0,
        >        "description": "",
        >        "image": "",
        >        "mapIds": [
        >            "65ff8a91-3d15-48bf-b4e7-f8d109d3f6da"
        >        ],
        >        "memo": "\t",
        >        "position": [
        >            382.00018310546875,
        >            388.5712585449219
        >        ],
        >        "sectionId": "413c26da-944f-4996-9347-bce0f4f7796e",
        >        "startFlag": [],
        >        "title": "Trying one's ability"
        >    },
        >    {
        >        "chapterId": "97d95bab-e352-4cf8-aa64-189f54cb886c",
        >        "clearFlag": [],
        >        "deleted": 0,
        >        "description": "",
        >        "image": "",
        >        "mapIds": [
        >            "a4297390-25ff-4731-9410-c72283d4ba3a"
        >        ],
        >        "memo": "",
        >        "position": [
        >            2985.142822265625,
        >            380.5714111328125
        >        ],
        >        "sectionId": "e57ac778-4da4-4c21-8f14-24d7d585bc86",
        >        "startFlag": [],
        >        "title": "Finals game of a tournament"
        >    },
        >    {
        >        "chapterId": "97d95bab-e352-4cf8-aa64-189f54cb886c",
        >        "clearFlag": [],
        >        "deleted": 0,
        >        "description": "",
        >        "image": "",
        >        "mapIds": [
        >            "60ec34cd-a305-4c3d-8b55-e69f5944a5ef"
        >        ],
        >        "memo": "",
        >        "position": [
        >            2985.142578125,
        >            717.7142944335938
        >        ],
        >        "sectionId": "386eb0df-8d58-478c-a461-6be7450673d9",
        >        "startFlag": [],
        >        "title": "King of Bretagne"
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "chapterId": "5859b122-61b3-9a58-b886-2483b495803b",
    >            "clearFlag": [],
    >            "deleted": 0,
    >            "description": "",
    >            "image": "",
    >            "mapIds": [
    >                "65ff8a91-3d15-48bf-b4e7-f8d109d3f6da"
    >            ],
    >            "memo": "\t",
    >            "position": [
    >                382.00018310546875,
    >                388.5712585449219
    >            ],
    >            "sectionId": "413c26da-944f-4996-9347-bce0f4f7796e",
    >            "startFlag": [],
    >            "title": "Trying one's ability"
    >        },
    >        {
    >            "chapterId": "97d95bab-e352-4cf8-aa64-189f54cb886c",
    >            "clearFlag": [],
    >            "deleted": 0,
    >            "description": "",
    >            "image": "",
    >            "mapIds": [
    >                "a4297390-25ff-4731-9410-c72283d4ba3a"
    >            ],
    >            "memo": "",
    >            "position": [
    >                2985.142822265625,
    >                380.5714111328125
    >            ],
    >            "sectionId": "e57ac778-4da4-4c21-8f14-24d7d585bc86",
    >            "startFlag": [],
    >            "title": "Finals game of a tournament"
    >        },
    >        {
    >            "chapterId": "97d95bab-e352-4cf8-aa64-189f54cb886c",
    >            "clearFlag": [],
    >            "deleted": 0,
    >            "description": "",
    >            "image": "",
    >            "mapIds": [
    >                "60ec34cd-a305-4c3d-8b55-e69f5944a5ef"
    >            ],
    >            "memo": "",
    >            "position": [
    >                2985.142578125,
    >                717.7142944335938
    >            ],
    >            "sectionId": "386eb0df-8d58-478c-a461-6be7450673d9",
    >            "startFlag": [],
    >            "title": "King of Bretagne"
    >        }
    >    ]
    >]
    >```
