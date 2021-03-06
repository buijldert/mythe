﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {

    [SerializeField]private Image _healthbar;
    [SerializeField]private Image _wing;
    private Player _playerScript;
    private float _healthOffset = 1;

    private void Start () 
    {
        _playerScript = GameObject.FindWithTag(Tags.PlayerTag).GetComponent<Player>();
	}

    private void Update () 
    {
        UpdateHealthbar();
	}

    private void UpdateHealthbar()
    {
        _healthbar.fillAmount = _playerScript.Health - _healthOffset;
        _wing.fillAmount = _playerScript.Health - _healthOffset;
    }
}
