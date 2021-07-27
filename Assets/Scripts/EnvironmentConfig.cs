using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentConfig : MonoBehaviour
{
    [SerializeField] List<Environment> _Environments;

    private static EnvironmentConfig _SINGLETON;

    private void Awake()
    {
        _SINGLETON = this;
    }

    static public Environment GetEnvironment()
    {
        return _SINGLETON.GetEnvironmentInner();
    }

    private Environment GetEnvironmentInner()
    {
#if DEVELOP
        return _Environments[0];
#elif PRODUCT
        return _Environments[1];
#else
        return _Environments[0];
#endif
    }
}

