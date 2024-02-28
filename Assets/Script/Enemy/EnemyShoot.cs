using System.Collections;
using UnityEngine;

public class EnemyShoot : Shoot
{
    [SerializeField] private float _secondBetweenShot;

    private WaitForSeconds _waitForSeconds;
    private Coroutine _shooting;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_secondBetweenShot);
        Shoot();
    }

    private void Shoot()
    {
        if (_shooting != null)
        {
            StopCoroutine(_shooting);
        }

        _shooting = StartCoroutine(DelayShootind());
    }

    private IEnumerator DelayShootind()
    {
        while (true)
        {
            yield return _waitForSeconds;

            Shot();
        }
    }
}
