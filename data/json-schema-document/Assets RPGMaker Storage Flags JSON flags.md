# JSON schema: Assets RPGMaker Storage Flags JSON flags

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* required - ['switches', 'variables']
* 😁 `switches` property
    * 😁 `switches` array - default: []
        * default - ```[]```
        * required - ['events', 'id', 'name']
        * 😁 `events` property
            * 😁 `events` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    [],
                >    [],
                >    []
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "caa9981e-f67a-49cd-a381-a5352fce02ec",
                >    "d975d44e-8c3a-40b5-9f1d-3096741a0072",
                >    "433beab1-46b6-48a7-8240-756e276a108b"
                >]
                >```
        * 😁 `name` property
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
            >        "events": [],
            >        "id": "caa9981e-f67a-49cd-a381-a5352fce02ec",
            >        "name": ""
            >    },
            >    {
            >        "events": [],
            >        "id": "d975d44e-8c3a-40b5-9f1d-3096741a0072",
            >        "name": ""
            >    },
            >    {
            >        "events": [],
            >        "id": "433beab1-46b6-48a7-8240-756e276a108b",
            >        "name": ""
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "events": [],
        >            "id": "caa9981e-f67a-49cd-a381-a5352fce02ec",
        >            "name": ""
        >        },
        >        {
        >            "events": [],
        >            "id": "d975d44e-8c3a-40b5-9f1d-3096741a0072",
        >            "name": ""
        >        },
        >        {
        >            "events": [],
        >            "id": "433beab1-46b6-48a7-8240-756e276a108b",
        >            "name": ""
        >        }
        >    ]
        >]
        >```
* 😁 `variables` property
    * 😁 `variables` array - default: []
        * default - ```[]```
        * required - ['events', 'id', 'name']
        * 😁 `events` property
            * 😁 `events` array - default: None
                * default - ```None```
            * examples:
                >```
                >[
                >    [],
                >    [],
                >    []
                >]
                >```
        * 😁 `id` property
            * examples:
                >```
                >[
                >    "13108098-3aaf-4935-8d44-130f7c7e1c07",
                >    "4bd03f56-0df4-4301-aa19-12495b2c1cf5",
                >    "2c6f895b-7643-4a24-82f6-2cd45f1e3e3b"
                >]
                >```
        * 😁 `name` property
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
            >        "events": [],
            >        "id": "13108098-3aaf-4935-8d44-130f7c7e1c07",
            >        "name": ""
            >    },
            >    {
            >        "events": [],
            >        "id": "4bd03f56-0df4-4301-aa19-12495b2c1cf5",
            >        "name": ""
            >    },
            >    {
            >        "events": [],
            >        "id": "2c6f895b-7643-4a24-82f6-2cd45f1e3e3b",
            >        "name": ""
            >    }
            >]
            >```
    * examples:
        >```
        >[
        >    [
        >        {
        >            "events": [],
        >            "id": "13108098-3aaf-4935-8d44-130f7c7e1c07",
        >            "name": ""
        >        },
        >        {
        >            "events": [],
        >            "id": "4bd03f56-0df4-4301-aa19-12495b2c1cf5",
        >            "name": ""
        >        },
        >        {
        >            "events": [],
        >            "id": "2c6f895b-7643-4a24-82f6-2cd45f1e3e3b",
        >            "name": ""
        >        }
        >    ]
        >]
        >```
* examples:
    >```
    >[
    >    {
    >        "switches": [
    >            {
    >                "events": [],
    >                "id": "caa9981e-f67a-49cd-a381-a5352fce02ec",
    >                "name": ""
    >            },
    >            {
    >                "events": [],
    >                "id": "d975d44e-8c3a-40b5-9f1d-3096741a0072",
    >                "name": ""
    >            },
    >            {
    >                "events": [],
    >                "id": "433beab1-46b6-48a7-8240-756e276a108b",
    >                "name": ""
    >            }
    >        ],
    >        "variables": [
    >            {
    >                "events": [],
    >                "id": "13108098-3aaf-4935-8d44-130f7c7e1c07",
    >                "name": ""
    >            },
    >            {
    >                "events": [],
    >                "id": "4bd03f56-0df4-4301-aa19-12495b2c1cf5",
    >                "name": ""
    >            },
    >            {
    >                "events": [],
    >                "id": "2c6f895b-7643-4a24-82f6-2cd45f1e3e3b",
    >                "name": ""
    >            }
    >        ]
    >    }
    >]
    >```
