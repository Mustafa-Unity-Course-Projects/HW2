using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_sc : MonoBehaviour
{
    public float r;
    public float g;
    public float b;
    public bool isDead = false;
    public float timeToDie = 0;
    SpriteRenderer sRenderer;
    Collider2D sCollider;
    public float s;

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.color = new Color(r, g, b);
        sCollider = GetComponent<Collider2D>();
        transform.localScale = new Vector3(s, s, s);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        isDead = true;
        timeToDie = PopulationManager_sc.elapsed;
        Debug.Log("Dead At: " + timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }
}
