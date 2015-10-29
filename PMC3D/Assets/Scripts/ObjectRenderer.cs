using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectRenderer : MonoBehaviour {
    public int posicion;
    private GameObject go;

	// Update is called once per frame
	void Update () {
        go = GameManager.inventory[posicion] as GameObject;
        if (go != null)
        {
            Instantiate(go, transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(go);
        }
	}
}
