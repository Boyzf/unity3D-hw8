using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGUI : MonoBehaviour
{
    private GameObject firework;

    // Start is called before the first frame update
    void Start()
    {
        firework = Instantiate(Resources.Load<GameObject>("Prefabs/FireworkGreen"), Vector3.zero, Quaternion.identity);
    }

}
