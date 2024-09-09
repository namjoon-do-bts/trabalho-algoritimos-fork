using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamemanage : MonoBehaviour
{
    public int moedas;

    public TMP_Text hud, msgVitoria;
    
    void Start()
    {
        moedas = FindObjectsByType<moeda>().Length;
    }

    public void AtualizarHud()
    {
        hud.text = $"Moedas restantes: {moedas}";
    }

    public void SubtrairMoedas(int valor)
    {
        moedas -= valor;
        AtualizarHud();
        if (moedas <= 0)
        {
            msgVitoria.text = "Parabéns";
        }     
    }
    
    
    
    
    
    
    
    
    
    
}


























