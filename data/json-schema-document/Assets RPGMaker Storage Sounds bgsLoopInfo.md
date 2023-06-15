# JSON schema: Assets RPGMaker Storage Sounds bgsLoopInfo

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    * required - ['name', 'start', 'end']
    * 😁 `name` property
        * examples:
            >```
            >[
            >    "City.ogg",
            >    "Clock.ogg",
            >    "Wind5.ogg"
            >]
            >```
    * 😁 `start` property
        * examples:
            >```
            >[
            >    341689,
            >    0,
            >    115650,
            >    10,
            >    572933
            >]
            >```
    * 😁 `end` property
        * examples:
            >```
            >[
            >    1533320,
            >    73877,
            >    395412
            >]
            >```
    * examples:
        >```
        >[
        >    {
        >        "name": "City.ogg",
        >        "start": 341689,
        >        "end": 1533320
        >    },
        >    {
        >        "name": "Wind4.ogg",
        >        "start": 0,
        >        "end": 892926
        >    },
        >    {
        >        "name": "Wind5.ogg",
        >        "start": 0,
        >        "end": 892926
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "name": "City.ogg",
    >            "start": 341689,
    >            "end": 1533320
    >        },
    >        {
    >            "name": "Wind4.ogg",
    >            "start": 0,
    >            "end": 892926
    >        },
    >        {
    >            "name": "Wind5.ogg",
    >            "start": 0,
    >            "end": 892926
    >        }
    >    ]
    >]
    >```
