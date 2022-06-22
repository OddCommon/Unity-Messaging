using System;
using System.Collections.Generic;
using OddCommon;
using UnityEngine;


[Serializable]
public class TestClassOddScriptableObjectSingle : OddScriptableObject<TestClassOddScriptableObjectSingle>
{
    [SerializeField] private int[] integers;
    [SerializeField] private List<GameObject> gameObjects;

    protected override void Awake()
    {
        base.Awake();
        this.onlyAllowSingleRuntimeInstance = true;
    }
}
