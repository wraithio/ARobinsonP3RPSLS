let rockBtn = document.getElementById("rockBtn");
let paperBtn = document.getElementById("paperBtn");
let scissorsBtn = document.getElementById("scissorsBtn");
let lizardBtn = document.getElementById("lizardBtn");
let spockBtn = document.getElementById("spockBtn");
let submitBtn = document.getElementById("submitBtn");
let menuBtn = document.getElementById("menuBtn");
let rulesBtn = document.getElementById("rulesBtn");
let vscpuBtn = document.getElementById("vscpuBtn");
let oneV1Btn = document.getElementById("1v1Btn");
let sdBtn = document.getElementById("sdBtn");
let of5Btn = document.getElementById("of5Btn");
let of7Btn = document.getElementById("of7Btn");
let gameIcon = document.getElementById("gameIcon");

rockBtn.addEventListener("mouseover", function(){
    gameIcon.src = "/Assets/rockmonsteravi.webp"
    gameIcon.alt = "Rock Monster"
})

paperBtn.addEventListener("mouseover", function(){
    gameIcon.src = "/Assets/papermonsteravi.webp"
    gameIcon.alt = "Paper Monster"
})
scissorsBtn.addEventListener("mouseover", function(){
    gameIcon.src = "/Assets/scissorsmonsteravi.webp"
    gameIcon.alt = "Scissors Monster"
})
lizardBtn.addEventListener("mouseover", function(){
    gameIcon.src = "/Assets/lizardmonsteravi.png"
    gameIcon.alt = "Lizard Monster"
})
spockBtn.addEventListener("mouseover", function(){
    gameIcon.src = "/Assets/spockavi.jpg"
    gameIcon.alt = "Spock in a robot suit"
})

