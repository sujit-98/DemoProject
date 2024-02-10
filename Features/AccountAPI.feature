Feature: Test AccountAPI

A short summary of the feature

@tag1
Scenario: Create new Account with valid data
	Given Account Initial Balance is "$1000"
	And   Account name is "Rajesh Mittal"
	And   Address is "Ahmedabad, Gujarat"
	When  POST endpoint triggered to create new account with above details
	Then  Verify the response code is 200
	And   Verify no error is returned
	And   Verify the success message “Account created successfully”
	And   Verify the account details are correctly returned in the JSON response

	Scenario: Edit Existing  Account with higher amount
	When  Put endpoint triggered to create new account with above details
	Then  Verify the response code is 200
	And   Verify no error is returned
	And   Verify the success message “Account created successfully”
	And   Verify the account details are correctly returned in the JSON response 

	Scenario: Delete Existing  Account 
	When  Delete endpoint triggered to create new account with above details
	Then  Verify the response code is 200
	And   Verify no error is returned
	And   Verify the success message “Account created successfully”
	And   Verify the account details are correctly returned in the JSON response 

