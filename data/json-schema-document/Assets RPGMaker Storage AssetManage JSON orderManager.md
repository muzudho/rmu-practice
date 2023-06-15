﻿# JSON schema: Assets RPGMaker Storage AssetManage JSON orderManager

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['orderDataList']
* 😁 `orderDataList` property
    * 😁 `orderDataList` array - default: []
        * default - ```[]```
        * required - ['assetTypeId', 'idList']
        * 😁 `assetTypeId` property
            * examples:
                >```
                >[
                >    0,
                >    1,
                >    2,
                >    3,
                >    4,
                >    5,
                >    6
                >]
                >```
        * 😁 `idList` property
            * 😁 `idList` array - default: None
                * default - ```None```
                * examples:
                    >```
                    >[
                    >    "78a965c8-7400-432e-a17f-93432f6b9ff5",
                    >    "02c771b2-247a-42d5-b6dd-ad398d3c6557",
                    >    "60cc7e88-f27a-4608-9152-06ca3704de2a"
                    >]
                    >```
            * examples:
                >```
                >[
                >    [
                >        "78a965c8-7400-432e-a17f-93432f6b9ff5",
                >        "02c771b2-247a-42d5-b6dd-ad398d3c6557",
                >        "60cc7e88-f27a-4608-9152-06ca3704de2a"
                >    ],
                >    [
                >        "510f4d1b-986d-444b-9d38-61454ffe898b",
                >        "d9200020-672a-4f11-b1f9-ce327262470a",
                >        "1d95da28-4bb8-4870-b323-0ff104edc77f"
                >    ],
                >    [
                >        "26b2219f-43b7-4c48-b05f-77312da9075f",
                >        "a5bb713c-e4e7-4b30-a00c-9e0895ddfb6c",
                >        "5974c2a9-764f-4af5-abf5-b87072417772"
                >    ]
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "assetTypeId": 0,
            >        "idList": [
            >            "78a965c8-7400-432e-a17f-93432f6b9ff5",
            >            "02c771b2-247a-42d5-b6dd-ad398d3c6557",
            >            "bce01112-43f1-4859-b0a7-42fa24dd0331"
            >        ]
            >    },
            >    {
            >        "assetTypeId": 1,
            >        "idList": [
            >            "510f4d1b-986d-444b-9d38-61454ffe898b",
            >            "d9200020-672a-4f11-b1f9-ce327262470a",
            >            "1d95da28-4bb8-4870-b323-0ff104edc77f"
            >        ]
            >    },
            >    {
            >        "assetTypeId": 6,
            >        "idList": [
            >            "f6bad097-a340-4fe8-b90e-9676c577cfeb",
            >            "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
            >            "e53500c2-2138-406d-bd24-baa0506134b1"
            >        ]
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "assetTypeId": 0,
        >            "idList": [
        >                "78a965c8-7400-432e-a17f-93432f6b9ff5",
        >                "02c771b2-247a-42d5-b6dd-ad398d3c6557",
        >                "2c662415-c937-4bb6-94b5-040ca6f5e4bf"
        >            ]
        >        },
        >        {
        >            "assetTypeId": 1,
        >            "idList": [
        >                "510f4d1b-986d-444b-9d38-61454ffe898b",
        >                "d9200020-672a-4f11-b1f9-ce327262470a",
        >                "7baaf801-2b61-484f-8ec3-5459f59e8f31"
        >            ]
        >        },
        >        {
        >            "assetTypeId": 6,
        >            "idList": [
        >                "f6bad097-a340-4fe8-b90e-9676c577cfeb",
        >                "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
        >                "e53500c2-2138-406d-bd24-baa0506134b1"
        >            ]
        >        }
        >    ]
        >]
        >```
* examples:
    >```
    >[
    >    {
    >        "orderDataList": [
    >            {
    >                "assetTypeId": 0,
    >                "idList": [
    >                    "78a965c8-7400-432e-a17f-93432f6b9ff5",
    >                    "02c771b2-247a-42d5-b6dd-ad398d3c6557",
    >                    "60cc7e88-f27a-4608-9152-06ca3704de2a"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 1,
    >                "idList": [
    >                    "510f4d1b-986d-444b-9d38-61454ffe898b",
    >                    "d9200020-672a-4f11-b1f9-ce327262470a",
    >                    "7baaf801-2b61-484f-8ec3-5459f59e8f31"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 2,
    >                "idList": [
    >                    "26b2219f-43b7-4c48-b05f-77312da9075f",
    >                    "a5bb713c-e4e7-4b30-a00c-9e0895ddfb6c",
    >                    "3c411337-8ba9-4951-a22b-db515afe0f65"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 3,
    >                "idList": [
    >                    "e7c8511c-dda2-4812-9ddb-03a8674ce085",
    >                    "97305d27-f354-47a6-b753-17665fac01cc",
    >                    "c1ecd373-0b09-4299-ab11-e320903e0c87"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 4,
    >                "idList": [
    >                    "e47f074e-92e7-4c73-88e9-238bd8fd9116",
    >                    "9cfb8ede-847b-46c0-a303-1abc27c3e6f9",
    >                    "35a6e8d7-4517-4d1f-a9e0-04a53088ae00"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 5,
    >                "idList": [
    >                    "eafa135e-b529-45ae-b9d5-8f5c1ec45731",
    >                    "7a8bfbcf-8256-4cbf-8358-0f43a13c9a9e",
    >                    "ec34bfe8-0c25-46d9-91ae-a6a9df98be4c"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 6,
    >                "idList": [
    >                    "f6bad097-a340-4fe8-b90e-9676c577cfeb",
    >                    "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
    >                    "e53500c2-2138-406d-bd24-baa0506134b1"
    >                ]
    >            }
    >        ]
    >    }
    >]
    >```