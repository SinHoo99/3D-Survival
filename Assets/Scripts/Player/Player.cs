using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerContorller contorller;
    public PlayerCondition condition;

    public ItemData itemData;
    public Action addItem;

    public Transform dropPosition;
    private void Awake()
    {
        CharacterManager.Instance.Player = this;
        contorller = GetComponent<PlayerContorller>();
        condition = GetComponent<PlayerCondition>();
    }
}
