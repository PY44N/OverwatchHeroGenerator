local a = {}

local HeroNum

function a:GenTank()
    HeroNum = math.random(1, 8)

    if HeroNum == 1 then
        return "D.VA"
    end
    if HeroNum == 2 then
        return "ORISA"
    end
    if HeroNum == 3 then
        return "REINHARDT"
    end
    if HeroNum == 4 then
        return "ROADHOG"
    end
    if HeroNum == 5 then
        return "SIGMA"
    end
    if HeroNum == 6 then
        return "WINSTON"
    end
    if HeroNum == 7 then
        return "WRECKING BALL"
    end
    if HeroNum == 8 then
        return "ZARYA"
    end

    return "ERROR"
end

function a:GenDamage()
    HeroNum = math.random(1, 17)

    if HeroNum == 1 then
        return "ASHE"
    end
    if HeroNum == 2 then
        return "BASTION"
    end
    if HeroNum == 3 then
        return "DOOMFIST"
    end
    if HeroNum == 4 then
        return "ECHO"
    end
    if HeroNum == 5 then
        return "GENJI"
    end
    if HeroNum == 6 then
        return "HANZO"
    end
    if HeroNum == 7 then
        return "JUNKRAT"
    end
    if HeroNum == 8 then
        return "MCCREE"
    end
    if HeroNum == 9 then
        return "MEI"
    end
    if HeroNum == 10 then
        return "PHARAH"
    end
    if HeroNum == 11 then
        return "REAPER"
    end
    if HeroNum == 12 then
        return "SOLDIER: 76"
    end
    if HeroNum == 13 then
        return "SOMBRA"
    end
    if HeroNum == 14 then
        return "SYMMETRA"
    end
    if HeroNum == 15 then
        return "TORBJÖRN"
    end
    if HeroNum == 16 then
        return "TRACER"
    end
    if HeroNum == 17 then
        return "WIDOWMAKER"
    end

    return "ERROR"
end

function a:GenSupport()
    HeroNum = math.random(1, 7)
    
    if HeroNum == 1 then
        return "ANA"
    end
    if HeroNum == 2 then
        return "BAPTISTE"
    end
    if HeroNum == 3 then
        return "BRIGITTE"
    end
    if HeroNum == 4 then
        return "LÚCIO"
    end
    if HeroNum == 5 then
        return "MERCY"
    end
    if HeroNum == 6 then
        return "MOIRA"
    end
    if HeroNum == 7 then
        return "ZENYATTA"
    end

    return "ERROR"
end

function a:Gen()
    HeroNum = math.random(1, 32)

    if HeroNum == 1 then
        return "ANA"
    end
    if HeroNum == 2 then
        return "ASHE"
    end
    if HeroNum == 3 then
        return "BAPTISTE"
    end
    if HeroNum == 4 then
        return "BASTION"
    end
    if HeroNum == 5 then
        return "BRIGITTE"
    end
    if HeroNum == 6 then
        return "D.VA"
    end
    if HeroNum == 7 then
        return "DOOMFIST"
    end
    if HeroNum == 8 then
        return "ECHO"
    end
    if HeroNum == 9 then
        return "GENJI"
    end
    if HeroNum == 10 then
        return "HANZO"
    end
    if HeroNum == 11 then
        return "JUNKRAT"
    end
    if HeroNum == 12 then
        return "LÚCIO"
    end
    if HeroNum == 13 then
        return "MCCREE"
    end
    if HeroNum == 14 then
        return "MEI"
    end
    if HeroNum == 15 then
        return "MERCY"
    end
    if HeroNum == 16 then
        return "MOIRA"
    end
    if HeroNum == 17 then
        return "ORISA"
    end
    if HeroNum == 18 then
        return "PHARAH"
    end
    if HeroNum == 19 then
        return "REAPER"
    end
    if HeroNum == 20 then
        return "REINHARDT"
    end
    if HeroNum == 21 then
        return "ROADHOG"
    end
    if HeroNum == 22 then
        return "SIGMA"
    end
    if HeroNum == 23 then
        return "SOLDIER: 76"
    end
    if HeroNum == 24 then
        return "SOMBRA"
    end
    if HeroNum == 25 then
        return "SYMMETRA"
    end
    if HeroNum == 26 then
        return "TORBJÖRN"
    end
    if HeroNum == 27 then
        return "TRACER"
    end
    if HeroNum == 28 then
        return "WIDOWMAKER"
    end
    if HeroNum == 29 then
        return "WINSTON"
    end
    if HeroNum == 30 then
        return "WRECKING BALL"
    end
    if HeroNum == 31 then
        return "ZARYA"
    end
    if HeroNum == 32 then
        return "ZENYATTA"
    end

    return "ERROR"
end

return a