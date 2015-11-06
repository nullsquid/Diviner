using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using SimpleJSON;
public class ProphecyManager : MonoBehaviour {
    JSONNode saveData = new JSONClass();
    
    public Flowchart first_sacrifice;

    void Start() {
        saveData["newString"] = first_sacrifice.GetStringVariable("endingKey");
    }
    public void saveToFile(string fileName) {


    }
}
