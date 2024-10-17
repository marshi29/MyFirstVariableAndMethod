using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndMethod : MonoBehaviour
{
    public int currentAge = 22;
    public int ageIncrease = 1;
    bool isFunny = true; // or: false
    string myName = "Marcus";
    string myMiddleName = "Johan";
    string myLastName = "Schmidt";
    public int a = 529;
    public int b = 713;


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("My initial values are: a={0}, b={1}", a, b);
        int c = a;
        a = b;
        b = c;
        Debug.LogFormat("My swapped values are: a={0}, b={1}", a, b);

        int d0 = 10;
        int d1 = 20;

        // Swapping a and b
        (a, b) = Swap(a, b); 
        Debug.LogFormat("My swapped a and b values with Swap method are: a={0}, b={1}", a, b);

        // Same 
        (d0, d1) = Swap(d0, d1);
        Debug.LogFormat("My swapped d0 and d1 values with Swap method are: d0={0}, d1={1}", d0, d1);

        // Same
        (int m1, int m2) = Swap(1, 7);
        Debug.LogFormat("My swapped m1 and m2 values with Swap method are: {0} and {1}", m1, m2);

        (float f1, float f2) = Swap(1.5f, 7.3f);
        Debug.LogFormat("My swapped 1.5f and 7.3f  values with Swap float method are: {0} and {1}", f1, f2);

    }



    // Update is called once per frame
    void Update()
    {

    }
    // Method for swapping 2 integers.
    (int, int) Swap(int m, int n)
    {
        //int temp = m;
        //m = n;
        //n = temp;

        return (n, m); // Important to remember to add at the end.
    }


    // Method for swapping 2 floats.
    (float, float) Swap(float m, float n)
    {
        //Since you only have to swap the values you don't need this just put in (n, m) in return instead of (m, n)
        //float temp = m;
        //m = n;
        //n = temp;

        return (n, m); // Important to remember to add at the end.
    }
}
            




