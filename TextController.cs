using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {office_0,office_1,annex_0, accounting_0,entrance_0, kevin, oscar, angela, ceiling, annex_1,
						bathroom_0, entrance_1, drawer, scroll, entrance_2, cushion, bathroom_1, bag, warehouse};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.office_0;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.office_0) 			{state_office_0();}
		else if (myState == States.office_1) 		{state_office_1();}
		else if (myState == States.annex_0)			{state_annex_0();}
		else if (myState == States.accounting_0) 	{state_accounting_0();}
		else if (myState == States.entrance_0) 		{state_entrance_0();}
		else if (myState == States.kevin)			{state_kevin();}
		else if (myState == States.oscar)			{state_oscar();}
		else if (myState == States.angela)			{state_angela();}
		else if (myState == States.ceiling)			{state_ceiling();}
		else if (myState == States.annex_1)			{state_annex_1();}
		else if (myState == States.bathroom_0)		{state_bathroom_0();}
		else if (myState == States.entrance_1)		{state_entrance_1();}
		else if (myState == States.drawer)			{state_drawer();}
		else if (myState == States.scroll)			{state_scroll();}
		else if (myState == States.entrance_2) 		{state_entracnce_2();}
		else if (myState == States.cushion)			{state_cushion();}
		else if (myState == States.bathroom_1)		{state_bathroom_1();}
		else if (myState == States.bag)				{state_bag();}
		else if (myState == States.warehouse)		{state_warehouse();}	
			
	}
	
	void state_office_0 () {
		text.text = "Press U to Uncover with hidden message using the lightbulb.";
		if (Input.GetKeyDown(KeyCode.U)) {myState = States.office_1;}
		}
	
	void state_office_1 () {
		text.text = "Press X to go to the Annex, A to go to Accounting, " +
					"E to go to the Entrance.";
		if (Input.GetKeyDown(KeyCode.X))		{myState = States.annex_0;}
		else if (Input.GetKeyDown(KeyCode.A))	{myState = States.accounting_0;}
		else if (Input.GetKeyDown(KeyCode.E))	{myState = States.entrance_0;}
	}
	
	void state_annex_0 () {
		text.text = "There's nothing in here but stupid Toby. " +
					"Press R to Return to roaming the Office.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.office_1;}
	}
	
	void state_accounting_0 () {
		text.text = "Press K for Kevin's Desk, O for Oscar's, A for Angela's";
		if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.kevin;}
		else if (Input.GetKeyDown(KeyCode.O)) 	{myState = States.oscar;}
		else if (Input.GetKeyDown(KeyCode.A))	{myState = States.angela;}
	}
	
	void state_kevin () {
		text.text = "You are at Kevin's desk.\n\n" +
					"Press R to Return to inspecting the other desks";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.accounting_0;}
	}
	
	void state_oscar () {
		text.text = "You are at Oscar's desk.\n\n" +
					"Press R to Return to inspecting the other desks";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.accounting_0;}
		
	}
	
	void state_angela () {
		text.text = "You are at Angela's desk.\n\n" +
					"You just realized the key word UP in the clue.\n" +
					"Press C to check the ceiling for the next clue.";
		if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.ceiling;}
	}
	
	void state_ceiling () {
		text.text = "You've found a key! It has a tag with the letter X " +
					"written on it. What could that mean?\n\n" +
					"Press X to visit the annex, B to the bathroom, or E to visit the Entrance";
		if (Input.GetKeyDown(KeyCode.X))		{myState = States.annex_1;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.bathroom_0;}
		else if (Input.GetKeyDown(KeyCode.E)) 	{myState = States.entrance_1;}	
	}
	void state_entrance_0 (){
		text.text = "You are at the entrance to Dunder Mifflin." +
					"Press R to return to roaming the office.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.office_1;} 	
	}
	
	void state_annex_1 (){
		text.text = "For once, the annex might not be entirely useless!\n\n" +
					"Press to L look in the drawers";
		if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.drawer;} 	
	}
	
	void state_drawer (){
		text.text = "There seems to be a fake bottom to this drawer " +
					"and theres a scroll inside. " +
					"Press R to read the scroll.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.scroll;} 	
	}
	
	void state_scroll (){
		text.text = "The scroll reads, Sedes Introiti. I think that means" +
					" seat of entrance.\n\n" +
					"Press E to go to the entrance";
		if (Input.GetKeyDown(KeyCode.E)) 		{myState = States.entrance_2;}
	}
	
	void state_entracnce_2 (){
		text.text = "Let's rip open the cushions!\n" +
					"Push C to Cut the cusion open.";
		if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cushion;}
	}
	
	void state_cushion (){
		text.text = "There's a hand of cards inside. Kevin says its a royal flush!" +
					" The next clue must be in the bathroom!\n\n" +
					"Press B to look in the bathroom.";
		if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bathroom_1;}
	}
	
	void state_bathroom_0 (){
		text.text = "Hmm just smells like urine to me.\n\n" +
					"Press R to return to accounting.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.ceiling;}
	}
	
	void state_entrance_1 (){
		text.text = "Well there's Erin here but that's nothing important.\n\n" +
					"Press R to return to accounting";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.ceiling;}
	}
	
	void state_bathroom_1 (){
		text.text = "Theres a little baggy taped behind the toilet!\n" +
					"Press S to See what's in it.";
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.bag;}
	}
	
	void state_bag (){
		text.text = "Its a toy forklift... THE WAREHOUSE!!\n" +
					"Press W to go to the Warehouse";
		if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.warehouse;}
	}
	
	void state_warehouse (){
		text.text = "Where is the holy grail? There doesn't seem " +
					"to be anything here...";
	}
}

