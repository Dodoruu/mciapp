using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDataBase : ScriptableObject
{
    public Characterselect[] character;

    public int CharacterCount
    {
        get
        {
            return character.Length;
        }
    }

    public Characterselect GetCharacter(int index)
    {
        return character[index];
    }

}
