using UnityEngine;

public class SphereController : MonoBehaviour {
    
    BreatheController bc;
    float scale;

	// Use this for initialization
	void Start () {
        bc = GameObject.Find("BreatheWith").GetComponent<BreatheController>();
	}
	
	// Update is called once per frame
	void Update () {
        scale = bc.currReading / 100f - 1f;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
