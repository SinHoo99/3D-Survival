using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerContorller contorller;
    public PlayerCondition condition;
    private void Awake()
    {
        CharacterManager.Instance.Player = this;
        contorller = GetComponent<PlayerContorller>();
        condition = GetComponent<PlayerCondition>();
    }
}
