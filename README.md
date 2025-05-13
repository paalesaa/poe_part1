# POE Part 2 ChatBot  ST10461720

## Description  
In POE Part 2, we expand the Cybersecurity Awareness ChatBot to provide more dynamic responses, recognise specific cybersecurity-related keywords, and incorporate memory to recall information shared by the user. It includes updated elements such as:  
- Random responses  
- Conversational flow  
- Memory and recall
- Sentiment detection

The chatbot focuses on topics related to *cybersecurity* i.e :
- Phishing
- Password security
- Public Wi-Fi
- Malware
- Firewall
- SQL Injection
- Privacy

## Usage  
Updated objectives:
1. Introduce variation by having the chatbot select from multiple predefined responses for common cybersecurity queries.
Tasks
* For some cybersecurity topics, such as "phishing tips", ensure the chatbot randomly selects
one of several informative responses.
Use arrays or lists to manage these responses effectively to keep interactions varied and engaging.
Example
User: "Give me a phishing tip."
Chatbot: (Randomly selects from a list of responses) "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations."

2. Conversation Flow
Objective: Enable the chatbot to maintain a conversational flow that feels natural and responsive.
Tasks
* Ensure the chatbot can handle follow-up questions or statements without restarting the
conversation, creating a seamless flow.
If the user expresses confusion or asks for more details, the chatbot should continue the current topic, especially for important cybersecurity topics.

3.Memory and Recall
Objective: Implement a memory feature to allow the chatbot to "remember" user details and refer. back to them.
Tasks
* Store certain information provided by the user (e.g., their name, favourite cybersecurity
topic) and use it later in the conversation.
Use this feature to personalise responses and make cybersecurity tips more engaging.
* User: "I'm interested in privacy."
Chatbot: "Great! I'll remember that you're interested in privacy. It's a crucial part of staying safe online."
Later in the conversation:
Chatbot: "As someone interested in privacy, you might want to review the security settings on your accounts."

4.Sentiment Detection
Objective: Allow the chatbot to adjust its responses based on the user's sentiment to create an
empathetic interaction.
Tasks
* Detect simple sentiments such as "worried", "curious", or "frustrated" when discussing cybersecurity topics.
Adjust the chatbot's responses accordingly to provide encouragement or support if the user feels overwhelmed or unsure.
Example
User: "I'm worried about online scams."
Chatbot: "It's completely understandable to feel that way. Scammers can be very convincing.
Let me share some tips to help you stay safe."

## Installation  
No installation is required. The chatbot runs directly as a console application.  
It is done/coded on Visual Studio 2022, on Netframe 4.0.8
Template: Console App C# Netframework

## Contribution  
Currently, contributions are not yet defined. Future updates can include contribution guidelines.  

## License  
This project does not use a specific license.  

This is an academic assignment and may be expanded in future iterations.


![memory and recall screenshot](https://github.com/user-attachments/assets/e83d9d75-b055-4a95-a1df-58464680cef6)


![sentiment detection screenshot](https://github.com/user-attachments/assets/7439ae60-3bc8-4604-9819-98274537bfa2)
