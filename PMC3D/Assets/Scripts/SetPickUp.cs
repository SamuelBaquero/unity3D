using UnityEngine;
using System.Collections;

public class SetPickUp : MonoBehaviour {

    public GameObject explosionPrefab;

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //add the item to the player inventory.
            if (GameManager.gm != null)
            {
                GameManager.gm.addSetPickUp(gameObject);
            }

            // explode if specified
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            // destroy after collection
            Destroy(gameObject);
        }
    }
}
