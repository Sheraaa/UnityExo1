using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGameManager : MonoBehaviour {

    public MemoryCube[] cubes;
    public MemoryCube firstCube;
    public MemoryCube secondCube;
    private int numberOfRemainingPairs;

	// Use this for initialization
	void Start () {
		foreach(MemoryCube cube in cubes) {
            cube.manager = this;
        }
        numberOfRemainingPairs = cubes.Length / 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CubeClicked(MemoryCube cube) {
        if (firstCube == null) {
            cube.Reveal();
            firstCube = cube;
        }else if(firstCube != cube && secondCube == null) {
            cube.Reveal();
            secondCube = cube;
            StartCoroutine(CompareCubesDelayded());
        }
    }

    IEnumerator CompareCubesDelayded() {
        yield return new WaitForSeconds (2f);
        if (secondCube.SecondColor == firstCube.SecondColor) {
            Destroy(firstCube.gameObject);
            Destroy(secondCube.gameObject);
            numberOfRemainingPairs--;
            if(numberOfRemainingPairs <=0) {
                Debug.Log("Vous avez gagné!");
            }
        }
        else {
            secondCube.Hide();
            firstCube.Hide();

        }
        firstCube = null;
        secondCube = null;
    }
}
