using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperUtilities
{
    //Empty string debud check
    public static bool ValidateCheckEmptyString(Object thisObject, string fieldName, string stringToCheck) {
        if(stringToCheck == "") {
            Debug.Log(fieldName + "is empty and must contain a value in object" + thisObject.name);
            return true;
        }
        return false;
    }
}
