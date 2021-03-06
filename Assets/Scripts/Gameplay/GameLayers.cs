using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLayers : MonoBehaviour
{
    [SerializeField] public LayerMask solidObjectsLayer;
    [SerializeField] public LayerMask interactableLayer;
    [SerializeField] public LayerMask grassLayer;
    [SerializeField] public LayerMask fovLayer;
    
    public static GameLayers i { get; set; }

    private void Awake()
    {
        i = this;
    }

    public LayerMask SolidLayer
    {
        get => solidObjectsLayer;
    }
    
    public LayerMask InteractableLayer
    {
        get => interactableLayer;
    }
    
    public LayerMask GrassLayer
    {
        get => grassLayer;
    }
    
    public LayerMask FovLayer
    {
        get => fovLayer;
    }

}
