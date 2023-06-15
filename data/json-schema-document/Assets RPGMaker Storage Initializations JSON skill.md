# JSON schema: Assets RPGMaker Storage Initializations JSON skill

* $schema: https://json-schema.org/draft/2019-09/schema
* $id: http://example.com/example.json
* 😁 `#ROOT#` array
    * default - ```[]```
    ■key: default
    * required - ['damage', 'id']
    * 😁 `damage` property
        ■key: default
        * required - ['magicAttack', 'normalAttack', 'specialAttack']
        * 😁 `magicAttack` property
            ■key: default
            * required - ['aMag', 'bMag', 'cDmg']
            * 😁 `aMag` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.3499999940395355
                    >]
                    >```
            * 😁 `bMag` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.6000000238418579
                    >]
                    >```
            * 😁 `cDmg` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    10.0
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "aMag": 0.3499999940395355,
                >        "bMag": 0.6000000238418579,
                >        "cDmg": 10.0
                >    }
                >]
                >```
        * 😁 `normalAttack` property
            ■key: default
            * required - ['aMag', 'bMag']
            * 😁 `aMag` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1.0
                    >]
                    >```
            * 😁 `bMag` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    1.0
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "aMag": 1.0,
                >        "bMag": 1.0
                >    }
                >]
                >```
        * 😁 `specialAttack` property
            ■key: default
            * required - ['aMag', 'bMag', 'cDmg']
            * 😁 `aMag` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    2.0
                    >]
                    >```
            * 😁 `bMag` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    0.0
                    >]
                    >```
            * 😁 `cDmg` property
                ■key: default
                * examples:
                    >```
                    >[
                    >    30.0
                    >]
                    >```
            * examples:
                >```
                >[
                >    {
                >        "aMag": 2.0,
                >        "bMag": 0.0,
                >        "cDmg": 30.0
                >    }
                >]
                >```
        * examples:
            >```
            >[
            >    {
            >        "magicAttack": {
            >            "aMag": 0.3499999940395355,
            >            "bMag": 0.6000000238418579,
            >            "cDmg": 10.0
            >        },
            >        "normalAttack": {
            >            "aMag": 1.0,
            >            "bMag": 1.0
            >        },
            >        "specialAttack": {
            >            "aMag": 2.0,
            >            "bMag": 0.0,
            >            "cDmg": 30.0
            >        }
            >    }
            >]
            >```
    * 😁 `id` property
        ■key: default
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
        >        "damage": {
        >            "magicAttack": {
        >                "aMag": 0.3499999940395355,
        >                "bMag": 0.6000000238418579,
        >                "cDmg": 10.0
        >            },
        >            "normalAttack": {
        >                "aMag": 1.0,
        >                "bMag": 1.0
        >            },
        >            "specialAttack": {
        >                "aMag": 2.0,
        >                "bMag": 0.0,
        >                "cDmg": 30.0
        >            }
        >        },
        >        "id": ""
        >    }
        >]
        >```
* examples:
    >```
    >[
    >    [
    >        {
    >            "damage": {
    >                "magicAttack": {
    >                    "aMag": 0.3499999940395355,
    >                    "bMag": 0.6000000238418579,
    >                    "cDmg": 10.0
    >                },
    >                "normalAttack": {
    >                    "aMag": 1.0,
    >                    "bMag": 1.0
    >                },
    >                "specialAttack": {
    >                    "aMag": 2.0,
    >                    "bMag": 0.0,
    >                    "cDmg": 30.0
    >                }
    >            },
    >            "id": ""
    >        }
    >    ]
    >]
    >```
