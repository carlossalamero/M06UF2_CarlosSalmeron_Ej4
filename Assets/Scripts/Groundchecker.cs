using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundchecker : MonoBehaviour
{
    Player _player;
    
    void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {

        _player.tocaSuelo = true;
        _player.animatronix.SetBool("Salto", false);

    }

    void OnTriggerExit2D(Collider2D col)
    {

        _player.tocaSuelo = false;

    }
}
