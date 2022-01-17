using eWolf.BookEffectV2.Interfaces;
using UnityEngine;
using TMPro;




public class BookController : MonoBehaviour
{
    public GameObject BookObject;

    public int pageCount = 0;
    public int endPageNum = 11;
    public TextMeshPro textMeshPro;
    private IBookControl _bookControl;
    public GameObject[] infographics;
    public GameObject spawnPos;

    public GameObject nextButton;
    //TextMeshPro textmeshPro = null;

    private GameObject currentObject = null;

    public GameObject beforeButton;



    public void Start()
    {
        beforeButton.SetActive(false);


    }
    public void turnNext()
    {

        pageCount++;
        textMeshPro.text = pageCount.ToString();


        spawnInfoObject();

        if (pageCount == endPageNum)
        {
            nextButton.SetActive(false);
        }


        if (!beforeButton.activeInHierarchy)
        {
            beforeButton.SetActive(true);
        }

    }

    public void turnBefore()
    {

        pageCount--;

        textMeshPro.text = pageCount.ToString();

        spawnInfoObject();


        if (pageCount == 0)
        {
            beforeButton.SetActive(false);
        }
        else if (!nextButton.activeInHierarchy)
        {
            nextButton.SetActive(true);
        }


    }

    void spawnInfoObject()
    {

        if (currentObject != null)
        {
            Destroy(currentObject);
        }

        if (infographics[pageCount] != null)
        {
            currentObject = Instantiate(infographics[pageCount], infographics[pageCount].transform.position + spawnPos.transform.position,  spawnPos.transform.rotation );

        }

    }






}