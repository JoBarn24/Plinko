using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*Transform siblingTransform = GetComponent<Transform>();
        Vector3 spawnPos = siblingTransform.position;
        
        //create new ball instance at position
        GameObject newObj = Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        Debug.Log(newObj.name);*/
    }

    // Update is called once per frame
    void Update()
    {
        //if input being used, then spawn more
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform siblingTransform = GetComponent<Transform>();
            Vector3 spawnPos = siblingTransform.position;
        
            //create new ball instance at position
            Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        }
    }
}
