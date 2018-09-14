using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class Game : MonoBehaviour {
    public GameObject Button;
    public Material[] Materials;
    public GameObject[] Cartas;
    public Material[] Numbers;
    public GameObject CardNumber;
    public GameObject SelectionCard;
    private int contObjective = 0;
    private int actualCont = 0;
    private Material materialObj = null;
    public GameObject WinSpryte;
    public GameObject LooseSpryte;



    // Use this for initialization
    void Start () {

        StartGame();
    }

    void OnCardClick(Material cardMaterial)
    {
        string materialName = cardMaterial.mainTexture.name;
        string materialObjString = materialObj.mainTexture.name;

        if(materialName == materialObjString)
        {
            actualCont++;
            if(actualCont == contObjective)
            {
                //Ya ganaste
                Debug.Log("Ganaste");
                Button.SetActive(true);
                WinSpryte.SetActive(true);
            }
        }
        else
        {
            //Ya Perdiste
            Debug.Log("Perdiste");
            Button.SetActive(true);
            LooseSpryte.SetActive(true);
        }
        
    }

    void Restart()
    {
        Button.SetActive(false);
        StartGame();
        for(int i=0; i < Cartas.Length; i++)
        {
            Cartas[i].SendMessage("Restart");

        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void StartGame()
    {
        WinSpryte.SetActive(false);
        LooseSpryte.SetActive(false);
        contObjective = 0;
        actualCont = 0;
        materialObj = null;
        Button.SetActive(false);
        int cardNumIndex = Random.Range(0, 3);
        contObjective = cardNumIndex + 1;
        int selectionCardIndex = Random.Range(0, 3);
        SelectionCard.GetComponent<Renderer>().material = Materials[selectionCardIndex];
        CardNumber.GetComponent<Renderer>().material = Numbers[cardNumIndex];
        materialObj = Materials[selectionCardIndex];
        int contPerro = 0;
        int contChango = 0;
        int contVaca = 0;
        bool isValidNum = false;
        int materialIndex = 0;
        for (int i = 0; i < Cartas.Length; i++)
        {
            while (!isValidNum)
            {

                materialIndex = Random.Range(0, 3);

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

}
