﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 pomak;
    void Start()
    {
        pomak = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + pomak;
    }
}
