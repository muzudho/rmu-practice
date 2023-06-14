# JSON schema: Assets RPGMaker Storage AssetManage JSON orderManager

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
■key: required, type(value): <class 'list'>
        * examples:
            >```
            >[
            >    [
            >        {
            >            "assetTypeId": 0,
            >            "idList": [
            >                "78a965c8-7400-432e-a17f-93432f6b9ff5",
            >                "02c771b2-247a-42d5-b6dd-ad398d3c6557",
            >                "2c662415-c937-4bb6-94b5-040ca6f5e4bf",
            >                "aedd60bd-f63f-4ae8-bf9d-a0cbd65fbe94",
            >                "bce01112-43f1-4859-b0a7-42fa24dd0331"
            >            ]
            >        },
            >        {
            >            "assetTypeId": 1,
            >            "idList": [
            >                "510f4d1b-986d-444b-9d38-61454ffe898b",
            >                "d9200020-672a-4f11-b1f9-ce327262470a",
            >                "1d95da28-4bb8-4870-b323-0ff104edc77f",
            >                "625aa0d8-deb8-4e36-9742-d745fdc32134",
            >                "3bf817d1-44b0-4d1e-aba3-9d4b6fb257cd",
            >                "82a780f5-2a8e-4215-88f1-f9ac412b20ea",
            >                "1832fe16-7a68-4996-ae5e-92ce109526a8",
            >                "b2cadbf8-139f-40c5-b83f-dd71ff2405a1",
            >                "7baaf801-2b61-484f-8ec3-5459f59e8f31"
            >            ]
            >        },
            >        {
            >            "assetTypeId": 2,
            >            "idList": [
            >                "26b2219f-43b7-4c48-b05f-77312da9075f",
            >                "a5bb713c-e4e7-4b30-a00c-9e0895ddfb6c",
            >                "5974c2a9-764f-4af5-abf5-b87072417772",
            >                "365224cf-85fd-4b2a-b3fe-34cf0cd0e2d3"
            >            ]
            >        },
            >        {
            >            "assetTypeId": 3,
            >            "idList": [
            >                "e7c8511c-dda2-4812-9ddb-03a8674ce085",
            >                "97305d27-f354-47a6-b753-17665fac01cc",
            >                "ee879f35-3bde-4755-a7ce-30e821fa15dd"
            >            ]
            >        },
            >        {
            >            "assetTypeId": 4,
            >            "idList": [
            >                "e47f074e-92e7-4c73-88e9-238bd8fd9116",
            >                "9cfb8ede-847b-46c0-a303-1abc27c3e6f9",
            >                "6c11557f-8bf1-4395-a95a-a68f4a512ef9",
            >                "c1d68d6d-f6ea-449a-a8c7-38217ca36a1e",
            >                "be343f14-c25a-4d47-ba73-dbacf22478e2"
            >            ]
            >        },
            >        {
            >            "assetTypeId": 5,
            >            "idList": [
            >                "eafa135e-b529-45ae-b9d5-8f5c1ec45731",
            >                "7a8bfbcf-8256-4cbf-8358-0f43a13c9a9e",
            >                "ec34bfe8-0c25-46d9-91ae-a6a9df98be4c",
            >                "99a2c28e-b132-417b-bc4f-e56f63aaaaae"
            >            ]
            >        },
            >        {
            >            "assetTypeId": 6,
            >            "idList": [
            >                "f6bad097-a340-4fe8-b90e-9676c577cfeb",
            >                "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
            >                "e53500c2-2138-406d-bd24-baa0506134b1",
            >                "c03b5d9e-c328-4754-89b9-49fe633810e9",
            >                "54289166-4a98-489e-accd-f5aee4fa4e39",
            >                "6f7d5b0d-cc94-48dd-9053-d6893672c45c"
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
    >                    "60cc7e88-f27a-4608-9152-06ca3704de2a",
    >                    "2c662415-c937-4bb6-94b5-040ca6f5e4bf",
    >                    "aedd60bd-f63f-4ae8-bf9d-a0cbd65fbe94",
    >                    "bce01112-43f1-4859-b0a7-42fa24dd0331"
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
    >                    "3c411337-8ba9-4951-a22b-db515afe0f65",
    >                    "60134411-d553-4f00-8f6f-16f591780ae9",
    >                    "365224cf-85fd-4b2a-b3fe-34cf0cd0e2d3"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 3,
    >                "idList": [
    >                    "e7c8511c-dda2-4812-9ddb-03a8674ce085",
    >                    "97305d27-f354-47a6-b753-17665fac01cc",
    >                    "c1ecd373-0b09-4299-ab11-e320903e0c87",
    >                    "ee879f35-3bde-4755-a7ce-30e821fa15dd"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 4,
    >                "idList": [
    >                    "e47f074e-92e7-4c73-88e9-238bd8fd9116",
    >                    "9cfb8ede-847b-46c0-a303-1abc27c3e6f9",
    >                    "35a6e8d7-4517-4d1f-a9e0-04a53088ae00",
    >                    "c1d68d6d-f6ea-449a-a8c7-38217ca36a1e",
    >                    "be343f14-c25a-4d47-ba73-dbacf22478e2"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 5,
    >                "idList": [
    >                    "eafa135e-b529-45ae-b9d5-8f5c1ec45731",
    >                    "7a8bfbcf-8256-4cbf-8358-0f43a13c9a9e",
    >                    "ec34bfe8-0c25-46d9-91ae-a6a9df98be4c",
    >                    "99a2c28e-b132-417b-bc4f-e56f63aaaaae"
    >                ]
    >            },
    >            {
    >                "assetTypeId": 6,
    >                "idList": [
    >                    "f6bad097-a340-4fe8-b90e-9676c577cfeb",
    >                    "5b32c153-14a4-4d0f-8ad2-8d25dddd47d3",
    >                    "e53500c2-2138-406d-bd24-baa0506134b1",
    >                    "bafc21d2-951d-4f80-8c12-e79c85d7c13d",
    >                    "9c0307d5-1002-4a1d-b1a9-47ac385e56ff",
    >                    "c03b5d9e-c328-4754-89b9-49fe633810e9",
    >                    "54289166-4a98-489e-accd-f5aee4fa4e39",
    >                    "6f7d5b0d-cc94-48dd-9053-d6893672c45c"
    >                ]
    >            }
    >        ]
    >    }
    >]
    >```
