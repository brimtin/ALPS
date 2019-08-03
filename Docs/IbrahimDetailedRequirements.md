# Project Step 4

## MVP
#### A login/ Registration page 
Scenario 	A user visits the site to submit a leave request
Given 			The user has not used the application before
And 			Does not currently have an active account
When 			User select "Register Here"
Then 			User is redirected to the registration page
And 			User fills out the registration form
When 			User selects "Register"
Given 			All required fields have been properly filled out
And				The username does not already exists
And 			The Password meets security requirements
Then 			User's information is stored 
And 			User is redirected to the login page
					
Scenario 	A user visits the site to submit a leave request
Given 			User has an active account
But 				User forgot password or username
And 			User selects "Forgot Password/Username" link
Then 			User is prompted to enter their email address
Given 			An account exists under that email address
Then 			User will receive a link to reset password
And				Email will also remind user that their username is their Email address
When 			user clicks on provided link or copy and pastes URL into a browser
Then 			User is prompted to enter and confirm a new password
Given 			New password meets all security requirements
And 			The password does not match the last 3 password used 
Then 			New password is saved and user is redirected to the login page
And 			User receive an email confirming password change

Scenario		A user visits the site to need to submit a leave request
Given 			User has an active account
And 			User enters a valid username and password 
Then 			User is granted access the to create new leave request feature

#### The option to generate a new leave request
Scenario		User selects "Submit A New Request" button
Given 			User has no open requests 
Then 			User is taken to a new page
Where		User is able to enter all the required information to process the request

#### The option to input personal information and details about the leave
Scenario		User is ready to fill out leave form
Given 			User meets all the requirements to initiate a new request
Then			User fills out destination information 
And				Dates requested
And				User's own personal information and home address will auto populate based on the user's profile information
But				User has the ability to change auto generated information
When 			All required fields are filled out, user can select "Next"

#### The option to submit the request and select their first line supervisor and Commander
Scenario 	User has is ready to submit a leave request
Given 			User has completed all previous steps
Then 			User can enter information about their approving authority
Given			User's platoon sergeant, 1st Sergeant, and commander have active accounts 
Then			User can search for their names 
And				Select their name for the drop down menu
But				If one or more approving authority has no active account
Then 			User can enter their email address 
Given			 A request does not need approval from a platoon sergeant, or 1st Sergeant
Then			User can leave those field blank

#### The option to notify users when a request requires their approval
Scenario		A leave request has been submitted that requires a user's approval
Given			User has an active account
Then			User will receive an email asking them to login to their account to view the request
Given			User has no active account
Then 			User will receive an email with a unique link that will allow them to view and service the request

#### The option to Approve or deny leave requests
Scenario		User has been notified that a request needs their approval
Given 			User has an active account
Then			User can login to their account and select the request from their Dashboard
Then			User will be able to review the request and select "Approve" or "Deny" at the bottom of page
When			User selects "Deny" 
Then			User will be required to provide a short explanation as to why they cannot approve the request
 
Scenario		User received an email with a link because a request needs their approval
Given 			User has no active account
When			User follows the link
Then 			User will have the same options to service the request as an active account holder

### the option to notify users when their request has been approved or denied.
Scenario		A request submitted by a user has been either approved or denied
Given			User's profile information is accurate
Then 			User will receive an email with the decision of the approving authority
And 			User can login to their account
Given			The request has been approved
Then			Under "Current Requests" user can print a copy of their approved leave

## Full Product
#### The option to input user's medical and personnel record to see how may leave days they have, and their eligibility to take leave
Scenario		A user just created an account and need to build their profile
Given 			They successfully logged into their account
Then			User is able to input how many days they have accrued
And 			User is also able to enter information about when they did required medical screenings

#### The option to check the status of the request
Scenario		User has submitted a request and wants to know the status of the request
Given			User has an active account and successfully logged into that account
Then			User can select "Current Requests"
And 			View a report of who already approved the request
And				Whose approval is still needed to process the request

####  The option to update the soldiers records  and to deduct any leave taken 
Scenario		A user has build their profile but has since moved to a new unit or has recently completed required 						   					.					medical screening
Given			User can login to their account
Then			User select "Update Profile" from their "Dashboard"
And 			Make necessary changes

Scenario		A user has requested leave and the leave has been approved
Given 			The soldier did in fact take the leave and is now back to duty
Then			The application automatically deducts the number of leave days taken form user's profile
But				The application also adds 2.5 days per month of leave to all active accounts. 

#### The option to update a leave request and adding supporting document during and after submission
Scenario		A user has submitted a leave request
But				They have not provided all the supporting documents that are needed to approve the request
Then			User can login to their account and upload supporting documents under "Current Requests"

## Stretch
#### The option to sign out on leave for officers and senior NCOs
Scenario 	A senior Non-Commissioned Officer or an Officer have submitted a leave request that has been approved
Given			The leave date has already started
Then			They can login to their account and check out on leave
Then			Staff Duty will be notified that user started their leave
#### Linking the application to soldiers leave and earnings, medical, and other records page, and automatically validating their eligibility to take leave
Scenario		Almost all information needed to determine leave eligibility is available without the user having to enter it
Then			The application will need access to  user's AKO account to make the process really smooth and convenient