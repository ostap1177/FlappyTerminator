using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] protected Bullet _bullet;
    [SerializeField] protected ShootPoint _shootPoint;
    [SerializeField] protected Vector3 _directionShoot;
    [SerializeField] protected float _speedBullet = 10;
    [SerializeField] protected float _delayBulletDestroed;

    protected void Shoot()
    {
        Bullet bullet = Instantiate(_bullet,_shootPoint.transform.position, _shootPoint.transform.rotation);
        Rigidbody2D bulletRigidBody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidBody.AddForce(_directionShoot * _speedBullet, ForceMode2D.Impulse);

        DestroyBulletDelayed(bullet, _delayBulletDestroed);
    }

    protected void DestroyBulletDelayed(Bullet bullet, float delay)
    {
        Destroy(bullet.gameObject, delay);
    }
}
