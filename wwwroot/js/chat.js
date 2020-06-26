"use strict";

//establishing connection....
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true

//Call client methods from hub, start recieving a mesage from server, and show message
connection.on("ReceiveMessage", function (user, message) {
    var msg = user + " : " + message;
    var li = document.createElement(li);
    li.textContent = msg;
    document.getElementById("messageLists").appendChild(li);
});

//start a connection from client to server, enable a send button
connection.start().then(function() {
    document.getElementById("sendButton").disabled = false
}).catch(function err() {
    return console.err(err.toString());
})

// Call hub methods from client, try to bind message and user and send message to server.
document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value
    var message = document.getElementById("messageInput").value
    connection.invoke("SendMessage",user, message).catch(function (err) {
        return console.error(err.toString());
    });
});