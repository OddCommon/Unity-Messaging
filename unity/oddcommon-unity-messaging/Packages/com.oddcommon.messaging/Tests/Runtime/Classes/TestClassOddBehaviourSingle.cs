using System;
using OddCommon;


[Serializable]
public class TestClassOddBehaviourSingle : OddBehaviour<TestClassOddBehaviourSingle>
{
    protected override void Awake()
    {
        base.Awake();
        this.onlyAllowSingleInstance = true;
    }
}
