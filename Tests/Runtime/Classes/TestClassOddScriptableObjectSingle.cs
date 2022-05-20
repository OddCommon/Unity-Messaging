using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using OddCommon;
using UnityEngine;

[Serializable]
public class TestClassOddScriptableObjectSingle : OddScriptableObjectSingle<TestClassOddScriptableObjectSingle>
{
    [SerializeField] private int[] integers;
    [SerializeField] private List<GameObject> gameObjects;
}
