using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Menu_chooseRole : MonoBehaviour
{

    private string currentPlayer;
    private int nbDieu = 1;
    private int nbPecheur = 1;

    public Text DieuLabel;
    public Text PecheurLabel;
    public Button ValidBtn;

    private HashSet<String> dieu;
    private HashSet<String> pecheur;

    // Start is called before the first frame update
    void Start()
    {
        this.currentPlayer = "a";
        this.ValidBtn.interactable = false;

        this.dieu = new HashSet<String>();
        this.pecheur = new HashSet<String>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPlayerAsDieu()
    {
        this.dieu.Add(this.currentPlayer);
        this.pecheur.Remove(this.currentPlayer);
        updateLabels();
        Debug.Log("Click to setPlayerAsDieu");
    }

    public void setPlayerAsPecheur()
    {
        this.pecheur.Add(this.currentPlayer);
        this.dieu.Remove(this.currentPlayer);
        updateLabels();
        Debug.Log("Click to setPlayerAsPecheur");
    }

    public void validatePlayerChoice()
    {
        Debug.Log("Click to validatePlayerChoice");
    }

    private void updateLabels()
    {
        if (this.dieu.Contains(this.currentPlayer)) {
            this.DieuLabel.color = new Color(255, 0, 0);
        } else {
            this.DieuLabel.color = new Color(0, 0, 0);
        }

        if(this.pecheur.Contains(this.currentPlayer)) {
            this.PecheurLabel.color = new Color(255, 0, 0);
        } else {
            this.PecheurLabel.color = new Color(0, 0, 0);
        }

        this.PecheurLabel.text = "Pêcheur\n" + this.pecheur.Count + "/" + this.nbPecheur;
        this.DieuLabel.text = "Dieu\n" + this.dieu.Count + "/" + this.nbDieu;
        if (this.pecheur.Contains(this.currentPlayer) || this.dieu.Contains(this.currentPlayer))
        {
            this.ValidBtn.interactable = true;
        }
    }
}
