using UnityEngine;

public class PlayerTracket : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _xOffset;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        _transform.position = new Vector3(_player.transform.position.x - _xOffset, _transform.position.y, _transform.position.z);
    }
}
