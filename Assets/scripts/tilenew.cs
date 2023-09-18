/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilenew : MonoBehaviour
{
    public GameObject[] section;
    public int zpos = 150;
    public bool creatingasection = false;
    public int setnum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!creatingasection)
        {
            creatingasection = true;
            StartCoroutine(genaratesection());
        }
    }
    IEnumerator genaratesection()
    {
        setnum=Random.Range(0,4);
        Instantiate(section[setnum],new Vector3(0,0,zpos ),Quaternion.identity);
        zpos += 150;
        yield return new WaitForSeconds(2);
        creatingasection=false;
    }

}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilenew : MonoBehaviour
{
    public GameObject[] section;
    public int zpos = 150;
    public int sectionSpacing = 150; // Distance between sections
    public bool creatingasection = false;
    public int setnum;

    private List<GameObject> instantiatedSections = new List<GameObject>();
    private Transform player; // Reference to the player's transform

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Assuming the player has a tag "Player"
    }

    // Update is called once per frame
    void Update()
    {
        if (!creatingasection && ShouldCreateSection())
        {
            creatingasection = true;
            StartCoroutine(GenerateSection());
        }
    }

   

    IEnumerator GenerateSection()
    {
        setnum = Random.Range(0, section.Length);
        GameObject newSection = Instantiate(section[setnum], new Vector3(0, 0, zpos), Quaternion.identity);
        instantiatedSections.Add(newSection);

        zpos += sectionSpacing;
        yield return new WaitForSeconds(0);

        DestroyOldestSection();
        creatingasection = false;
    }
 bool ShouldCreateSection()
    {
        // Calculate a threshold distance ahead of the player to create the next section
        float thresholdDistance = player.position.z + 300f;
        return zpos <= thresholdDistance;
    }
    void DestroyOldestSection()
    {
        if (instantiatedSections.Count > 8)
        {
            GameObject oldestSection = instantiatedSections[0];
            instantiatedSections.RemoveAt(0);
            Destroy(oldestSection);
        }
    }
}