﻿using UnityEngine;
using System.Collections;

public class FishEnemyDeath : EnemyDeath, IKillable
{

    // Use this for initialization
    void Start()
    {
        base.Start();
        _stoneEnemy = ObjectNames.fishStoneEnemyName;
        _slicedEnemy = ObjectNames.fishSlicedEnemyName;
        _disintegratedEnemy = ObjectNames.fishEnemyDisintegratedName;
    }

}
