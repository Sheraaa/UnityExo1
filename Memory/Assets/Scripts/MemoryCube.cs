using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCube : MonoBehaviour {
    public Color baseColor;
    private Renderer render;
    bool clicked = false;

	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer>();
        render.material.color = baseColor;
    }

    private void OnMouseDown() {
        if (render.material.color == baseColor) {
            render.material.color = Color.red;
        } else {
            render.material.color = baseColor;
        }
    }


}
