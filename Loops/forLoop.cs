using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    int enemies = 3;

    void Start () {
        for(int i = 0; i < enemies; i++) {
            Debug.Log("Enemy numer" + i + " created!");
        }
    }

}
