using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//wird an Objekt angehängt, welches den Namen anzeigt
// AM  Keyword Klassenname  ELternklasse
public class DisplayName : MonoBehaviour
{ 
    public PlayerName newPlayerName;
    private void Start()
    {
        gameObject.GetComponent<Text>().text = newPlayerName.runtimevalue; //Textkomponente von Objekt holen und Spielernamen anzeigen
    }
}