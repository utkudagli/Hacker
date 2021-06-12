using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public Image bg;
    public Text tb;
    public Text press;
    public bool isPhoneChecked = false;
    public Sprite phone;
    int phoneStat = 0;
    bool hacked = false;

    void Start()
    {
        SetInvisible();
    }

    private void SetVisible()
    {
        bg.enabled = true;
        tb.enabled = true;
        press.enabled = true;
    }

    private void SetInvisible()
    {
        bg.enabled = false;
        tb.enabled = false;
        press.enabled = false;
    }

    public void InteractionBed()
    {
        SetVisible();
        tb.text = "I don't want to sleep anymore";
        StartCoroutine(Skip());
    }

    public void WindowInteraction() 
    {
        SetVisible();
        tb.text = "They killed the all lights again.";
        StartCoroutine(Skip());
    }
    public void KitchenInteraction()
    {
        SetVisible();
        tb.text = "I am not hungry";
        StartCoroutine(Skip());
    }
    public void DoorInteraction()
    {
        SetVisible();
        tb.text = "Can't go anywhere";
        StartCoroutine(Skip());
    }

    public void PCInteraction()
    {
        if (!hacked)
        {
            if (!isPhoneChecked)
            {
                SetVisible();
                tb.text = "I don't want to check my computer.";
            }
            else
            {
                phoneStat = 0;
                SceneManager.LoadScene("TheCyberNet", 0);
            }
        }
        else
        {
            SetVisible();
            tb.text = "I don't want to check my computer.";
        }
    }
    public void PhoneInteraction()
    {
        if (!hacked)
        {
            isPhoneChecked = true;
            SetVisible();
            if (phoneStat == 0)
            {
                tb.text = "Hey mate! I know you are in pain. But please, don't do something stupid. I'll see you tomorrow.";
                StartCoroutine(Wait());
                phoneStat++;
            }
            else if (phoneStat == 1)
            {
                tb.text = "New message received!";
                StartCoroutine(Wait());
                phoneStat++;
            }
            else if (phoneStat == 2)
            {

                tb.text = "Hello, I know what have EvilCorp. done to your parents. I know you want revenge. I will give you what you want but first you need to" +
                    " bring something what i need.";
                StartCoroutine(Wait());
                phoneStat++;
            }
            else
            {
                tb.text = "I have send the information to your computer. After you've succeeded sent me the documents, then I will contact you.";
                StartCoroutine(Skip());
            }
        }
        else
        {
            SetVisible();
            if (phoneStat == 0)
            {
                tb.text = "Thank you! I have received the documents. Before, I tell you what happened to your parents, I must say something very important.";
                StartCoroutine(Wait());
                phoneStat++;
            }
            else if (phoneStat == 1)
            {
                tb.text = "The server that you've entered was protected by two different protection method. The first one was a simple firewall. But I wasn't sure what was" +
                    "the second one.";
                StartCoroutine(Wait());
                phoneStat++;
            }
            else if (phoneStat == 2)
            {
                tb.text = "Now I am sure. The second one was location locator they are now where are you now. Probably they are at the middle of the way." +
                    "So good luck.";
                StartCoroutine(Wait());
                phoneStat++;
            }
            else{
                tb.text = "Thank you for playing! :).  Please press any button to close the game.";
                StartCoroutine(WaitToClose());

            }
        }
        
    }

    private IEnumerator Skip()
    {
        yield return new WaitForSeconds(0.5f);
        yield return WaitForKeyPress();
    }
    private IEnumerator WaitForKeyPress()
    {
        bool done = false;
        while (!done)
        {
            if (Input.anyKey) {
                done = true;
                tb.text = "";
                SetInvisible();
            }
            yield return null;
        }
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        yield return WaitForKey();
    }
    private IEnumerator WaitForKey()
    {
        bool done = false;
        while (!done)
        {
            if (Input.anyKey)
            {
                done = true;
            }
            yield return null;
        }
    }
    private IEnumerator WaitToClose()
    {
        yield return new WaitForSeconds(0.5f);
        yield return PressToClose();
    }
    private IEnumerator PressToClose()
    {
        bool done = false;
        while (!done)
        {
            if (Input.anyKey)
            {
                done = true;
                Application.Quit();
            }
            yield return null;
        }
    }
}
