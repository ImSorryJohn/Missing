using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool disabled = true;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToDisable.SetActive(false);
        }
    }


}
