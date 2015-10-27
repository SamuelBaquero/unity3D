using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager gm;
    public GameObject player;
    private ArrayList inventory;
    public GameObject mainCanvas;
    public GameObject initialMenu;
    public GameObject inGameMenu;

	// Use this for initialization
	void Start () {
        if (player == null)
        {
            GameObject.FindWithTag("Player");
        }
        //Player Inventory.
        inventory = new ArrayList();
        //Turn off mainCanvas, initialize Main Menu
        mainCanvas.;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
