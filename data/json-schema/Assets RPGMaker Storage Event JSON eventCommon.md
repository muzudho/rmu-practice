# JSON schema: Assets RPGMaker Storage Event JSON eventCommon

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['conditions', 'eventId', 'name']
    * 😁 `conditions` property
        * 😁 `conditions` array - default: None
            * default - ```None```
            * required - ['trigger', 'switchId']
            * 😁 `trigger` property
                * examples:
                    >```
                    >[
                    >    0
                    >]
                    >```
            * 😁 `switchId` property
                * examples:
                    >```
                    >[
                    >    "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "trigger": 0,
                >        "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
                >    },
                >    {
                >        "trigger": 0,
                >        "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
                >    },
                >    {
                >        "trigger": 0,
                >        "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    [
            >        {
            >            "trigger": 0,
            >            "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
            >        }
            >    ],
            >    [
            >        {
            >            "trigger": 0,
            >            "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
            >        }
            >    ],
            >    [
            >        {
            >            "trigger": 0,
            >            "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
            >        }
            >    ]
            >]
            >```
    * 😁 `eventId` property
        * examples:
            >```
            >[
            >    "d8e2bbf4-5155-4181-a32a-332eed2c581a",
            >    "bc2be67e-8d4c-4ce8-b703-461183a0467b",
            >    "83e8fcc7-d0b9-4490-b24a-8f2112c6dbd0"
            >]
            >```
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "Church Resurrection",
            >    "Church Poison Cure",
            >    "Church Paralysis Cure"
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "conditions": [
        >            {
        >                "trigger": 0,
        >                "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
        >            }
        >        ],
        >        "eventId": "d8e2bbf4-5155-4181-a32a-332eed2c581a",
        >        "name": "Church Resurrection"
        >    },
        >    {
        >        "conditions": [
        >            {
        >                "trigger": 0,
        >                "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
        >            }
        >        ],
        >        "eventId": "47700385-9153-48e8-aee7-c310be5ceaba",
        >        "name": "Yellowsand Settlement Dialogue Event"
        >    },
        >    {
        >        "conditions": [
        >            {
        >                "trigger": 0,
        >                "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
        >            }
        >        ],
        >        "eventId": "4a3162ae-1408-49be-832a-3ec3523d065c",
        >        "name": "Yellowsand Settlement Exit Event"
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "conditions": [
    >                {
    >                    "trigger": 0,
    >                    "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
    >                }
    >            ],
    >            "eventId": "d8e2bbf4-5155-4181-a32a-332eed2c581a",
    >            "name": "Church Resurrection"
    >        },
    >        {
    >            "conditions": [
    >                {
    >                    "trigger": 0,
    >                    "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
    >                }
    >            ],
    >            "eventId": "47700385-9153-48e8-aee7-c310be5ceaba",
    >            "name": "Yellowsand Settlement Dialogue Event"
    >        },
    >        {
    >            "conditions": [
    >                {
    >                    "trigger": 0,
    >                    "switchId": "d1d4f32a-c00d-4783-8cbd-63c0f8584a28"
    >                }
    >            ],
    >            "eventId": "4a3162ae-1408-49be-832a-3ec3523d065c",
    >            "name": "Yellowsand Settlement Exit Event"
    >        }
    >    ]
    >]
    >```
