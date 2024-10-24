using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    //Internal variables
    public string name;
    public int exp = 0;

    public Character()
    {
        //Local parameter for the class
        this.name = "Name stricken from history";
        this.exp = 0;
    }

    //Input parameter for the class
    public Character(string name)
    {
        this.name = name;
    }

    //"this" is always the variable, and without, is the input parameters.
    public Character(string name, int exp)
    {
        this.name = name;
        this.exp = exp;
    }

    public virtual void PrintStatsInfo()
    {
        //This means "this value for this class" Variables for the object you are currently working with
        Debug.LogFormat("Character: {0} - {1} EXP", this.name, this.exp);
    }

    public string GetCharacterName()
        {
            return this.name;
        }
}
