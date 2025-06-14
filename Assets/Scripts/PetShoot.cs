using System.Collections;
using UnityEngine;

public class PetShoot : MonoBehaviour
{
    [SerializeField] private GameObject[] bulletPrefabs;
    [SerializeField] private float shootDelay;
    [SerializeField] private float shootingRange1;
    [SerializeField] private float shootingRange2;


    [SerializeField] private bool forceWeaponSelection;
    private GameObject currentBulletPrefab;

    private void Start()
    {
        currentBulletPrefab = bulletPrefabs[0];
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            float distance = float.MaxValue;
            GameObject currentEnemy = null;

            foreach (GameObject enemy in enemies)
            {
                if (Vector3.Distance(transform.position, enemy.transform.position) < distance)
                {
                    distance = Vector3.Distance(transform.position, enemy.transform.position);
                    currentEnemy = enemy;
                }
            }

            GameObject bulletPrefab = null;
            if (forceWeaponSelection)
            {
                bulletPrefab = currentBulletPrefab;
            }
            else
            {
                if (distance <= shootingRange1)
                {
                    bulletPrefab = bulletPrefabs[0];
                }
                else if (distance <= shootingRange2)
                {
                    bulletPrefab = bulletPrefabs[1];
                }
            }
            if (currentEnemy != null && distance <= shootingRange2)
            {
                Vector3 direction = currentEnemy.transform.position - transform.position;
                GameObject obj = Instantiate(bulletPrefab);
                obj.transform.position = transform.position;

                obj.GetComponent<BulletMovement>().SetUp(direction.normalized);
            }
            yield return new WaitForSeconds(shootDelay);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentBulletPrefab = bulletPrefabs[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentBulletPrefab = bulletPrefabs[1];
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, shootingRange1);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootingRange2);
    }

}
