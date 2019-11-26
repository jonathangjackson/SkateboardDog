using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Forward : MonoBehaviour
{
    private float posA;
    private float posB;
    private float weight;
    private Vector3 start;
    private bool flip;

    private int sourcePos;
    // Start is called before the first frame update
    void Start()
    {
        flip = false;
        weight = 0;
        sourcePos = 0;

        posB = Mathf.Sqrt(Mathf.Pow((this.GetComponent<LookAtConstraint>().GetSource(sourcePos).sourceTransform.position.z - this.GetComponent<Transform>().position.z), 2.0f) + Mathf.Pow(this.GetComponent<LookAtConstraint>().GetSource(sourcePos).sourceTransform.position.x - this.GetComponent<Transform>().position.x, 2.0f));
        start = this.GetComponent<Transform>().position;


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 20;

        posA = Mathf.Sqrt(Mathf.Pow((start.z - this.GetComponent<Transform>().position.z), 2.0f) + Mathf.Pow(start.x - this.GetComponent<Transform>().position.x, 2.0f));
        if (!flip)
        {
            weight = posA / (posB / 2.0f);
            if (weight >= 1.0f)
            {
                flip = true;
                weight = 1.0f;
            }
        }
        else
        {
            weight = (posB / posA) - 1.0f;
            if (weight <= 0.0f && sourcePos < this.GetComponent<LookAtConstraint>().sourceCount)
            {
                ConstraintSource cs = this.GetComponent<LookAtConstraint>().GetSource(sourcePos);
                cs.weight = 0;
                this.GetComponent<LookAtConstraint>().SetSource(sourcePos, cs);
                sourcePos++;
                cs = this.GetComponent<LookAtConstraint>().GetSource(sourcePos);
                cs.weight = 1;
                this.GetComponent<LookAtConstraint>().SetSource(sourcePos, cs);
                posB = Mathf.Sqrt(Mathf.Pow((this.GetComponent<LookAtConstraint>().GetSource(sourcePos).sourceTransform.position.z - this.GetComponent<Transform>().position.z), 2.0f) + Mathf.Pow(this.GetComponent<LookAtConstraint>().GetSource(sourcePos).sourceTransform.position.x - this.GetComponent<Transform>().position.x, 2.0f));
                flip = false;
                weight = 0;
                start = this.GetComponent<Transform>().position;
            }
        }
        if (this.GetComponent<LookAtConstraint>().constraintActive)
        {
            //ConstraintSource cs = this.GetComponent<LookAtConstraint>().GetSource(sourcePos);
            //cs.weight = weight;
            this.GetComponent<LookAtConstraint>().weight = weight;
        }
    }
}
