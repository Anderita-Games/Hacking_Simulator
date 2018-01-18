#pragma strict
var Command : UnityEngine.UI.InputField;
var line1 : UnityEngine.UI.Text;
var line2 : UnityEngine.UI.Text;
var line3 : UnityEngine.UI.Text;
var line4 : UnityEngine.UI.Text;
var line5 : UnityEngine.UI.Text;
var line6 : UnityEngine.UI.Text;
var line7 : UnityEngine.UI.Text;
var line8 : UnityEngine.UI.Text;
var line9 : UnityEngine.UI.Text;
var line10 : UnityEngine.UI.Text;
var line11 : UnityEngine.UI.Text;
var line12 : UnityEngine.UI.Text;
var line13 : UnityEngine.UI.Text;
var line14 : UnityEngine.UI.Text;
var line15 : UnityEngine.UI.Text;
var line16 : UnityEngine.UI.Text;
var line17 : UnityEngine.UI.Text;
var line18 : UnityEngine.UI.Text;
var line19 : UnityEngine.UI.Text;
var line20 : UnityEngine.UI.Text;
var line21 : UnityEngine.UI.Text;
var line22 : UnityEngine.UI.Text;
var line23 : UnityEngine.UI.Text;
var line24 : UnityEngine.UI.Text;
var line25 : UnityEngine.UI.Text;
var line26 : UnityEngine.UI.Text;
var line27 : UnityEngine.UI.Text;
var line28 : UnityEngine.UI.Text;
var line29 : UnityEngine.UI.Text;
var line30 : UnityEngine.UI.Text;
var line31 : UnityEngine.UI.Text;
var line32 : UnityEngine.UI.Text;
var line33 : UnityEngine.UI.Text;
var line34 : UnityEngine.UI.Text;
var line35 : UnityEngine.UI.Text;
var line36 : UnityEngine.UI.Text;
var line37 : UnityEngine.UI.Text;
var line38 : UnityEngine.UI.Text;
var line39 : UnityEngine.UI.Text;
var line40 : UnityEngine.UI.Text;
var line41 : UnityEngine.UI.Text;
var line42 : UnityEngine.UI.Text;
var line43 : UnityEngine.UI.Text;
var line44 : UnityEngine.UI.Text;
var line45 : UnityEngine.UI.Text;
var line46 : UnityEngine.UI.Text;
var line47 : UnityEngine.UI.Text;
var line48 : UnityEngine.UI.Text;
var level = "index";
var username = "";
var strike = 3;

function Start () {
	line46.text = "Welcome to Proletariat!";
	line47.text = "The Ultimate hacking text adventure made by Andrew Friedman";
	line48.text = "Type 'help' for a list of commands";
}

function Update () {
}

function Commander () {
	transition();
	line48.text = Command.text;
	transition();
	if (level == "index") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " start";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " files";
			transition();
			line48.text = " pl";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help start") {        				//Help ifs ↓
			line48.text = "FUNCTION: Starts Programs";
		}else if (Command.text == "help cls") {        
			line48.text = "FUNCTION: Clears Screen";
		}else if (Command.text == "help files") {        
			line48.text = "FUNCTION: Shows list of files on computer";
		}else if (Command.text == "help pl") {        
			line48.text = "FUNCTION: Shows list of programs";
		}else if (Command.text == "help exit") {        
			line48.text = "FUNCTION: Exits Program";
		}else if (Command.text == "start") {							//Start ifs ↓
			line48.text = "ERROR: Define program that is starting";
		}else if (Command.text == "start mail") {
			line48.text = "Loading Mail...";
			transition();
			line48.text = "Mail loaded";
			transition();
			line48.text = "Type help for a list of commands";
			level = "mail";
		}else if (Command.text == "start news") {
			line48.text = "ERROR: Currently Unavailable";
		}else if (Command.text == "start web") {
			line48.text = "ERROR: Currently Unavailable";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "files") {
			line48.text = "Files:";
			if (PlayerPrefs.GetInt("Expense") == 1) {
				transition();
				line48.text = " EXPENSE REPORT";
			}else if (PlayerPrefs.GetInt("Security") == 1) {
				transition();
				line48.text = " MAXIMUM SECURITY PASS";
			}
		}else if (Command.text == "pl") {
			line48.text = "Programs:";
			transition();
			line48.text = " mail";
			transition();
			line48.text = " news";
			transition();
			line48.text = " web";
			if (PlayerPrefs.GetInt("Hacking") == 1) {
				transition();
				line48.text = " hack";
			}
		}else if (Command.text == "start hack" && PlayerPrefs.GetInt("Hacking") == 1) {
			level = "hack";
			line48.text = "Starting Hacking Program...";
			line48.text = "Program loaded >:)";
		}else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "mail") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " welcome";
			if (PlayerPrefs.GetInt("Jeff") == 1) {
				transition();
				line48.text = " jeff";
			}else if (PlayerPrefs.GetInt("Andrew") == 1) {
				transition();
				line48.text = " andrew";
			}else if (PlayerPrefs.GetInt("Done") == 1) {
				transition();
				line48.text = " done";
			}
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open welcome") {
			line48.text = "Subject: Hello";
			transition();
			line48.text = "To: you";
			transition();
			line48.text = "From: ";
			transition();
			line48.text = "By opening this email, you have downloaded the hacking program.";
			transition();
			line48.text = "I need you to hack into Alice's account";
			transition();
			line48.text = "She isnt the brightest";
			PlayerPrefs.SetInt("Hacking", 1);
		}else if (Command.text == "open jeff") {
			line48.text = "Subject: Jeff";
			transition();
			line48.text = "To: you";
			transition();
			line48.text = "From: ";
			transition();
			line48.text = "Now its time to hack Jeff.";
			transition();
			line48.text = "As you cn tell he has a thing for Alice.";
			transition();
			line48.text = "Good Luck!";
		}else if (Command.text == "open andrew") {
			line48.text = "Subject: Andrew";
			transition();
			line48.text = "To: you";
			transition();
			line48.text = "From: ";
			transition();
			line48.text = "Andrew has access to a lot of things.";
			transition();
			line48.text = "He doesnt care about his job since he is very new.";
			transition();
			line48.text = "Good Luck!";
		}else if (Command.text == "open done") {
			line48.text = "Subject: Done for now";
			transition();
			line48.text = "To: you";
			transition();
			line48.text = "From: ";
			transition();
			line48.text = "Good job!";
			transition();
			line48.text = "keep on exploring for more evidence.";
			transition();
			line48.text = "I may not contact you for a while!";
		}else if (Command.text == "exit") {
			level = "index";
			line48.text = "Going back to index";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "hack") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " login";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help login") {
			line48.text = "FUNCTION: goes to login screen";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears ";
		}else if (Command.text == "login") {
			level = "login";
			line48.text = "Username:";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "exit") {
			level = "index";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "login") {
		if (username == "") {
			username = Command.text;
			line48.text = "Password:";	
		}else if (strike != 0) {
			if (username == "alice" && Command.text == "password") {
				level = "alice";
				line48.text = "LOGIN SUCCESSFUL";
				username = "";
			}else if (username == "jeff" && Command.text == "alice") {
				level = "jeff";
				line48.text = "LOGIN SUCCESSFUL";
				username = "";
			}else if (username == "andrew" && Command.text == "") {
				level = "andrew";
				line48.text = "LOGIN SUCCESSFUL";
				PlayerPrefs.SetInt("Done", 1);
				username = "";
			}else if (username == "michael" && Command.text == "is the best") {
				level = "michael";
				line48.text = "LOGIN SUCCESSFUL";
				username = "";
			}else if (username == "osaze" && Command.text == "baseball") {
				level = "osaze";
				line48.text = "LOGIN SUCCESSFUL";
				username = "";
			}else if (username == "bob" && Command.text == "alice") {
				level = "bob";
				line48.text = "LOGIN SUCCESSFUL";
				username = "";
			}else {
				line48.text = "PASSWORD INCORRECT";
				transition();
				strike -= 1;
				line48.text = "YOU HAVE " + strike + " TRIES LEFT!";
			}
		}else if (strike == 0) {
			line48.text = "FAILURE TO LOGIN";
			transition();
			strike = 3;
			username = "";
			line48.text = "EXITING LOGIN...";
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
	}else if (level == "alice") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " alice #1";
			transition();
			line48.text = " alice #2";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open alice #1") {
			line48.text = "To: Alice@Ticon.com";
			transition();
			line48.text = "From: Jeff@Ticon.com";
			transition();
			line48.text = "We should do something sometime!";
			transition();
			line48.text = "How about going to the baseball game";
			transition();
			line48.text = "with me and Osaze?";
			PlayerPrefs.SetInt("Jeff", 1);
		}else if (Command.text == "open alice #2") {
			line48.text = "To: Jeff@Ticon.com";
			transition();
			line48.text = "From: Alice@Ticon.com";
			transition();
			line48.text = "I would love to do that,";
			transition();
			line48.text = "but I cant because I already told";
			transition();
			line48.text = "Bob I would grab a drink with him.";
		}else if (Command.text == "exit") {
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "jeff") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " jeff #1";
			transition();
			line48.text = " jeff #2";
			transition();
			line48.text = " jeff #3";
			transition();
			line48.text = " jeff #4";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open jeff #1") {
			line48.text = "To: Osaze@Ticon.com";
			transition();
			line48.text = "From: Jeff@Ticon.com";
			transition();
			line48.text = "Dude she cant make it because";
			transition();
			line48.text = "of freaking Bob!";
			transition();
			line48.text = "BOB IS THE WORST!";
		}else if (Command.text == "open jeff #2") {
			line48.text = "To: Bob@Ticon.com";
			transition();
			line48.text = "From: Alice@Ticon.com";
			transition();
			line48.text = "Not cool bro,";
			transition();
			line48.text = "you knew I had a thing for her.";

		}else if (Command.text == "open jeff #3") {
			line48.text = "To: Michael@Ticon.com";
			transition();
			line48.text = "From: Jeff@Ticon.com";
			transition();
			line48.text = "Hey boss,";
			transition();
			line48.text = "there are some holes in this expense report";
			transition();
			line48.text = "I would print it and drop it off in you office,";
			transition();
			line48.text = "but the printer isnt working.";
			transition();
			line48.text = "{DOWNLOADED EXPENSE REPORT}";
			PlayerPrefs.SetInt("Expense", 1);
		}else if (Command.text == "open jeff #4") {
			line48.text = "To: Andrew@TechHelp.com";
			transition();
			line48.text = "From: Jeff@Ticon.com";
			transition();
			line48.text = "Hey new guy,";
			transition();
			line48.text = "the printer isnt working.";
			transition();
			line48.text = "fix it";
			PlayerPrefs.SetInt("Andrew", 1);
		}else if (Command.text == "exit") {
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "andrew") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " andrew #1";
			transition();
			line48.text = " andrew #2";
			transition();
			line48.text = " andrew #3";
			transition();
			line48.text = " andrew #4";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open andrew #1") {
			line48.text = "To: Jeff@Ticon.com";
			transition();
			line48.text = "From: Andrew@TechHelp.com";
			transition();
			line48.text = "K";
			transition();
			line48.text = "I'll look at the printer on friday";
			transition();
			line48.text = "BOB IS THE WORST!";
		}else if (Command.text == "open andrew #2") {
			line48.text = "To: Ester@TechHelp.com";
			transition();
			line48.text = "From: Andrew@TechHelp.com";
			transition();
			line48.text = "Hey I have some ideas about the website";
			transition();
			line48.text = "We should talk about it sometime.";

		}else if (Command.text == "open andrew #3") {
			line48.text = "To: Andrew@Silverton.com";
			transition();
			line48.text = "From: Andrew@TechHelp.com";
			transition();
			line48.text = "For later";
			transition();
			line48.text = "01000100 01100101 01110100 01101111 01110101 01110010";
			transition();
			line48.text = "{DOWNLOADED MAXIMUM SECURITY PASS}";
			PlayerPrefs.SetInt("Security", 1);
		}else if (Command.text == "open andrew #4") {
			line48.text = "To: Harold@TechHelp.com";
			transition();
			line48.text = "From: Andrew@TechHelp.com";
			transition();
			line48.text = "Thanks for the job opportunity!";
		}else if (Command.text == "exit") {
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "michael") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " michael #1";
			transition();
			line48.text = " michael #2";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open michael #1") {
			line48.text = "To: Jeff@Ticon.com";
			transition();
			line48.text = "From: Michael@Ticon.com";
			transition();
			line48.text = "Dont worry about it Jeff.";
			transition();
			line48.text = "I probably jsut forgot about some small expenses.";
		}else if (Command.text == "open michael #2") {
			line48.text = "To: Zander@Ticon.com";
			transition();
			line48.text = "From: Michael@Ticon.com";
			transition();
			line48.text = "He is starting to catch on.";
			transition();
			line48.text = "What should I do?";
		}else if (Command.text == "exit") {
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "osaze") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " osaze #1";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open osaze #1") {
			line48.text = "To: Jeff@Ticon.com";
			transition();
			line48.text = "From: Osaze@Ticon.com";
			transition();
			line48.text = "that really sucks!";
			transition();
			line48.text = "Michael just walked past me saying he 'is the best'";
			transition();
			line48.text = "He is so narcissistic!";
		}else if (Command.text == "exit") {
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}else if (level == "bob") {
		if (Command.text == "help") {
			line48.text = "Command List:";
			transition();
			line48.text = " help";
			transition();
			line48.text = " ls";
			transition();
			line48.text = " cls";
			transition();
			line48.text = " open";
			transition();
			line48.text = " exit";
		}else if (Command.text == "help ls") {
			line48.text = "FUNCTION: Shows list of emails";
		}else if (Command.text == "help cls") {
			line48.text = "FUNCTION: Clears screen";
		}else if (Command.text == "ls") {
			line48.text = "Mail:";
			transition();
			line48.text = " bob #1";
		}else if (Command.text == "cls") {
			clear();
		}else if (Command.text == "open osaze #1") {
			line48.text = "To: Alice@Ticon.com";
			transition();
			line48.text = "From: Bob@Ticon.com";
			transition();
			line48.text = "Hey u wanna grab a beer sometime?";
		}else if (Command.text == "exit") {
			level = "hack";
			line48.text = "Going back to program 'Hack'";
		}
		else {
			line48.text = "Command " + Command.text + " not found!";
		}
	}
	//THE DOPEST EASTER EGG IN EXHISTANCCCCEEEE
	if (Command.text == "hack the planet") {
		hacktheplanet();
	}
	Command.text = "...";
}

function transition() {
	line1.text = line2.text;
	line2.text = line3.text;
	line3.text = line4.text;
	line4.text = line5.text;
	line5.text = line6.text;
	line6.text = line7.text;
	line7.text = line8.text;
	line8.text = line9.text;
	line9.text = line10.text;
	line10.text = line11.text;
	line11.text = line12.text;
	line12.text = line13.text;
	line13.text = line14.text;
	line14.text = line15.text;
	line15.text = line16.text;
	line16.text = line17.text;
	line17.text = line18.text;
	line18.text = line19.text;
	line19.text = line20.text;
	line20.text = line21.text;
	line21.text = line22.text;
	line22.text = line23.text;
	line23.text = line24.text;
	line24.text = line25.text;
	line25.text = line26.text;
	line26.text = line27.text;
	line27.text = line28.text;
	line28.text = line29.text;
	line29.text = line30.text;
	line30.text = line31.text;
	line31.text = line32.text;
	line32.text = line33.text;
	line33.text = line34.text;
	line34.text = line35.text;
	line35.text = line36.text;
	line36.text = line37.text;
	line37.text = line38.text;
	line38.text = line39.text;
	line39.text = line40.text;
	line40.text = line41.text;
	line41.text = line42.text;
	line42.text = line43.text;
	line43.text = line44.text;
	line44.text = line45.text;
	line45.text = line46.text;
	line46.text = line47.text;
	line47.text = line48.text;
	
}

function clear() {
	line1.text = "";
	line2.text = "";
	line3.text = "";
	line4.text = "";
	line5.text = "";
	line6.text = "";
	line7.text = "";
	line8.text = "";
	line9.text = "";
	line10.text = "";
	line11.text = "";
	line12.text = "";
	line13.text = "";
	line14.text = "";
	line15.text = "";
	line16.text = "";
	line17.text = "";
	line18.text = "";
	line19.text = "";
	line20.text = "";
	line21.text = "";
	line22.text = "";
	line23.text = "";
	line24.text = "";
	line25.text = "";
	line26.text = "";
	line27.text = "";
	line28.text = "";
	line29.text = "";
	line30.text = "";
	line31.text = "";
	line32.text = "";
	line33.text = "";
	line34.text = "";
	line35.text = "";
	line36.text = "";
	line37.text = "";
	line38.text = "";
	line39.text = "";
	line40.text = "";
	line41.text = "";
	line42.text = "";
	line43.text = "";
	line44.text = "";
	line45.text = "";
	line46.text = "";
	line47.text = "";
}

function hacktheplanet() {
	line1.text = "HACK THE PLANET";
	line2.text = "HACK THE PLANET";
	line3.text = "HACK THE PLANET";
	line4.text = "HACK THE PLANET";
	line5.text = "HACK THE PLANET";
	line6.text = "HACK THE PLANET";
	line7.text = "HACK THE PLANET";
	line8.text = "HACK THE PLANET";
	line9.text = "HACK THE PLANET";
	line10.text = "HACK THE PLANET";
	line11.text = "HACK THE PLANET";
	line12.text = "HACK THE PLANET";
	line13.text = "HACK THE PLANET";
	line14.text = "HACK THE PLANET";
	line15.text = "HACK THE PLANET";
	line16.text = "HACK THE PLANET";
	line17.text = "HACK THE PLANET";
	line18.text = "HACK THE PLANET";
	line19.text = "HACK THE PLANET";
	line20.text = "HACK THE PLANET";
	line21.text = "HACK THE PLANET";
	line22.text = "HACK THE PLANET";
	line23.text = "HACK THE PLANET";
	line24.text = "HACK THE PLANET";
	line25.text = "HACK THE PLANET";
	line26.text = "HACK THE PLANET";
	line27.text = "HACK THE PLANET";
	line28.text = "HACK THE PLANET";
	line29.text = "HACK THE PLANET";
	line30.text = "HACK THE PLANET";
	line31.text = "HACK THE PLANET";
	line32.text = "HACK THE PLANET";
	line33.text = "HACK THE PLANET";
	line34.text = "HACK THE PLANET";
	line35.text = "HACK THE PLANET";
	line36.text = "HACK THE PLANET";
	line37.text = "HACK THE PLANET";
	line38.text = "HACK THE PLANET";
	line39.text = "HACK THE PLANET";
	line40.text = "HACK THE PLANET";
	line41.text = "HACK THE PLANET";
	line42.text = "HACK THE PLANET";
	line43.text = "HACK THE PLANET";
	line44.text = "HACK THE PLANET";
	line45.text = "HACK THE PLANET";
	line46.text = "HACK THE PLANET";
	line47.text = "HACK THE PLANET";
}