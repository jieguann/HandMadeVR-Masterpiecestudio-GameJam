using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetPrefeb = new List<GameObject>();
    public GameObject PlayerPosition;
    private BoxCollider box;

    GameObject temp;

    public List<GameObject> target = new List<GameObject>();

    public int maxofPrefeb;
    private Vector3 GenerateRandomPosition()
    {
        var randomPosition = new Vector3(
            Random.Range(box.bounds.min.x, box.bounds.max.x), 
            Random.Range(box.bounds.min.y, box.bounds.max.y), 
            Random.Range(box.bounds.min.z, box.bounds.max.z));

        return randomPosition;
    }
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>();
        for(int i = 0; i< maxofPrefeb; i++) {
            var randomIndex = Random.Range(0, 2);
            print(randomIndex);
            //remove
            /*
            temp = Instantiate(targetPrefeb[randomIndex], GenerateRandomPosition(), targetPrefeb[randomIndex].transform.rotation);
            temp.tag = "target"+i.ToString();
            target.Add(temp);
            */
            ///uncomment
           target.Add(Instantiate(targetPrefeb[randomIndex], GenerateRandomPosition(), targetPrefeb[randomIndex].transform.rotation));
        }
        
        //SpawnTarget();
    }

    // Update is called once per frame
    void Update()
    {
   
        for (int i = 0; i < maxofPrefeb; i++)
        {
            if(target[i] != null){
                target[i].transform.LookAt(PlayerPosition.transform);
            }
        }
    }
}
