using UnityEngine;
using Random = System.Random;


public class TriggerBoom : MonoBehaviour
{
    public GameObject[] boom;
    private Random _random = new Random();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Boom");
        for (int i = 0; i < boom.Length; i++)
        {
            if(i == 0)
                boom[i].GetComponent<Rigidbody>().AddForce(new Vector3(-3,1,0),ForceMode.Impulse);
            if(i == 1)
                boom[i].GetComponent<Rigidbody>().AddForce(new Vector3(3,1,0),ForceMode.Impulse);
            if(i == 2)
                boom[i].GetComponent<Rigidbody>().AddForce(new Vector3(0,1,-3),ForceMode.Impulse);
            if(i == 3)
                boom[i].GetComponent<Rigidbody>().AddForce(new Vector3(0,1,3),ForceMode.Impulse);
            else
            {
                boom[i].GetComponent<Rigidbody>().AddForce(new Vector3(_random.Next(-3,3),1,_random.Next(-3,3)),ForceMode.Impulse);
            }
            
        }
        
    }
}
