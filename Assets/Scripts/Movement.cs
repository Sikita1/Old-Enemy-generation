using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;

    private void Update()
    {
        if(_target != null)
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, _target.position.z), _speed * Time.deltaTime);
    }

    public void SetTarget(Transform target) => _target = target;
}
