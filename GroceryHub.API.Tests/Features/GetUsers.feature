Feature: GetUsers

Scenario: Should return all user profiles
	Given a user profile exists
	When I GET 'api/userProfiles'
	Then the status should be 200