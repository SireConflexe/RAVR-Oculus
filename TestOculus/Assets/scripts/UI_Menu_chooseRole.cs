using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Menu_chooseRole : MonoBehaviour
{
    public Button ValidBtn;
    public Text PecheurLabel;
    public Text DieuLabel;

    private bool isDieu;
    private bool isPecheur;

    // Start is called before the first frame update
    void Start()
    {
        this.isDieu = false;
        this.isPecheur = false;

        this.ValidBtn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setPlayerAsDieu()
    {
        this.isDieu = true;
        this.isPecheur = false;
        updateLabels();
        Debug.Log("Click to setPlayerAsDieu");
    }

    public void setPlayerAsPecheur()
    {
        this.isDieu = false;
        this.isPecheur = true;
        updateLabels();
        Debug.Log("Click to setPlayerAsPecheur");
    }

    public void validatePlayerChoice()
    {
        Debug.Log("Click to validatePlayerChoice");
        SceneManager.LoadScene("Scenes/SampleScene", LoadSceneMode.Single);
    }

    private void updateLabels()
    {
        if (this.isDieu) {
            this.DieuLabel.color = new Color(0, 155.0f / 255.0f, 255.0f / 255.0f);
        } else {
            this.DieuLabel.color = new Color(0, 0, 0);
        }

        if(this.isPecheur) {
            this.PecheurLabel.color = new Color(0, 155.0f/255.0f, 255.0f/255.0f);
        } else {
            this.PecheurLabel.color = new Color(0, 0, 0);
        }

        if (this.isPecheur || this.isDieu) {
            this.ValidBtn.interactable = true;
        }
    }
}
