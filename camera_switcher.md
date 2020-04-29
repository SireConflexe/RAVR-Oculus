# Mise en place du switch de camera via button

1. Créer un **EmptyObject** appelé *CameraManager*
2. Créer le script suivant : 

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
	public Camera PlayerCamera;
	public Camera GodCamera;

	public void god(){
		PlayerCamera.enabled 	= false;
		GodCamera.enabled 		= true;
	}

	public void player(){
		PlayerCamera.enabled 	= true;
		GodCamera.enabled	 	= false;
	}
}
```

3. Créer une **Camera** *GodCamera*
4. Créer une **Camera** *PlayerCamera*
5. Retourner dans le *CameraManager* puis drag'n'dropper le script dedans
6. Dans le *CameraManager*, drag'n'dropper les cameras pour les linker aux attributs correspondant 
7. Créer Deux **Button** *God* et *Player*
8. Pour les deux, dans l'onglet *OnClick* ajouter le *CameraManager* et selectionner la fonction *god* ou *player* dans *switchCamera*