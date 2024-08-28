﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipFunc_32901 : EquipmentFunc
{
    public float cd;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        cd = 10;
        buff.attack_perentage -= 0.1f;
        bullet.OnHitEvent += OnHit;
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else {
            cd = 0;
        }


    }

    protected override void OnHit(Bullets bt, GameObject go)
    {
        if (bt.isCrit && cd == 0)
        {
            int rdnum = Random.Range(1, 100);
            if (rdnum <= 50)
            {
                cd = 10;
                go.GetComponent<Enemy>().Transfer2Route(-1);
            }
        }
    }

    protected override void OnDestroy()
    {
        buff.attack_perentage += 0.1f;
        bullet.OnHitEvent -= OnHit;
    }
}
