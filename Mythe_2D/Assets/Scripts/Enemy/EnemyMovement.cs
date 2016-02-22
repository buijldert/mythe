﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] private int movespeed = 1;
    private Vector2 userDirection = Vector2.right;

	void Update () 
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }
}
