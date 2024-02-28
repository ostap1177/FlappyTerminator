using UnityEngine;

public class PlayerShoot : Shoot
{
    [SerializeField] private KeyCode _shootKey;

    private void Update()
    {
        if (Input.GetKeyDown(_shootKey) == true)
        {
            Shot();
        }
    }
}
