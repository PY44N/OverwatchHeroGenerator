local discordia = require('discordia')
local client = discordia.Client()
local prefix = "!"
local file = io.open("token.txt", "rb")
local token = file:read "*a"
local Hero = require("Hero")
file:close()

client:on('messageCreate', function(message)
    local text = string.lower(message.content)

    if string.match(text, "!") then
        text = text:gsub("!", "")
        if string.match(text, "gen") or string.match(text, "generate") then 
            if string.match(text, "all") then
                message.channel:send("Your Hero Is: "..Hero.Gen())
            elseif string.match(text, "tank") then
                message.channel:send("Your Hero Is: "..Hero.GenTank())
            elseif string.match(text, "damage") then
                message.channel:send("Your Hero Is: "..Hero.GenDamage())
            elseif string.match(text, "support") then
                message.channel:send("Your Hero Is: "..Hero.GenSupport())
            else
                message.channel:send("Hero Type Not Found, Hero Types are All, Tank, Damage, and Support")
            end
        end
    end
end)

client:run("Bot "..token)