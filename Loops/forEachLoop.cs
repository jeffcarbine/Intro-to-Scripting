using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour
{
    void Start ()
    {
        string[] rickRoll = new string[5];

        rickRoll[0] = "Never";
        rickRoll[1] = "gonna";
        rickRoll[2] = "give";
        rickRoll[3] = "you";
        rickRoll[4] = "up";

        foreach(string item in rickRoll)
        {
            print (item);
        }
    }
}
