//Vars
const Discord = require('discord.js')
const client = new Discord.Client()
const Hero = require('./hero.js')
var fs = require('fs');

//Core
client.on('ready', () => {
    console.log("Connected as " + client.user.tag)
    client.user.setActivity("!Generate"); 
})

client.on('message', (msg) => {
    if (msg.author != client.user) {
        if  (msg.content.startsWith("!")) {
            ProcessCmd(msg)
        }
    }
})

//Process Command
function ProcessCmd(msg) {
    let fullCommand = msg.content.substr(1)
    let splitCommand = fullCommand.split(" ")
    let primaryCommand = splitCommand[0].toLowerCase()
    let arguments
    if (splitCommand[1]) {
        arguments = splitCommand[1]
    } else {
        arguments = ""
    }
    if (primaryCommand == "gen" || primaryCommand == "generate") {
        GenerateCmd(msg, arguments)
    }
}

//Commands
function GenerateCmd(msg, args) {
    if (args == "all") {
        msg.channel.send("Your Hero Is: " + Hero.Gen())
    } else if (args == "tank") {
        msg.channel.send("Your Hero Is: " + Hero.GenTank())
    } else if (args == "damage") {
        msg.channel.send("Your Hero Is: " + Hero.GenDamage())
    } else if (args == "support") {
        msg.channel.send("Your Hero Is: " + Hero.GenSupport())
    } else {
        msg.channel.send("Hero Type Not Found, Hero Types are All, Tank, Damage, and Support")
    }
}

//Read Token Then Run
fs.readFile('token.txt', 'utf8', function(err, Token) {
    if (err) throw err;
    client.login(Token)
});