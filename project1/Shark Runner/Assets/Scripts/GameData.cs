using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a static class that holds the points value in between scenes
public static class GameData
{

    private static int points;

    public static int GetPoints()
    {
        return points;
    }

    public static void ResetPoints() 
    {
        points = 0;
    }

    public static void AddPoints(int addPoints) 
    {
        points += addPoints;
    }

}
