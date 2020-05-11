using System.ComponentModel;
using UnityEngine;
using Component = UnityEngine.Component;

public class displayMenu : MonoBehaviour
{

    public GameObject roleMenu;
    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerManager_global.getIsFirstGame())
        {
            this.displayRoleMenu();
            PlayerManager_global.setIsFirstGame(false);
        } else {
            this.displayGameOverMenu();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayRoleMenu()
    {
        roleMenu.SetActive(true);
        gameOverMenu.SetActive(false);
    }

    public void displayGameOverMenu()
    {
        roleMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }
}
