using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _tapForce = 10;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _maxRotationZ;
    [SerializeField] private float _minRotationZ;
    [SerializeField] private KeyCode _jumpKey;
    [SerializeField] private Quaternion _startRotation;
 
    private Rigidbody2D _rigidbody;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
        _transform.position = _startPosition;

        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = Vector2.zero;

        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
    }

    private void Start()
    {
        ResetPlayer();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_jumpKey))
        {
            _rigidbody.velocity = new Vector2(0, 0);
            _transform.rotation = _maxRotation;
            _rigidbody.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);
        }

        _transform.rotation = Quaternion.Lerp(transform.rotation,_minRotation,_rotationSpeed * Time.deltaTime);
    }

    public void ResetPlayer()
    {
        _transform.position = _startPosition;
        _transform.rotation = _startRotation;
        _rigidbody.velocity = Vector2.zero;
    }
}
