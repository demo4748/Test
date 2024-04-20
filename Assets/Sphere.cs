using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;

    public GameObject obj3;

    public GameObject text1;
    public GameObject text2;

    public Transform player;
    public PickUpScript pickup;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("A"))
        {
            Debug.Log("BOX A");
            GameObject text12;
            text12 = Instantiate(text1, transform.position, Quaternion.identity);
            Destroy(text12, 3);
            GameObject ob1;
            ob1 = Instantiate(obj1, transform.position, Quaternion.identity);
            Destroy(ob1, 5);
        }

        if (other.CompareTag("B"))
        {
            Debug.Log("BOX B");
            GameObject text13;
            text13 = Instantiate(text2, transform.position, Quaternion.identity);
            Destroy(text13, 3);
            GameObject ob2;
            ob2=Instantiate(obj2, transform.position, Quaternion.identity);
            Destroy(ob2, 5);
        }

        if (other.CompareTag("C"))
        {
            Debug.Log("BOX C");
            //GameObject ob3;
            //ob3=Instantiate(obj3, transform.position, Quaternion.identity);
            //Destroy(ob3, 5);
            this.gameObject.transform.position = new Vector3(18.81018f,0.4f,29.47633f);
            player.transform.position = new Vector3(18.9036f, 1.08f, 28.3440f);
            player.transform.rotation = new Quaternion(0f, 0.3f, 0f,1);
            pickup.PickUpObject(this.gameObject);
        }
    }
}
