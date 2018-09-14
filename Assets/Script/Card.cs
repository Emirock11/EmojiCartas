using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    // Use this for initialization

    public GameObject MainG;
    private bool used=false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Restart() {
        used = false;
    }

    void OnMouseDown()
    {
        
        if (!used)
        {
            MainG.SendMessage("OnCardClick", this.gameObject.GetComponent<Renderer>().material);
            used = true;
        }
    }
}
