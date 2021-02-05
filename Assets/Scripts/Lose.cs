using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject losePanel;
    private PlayerMove player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    public void Loose()
    {
        losePanel.SetActive(true);
        player.canMove = false;
    }
}