using UnityEngine;
using System.Collections;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Fungus;
public class PersistentData : MonoBehaviour {
    public Flowchart first_sacrifice;
    public Flowchart main_menu;
    public int totalOmens;
    public List<string> seriesOfOmens = new List<string>();
    
    public string[] seriesOfProphecies;
    //JSONNode saveData = new JSONClass();
    //JsonObject saveData = new JsonObject();
    // public JSONObject data = new JSONObject();
    public Dictionary<string, int> heldProphecies = new Dictionary<string, int>();
    
    public void AutoSave() {
        
        
        string savePath = Application.persistentDataPath + "/saveData.txt";
        StreamWriter saveData = new StreamWriter(savePath, true);
        
        //if (newOmen == true) {
            saveData.WriteLine(first_sacrifice.GetStringVariable("endingKey"));
       // }
        //Debug.Log((first_sacrifice.GetStringVariable("endingKey")));
        saveData.Flush();
        saveData.Close();
        //Debug.Log(newOmen);
    }

    public void Load() {
        foreach (string omen in seriesOfProphecies) {
            if (omen == first_sacrifice.GetStringVariable("endingKey") + "  ~") {
                Debug.Log("this works");
            }
            Debug.Log(omen);
        }
        string loadPath = Application.persistentDataPath + "/saveData.txt";
        StreamReader loadData = new StreamReader(loadPath);
        string rawStream = loadData.ReadToEnd();
        
        seriesOfProphecies = rawStream.Split('~');

        

        loadData.Close();
        for(int i = 0; i < seriesOfProphecies.Length; i++) {
            seriesOfOmens.Add(seriesOfProphecies[i]);
        }
        totalOmens = seriesOfOmens.Distinct().ToList().Count();
        main_menu.SetIntegerVariable("numberOfOmens", totalOmens); 
    }


}
