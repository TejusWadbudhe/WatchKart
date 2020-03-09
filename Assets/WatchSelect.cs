using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnim;
    Animation w2WindowAnim;
    Animation w3WindowAnim;

    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnim = w1Window.GetComponent<Animation>();
        w2WindowAnim = w2Window.GetComponent<Animation>();
        w3WindowAnim = w3Window.GetComponent<Animation>();
    }

    public void WatchOneButtonClicked()
    {
        Debug.Log("Set Active - 1");
        watchModel1.SetActive(true);
        Debug.Log("Not active - 2");
        watchModel2.SetActive(false);
        Debug.Log("Not Active - 3");
        watchModel3.SetActive(false);

        Debug.Log("W1 Animation");
        w1WindowAnim["w1Anim"].speed = 1;
        w1WindowAnim.Play();
    }

    public void WatchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowAnim["w2Anim"].speed = 1;
        w2WindowAnim.Play();
    }

    public void WatchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3WindowAnim["w3Anim"].speed = 1;
        w3WindowAnim.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName == "w1Close")
        {
            w1WindowAnim["w1Anim"].speed = -1;
            w1WindowAnim["w1Anim"].time = w1WindowAnim["w1Anim"].length;
            w1WindowAnim.Play();
        }else if(buttonName == "w2Close")
        {
            w2WindowAnim["w2Anim"].speed = -1;
            w2WindowAnim["w2Anim"].time = w2WindowAnim["w2Anim"].length;
            w2WindowAnim.Play();
        }
        else if(buttonName == "w3Close")
        {
            w3WindowAnim["w3Anim"].speed = -1;
            w3WindowAnim["w3Anim"].time = w3WindowAnim["w3Anim"].length;
            w3WindowAnim.Play();
        }
    }
}
