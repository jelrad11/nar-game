using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitInteraction : MonoBehaviour {

    [SerializeField]
    private AudioClip _woosh;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerMovement player = other.GetComponent<PlayerMovement>();
                player.enemiesGone++;

                AudioSource.PlayClipAtPoint(_woosh, transform.position, 1f);

                Destroy(this.gameObject);

                
            }
            
        }
    }
}
