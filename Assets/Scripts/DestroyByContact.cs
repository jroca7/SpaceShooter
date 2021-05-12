using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
        return;

        Instantiate(explosion, transform.position, transform.rotation);
        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            SceneManager.LoadScene(0);
        }


        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
