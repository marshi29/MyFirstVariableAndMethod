using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAge : MonoBehaviour
{
    public int currentAge = 22;
    public int ageIncrease = 1;
    public int afterIncrementYears = 10;

    // Start is called before the first frame update
    void Start()
    {
        //We recieve 1 parameter from the return of the method and use 1
        (currentAge) = AgeIncreasedMethod(currentAge);
        //Printing in the debug log: age after one year.
        Debug.LogFormat("My age next year is: {0}", currentAge);

        //We recieve 1 parameter from the return of the method and use 2
        currentAge = AgeIncreasedMethod(currentAge, afterIncrementYears);
        //Printing in the debug log: age after increment years.
        Debug.LogFormat("My age in {1} years is: {0}", currentAge, afterIncrementYears);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Method for increasing currentage by 1, using one parameter
    int AgeIncreasedMethod(int currentAge)
    {
        //Returning the value of age + 1

        return (currentAge + 1);
    }

    //Method for increasing currentage by increment, using two parameter
    int AgeIncreasedMethod(int currentAge, int afterIncrementYears)
    { 
        //Returning the value of age + increment
        return (currentAge + afterIncrementYears - 1);
    }


}
