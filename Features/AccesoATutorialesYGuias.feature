Feature: Access to Tutorials and Guides
	As a user
	I want to access tutorials and guides that teach me how to use the platform's features
	So that I can maximize my experience.

@SearchForTutorials Scenario: Tutorials and guides should be organized by topic and easy to search
	Given that the user is in the tutorials section
	When they search for a specific topic
	And use the search function
	Then they should find relevant results that match their search

@ViewingTutorials Scenario: Each tutorial should include a video or a series of images illustrating the steps to follow
	Given that the user has selected a tutorial
	When they view it
	And follow the instructions
	Then they should be able to complete the described process without confusion
