using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _instance;
    public static T instance
    {
        get
        {
            return _instance;
        }
    }

    protected virtual bool Init()
    {
        if (instance != null)
        {
            Debug.LogWarning("overlap SingleToon " + this.ToString());
            Destroy(gameObject);
            return false;
        }

        _instance = this as T;
        if(transform.root == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        return true;
    }

}
