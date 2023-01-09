using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public int can = 5;

    public TextMeshProUGUI canMetni;
    public TextMeshProUGUI tahmineYaklastinizMetni;
    public TMP_InputField tahminGiris;

    public int tahmin;
    public int tutulanSayi;

 

    void Start()
    {
        tutulanSayi = UnityEngine.Random.Range(0, 20);
        can = 5;
        canMetni.text = "Can : " + can.ToString();
        tahmineYaklastinizMetni.gameObject.SetActive(false);
       
    }
    private void Update()
    {
        canMetni.text = "Can : " + can.ToString();
    }

    public void TahminGonder()
    {
        tahmin = Convert.ToInt16(tahminGiris.text); //16 2 byte, 32 4 bytle, 64 8 bytle | -32.768 - 32.767 |

        canMetni.text = "Can : "+can.ToString();

        if(tahmin == tutulanSayi) // == e�itse demektir.
        {
            //bu kod bloklar�n� �al��t�r
            tahmineYaklastinizMetni.gameObject.SetActive(true);
            tahmineYaklastinizMetni.color = Color.green;
            tahmineYaklastinizMetni.text = "Tebrikler! Do�ru bildiniz.";
        }
        else if(tahmin < tutulanSayi)
        {
            can--;
            tahmineYaklastinizMetni.gameObject.SetActive(true);
            tahmineYaklastinizMetni.color = Color.white;
            tahmineYaklastinizMetni.text = "Tahmininiz tutulan say�dan k���kt�r!";
        }
        else if (tahmin > tutulanSayi)
        {
            can--;
            tahmineYaklastinizMetni.gameObject.SetActive(true);
            tahmineYaklastinizMetni.color = Color.white;
            tahmineYaklastinizMetni.text = "Tahmininiz tutulan say�dan B�Y�KT�R!";
        }
        else
        {
            tahmineYaklastinizMetni.gameObject.SetActive(true);
            tahmineYaklastinizMetni.color = Color.white;
        }

    }
    public void YenidenOyna()
    {
        SceneManager.LoadScene(1); 
    }




}
