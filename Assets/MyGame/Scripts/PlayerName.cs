using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu] 
//AM   Keyword Klassenname Elternklasse    
public class PlayerName : ScriptableObject, ISerializationCallbackReceiver
{
    // AM  Variablentyp Variablenname
    public string runtimevalue; //while game is played, value changes 
    public string initialvalue;
    public void OnBeforeSerialize()
    {

    }
    public void OnAfterDeserialize() //when the game ends, value gets reset
    {
        runtimevalue = initialvalue;
    }
}
