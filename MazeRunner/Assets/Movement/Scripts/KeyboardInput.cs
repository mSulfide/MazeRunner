using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private Movement _player;
    private void Update()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        _player.Move(direction);
    }
}
