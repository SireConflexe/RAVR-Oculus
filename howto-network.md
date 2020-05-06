# Mettre en place le multi sur Unity

1. Ajouter à notre scène un Gameobject et l'appeler **NetworkManager**
2. Ajouter un component *NetworkManager*
3. Pour chaque prefab qui doit être synchronisé, ajouter le component *NetWorkIdentity* et *NetworkTransform*
4. Mettre dans les objets spawnable dans le **NetworkManager**, ainsi que les objets qui doivent arriver lors du spawn du joueur
5. Exemple de script de control du prefab player :
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MovePlayer : NetworkBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            // exit from update if this is not the local player
            return;
        }

        if(Input.GetKeyDown(KeyCode.Z))
            transform.Translate(0.0f, 0.0f, speed);

        if(Input.GetKeyDown(KeyCode.S))
            transform.Translate(0.0f, 0.0f, -speed);

        if(Input.GetKeyDown(KeyCode.Q))
            transform.Translate(-speed, 0.0f, 0.0f);

        if(Input.GetKeyDown(KeyCode.D))
            transform.Translate(speed, 0.0f, 0.0f);
    }
}
```
6. Mettre dans le **NetworkManager** le component *NetworkHUD* pour gerer la connexion tant que notre interface de connexion n'est pas définie 
