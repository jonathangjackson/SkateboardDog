using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDogs : MonoBehaviour
{

    public Transform SpawnPoint;
    public GameObject prefab;

    void OnTriggerEnter()
    {
        Debug.Log("SPAWN");
        GameObject newDog = Instantiate(prefab, SpawnPoint.position, SpawnPoint.rotation);
        //newDog.gameObject.tag = "NewDog";

        //newDog.AddComponent<Animation>();
        //newDog.AddComponent<Animator>();
        
        //Animator animator = newDog.GetComponent<Animator>();

        //animator.runtimeAnimatorController = Resources.Load("Animations/Dog2") as RuntimeAnimatorController;

        //newDog.GetComponent<Animation>().GetComponent<Animation>().Play("Dog Run");

    }
}
