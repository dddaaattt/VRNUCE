using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform[] position;
    public GameObject player;
    public GameObject[] ObjectPositon;
    public GameObject[] UIObject;

    private void Start()
    {
        SetPositonPlayer(0);
    }

    public void SetPositonPlayer(int numberOfPosition)
    {
        foreach (var item in ObjectPositon)
        {
            item.SetActive(true);
        }
        foreach (var item in UIObject)
        {
            item.SetActive(false);
        }
        ObjectPositon[numberOfPosition].SetActive(false);
        UIObject[numberOfPosition].SetActive(true);
        player.transform.position = position[numberOfPosition].position;
        player.transform.rotation = position[numberOfPosition].rotation;
    }
}
