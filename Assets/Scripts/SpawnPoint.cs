using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _target;

    public Vector3 GetVector()
    {
        return _target.position;
    }
}
