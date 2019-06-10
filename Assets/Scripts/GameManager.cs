using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Gm;

    private void Awake()
    {
        if (Gm == null)
        {
            Gm = this;
        }
    }
}
