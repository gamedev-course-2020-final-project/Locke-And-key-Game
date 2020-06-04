using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * This class control the situation on game in Level 1
 */
public class Level1 : MonoBehaviour
{
    [SerializeField] GameObject mirrorKey;
    [SerializeField] GameObject clothMirror;
    [SerializeField] GameObject standingMirror;
    [SerializeField] GameObject player;
    [SerializeField] GameObject mother;
    [SerializeField] GameObject mirrorCard;

    private Animator mirror_key_animator;
    private bool isFirst = true;
    private bool isSecond = false;

    
   



    // Start is called before the first frame update
    void Start()
    {
        mirror_key_animator = mirrorKey.GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {

        state1();
        state2();
    }




    /*private void playTheVideo()
    {
        if (isFirst)
        {
            Debug.Log("Played the video");
            StartCoroutine(GameObject.Find("MotherVideo").GetComponent<StreamVideo>().PlayVideo());
            if (clothMirror != null)
            {
                StartCoroutine(clothMirror.GetComponent<BreakMirror>().Break());
            }
            mirrorKey.GetComponent<Animator>().enabled = false;
            Destroy(mother);
            isFirst = false;
        }
    }*/

    void state1()
    {
        AnimatorStateInfo state = mirror_key_animator.GetCurrentAnimatorStateInfo(0);
        
        //if the animation of key in cloth mirror finish start the first mission
        if (state.IsName("Rotate") && state.normalizedTime > 0.9f && state.normalizedTime < 1f)
        {
            
            StartCoroutine(playMotherAnimation());
        }
    }

    void state2()
    {
        if (isSecond)
        {
            //UI first for first mission(text box)

            AnimatorStateInfo state = mirror_key_animator.GetCurrentAnimatorStateInfo(0);
            //GameObject mirror2_hole =  mirrorKey.GetComponent<KeyProperties>().currentHole;
            if (state.IsName("Rotate2") && state.normalizedTime > 0.9f && state.normalizedTime < 1f)
            {
                Debug.Log("state2 begin");
                DontDestroyOnLoad(player);
                DontDestroyOnLoad(mirrorKey);
                SceneManager.LoadScene("MirrorRoom");
            }
        }
    }

    IEnumerator playMotherAnimation()
    {
        if (isFirst)
        {
            Debug.Log("first mission begin");
            isFirst = false;
            Animator mom_animator = mother.GetComponent<Animator>();
            mom_animator.SetBool("isMission1Start", true);
            mom_animator.Play("mission1");
            yield return new WaitForSeconds(10);
            Destroy(mother);
            StartCoroutine(clothMirror.GetComponent<BreakMirror>().Break());
            yield return new WaitForSeconds(2);
            mirrorKey.GetComponent<Animator>().enabled = false;
            GameObject text = GameObject.Find("New Text");
            text.GetComponent<MeshRenderer>().enabled = true;
            yield return new WaitForSeconds(6);
            text.GetComponent<MeshRenderer>().enabled = false;
            isSecond = true;
        }
    }
}
