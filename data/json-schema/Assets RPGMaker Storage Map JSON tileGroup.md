# JSON schema: Assets RPGMaker Storage Map JSON tileGroup

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['id', 'name', 'tileList']
    * 😁 `id` property
        * examples:
            >```
            >[
            >    "e48fd666-fd65-4a13-85bb-649f0ebd8649",
            >    "8b6fe8cc-7604-401d-9d24-4afd141ebfbb",
            >    "e1c4300a-bbb1-4fce-90a7-592d89276ea2"
            >]
            >```
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "World_A1",
            >    "World_A2",
            >    "World_B",
            >    "Plant"
            >]
            >```
    * 😁 `tileList` property
        * 😁 `tileList` array - default: None
            * default - ```None```
            * required - ['id', 'type']
            * 😁 `id` property
                * examples:
                    >```
                    >[
                    >    "e94cf3bf-dfac-48b7-8621-e8eae26bcede",
                    >    "6a9d5704-e8de-446c-bace-bd94656ff58a",
                    >    "6e2653fd-0a90-4c55-a4e0-ab674139b897"
                    >]
                    >```
            * 😁 `type` property
                * examples:
                    >```
                    >[
                    >    "AutoTileA",
                    >    "NormalTile",
                    >    "LargeParts"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "id": "e94cf3bf-dfac-48b7-8621-e8eae26bcede",
                >        "type": "AutoTileA"
                >    },
                >    {
                >        "id": "6e2653fd-0a90-4c55-a4e0-ab674139b897",
                >        "type": "LargeParts"
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "id": "e94cf3bf-dfac-48b7-8621-e8eae26bcede",
            >            "type": "AutoTileA"
            >        },
            >        {
            >            "id": "ff795efe-ddb2-48fa-aa34-a35013c4ea35",
            >            "type": "NormalTile"
            >        }
            >    ],
            >    [
            >        {
            >            "id": "be90714a-d79f-46f4-8828-b0257dcd1e23",
            >            "type": "AutoTileA"
            >        },
            >        {
            >            "id": "1ed9c433-7883-4ab1-92f9-f46f8836ce9d",
            >            "type": "AutoTileA"
            >        }
            >    ],
            >    [
            >        {
            >            "id": "269511b2-b7cd-4140-a0b7-8a7b25571256",
            >            "type": "NormalTile"
            >        },
            >        {
            >            "id": "62f11b03-4b2e-406a-b22a-5a45e290d86f",
            >            "type": "NormalTile"
            >        }
            >    ],
            >    [
            >        {
            >            "id": "be12c325-6089-40d9-a31f-5da78a0353e3",
            >            "type": "NormalTile"
            >        },
            >        {
            >            "id": "6e2653fd-0a90-4c55-a4e0-ab674139b897",
            >            "type": "LargeParts"
            >        }
            >    ]
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "id": "e1c4300a-bbb1-4fce-90a7-592d89276ea2",
        >        "name": "World_B",
        >        "tileList": [
        >            {
        >                "id": "269511b2-b7cd-4140-a0b7-8a7b25571256",
        >                "type": "NormalTile"
        >            },
        >            {
        >                "id": "abf62cb2-5e83-4be5-8440-bbbc82a4ca50",
        >                "type": "NormalTile"
        >            },
        >            {
        >                "id": "62f11b03-4b2e-406a-b22a-5a45e290d86f",
        >                "type": "NormalTile"
        >            }
        >        ]
        >    },
        >    {
        >        "id": "98ea1903-31ba-4656-8efd-e8f8aff45f72",
        >        "name": "Plant",
        >        "tileList": [
        >            {
        >                "id": "be12c325-6089-40d9-a31f-5da78a0353e3",
        >                "type": "NormalTile"
        >            },
        >            {
        >                "id": "567325ad-6d23-4548-8297-c2e84c5fa898",
        >                "type": "NormalTile"
        >            },
        >            {
        >                "id": "88dfb2bf-a110-4198-99d5-04a005559594",
        >                "type": "NormalTile"
        >            },
        >            {
        >                "id": "6a9d5704-e8de-446c-bace-bd94656ff58a",
        >                "type": "LargeParts"
        >            },
        >            {
        >                "id": "6e2653fd-0a90-4c55-a4e0-ab674139b897",
        >                "type": "LargeParts"
        >            }
        >        ]
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "id": "e48fd666-fd65-4a13-85bb-649f0ebd8649",
    >            "name": "World_A1",
    >            "tileList": [
    >                {
    >                    "id": "e94cf3bf-dfac-48b7-8621-e8eae26bcede",
    >                    "type": "AutoTileA"
    >                },
    >                {
    >                    "id": "d12fbb18-2d25-4475-8d3c-d9dbf6b2ba4f",
    >                    "type": "AutoTileA"
    >                },
    >                {
    >                    "id": "ff795efe-ddb2-48fa-aa34-a35013c4ea35",
    >                    "type": "NormalTile"
    >                }
    >            ]
    >        },
    >        {
    >            "id": "8b6fe8cc-7604-401d-9d24-4afd141ebfbb",
    >            "name": "World_A2",
    >            "tileList": [
    >                {
    >                    "id": "be90714a-d79f-46f4-8828-b0257dcd1e23",
    >                    "type": "AutoTileA"
    >                },
    >                {
    >                    "id": "7fc50b3b-7fe8-414f-8ad0-a488f71b8054",
    >                    "type": "AutoTileA"
    >                },
    >                {
    >                    "id": "1ed9c433-7883-4ab1-92f9-f46f8836ce9d",
    >                    "type": "AutoTileA"
    >                }
    >            ]
    >        },
    >        {
    >            "id": "98ea1903-31ba-4656-8efd-e8f8aff45f72",
    >            "name": "Plant",
    >            "tileList": [
    >                {
    >                    "id": "be12c325-6089-40d9-a31f-5da78a0353e3",
    >                    "type": "NormalTile"
    >                },
    >                {
    >                    "id": "567325ad-6d23-4548-8297-c2e84c5fa898",
    >                    "type": "NormalTile"
    >                },
    >                {
    >                    "id": "88dfb2bf-a110-4198-99d5-04a005559594",
    >                    "type": "NormalTile"
    >                },
    >                {
    >                    "id": "6a9d5704-e8de-446c-bace-bd94656ff58a",
    >                    "type": "LargeParts"
    >                },
    >                {
    >                    "id": "6e2653fd-0a90-4c55-a4e0-ab674139b897",
    >                    "type": "LargeParts"
    >                }
    >            ]
    >        }
    >    ]
    >]
    >```
