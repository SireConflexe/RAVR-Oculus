using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager_global
{

    public static bool isFirstGame = true;

    public static bool getIsFirstGame() {
        return isFirstGame;
    }

    public static void setIsFirstGame(bool status)
    {
        isFirstGame = status;
    }
}
