using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamemanage : MonoBehaviour
{
    public int moedas;

    public TMP_Text hud, msgVitoria;
    public AudioClip clipmoeda, clipvitoria;

    private AudioSource sourse;
    
    void Start()
    {
        moedas = FindObjectsOfType<moeda>().Length;

        TryGetComponent(out sourse);
        hud.text = $"Moedas restantes: {moedas}";
    }


    public void SubtrairMoedas(int valor)
    {
        moedas = moedas - valor;
        hud.text = $"Moedas restantes: {moedas}";
        sourse.PlayOneShot(clipmoeda);
        
        if (moedas <= 0)
        {
            msgVitoria.text = "Parabéns";
            sourse.Stop();
            sourse.PlayOneShot(clipvitoria);
            
        }     
    }
}


























