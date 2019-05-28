using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCube : MonoBehaviour {
    public Color baseColor;
    public Color SecondColor;
    private Renderer render;
    public MemoryGameManager manager;

	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer>();
        render.material.color = baseColor;
    }

    public void Reveal() {
        render.material.color = SecondColor;
    }

    public void Hide() {
        render.material.color = baseColor;
    }


    private void OnMouseDown() {
        //if (render.material.color == baseColor) {
        //    render.material.color = Color.red;
        //} else {
        //    render.material.color = baseColor;
        //}

        manager.CubeClicked(this);
    }


}
