# JSON schema: Assets RPGMaker Storage Sounds bgmLoopInfo

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['name', 'start', 'end']
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "U_Battle_01.wav",
            >    "U_Town_01.wav",
            >    "U_Village_01.wav"
            >]
            >```
    * 😁 `start` property
        * examples:
            >```
            >[
            >    -1
            >]
            >```
    * 😁 `end` property
        * examples:
            >```
            >[
            >    -1
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "name": "U_Battle_01.wav",
        >        "start": -1,
        >        "end": -1
        >    },
        >    {
        >        "name": "U_Town_01.wav",
        >        "start": -1,
        >        "end": -1
        >    },
        >    {
        >        "name": "U_Village_01.wav",
        >        "start": -1,
        >        "end": -1
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "name": "U_Battle_01.wav",
    >            "start": -1,
    >            "end": -1
    >        },
    >        {
    >            "name": "U_Town_01.wav",
    >            "start": -1,
    >            "end": -1
    >        },
    >        {
    >            "name": "U_Village_01.wav",
    >            "start": -1,
    >            "end": -1
    >        }
    >    ]
    >]
    >```
