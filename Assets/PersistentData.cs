using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using Fungus;
public class PersistentData : MonoBehaviour {
    public Flowchart first_sacrifice;
    public Flowchart main_menu;
    public int totalOmens;
    //JSONNode saveData = new JSONClass();
    //JsonObject saveData = new JsonObject();
   // public JSONObject data = new JSONObject();
    public Dictionary<string, int> heldProphecies = new Dictionary<string, int>();
    void Start() {
        //GameObject.DontDestroyOnLoad(this);
    }
    
    public void AutoSave() {
        string savePath = Application.persistentDataPath + "/saveData.txt";
        StreamWriter saveData = new StreamWriter(savePath, true);
        saveData.WriteLine(first_sacrifice.GetStringVariable("endingKey"));
        //Debug.Log((first_sacrifice.GetStringVariable("endingKey")));
        saveData.Flush();
        saveData.Close();
    }

    public void Load() {
        string loadPath = Application.persistentDataPath + "/saveData.txt";
        StreamReader loadData = new StreamReader(loadPath);
        string rawStream = loadData.ReadToEnd();
        string[] seriesOfProphecies = rawStream.Split('~');
        foreach(string prophecy in seriesOfProphecies) {
            Debug.Log(prophecy);
        }
        
        loadData.Close();
        totalOmens = seriesOfProphecies.Length;
        main_menu.SetIntegerVariable("numberOfOmens", totalOmens); 
    }

    public void AddProphecy(string prophKey) {
        heldProphecies.Add(prophKey, 1);
    }


    public int ReturnNumberOfProphecies() {
        int totalNumberOfProphecies = 0;
        foreach(KeyValuePair<string, int> pair in heldProphecies) {
            totalNumberOfProphecies += pair.Value;
        }
        Debug.Log("total prophecies are " + totalNumberOfProphecies);
        return totalNumberOfProphecies;
        
    }


}
