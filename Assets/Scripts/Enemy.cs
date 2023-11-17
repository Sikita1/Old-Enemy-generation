using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Movement _movement;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }

    public void SetTarget(Transform target) => _movement.SetTarget(target);
}
