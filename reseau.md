+ Objet en réseau

++ Le Network Manager et HUD


Dans la scène "**NetworkScene**" récupéré le GameObject "**NetWork**" et copier le dans la nouvelle scène.
Ce dernier va rajouter un HUD visible en haut à gauche dans la simulation.

++ Paramètrage des objets en réseaux

Procèdure à suivre pour chaque objets partagés en réseaux.
Ajouter dans les components de l'objet ->  **Network Identity**.
* Si l'objet ne peux être contrôlé que par le joueur local cocher l'option "**Local Player Authority**"
* Si l'objet ne peux être contrôlé que par le server (host) cocher l'option "**Server Only**"

Pour les script associés aux objets partagés en réseaux : 

* Ajouter : ```using UnityEngine.Networking;```
* Dans la déclarationde la classe changer ```MonoBehaviour``` par ```NetworkBehaviour```
* Pour contrôler si une action viens bien du jouer local vous pouvez ajouter l'instruction : ```if(!isLocalPlayer){return ;}```

Exemple de script pour un objet partagé en réseau : **PlayerController.cs**


++ En simulation

Pour faire des test Local : Choississez "LAN HOST(H)" dans le NetWork HUD.
Pour faire des test Réseaux : Lancez deux simulations avec un LAN Host et un "Lan Client".