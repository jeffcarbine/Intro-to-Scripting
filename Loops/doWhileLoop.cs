using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour
{
    void Start() {
        bool isTrue = false;
        do {
            print ("The boolean is true!");
        }
        while(isTrue == true);
    }
}
