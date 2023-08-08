using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateObject : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private SpawnPoint[] _spawnPoints;
    private float _delay = 2;
    private Coroutine _coroutine;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
        _coroutine = StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);

        while (true)
        {
            int curentSpawn = Random.Range(0, _spawnPoints.Length);

            Enemy enemy = Instantiate(_enemy, _spawnPoints[curentSpawn].transform.position, Quaternion.identity);
            enemy.SetPath(_spawnPoints[curentSpawn].GetVector());

            yield return delay;
        }
    }
}
