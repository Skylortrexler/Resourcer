using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkNode : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

	private void OnMouseEnter()
	{
        spriteRenderer.color = Color.black;

    }

    private void OnMouseExit()
	{
        spriteRenderer.color = Color.white;

    }
}
