using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            Die();
        }
    }

    void Die(){
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MovePlayer>().enabled = false;
        ReloadLevel();
    }

    void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
