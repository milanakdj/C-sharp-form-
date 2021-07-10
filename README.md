# C-sharp-form-


created in the default vs location 

and checked the box that said create the solution and the project in the same page 

cause of some error i got after not doing these two things, something along the lines of intelligense finished intializing but an error occured when attempting to load the document.

error code: 0x80131500






lab last
	need to create a contorl that is show over and over again in the form of different boxes
	these are called user contorls
	
	right click the project(winformapp1) >> add>> user controls
	
	simple rectangular area showup
	
	then after finishing up with the controls
	
	remove the buttons from the old one and then replace them with contorl
	
	add border
	
	then we going to look into how to pass informations into the controls
	
	then set a parameteriezed constructor to get he values for the data items to be showin the controls
	
	then use load function, which is called only after all the ui is made 
	
	
	
	
1st page/ form
	
	FormBorderStyel- none
	set the size to 700,400
	StartPosition- centerScreen
	
	import pictureBox
	then add the image
	
	then the 2 panels
	
	then make sure the background is black so you can tell what window area is useable
	
	then add timer 
		change the millisecond timer
		change Enabled to True
		
		and load the event
		
		set the panel2 to grow by some amount
		
		 then when it reaches the width
			cause the time to stop
			then cause the form2 object to be created 
			then show it 
			then hide the current
		
2nd page/ form2

	add 
		pictureBox
		timer
		progressBar
		button
	
	
	then add a event that when the button is pressed the timer start
	add a integer that measures how much the timer has been increased by
	now inside timer 
		we want to  cause the progressBar to start to increase
		so for that we use progressBar.Increment(5)
		if the value of the progressBar.Value==100
		then the subroutine of hiding the current and loading the next form
		
3rd page/ form3
	add two label, text box and a button called
	adjust the tab index
	
	add PasswordChar as something so that that would show up instead of the texts
	
	and if we want to return to the old form after closing say Form3
		then basically create an instance of Form2 in the class inside of Form3
			then initialize it as the value passed into this Form3 by the Form2 using this
				looks like:
					In form3
						Form4 form = new Form4(this);
					In Form4
						Form3 selectionForm;
						public Form4(Form3 form)
						{
							InitializeComponent();
							selectionForm = form;
						}
						private void Form4_FormClosing(object sender, FormClosingEventArgs e)
						{
							selectionForm.Show();
							this.Hide();
						}
						

Take_Out
	StartPosition-Center Screen
	WindowState- Maximized
	Then stretch to increase the size of it
	
	Insert two panels
	one for search 
	and the other for data grid view
	
						
