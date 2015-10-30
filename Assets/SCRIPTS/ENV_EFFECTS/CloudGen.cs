using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CloudGen : MonoBehaviour {
    public List<Cloud> clouds = new List<Cloud>();
    public List<float> cloudPositions = new List<float>();
    public bool generateClouds = true;
	// Use this for initialization
	void Start () {
        generateClouds = true;
        StartCoroutine(GenerateCloud());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator GenerateCloud() {
        while (generateClouds) {
            CloudMake(clouds[Random.Range(0, clouds.Count)]);
            yield return new WaitForSeconds(Random.Range(10, 20));
        }
        yield return null;
        
    }
    void CloudMake(Cloud cloudToMake) {

        Cloud newCloud;

        newCloud = Instantiate(cloudToMake, transform.position + new Vector3(0, cloudPositions[Random.Range(0, cloudPositions.Count)], 0), transform.rotation) as Cloud;
        
    }

}
