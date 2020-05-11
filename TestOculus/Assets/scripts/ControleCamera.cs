using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    public GameObject joueur;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - joueur.transform.position;
    }

    void LateUpdate()
    {
        transform.position = joueur.transform.position + offset;
    }
}
