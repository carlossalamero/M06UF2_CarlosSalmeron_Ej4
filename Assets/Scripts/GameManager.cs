using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private SFXmanager sfxmanager;
    private BGMmanager bgmmanager;
    public bool misplaying = true;

    // Start is called before the first frame update
    void Awake()
    {
        
        sfxmanager = GameObject.Find("SFXmanager").GetComponent<SFXmanager>();
        bgmmanager = GameObject.Find("BGMmanager").GetComponent<BGMmanager>();

    }

    // Update is called once per frame
    public void Muerte()
    {        
        misplaying = false;
        bgmmanager.STOPBGM();
        sfxmanager.DeathSound();
    }

    public void Muerteninja()
    {        
        bgmmanager.STOPBGM();
        sfxmanager.NinjaSound();
        bgmmanager.StartBGM();
    }
}
