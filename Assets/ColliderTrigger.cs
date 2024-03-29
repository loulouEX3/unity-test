using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject Fireworks;
    public GameObject Sun;
    public GameObject AnimationSun;
    public GameObject Bird;

    private void OnTriggerStay (Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Sun.transform.Rotate(-50, 0, 0);
        Fireworks.SetActive(true);
        Bird.SetActive(false);
    }

    
}