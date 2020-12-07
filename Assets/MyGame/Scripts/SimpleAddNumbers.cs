using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//AM   Keyword  Klassenname     Elternklasse
public class SimpleAddNumbers : MonoBehaviour
{ // AM    Variablen-typ Variablen-Name
    public InputField input1;
    public InputField input2;
    public int result;
    public Button resultButton;
    // Am  return type   Methodenname   leere Parameterliste
    public void CalculateResult()
    {
        result = int.Parse(input1.text) + int.Parse(input2.text); //Konvertieren von String zu Int und Hinzufügen des eingegebenen Betrags 
        GameObject resulttext = resultButton.gameObject.transform.GetChild(0).gameObject; //liefert das Child des buttons (Textfield)
        resulttext.GetComponent<Text>().text = result.ToString(); //Zeigt Ergebnis im Textfeld 
        resultButton.interactable = false; //deaktiviert den button nach onclick
    }
}

