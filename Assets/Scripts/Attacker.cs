using UnityEngine;

using System.Collections;

public class Attacker : MonoBehaviour
{
    [Range(-1f, 1.5f)] public float walkSpeed;

	// Use this for initialization
	void Start ()
    {
        Rigidbody2D myRGB = gameObject.AddComponent<Rigidbody2D>();
        myRGB.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(name + " trigger enter");
    }
}
