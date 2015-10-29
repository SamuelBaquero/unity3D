using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager gm;
    public static ArrayList inventory;

    public enum gameStates {Playing, Pause, Menu};
    public gameStates gameState = gameStates.Menu;

    public GameObject player;
    public GameObject mainCanvas;
    public GameObject menuCanvas;
    public GameObject pauseMenuCanvas;

	// Use this for initialization
	void Start () {
        if(gm == null)
            gm.gameObject.GetComponent<GameManager>();

        if (player == null)
        {
            GameObject.FindWithTag("Player");
        }
        //Player Inventory.
        inventory = new ArrayList();
        //Make other canvas inactive.
        mainCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        switch (gameState)
        {
            case gameStates.Playing:
                if( Input.GetKeyDown(KeyCode.Escape))
                {
                    //Change the game state.
                    gameState = gameStates.Pause;
                    //Pause the game.
                    Time.timeScale = 0;
                    //Show the Pause Menu.
                    pauseMenuCanvas.SetActive(true);
                }
                break;
            case gameStates.Pause:
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    //Change the game state.
                    gameState = gameStates.Playing;
                    //Hide the pause menu.
                    pauseMenuCanvas.SetActive(false);
                    //Unpause the game.
                    Time.timeScale = 1;
                }
                break;
            case gameStates.Menu:
                //nothing
                break;
        }
	}

    public void addSetPickUp(GameObject pickUp)
    {
        inventory.Add(pickUp);
    }

    GameObject dropPickUp(GameObject pickup)
    {
        GameObject temp = inventory[0] as GameObject;
        inventory.RemoveAt(0);
        return temp;
    }

    void clearInventory()
    {
        inventory.Clear();
    }

    public void playGame()
    {
        gameStates
    }
}

