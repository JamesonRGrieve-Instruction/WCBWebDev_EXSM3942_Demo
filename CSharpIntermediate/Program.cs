/**
 *What is agile?
 *Agile is an interative approach to software development that focuses on building small and easily accomplishable increments.
 *Requirements, plans and results are constantly evaluated so teams can quickly respond to change. 
 *
 *4 pillars of Agile:
 *  1: Individuals and interactions over process and tools - it is more important to communicate with the client and deal with their
 *     questions and suggestions over focusing on the process and tools used. 
 *  2: Working software over comprehensive documentation - while documentation is very important, having a working project that can be
 *     delivered to the client is far more important.
 *  3: Customer collaboration over contract negotiation - clients should be involved in all phases of the project so the team can 
 *     ensure that the final product meets all expectations over following the contract to the tee.
 *  4: Responding to change over following a plan - teams should be able to quickly adapt to change and priorities can be reshifted
 *     from iteration to iteration to ensure the end product meets all expectations. 
 *     
 *12 Principles of Agile Development (Litmus Test):
 *  1: The highest priority is to satisfy the client through early and continuous delivery of working product.
 *  2: Accept changing requirements even if its late in development; this allows the customer to retain competitive advantage.
 *  3: Delivering working product frequently, with a preference for a shorter time scale. 
 *  4: Client and developer should work together daily throughout the project.
 *  5: Build projects around motivated individuals. Give them the environment and support they need, and trust them to get the job
 *     done.
 *  6: The most efficient and effective method of conveying information to and within a development team is face-to-face conversation.
 *  7: Working software is the primary measure of progress. 
 *  8: Agile processes promote sustainable development. The sponsors, developers and users should be able to maintain a constant pace
 *     indefinitely. This usually means a standard 40 hour work week with minimal to no overtime.
 *  9: Continuous attention to technical excellence and good design enhances agility.
 * 10: Simplicity - the art of maximizing the amount of work not done - is essential.
 * 11: The best architectures, requirements and designs emerge from self-organizing teams. 
 * 12: At regular intervals, the team reflects on how to become more efficient, then tunes and adjusts its behavior accordingly. 
 * 
 *Sprints:
 *Sprints, or otherwise known as iterations, is a short period of time where a development team works to complete specific tasks, 
 *milestones, or deliverables. Typically a sprint lasts anywhere between 1 to 4 weeks, depending on the team. It is a fixed period 
 *of development with an end goal. 
 *
 *Sprint Cycle:
 *  1: Planning (determine how much work can be completed within one sprint without overworking)
 *  2: Check-Ins (daily stand ups to see where every team member is at with their assigned tasks)
 *     Stand Up Questions:
 *          1: What did you do?
 *          2: What are you going to do?
 *          3: What do you need help with?
 *  3: Reviews (determine what was accomplished and what wasn't, and then change project forecasts; this step involves both client
 *     and development team)
 *  4: Retrospectives (development team discusses achievesments and challenges; future processes may be changed to avoid future
 *     challenges)
 *     
 *User Stories:
 *A user story is a piece of a project (smallest piece) that can be worked on which represents some value to the client and can be
 *delivered during a sprint. Instead of building a large project from an epic description, we break down the large project into smaller
 *tasks that can be completed in a matter of hours and that can be assigned to different sprints. A user story takes the perspective
 *of someone who is going to use the software that is being developed.
 *
 *User Story Format:
 *As a [type of user], I want [a feature] so that [reason the feature is needed].
 *
 *Examples:
 *1. As an administrator, I want to be able to add and delete users from my website so that I can moderate who has access to the 
 *   content. 
 *2. As a user, I want to be able to sign up for the website, so that I can gain access to members only features.
 *
 *Good User Stories fit the INVEST Model:
 *  Independent: user story can be developed in any sequence, and changes to one story does not affect any other stories.
 *  Negotiable: the team can decide how to implement the story, there is no fixed workflow.
 *  Valuable: each story delivers some sort of value towards the end product.
 *  Estimable: it should be easy to determine approximately how much time a story takes to complete. 
 *  Small: a story should go through the entire cycle (designing, coding, and testing) in a single sprint.
 *  Testable: there should be clear acceptance criteria to check whether a story is properly implemented. 
 *  
 *Acceptance Criteria:
 *An acceptance criteria is a set of conditions that are used to confirm when a story is completed.
 *
 *Example:
 *  User Story: As an administrator, I want to be able to add and delete users from my website so that I can moderate who has access to the 
 *              content.
 *  Possible Acceptance Criterias:
 *      1. The control users page only contains a list of members and not other administrators.
 *      2. A deleted user is instantly logged out of they happen to be logged on at the time that I delete their account.
 *      3. When a user is added, I should be able to set a custom username and password for them; their join date should be 
 *         automatically filled with the day, month, year and time. 
 *         
 * Team 1: I want a piece of software developed which allows me to run a convenience store without 
 *          any cashiers. A customer would come to a locked gate and scan a QR code from an app
 *          which I've already developed. The customer would then be allowed to enter the store as the
 *          gate will unlock for them. If anyone tries to pass through the gate without first scanning
 *          the QR code, an alarm should ring to deter them, and a camera on the gate should take a
 *          picture of them. Once in the store, the customer can then pick up a basket and begin 
 *          shopping. Once the customer is done shopping, they should be able to place their basket
 *          filled with goods into a box which automatically scans the contents of the basket and 
 *          then deducts money from the customer's account (via the app with the QR code). The store is
 *          open between 4 AM to 12 AM and a customer should be able to enter only between those times.
 *          I also have some staff who restock the shelves, and they are allowed in the store between 12
 *          AM and 4 AM. I am worried about my stockers stealing inventory, so I want the exit gate to 
 *          scan over the stockers as they leave to ensure they do not carry any store products. 
 *          
 *          - As a customer I want to be able to scan a QR code, so that I can enter the store.
 *          - As a manager I want to have an alarm ring and my picture taken if I did not scan a QR code, so that I know
 *            the store is safe.
 *          - As a customer, I want to put my basket into a box and have payment automatically be taken from my app, so that
 *            I am not inconvienced.
 *          - As a restocker, I want to be able to scan a QR code, so that I can enter the store to work.
 *          - As a manager, I want the exit gate to scan over stockers leaving the store, so I can ensure they aren't stealing
 *            from me.
 *          
 * Team 2: I am the CEO of a multi-national hotel chain and its time we were brought into the 21st century.
 *          I want an online booking software that allows customers to book rooms available in our hotels.
 *          The customer is expected to sign up for our website with their first name, last name, home 
 *          address, and email address. All of the information is required.The customer should then be 
 *          able to select the province and city to see which hotels have rooms available. Once a 
 *          customer puts a room on reserve, the room should be taken off the listing website. It is 
 *          then the job of a staff member to check that a room is indeed available for reservation 
 *          before either accepting or declining a reservation. In either case, the customer should be
 *          informed of the status of their reservation by email. A manager has the ability to accept
 *          or decline a reservation and also be able to see a full list of accepted reservations. The
 *          manager also reserves the right to cancel any accepted reservations at their discretion. 
 *          Finally, an administrator has the ability to everything that a staff member and a manager
 *          can do, but the administrator can also add new customers, staff members, and managers into 
 *          the system.
 *          
 *          - As a customer, I want to be able to book rooms online, so that it is convenient.
 *          - As a customer, I want to be able to sign up for the website, so that I can book hotel rooms. 
 *          - As a customer, I want to be able to see what hotel rooms are available, so that I know what choices I have.
 *          - As a staff member, I want to be able to inform a customer on whether their reservation is accepted or declined
 *            so that they know whether or not the room is actually available. 
 *          - As a mamnger, I want the abilities of a staff member and to also cancel accepted reservations, so that I can ensure 
 *            that my hotel is running smoothly.
 *          - As an administrator, I want all the abilities of a manager and also to add new users, so that I can manage our roster
 *            of users and take care of day to day business.
 *          
 **/
