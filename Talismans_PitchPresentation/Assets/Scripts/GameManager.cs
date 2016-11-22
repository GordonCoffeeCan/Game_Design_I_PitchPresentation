using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    private Transform talismanSmall;
    private Transform talismanMedium;
    private Transform talismanLarge;
    private Transform strokes;
    private Transform talismanExample;
    private Transform weaponExample;
    private Transform fakeEnemy;

    private int objectID;

	// Use this for initialization
	void Start () {
        talismanSmall = GameObject.Find("Talisman_Frame_Small").transform;
        talismanMedium = GameObject.Find("Talisman_Frame_Large").transform;
        talismanLarge = GameObject.Find("Talisman_Frame_Medium").transform;
        strokes = GameObject.Find("Strokes").transform;
        talismanExample = GameObject.Find("Combination_Example").transform;
        weaponExample = GameObject.Find("CombinedWeapon").transform;
        fakeEnemy = GameObject.Find("FakeEnemy").transform;

        objectID = 0;

        talismanSmall.gameObject.SetActive(true);
        talismanMedium.gameObject.SetActive(true);
        talismanLarge.gameObject.SetActive(true);
        strokes.gameObject.SetActive(true);

        talismanExample.gameObject.SetActive(false);
        weaponExample.gameObject.SetActive(false);
        fakeEnemy.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1")) {
            objectID++;
            if (objectID >= 3) {
                objectID = 0;
            }
            switch (objectID) {
                case 0:
                    talismanSmall.gameObject.SetActive(true);
                    talismanMedium.gameObject.SetActive(true);
                    talismanLarge.gameObject.SetActive(true);
                    strokes.gameObject.SetActive(true);

                    talismanExample.gameObject.SetActive(false);
                    weaponExample.gameObject.SetActive(false);
                    fakeEnemy.gameObject.SetActive(false);
                    break;
                case 1:
                    talismanSmall.gameObject.SetActive(false);
                    talismanMedium.gameObject.SetActive(false);
                    talismanLarge.gameObject.SetActive(false);
                    strokes.gameObject.SetActive(false);

                    talismanExample.gameObject.SetActive(true);
                    weaponExample.gameObject.SetActive(false);
                    fakeEnemy.gameObject.SetActive(false);
                    break;
                case 2:
                    talismanSmall.gameObject.SetActive(false);
                    talismanMedium.gameObject.SetActive(false);
                    talismanLarge.gameObject.SetActive(false);
                    strokes.gameObject.SetActive(false);

                    talismanExample.gameObject.SetActive(false);
                    weaponExample.gameObject.SetActive(true);
                    fakeEnemy.gameObject.SetActive(true);
                    break;
            }
        }
	}
}
