using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour
{
    public GameObject straightObj;
    public GameObject fifteenObj;
    public GameObject thirtyObj;
    public GameObject ninetyObj;
    public int roadLength = 0;
    Vector3 genPos = new Vector3(0, 0, -438);
    Vector3 genSize = new Vector3(20, 1, 20);
    float rotation = -90f;
    float rotationB = -90;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i< roadLength; i++)
        {
            GameObject clone = null;
            float xMovement = 0.0f;
            switch (Random.Range(0, 4))
            {
                case 0:
                    clone = Instantiate(straightObj, genPos, new Quaternion(0, 0, 0, 0));
                    break;
                case 1:
                    clone = Instantiate(fifteenObj, genPos, new Quaternion(0, 0, 0, 0));
                    rotationB += 30;
                    break;
                case 2:
                    clone = Instantiate(thirtyObj, genPos, new Quaternion(0, 0, 0, 0));
                    rotationB += 60;
                    break;
                case 3:
                    clone = Instantiate(ninetyObj, genPos, new Quaternion(0, 0, 0, 0));
                    rotationB += 90;
                    break;
            }
            clone.GetComponent<Transform>().localScale = genSize;
            clone.transform.rotation = Quaternion.AngleAxis(rotation, Vector3.up);
            clone.transform.position = genPos;
            if(i > 0)
                clone.transform.position += clone.transform.forward * 90;
            clone.name = i.ToString();
            genPos = clone.transform.position;
            rotation = rotationB;
            
            //genPos = new Vector3(genPos.x + xMovement, genPos.y, genPos.z + 101.5f);
        }
        //GameObject clone = Instantiate(straightObj);
        //GameObject secondClone = Instantiate(thirtyObj, new Vector3(clone.GetComponent<Transform>().position.x + 5.075f, clone.GetComponent<Transform>().position.y, clone.GetComponent<Transform>().position.z), new Quaternion(0,0,0,0));//clone.GetComponent<Mesh>().bounds.size.x, 0, 0)
        //GameObject thirdClone = Instantiate(ninetyObj, new Vector3(secondClone.GetComponent<Transform>().position.x + 5.075f, clone.GetComponent<Transform>().position.y, clone.GetComponent<Transform>().position.z), new Quaternion(0, 0, 0, 0));

        //Thirty = rotate 60, fifteen = rotate 30, sixty = ninety 90
        //thirdClone.transform.rotation = Quaternion.AngleAxis(60, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
