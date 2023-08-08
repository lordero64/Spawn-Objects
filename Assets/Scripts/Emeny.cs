using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _firstDirectory;

    public void SetPath(Vector3 directory)
    {
        _firstDirectory = directory;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _firstDirectory, _speed * Time.deltaTime);
    }
}
