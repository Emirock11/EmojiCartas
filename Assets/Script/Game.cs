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
        SelectionCard.GetComponent<Renderer>().material = Materials[selectionCardIndex];
        int contPerro=0;
        int contChango=0;
        int contVaca=0;
        bool isValidNum = false;
        int materialIndex = 0;
        for (int i =0; i < Cartas.Length; i++) {
            while (!isValidNum)
            {

                materialIndex = Random.Range(0,3);

                switch (materialIndex)
                {
                    case 0:
                        if (contPerro < 3)
                        {
                            contPerro++;
                            isValidNum = true;
                        }
                    break;

                    case 1:
                        if (contChango < 3)
                        {
                            contChango++;
                            isValidNum = true;
                        }
                        break;

                    case 2:
                        if (contVaca < 3)
                        {
                            contVaca++;
                            isValidNum = true;
                        }
                        break;
                }
                
            }
            isValidNum = false;
            Cartas[i].GetComponent<Renderer>().material = Materials[materialIndex];
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
