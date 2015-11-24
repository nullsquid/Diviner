using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SpecialEndings : MonoBehaviour {

    // Use this for initialization
    public Image red;
    public Image black;
    public Image white;
    void OnLevelWasLoaded(int level) {
        /*foreach(string prophecy in gameObject.GetComponent<PersistentData>().seriesOfProphecies) {
           Debug.Log(prophecy);
           if(prophecy == "Red summer dragon ") {
                Debug.Log("Red Ending");
            }
           if(prophecy == "Black autumn squid ") {
                Debug.Log("Black");
            }
           if(prophecy == "White winter sheep ") {
                Debug.Log("White");
            }
           
        }*/
        if (level == 0) { 
            for (int i = 0; i < gameObject.GetComponent<PersistentData>().seriesOfProphecies.Length; i++) {
                Debug.Log(gameObject.GetComponent<PersistentData>().seriesOfProphecies[i]);
                if (gameObject.GetComponent<PersistentData>().seriesOfProphecies[i] == "Red summer dragon") {
                    Debug.Log("Red Ending");
                    red.enabled = true;
                }
                if (gameObject.GetComponent<PersistentData>().seriesOfProphecies[i] == "Black autumn squid") {
                    Debug.Log("Black");
                    black.enabled = true;
                }
                if (gameObject.GetComponent<PersistentData>().seriesOfProphecies[i] == "White winter sheep") {
                    Debug.Log("White");
                }
            }
         }
	}

	
	// Update is called once per frame
	void Update () {
	
	}
    void ShowRedBadge() {


    }
}
