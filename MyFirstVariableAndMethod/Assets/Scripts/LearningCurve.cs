using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();

        Character nicerHero = new Character("Nice Secret Name");

        Character jamesBond = new Character("James Bond", 100);

        hero.PrintStatsInfo();
        nicerHero.PrintStatsInfo();
        jamesBond.PrintStatsInfo();

        //string characterName = jamesBond.name; //DO NOT USE THIS LINE, BAD PRACTICE!!!

        //New method
        string myFavoriteCharacterName = jamesBond.GetCharacterName();
            Debug.LogFormat(myFavoriteCharacterName);

        nicerHero = jamesBond;
    }

    //Nicerhero goes lost because the address in memory becoems the same as JamesBond, 2 names indicate the same address location in memory.
    //nicerHero = jamesBond

    // Update is called once per frame
    void Update()
    {
        
    }
}
