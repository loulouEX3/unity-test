using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject Fireworks;
    public GameObject Sun;
    public GameObject AnimationSun;

    private void OnTriggerStay (Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Sun.SetActive(false);
        Fireworks.SetActive(true);
       // AnimationSun.SetActive(true);
        //StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(3);
        AnimationSun.SetActive(false);
    }
}