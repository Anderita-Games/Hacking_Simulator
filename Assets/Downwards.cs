using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Downwards : MonoBehaviour
{
    public UnityEngine.UI.InputField Command;
    public UnityEngine.UI.Text line1;
    public UnityEngine.UI.Text line2;
    public UnityEngine.UI.Text line3;
    public UnityEngine.UI.Text line4;
    public UnityEngine.UI.Text line5;
    public UnityEngine.UI.Text line6;
    public UnityEngine.UI.Text line7;
    public UnityEngine.UI.Text line8;
    public UnityEngine.UI.Text line9;
    public UnityEngine.UI.Text line10;
    public UnityEngine.UI.Text line11;
    public UnityEngine.UI.Text line12;
    public UnityEngine.UI.Text line13;
    public UnityEngine.UI.Text line14;
    public UnityEngine.UI.Text line15;
    public UnityEngine.UI.Text line16;
    public UnityEngine.UI.Text line17;
    public UnityEngine.UI.Text line18;
    public UnityEngine.UI.Text line19;
    public UnityEngine.UI.Text line20;
    public UnityEngine.UI.Text line21;
    public UnityEngine.UI.Text line22;
    public UnityEngine.UI.Text line23;
    public UnityEngine.UI.Text line24;
    public UnityEngine.UI.Text line25;
    public UnityEngine.UI.Text line26;
    public UnityEngine.UI.Text line27;
    public UnityEngine.UI.Text line28;
    public UnityEngine.UI.Text line29;
    public UnityEngine.UI.Text line30;
    public UnityEngine.UI.Text line31;
    public UnityEngine.UI.Text line32;
    public UnityEngine.UI.Text line33;
    public UnityEngine.UI.Text line34;
    public UnityEngine.UI.Text line35;
    public UnityEngine.UI.Text line36;
    public UnityEngine.UI.Text line37;
    public UnityEngine.UI.Text line38;
    public UnityEngine.UI.Text line39;
    public UnityEngine.UI.Text line40;
    public UnityEngine.UI.Text line41;
    public UnityEngine.UI.Text line42;
    public UnityEngine.UI.Text line43;
    public UnityEngine.UI.Text line44;
    public UnityEngine.UI.Text line45;
    public UnityEngine.UI.Text line46;
    public UnityEngine.UI.Text line47;
    public UnityEngine.UI.Text line48;
    public string level;
    public string username;
    public int strike;
    public virtual void Start()
    {
        this.line46.text = "Welcome to Proletariat!";
        this.line47.text = "The Ultimate hacking text adventure made by Andrew Friedman";
        this.line48.text = "Type 'help' for a list of commands";
    }

    public virtual void Update()
    {
    }

    public virtual void Commander()
    {
        this.transition();
        this.line48.text = this.Command.text;
        this.transition();
        if (this.level == "index")
        {
            if (this.Command.text == "help")
            {
                this.line48.text = "Command List:";
                this.transition();
                this.line48.text = " help";
                this.transition();
                this.line48.text = " start";
                this.transition();
                this.line48.text = " cls";
                this.transition();
                this.line48.text = " files";
                this.transition();
                this.line48.text = " pl";
                this.transition();
                this.line48.text = " exit";
            }
            else
            {
                if (this.Command.text == "help start") //Help ifs ↓
                {
                    this.line48.text = "FUNCTION: Starts Programs";
                }
                else
                {
                    if (this.Command.text == "help cls")
                    {
                        this.line48.text = "FUNCTION: Clears Screen";
                    }
                    else
                    {
                        if (this.Command.text == "help files")
                        {
                            this.line48.text = "FUNCTION: Shows list of files on computer";
                        }
                        else
                        {
                            if (this.Command.text == "help pl")
                            {
                                this.line48.text = "FUNCTION: Shows list of programs";
                            }
                            else
                            {
                                if (this.Command.text == "help exit")
                                {
                                    this.line48.text = "FUNCTION: Exits Program";
                                }
                                else
                                {
                                    if (this.Command.text == "start") //Start ifs ↓
                                    {
                                        this.line48.text = "ERROR: Define program that is starting";
                                    }
                                    else
                                    {
                                        if (this.Command.text == "start mail")
                                        {
                                            this.line48.text = "Loading Mail...";
                                            this.transition();
                                            this.line48.text = "Mail loaded";
                                            this.transition();
                                            this.line48.text = "Type help for a list of commands";
                                            this.level = "mail";
                                        }
                                        else
                                        {
                                            if (this.Command.text == "start news")
                                            {
                                                this.line48.text = "ERROR: Currently Unavailable";
                                            }
                                            else
                                            {
                                                if (this.Command.text == "start web")
                                                {
                                                    this.line48.text = "ERROR: Currently Unavailable";
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "cls")
                                                    {
                                                        this.clear();
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "files")
                                                        {
                                                            this.line48.text = "Files:";
                                                            if (PlayerPrefs.GetInt("Expense") == 1)
                                                            {
                                                                this.transition();
                                                                this.line48.text = " EXPENSE REPORT";
                                                            }
                                                            else
                                                            {
                                                                if (PlayerPrefs.GetInt("Security") == 1)
                                                                {
                                                                    this.transition();
                                                                    this.line48.text = " MAXIMUM SECURITY PASS";
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (this.Command.text == "pl")
                                                            {
                                                                this.line48.text = "Programs:";
                                                                this.transition();
                                                                this.line48.text = " mail";
                                                                this.transition();
                                                                this.line48.text = " news";
                                                                this.transition();
                                                                this.line48.text = " web";
                                                                if (PlayerPrefs.GetInt("Hacking") == 1)
                                                                {
                                                                    this.transition();
                                                                    this.line48.text = " hack";
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if ((this.Command.text == "start hack") && (PlayerPrefs.GetInt("Hacking") == 1))
                                                                {
                                                                    this.level = "hack";
                                                                    this.line48.text = "Starting Hacking Program...";
                                                                    this.line48.text = "Program loaded >:)";
                                                                }
                                                                else
                                                                {
                                                                    this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            if (this.level == "mail")
            {
                if (this.Command.text == "help")
                {
                    this.line48.text = "Command List:";
                    this.transition();
                    this.line48.text = " help";
                    this.transition();
                    this.line48.text = " ls";
                    this.transition();
                    this.line48.text = " cls";
                    this.transition();
                    this.line48.text = " open";
                    this.transition();
                    this.line48.text = " exit";
                }
                else
                {
                    if (this.Command.text == "help ls")
                    {
                        this.line48.text = "FUNCTION: Shows list of emails";
                    }
                    else
                    {
                        if (this.Command.text == "help cls")
                        {
                            this.line48.text = "FUNCTION: Clears screen";
                        }
                        else
                        {
                            if (this.Command.text == "ls")
                            {
                                this.line48.text = "Mail:";
                                this.transition();
                                this.line48.text = " welcome";
                                if (PlayerPrefs.GetInt("Jeff") == 1)
                                {
                                    this.transition();
                                    this.line48.text = " jeff";
                                }
                                else
                                {
                                    if (PlayerPrefs.GetInt("Andrew") == 1)
                                    {
                                        this.transition();
                                        this.line48.text = " andrew";
                                    }
                                    else
                                    {
                                        if (PlayerPrefs.GetInt("Done") == 1)
                                        {
                                            this.transition();
                                            this.line48.text = " done";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (this.Command.text == "cls")
                                {
                                    this.clear();
                                }
                                else
                                {
                                    if (this.Command.text == "open welcome")
                                    {
                                        this.line48.text = "Subject: Hello";
                                        this.transition();
                                        this.line48.text = "To: you";
                                        this.transition();
                                        this.line48.text = "From: ";
                                        this.transition();
                                        this.line48.text = "By opening this email, you have downloaded the hacking program.";
                                        this.transition();
                                        this.line48.text = "I need you to hack into Alice's account";
                                        this.transition();
                                        this.line48.text = "She isnt the brightest";
                                        PlayerPrefs.SetInt("Hacking", 1);
                                    }
                                    else
                                    {
                                        if (this.Command.text == "open jeff")
                                        {
                                            this.line48.text = "Subject: Jeff";
                                            this.transition();
                                            this.line48.text = "To: you";
                                            this.transition();
                                            this.line48.text = "From: ";
                                            this.transition();
                                            this.line48.text = "Now its time to hack Jeff.";
                                            this.transition();
                                            this.line48.text = "As you cn tell he has a thing for Alice.";
                                            this.transition();
                                            this.line48.text = "Good Luck!";
                                        }
                                        else
                                        {
                                            if (this.Command.text == "open andrew")
                                            {
                                                this.line48.text = "Subject: Andrew";
                                                this.transition();
                                                this.line48.text = "To: you";
                                                this.transition();
                                                this.line48.text = "From: ";
                                                this.transition();
                                                this.line48.text = "Andrew has access to a lot of things.";
                                                this.transition();
                                                this.line48.text = "He doesnt care about his job since he is very new.";
                                                this.transition();
                                                this.line48.text = "Good Luck!";
                                            }
                                            else
                                            {
                                                if (this.Command.text == "open done")
                                                {
                                                    this.line48.text = "Subject: Done for now";
                                                    this.transition();
                                                    this.line48.text = "To: you";
                                                    this.transition();
                                                    this.line48.text = "From: ";
                                                    this.transition();
                                                    this.line48.text = "Good job!";
                                                    this.transition();
                                                    this.line48.text = "keep on exploring for more evidence.";
                                                    this.transition();
                                                    this.line48.text = "I may not contact you for a while!";
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "exit")
                                                    {
                                                        this.level = "index";
                                                        this.line48.text = "Going back to index";
                                                    }
                                                    else
                                                    {
                                                        this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (this.level == "hack")
                {
                    if (this.Command.text == "help")
                    {
                        this.line48.text = "Command List:";
                        this.transition();
                        this.line48.text = " help";
                        this.transition();
                        this.line48.text = " login";
                        this.transition();
                        this.line48.text = " cls";
                        this.transition();
                        this.line48.text = " exit";
                    }
                    else
                    {
                        if (this.Command.text == "help login")
                        {
                            this.line48.text = "FUNCTION: goes to login screen";
                        }
                        else
                        {
                            if (this.Command.text == "help cls")
                            {
                                this.line48.text = "FUNCTION: Clears ";
                            }
                            else
                            {
                                if (this.Command.text == "login")
                                {
                                    this.level = "login";
                                    this.line48.text = "Username:";
                                }
                                else
                                {
                                    if (this.Command.text == "cls")
                                    {
                                        this.clear();
                                    }
                                    else
                                    {
                                        if (this.Command.text == "exit")
                                        {
                                            this.level = "index";
                                        }
                                        else
                                        {
                                            this.line48.text = ("Command " + this.Command.text) + " not found!";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (this.level == "login")
                    {
                        if (this.username == "")
                        {
                            this.username = this.Command.text;
                            this.line48.text = "Password:";
                        }
                        else
                        {
                            if (this.strike != 0)
                            {
                                if ((this.username == "alice") && (this.Command.text == "password"))
                                {
                                    this.level = "alice";
                                    this.line48.text = "LOGIN SUCCESSFUL";
                                    this.username = "";
                                }
                                else
                                {
                                    if ((this.username == "jeff") && (this.Command.text == "alice"))
                                    {
                                        this.level = "jeff";
                                        this.line48.text = "LOGIN SUCCESSFUL";
                                        this.username = "";
                                    }
                                    else
                                    {
                                        if ((this.username == "andrew") && (this.Command.text == ""))
                                        {
                                            this.level = "andrew";
                                            this.line48.text = "LOGIN SUCCESSFUL";
                                            PlayerPrefs.SetInt("Done", 1);
                                            this.username = "";
                                        }
                                        else
                                        {
                                            if ((this.username == "michael") && (this.Command.text == "is the best"))
                                            {
                                                this.level = "michael";
                                                this.line48.text = "LOGIN SUCCESSFUL";
                                                this.username = "";
                                            }
                                            else
                                            {
                                                if ((this.username == "osaze") && (this.Command.text == "baseball"))
                                                {
                                                    this.level = "osaze";
                                                    this.line48.text = "LOGIN SUCCESSFUL";
                                                    this.username = "";
                                                }
                                                else
                                                {
                                                    if ((this.username == "bob") && (this.Command.text == "alice"))
                                                    {
                                                        this.level = "bob";
                                                        this.line48.text = "LOGIN SUCCESSFUL";
                                                        this.username = "";
                                                    }
                                                    else
                                                    {
                                                        this.line48.text = "PASSWORD INCORRECT";
                                                        this.transition();
                                                        this.strike = this.strike - 1;
                                                        this.line48.text = ("YOU HAVE " + this.strike) + " TRIES LEFT!";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (this.strike == 0)
                                {
                                    this.line48.text = "FAILURE TO LOGIN";
                                    this.transition();
                                    this.strike = 3;
                                    this.username = "";
                                    this.line48.text = "EXITING LOGIN...";
                                    this.level = "hack";
                                    this.line48.text = "Going back to program 'Hack'";
                                }
                            }
                        }
                    }
                    else
                    {
                        if (this.level == "alice")
                        {
                            if (this.Command.text == "help")
                            {
                                this.line48.text = "Command List:";
                                this.transition();
                                this.line48.text = " help";
                                this.transition();
                                this.line48.text = " ls";
                                this.transition();
                                this.line48.text = " cls";
                                this.transition();
                                this.line48.text = " open";
                                this.transition();
                                this.line48.text = " exit";
                            }
                            else
                            {
                                if (this.Command.text == "help ls")
                                {
                                    this.line48.text = "FUNCTION: Shows list of emails";
                                }
                                else
                                {
                                    if (this.Command.text == "help cls")
                                    {
                                        this.line48.text = "FUNCTION: Clears screen";
                                    }
                                    else
                                    {
                                        if (this.Command.text == "ls")
                                        {
                                            this.line48.text = "Mail:";
                                            this.transition();
                                            this.line48.text = " alice #1";
                                            this.transition();
                                            this.line48.text = " alice #2";
                                        }
                                        else
                                        {
                                            if (this.Command.text == "cls")
                                            {
                                                this.clear();
                                            }
                                            else
                                            {
                                                if (this.Command.text == "open alice #1")
                                                {
                                                    this.line48.text = "To: Alice@Ticon.com";
                                                    this.transition();
                                                    this.line48.text = "From: Jeff@Ticon.com";
                                                    this.transition();
                                                    this.line48.text = "We should do something sometime!";
                                                    this.transition();
                                                    this.line48.text = "How about going to the baseball game";
                                                    this.transition();
                                                    this.line48.text = "with me and Osaze?";
                                                    PlayerPrefs.SetInt("Jeff", 1);
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "open alice #2")
                                                    {
                                                        this.line48.text = "To: Jeff@Ticon.com";
                                                        this.transition();
                                                        this.line48.text = "From: Alice@Ticon.com";
                                                        this.transition();
                                                        this.line48.text = "I would love to do that,";
                                                        this.transition();
                                                        this.line48.text = "but I cant because I already told";
                                                        this.transition();
                                                        this.line48.text = "Bob I would grab a drink with him.";
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "exit")
                                                        {
                                                            this.level = "hack";
                                                            this.line48.text = "Going back to program 'Hack'";
                                                        }
                                                        else
                                                        {
                                                            this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (this.level == "jeff")
                            {
                                if (this.Command.text == "help")
                                {
                                    this.line48.text = "Command List:";
                                    this.transition();
                                    this.line48.text = " help";
                                    this.transition();
                                    this.line48.text = " ls";
                                    this.transition();
                                    this.line48.text = " cls";
                                    this.transition();
                                    this.line48.text = " open";
                                    this.transition();
                                    this.line48.text = " exit";
                                }
                                else
                                {
                                    if (this.Command.text == "help ls")
                                    {
                                        this.line48.text = "FUNCTION: Shows list of emails";
                                    }
                                    else
                                    {
                                        if (this.Command.text == "help cls")
                                        {
                                            this.line48.text = "FUNCTION: Clears screen";
                                        }
                                        else
                                        {
                                            if (this.Command.text == "ls")
                                            {
                                                this.line48.text = "Mail:";
                                                this.transition();
                                                this.line48.text = " jeff #1";
                                                this.transition();
                                                this.line48.text = " jeff #2";
                                                this.transition();
                                                this.line48.text = " jeff #3";
                                                this.transition();
                                                this.line48.text = " jeff #4";
                                            }
                                            else
                                            {
                                                if (this.Command.text == "cls")
                                                {
                                                    this.clear();
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "open jeff #1")
                                                    {
                                                        this.line48.text = "To: Osaze@Ticon.com";
                                                        this.transition();
                                                        this.line48.text = "From: Jeff@Ticon.com";
                                                        this.transition();
                                                        this.line48.text = "Dude she cant make it because";
                                                        this.transition();
                                                        this.line48.text = "of freaking Bob!";
                                                        this.transition();
                                                        this.line48.text = "BOB IS THE WORST!";
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "open jeff #2")
                                                        {
                                                            this.line48.text = "To: Bob@Ticon.com";
                                                            this.transition();
                                                            this.line48.text = "From: Alice@Ticon.com";
                                                            this.transition();
                                                            this.line48.text = "Not cool bro,";
                                                            this.transition();
                                                            this.line48.text = "you knew I had a thing for her.";
                                                        }
                                                        else
                                                        {
                                                            if (this.Command.text == "open jeff #3")
                                                            {
                                                                this.line48.text = "To: Michael@Ticon.com";
                                                                this.transition();
                                                                this.line48.text = "From: Jeff@Ticon.com";
                                                                this.transition();
                                                                this.line48.text = "Hey boss,";
                                                                this.transition();
                                                                this.line48.text = "there are some holes in this expense report";
                                                                this.transition();
                                                                this.line48.text = "I would print it and drop it off in you office,";
                                                                this.transition();
                                                                this.line48.text = "but the printer isnt working.";
                                                                this.transition();
                                                                this.line48.text = "{DOWNLOADED EXPENSE REPORT}";
                                                                PlayerPrefs.SetInt("Expense", 1);
                                                            }
                                                            else
                                                            {
                                                                if (this.Command.text == "open jeff #4")
                                                                {
                                                                    this.line48.text = "To: Andrew@TechHelp.com";
                                                                    this.transition();
                                                                    this.line48.text = "From: Jeff@Ticon.com";
                                                                    this.transition();
                                                                    this.line48.text = "Hey new guy,";
                                                                    this.transition();
                                                                    this.line48.text = "the printer isnt working.";
                                                                    this.transition();
                                                                    this.line48.text = "fix it";
                                                                    PlayerPrefs.SetInt("Andrew", 1);
                                                                }
                                                                else
                                                                {
                                                                    if (this.Command.text == "exit")
                                                                    {
                                                                        this.level = "hack";
                                                                        this.line48.text = "Going back to program 'Hack'";
                                                                    }
                                                                    else
                                                                    {
                                                                        this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (this.level == "andrew")
                                {
                                    if (this.Command.text == "help")
                                    {
                                        this.line48.text = "Command List:";
                                        this.transition();
                                        this.line48.text = " help";
                                        this.transition();
                                        this.line48.text = " ls";
                                        this.transition();
                                        this.line48.text = " cls";
                                        this.transition();
                                        this.line48.text = " open";
                                        this.transition();
                                        this.line48.text = " exit";
                                    }
                                    else
                                    {
                                        if (this.Command.text == "help ls")
                                        {
                                            this.line48.text = "FUNCTION: Shows list of emails";
                                        }
                                        else
                                        {
                                            if (this.Command.text == "help cls")
                                            {
                                                this.line48.text = "FUNCTION: Clears screen";
                                            }
                                            else
                                            {
                                                if (this.Command.text == "ls")
                                                {
                                                    this.line48.text = "Mail:";
                                                    this.transition();
                                                    this.line48.text = " andrew #1";
                                                    this.transition();
                                                    this.line48.text = " andrew #2";
                                                    this.transition();
                                                    this.line48.text = " andrew #3";
                                                    this.transition();
                                                    this.line48.text = " andrew #4";
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "cls")
                                                    {
                                                        this.clear();
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "open andrew #1")
                                                        {
                                                            this.line48.text = "To: Jeff@Ticon.com";
                                                            this.transition();
                                                            this.line48.text = "From: Andrew@TechHelp.com";
                                                            this.transition();
                                                            this.line48.text = "K";
                                                            this.transition();
                                                            this.line48.text = "I'll look at the printer on friday";
                                                            this.transition();
                                                            this.line48.text = "BOB IS THE WORST!";
                                                        }
                                                        else
                                                        {
                                                            if (this.Command.text == "open andrew #2")
                                                            {
                                                                this.line48.text = "To: Ester@TechHelp.com";
                                                                this.transition();
                                                                this.line48.text = "From: Andrew@TechHelp.com";
                                                                this.transition();
                                                                this.line48.text = "Hey I have some ideas about the website";
                                                                this.transition();
                                                                this.line48.text = "We should talk about it sometime.";
                                                            }
                                                            else
                                                            {
                                                                if (this.Command.text == "open andrew #3")
                                                                {
                                                                    this.line48.text = "To: Andrew@Silverton.com";
                                                                    this.transition();
                                                                    this.line48.text = "From: Andrew@TechHelp.com";
                                                                    this.transition();
                                                                    this.line48.text = "For later";
                                                                    this.transition();
                                                                    this.line48.text = "01000100 01100101 01110100 01101111 01110101 01110010";
                                                                    this.transition();
                                                                    this.line48.text = "{DOWNLOADED MAXIMUM SECURITY PASS}";
                                                                    PlayerPrefs.SetInt("Security", 1);
                                                                }
                                                                else
                                                                {
                                                                    if (this.Command.text == "open andrew #4")
                                                                    {
                                                                        this.line48.text = "To: Harold@TechHelp.com";
                                                                        this.transition();
                                                                        this.line48.text = "From: Andrew@TechHelp.com";
                                                                        this.transition();
                                                                        this.line48.text = "Thanks for the job opportunity!";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (this.Command.text == "exit")
                                                                        {
                                                                            this.level = "hack";
                                                                            this.line48.text = "Going back to program 'Hack'";
                                                                        }
                                                                        else
                                                                        {
                                                                            this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (this.level == "michael")
                                    {
                                        if (this.Command.text == "help")
                                        {
                                            this.line48.text = "Command List:";
                                            this.transition();
                                            this.line48.text = " help";
                                            this.transition();
                                            this.line48.text = " ls";
                                            this.transition();
                                            this.line48.text = " cls";
                                            this.transition();
                                            this.line48.text = " open";
                                            this.transition();
                                            this.line48.text = " exit";
                                        }
                                        else
                                        {
                                            if (this.Command.text == "help ls")
                                            {
                                                this.line48.text = "FUNCTION: Shows list of emails";
                                            }
                                            else
                                            {
                                                if (this.Command.text == "help cls")
                                                {
                                                    this.line48.text = "FUNCTION: Clears screen";
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "ls")
                                                    {
                                                        this.line48.text = "Mail:";
                                                        this.transition();
                                                        this.line48.text = " michael #1";
                                                        this.transition();
                                                        this.line48.text = " michael #2";
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "cls")
                                                        {
                                                            this.clear();
                                                        }
                                                        else
                                                        {
                                                            if (this.Command.text == "open michael #1")
                                                            {
                                                                this.line48.text = "To: Jeff@Ticon.com";
                                                                this.transition();
                                                                this.line48.text = "From: Michael@Ticon.com";
                                                                this.transition();
                                                                this.line48.text = "Dont worry about it Jeff.";
                                                                this.transition();
                                                                this.line48.text = "I probably jsut forgot about some small expenses.";
                                                            }
                                                            else
                                                            {
                                                                if (this.Command.text == "open michael #2")
                                                                {
                                                                    this.line48.text = "To: Zander@Ticon.com";
                                                                    this.transition();
                                                                    this.line48.text = "From: Michael@Ticon.com";
                                                                    this.transition();
                                                                    this.line48.text = "He is starting to catch on.";
                                                                    this.transition();
                                                                    this.line48.text = "What should I do?";
                                                                }
                                                                else
                                                                {
                                                                    if (this.Command.text == "exit")
                                                                    {
                                                                        this.level = "hack";
                                                                        this.line48.text = "Going back to program 'Hack'";
                                                                    }
                                                                    else
                                                                    {
                                                                        this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (this.level == "osaze")
                                        {
                                            if (this.Command.text == "help")
                                            {
                                                this.line48.text = "Command List:";
                                                this.transition();
                                                this.line48.text = " help";
                                                this.transition();
                                                this.line48.text = " ls";
                                                this.transition();
                                                this.line48.text = " cls";
                                                this.transition();
                                                this.line48.text = " open";
                                                this.transition();
                                                this.line48.text = " exit";
                                            }
                                            else
                                            {
                                                if (this.Command.text == "help ls")
                                                {
                                                    this.line48.text = "FUNCTION: Shows list of emails";
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "help cls")
                                                    {
                                                        this.line48.text = "FUNCTION: Clears screen";
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "ls")
                                                        {
                                                            this.line48.text = "Mail:";
                                                            this.transition();
                                                            this.line48.text = " osaze #1";
                                                        }
                                                        else
                                                        {
                                                            if (this.Command.text == "cls")
                                                            {
                                                                this.clear();
                                                            }
                                                            else
                                                            {
                                                                if (this.Command.text == "open osaze #1")
                                                                {
                                                                    this.line48.text = "To: Jeff@Ticon.com";
                                                                    this.transition();
                                                                    this.line48.text = "From: Osaze@Ticon.com";
                                                                    this.transition();
                                                                    this.line48.text = "that really sucks!";
                                                                    this.transition();
                                                                    this.line48.text = "Michael just walked past me saying he 'is the best'";
                                                                    this.transition();
                                                                    this.line48.text = "He is so narcissistic!";
                                                                }
                                                                else
                                                                {
                                                                    if (this.Command.text == "exit")
                                                                    {
                                                                        this.level = "hack";
                                                                        this.line48.text = "Going back to program 'Hack'";
                                                                    }
                                                                    else
                                                                    {
                                                                        this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (this.level == "bob")
                                            {
                                                if (this.Command.text == "help")
                                                {
                                                    this.line48.text = "Command List:";
                                                    this.transition();
                                                    this.line48.text = " help";
                                                    this.transition();
                                                    this.line48.text = " ls";
                                                    this.transition();
                                                    this.line48.text = " cls";
                                                    this.transition();
                                                    this.line48.text = " open";
                                                    this.transition();
                                                    this.line48.text = " exit";
                                                }
                                                else
                                                {
                                                    if (this.Command.text == "help ls")
                                                    {
                                                        this.line48.text = "FUNCTION: Shows list of emails";
                                                    }
                                                    else
                                                    {
                                                        if (this.Command.text == "help cls")
                                                        {
                                                            this.line48.text = "FUNCTION: Clears screen";
                                                        }
                                                        else
                                                        {
                                                            if (this.Command.text == "ls")
                                                            {
                                                                this.line48.text = "Mail:";
                                                                this.transition();
                                                                this.line48.text = " bob #1";
                                                            }
                                                            else
                                                            {
                                                                if (this.Command.text == "cls")
                                                                {
                                                                    this.clear();
                                                                }
                                                                else
                                                                {
                                                                    if (this.Command.text == "open osaze #1")
                                                                    {
                                                                        this.line48.text = "To: Alice@Ticon.com";
                                                                        this.transition();
                                                                        this.line48.text = "From: Bob@Ticon.com";
                                                                        this.transition();
                                                                        this.line48.text = "Hey u wanna grab a beer sometime?";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (this.Command.text == "exit")
                                                                        {
                                                                            this.level = "hack";
                                                                            this.line48.text = "Going back to program 'Hack'";
                                                                        }
                                                                        else
                                                                        {
                                                                            this.line48.text = ("Command " + this.Command.text) + " not found!";
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //THE DOPEST EASTER EGG IN EXHISTANCCCCEEEE
        if (this.Command.text == "hack the planet")
        {
            this.hacktheplanet();
        }
        this.Command.text = "...";
    }

    public virtual void transition()
    {
        this.line1.text = this.line2.text;
        this.line2.text = this.line3.text;
        this.line3.text = this.line4.text;
        this.line4.text = this.line5.text;
        this.line5.text = this.line6.text;
        this.line6.text = this.line7.text;
        this.line7.text = this.line8.text;
        this.line8.text = this.line9.text;
        this.line9.text = this.line10.text;
        this.line10.text = this.line11.text;
        this.line11.text = this.line12.text;
        this.line12.text = this.line13.text;
        this.line13.text = this.line14.text;
        this.line14.text = this.line15.text;
        this.line15.text = this.line16.text;
        this.line16.text = this.line17.text;
        this.line17.text = this.line18.text;
        this.line18.text = this.line19.text;
        this.line19.text = this.line20.text;
        this.line20.text = this.line21.text;
        this.line21.text = this.line22.text;
        this.line22.text = this.line23.text;
        this.line23.text = this.line24.text;
        this.line24.text = this.line25.text;
        this.line25.text = this.line26.text;
        this.line26.text = this.line27.text;
        this.line27.text = this.line28.text;
        this.line28.text = this.line29.text;
        this.line29.text = this.line30.text;
        this.line30.text = this.line31.text;
        this.line31.text = this.line32.text;
        this.line32.text = this.line33.text;
        this.line33.text = this.line34.text;
        this.line34.text = this.line35.text;
        this.line35.text = this.line36.text;
        this.line36.text = this.line37.text;
        this.line37.text = this.line38.text;
        this.line38.text = this.line39.text;
        this.line39.text = this.line40.text;
        this.line40.text = this.line41.text;
        this.line41.text = this.line42.text;
        this.line42.text = this.line43.text;
        this.line43.text = this.line44.text;
        this.line44.text = this.line45.text;
        this.line45.text = this.line46.text;
        this.line46.text = this.line47.text;
        this.line47.text = this.line48.text;
    }

    public virtual void clear()
    {
        this.line1.text = "";
        this.line2.text = "";
        this.line3.text = "";
        this.line4.text = "";
        this.line5.text = "";
        this.line6.text = "";
        this.line7.text = "";
        this.line8.text = "";
        this.line9.text = "";
        this.line10.text = "";
        this.line11.text = "";
        this.line12.text = "";
        this.line13.text = "";
        this.line14.text = "";
        this.line15.text = "";
        this.line16.text = "";
        this.line17.text = "";
        this.line18.text = "";
        this.line19.text = "";
        this.line20.text = "";
        this.line21.text = "";
        this.line22.text = "";
        this.line23.text = "";
        this.line24.text = "";
        this.line25.text = "";
        this.line26.text = "";
        this.line27.text = "";
        this.line28.text = "";
        this.line29.text = "";
        this.line30.text = "";
        this.line31.text = "";
        this.line32.text = "";
        this.line33.text = "";
        this.line34.text = "";
        this.line35.text = "";
        this.line36.text = "";
        this.line37.text = "";
        this.line38.text = "";
        this.line39.text = "";
        this.line40.text = "";
        this.line41.text = "";
        this.line42.text = "";
        this.line43.text = "";
        this.line44.text = "";
        this.line45.text = "";
        this.line46.text = "";
        this.line47.text = "";
    }

    public virtual void hacktheplanet()
    {
        this.line1.text = "HACK THE PLANET";
        this.line2.text = "HACK THE PLANET";
        this.line3.text = "HACK THE PLANET";
        this.line4.text = "HACK THE PLANET";
        this.line5.text = "HACK THE PLANET";
        this.line6.text = "HACK THE PLANET";
        this.line7.text = "HACK THE PLANET";
        this.line8.text = "HACK THE PLANET";
        this.line9.text = "HACK THE PLANET";
        this.line10.text = "HACK THE PLANET";
        this.line11.text = "HACK THE PLANET";
        this.line12.text = "HACK THE PLANET";
        this.line13.text = "HACK THE PLANET";
        this.line14.text = "HACK THE PLANET";
        this.line15.text = "HACK THE PLANET";
        this.line16.text = "HACK THE PLANET";
        this.line17.text = "HACK THE PLANET";
        this.line18.text = "HACK THE PLANET";
        this.line19.text = "HACK THE PLANET";
        this.line20.text = "HACK THE PLANET";
        this.line21.text = "HACK THE PLANET";
        this.line22.text = "HACK THE PLANET";
        this.line23.text = "HACK THE PLANET";
        this.line24.text = "HACK THE PLANET";
        this.line25.text = "HACK THE PLANET";
        this.line26.text = "HACK THE PLANET";
        this.line27.text = "HACK THE PLANET";
        this.line28.text = "HACK THE PLANET";
        this.line29.text = "HACK THE PLANET";
        this.line30.text = "HACK THE PLANET";
        this.line31.text = "HACK THE PLANET";
        this.line32.text = "HACK THE PLANET";
        this.line33.text = "HACK THE PLANET";
        this.line34.text = "HACK THE PLANET";
        this.line35.text = "HACK THE PLANET";
        this.line36.text = "HACK THE PLANET";
        this.line37.text = "HACK THE PLANET";
        this.line38.text = "HACK THE PLANET";
        this.line39.text = "HACK THE PLANET";
        this.line40.text = "HACK THE PLANET";
        this.line41.text = "HACK THE PLANET";
        this.line42.text = "HACK THE PLANET";
        this.line43.text = "HACK THE PLANET";
        this.line44.text = "HACK THE PLANET";
        this.line45.text = "HACK THE PLANET";
        this.line46.text = "HACK THE PLANET";
        this.line47.text = "HACK THE PLANET";
    }

    public Downwards()
    {
        this.level = "index";
        this.username = "";
        this.strike = 3;
    }

}