using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _numberEnemies;
    [SerializeField] private float _interval;

    [SerializeField] private Transform _target;

    private WaitForSeconds _delay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int minInclusive = 0;

        _delay = new WaitForSeconds(_interval);

        for (int i = 0; i < _numberEnemies; i++)
        {
            int randomPosition = Random.Range(minInclusive, _spawnPoints.Length);
            Enemy enemy = Instantiate(_enemy, _spawnPoints[randomPosition].position, Quaternion.identity);
            enemy.SetTarget(_target);
            yield return _delay;
        }
    }
}
