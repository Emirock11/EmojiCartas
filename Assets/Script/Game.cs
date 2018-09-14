using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Game : MonoBehaviour {

    public Material[] Materials;
    public GameObject[] Cartas;
    public Material[] Numbers;
    public GameObject CardNumber;
    public GameObject SelectionCard;
    


    // Use this for initialization
    void Start () {
        int cardNumIndex = Random.Range(0,3);
        int selectionCardIndex = Random.Range(0, 3);
        SelectionCard.GetComponent<Renderer>().material = Materials[selectionCardIndex];
        CardNumber.GetComponent<Renderer>().material = Numbers[cardNumIndex];

        for(int i =0; i < Cartas.Length; i++) {
            int materialIndex = Random.Range(0, 3);
            Cartas[i].GetComponent<Renderer>().material = Materials[materialIndex];
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
