using UnityEngine;
using System.Collections;
using UnityEditor;

public class SetMass : MonoBehaviour {

    [MenuItem("Tools/SetMass")]

    //This is only working for onjects that I have highlighted, is this correct?
    static void SettingMass()
    {
        Debug.Log("Setting Mass");

        foreach (GameObject currObj in Selection.gameObjects)
        {
            //Check for a rigid body, if there is none, create one.
            if (!currObj.GetComponent<Rigidbody>())
            {
                currObj.AddComponent<Rigidbody>();
            }

            var objSize = currObj.GetComponent<Renderer>().bounds.size.magnitude;

            //Next, Get the renderer object.
            currObj.rigidbody.mass = currObj.rigidbody.mass*objSize;
        }
    } 
}
