using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTimer : MonoBehaviour
{
    public GameObject set1;
    public GameObject set2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("platformSwitch");
        //InvokeRepeating("platform1", 0, 0);
        // InvokeRepeating("platform2", 0, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator platformSwitch()
    {
        while (true)
        {
            new WaitForSeconds(2);
            set1.SetActive(false);
            set2.SetActive(true);

            yield return new WaitForSeconds(2);
            set1.SetActive(true);
            set2.SetActive(false);
        }
    }
    

    void platform1()
    {
        set1.SetActive(true);
        new WaitForSeconds(2);
        set1.SetActive(false);
        new WaitForSeconds(2);
    }

    void platform2()
    {
        set2.SetActive(false);
        new WaitForSeconds(2);
        set2.SetActive(true);
        new WaitForSeconds(2);
    }
}
