# JSON schema: Assets RPGMaker Storage Outline connection

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['id', 'lPortDirection', 'lPortOrientation', 'lUuid', 'rPortDirection', 'rPortOrientation', 'rUuid']
    * 😁 `id` property
        * examples:
            >```
            >[
            >    "a692d568-c8f2-4687-8499-856e16e7d177",
            >    "31e70be7-9607-471c-b53b-3689638b1891",
            >    "b25ee7a9-3a56-4a1f-b3e4-93b2b1fb54ff"
            >]
            >```
    * 😁 `lPortDirection` property
        * examples:
            >```
            >[
            >    2
            >]
            >```
    * 😁 `lPortOrientation` property
        * examples:
            >```
            >[
            >    1,
            >    0
            >]
            >```
    * 😁 `lUuid` property
        * examples:
            >```
            >[
            >    "5859b122-61b3-9a58-b886-2483b495803b",
            >    "e57ac778-4da4-4c21-8f14-24d7d585bc86",
            >    "386eb0df-8d58-478c-a461-6be7450673d9"
            >]
            >```
    * 😁 `rPortDirection` property
        * examples:
            >```
            >[
            >    1
            >]
            >```
    * 😁 `rPortOrientation` property
        * examples:
            >```
            >[
            >    1,
            >    0
            >]
            >```
    * 😁 `rUuid` property
        * examples:
            >```
            >[
            >    "413c26da-944f-4996-9347-bce0f4f7796e",
            >    "386eb0df-8d58-478c-a461-6be7450673d9",
            >    "79cc3f56-1a84-40e1-a55a-ef4403baa611"
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "id": "a692d568-c8f2-4687-8499-856e16e7d177",
        >        "lPortDirection": 2,
        >        "lPortOrientation": 1,
        >        "lUuid": "5859b122-61b3-9a58-b886-2483b495803b",
        >        "rPortDirection": 1,
        >        "rPortOrientation": 1,
        >        "rUuid": "413c26da-944f-4996-9347-bce0f4f7796e"
        >    },
        >    {
        >        "id": "31e70be7-9607-471c-b53b-3689638b1891",
        >        "lPortDirection": 2,
        >        "lPortOrientation": 1,
        >        "lUuid": "e57ac778-4da4-4c21-8f14-24d7d585bc86",
        >        "rPortDirection": 1,
        >        "rPortOrientation": 1,
        >        "rUuid": "386eb0df-8d58-478c-a461-6be7450673d9"
        >    },
        >    {
        >        "id": "b25ee7a9-3a56-4a1f-b3e4-93b2b1fb54ff",
        >        "lPortDirection": 2,
        >        "lPortOrientation": 0,
        >        "lUuid": "386eb0df-8d58-478c-a461-6be7450673d9",
        >        "rPortDirection": 1,
        >        "rPortOrientation": 0,
        >        "rUuid": "79cc3f56-1a84-40e1-a55a-ef4403baa611"
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "id": "a692d568-c8f2-4687-8499-856e16e7d177",
    >            "lPortDirection": 2,
    >            "lPortOrientation": 1,
    >            "lUuid": "5859b122-61b3-9a58-b886-2483b495803b",
    >            "rPortDirection": 1,
    >            "rPortOrientation": 1,
    >            "rUuid": "413c26da-944f-4996-9347-bce0f4f7796e"
    >        },
    >        {
    >            "id": "31e70be7-9607-471c-b53b-3689638b1891",
    >            "lPortDirection": 2,
    >            "lPortOrientation": 1,
    >            "lUuid": "e57ac778-4da4-4c21-8f14-24d7d585bc86",
    >            "rPortDirection": 1,
    >            "rPortOrientation": 1,
    >            "rUuid": "386eb0df-8d58-478c-a461-6be7450673d9"
    >        },
    >        {
    >            "id": "b25ee7a9-3a56-4a1f-b3e4-93b2b1fb54ff",
    >            "lPortDirection": 2,
    >            "lPortOrientation": 0,
    >            "lUuid": "386eb0df-8d58-478c-a461-6be7450673d9",
    >            "rPortDirection": 1,
    >            "rPortOrientation": 0,
    >            "rUuid": "79cc3f56-1a84-40e1-a55a-ef4403baa611"
    >        }
    >    ]
    >]
    >```
