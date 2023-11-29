using UnityEngine;
using static UnityEngine.Mathf;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction)
    {
        direction = direction.normalized * Min(1, Max(Abs(direction.x), Abs(direction.z)));
        _controller.SimpleMove(_speed * direction);
    }
}
