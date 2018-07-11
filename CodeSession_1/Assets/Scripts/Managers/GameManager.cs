﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private WorldManager _worldManager;

    private void Start()
    {
        _worldManager.BuildWorld();
    }
}
