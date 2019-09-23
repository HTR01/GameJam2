using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTimer : MonoBehaviour
{
    public GameObject set1;
    public GameObject set2;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("platformSwitch");
       // InvokeRepeating("platform1", 0, 0);
        
        active = true;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator platformSwitch()
    {

           set1.SetActive(false);
           set2.SetActive(true);
           Debug.Log("Part 1");
           new WaitForSeconds(2);

           set1.SetActive(true);
           set2.SetActive(false);
           Debug.Log("Part 2");
           yield return new WaitForSeconds(2);
        
    }
    

    public void platform1()
    {
        set1.SetActive(true);
        set2.SetActive(false);
        new WaitForSeconds(2);
        set1.SetActive(false);
        set2.SetActive(true);
        new WaitForSeconds(2);
    }

    
}
