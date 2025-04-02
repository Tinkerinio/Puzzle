using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;
    
    void Start()
    {
        winText.SetActive(false);
    }

    void Update()
    {
        if (Bear.locked && Koala.locked && Hare.locked && Tiger.locked)
            winText.SetActive(true);
    }
}
