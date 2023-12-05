// Put your code here

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

const roll = () => {
    let dieValue = getRandomInt(1, 6)
    return dieValue
}

const numbersToWords = ["one", "two", "three", "four", "five", "six"]

console.log("Let's roll some dice, baby!")
console.log("----------------------------")

for (let i = 0; i < 10; i++) {
    let die1 = roll()
    let die2 = roll()
    let message = `${numbersToWords[die1 - 1]} + ${numbersToWords[die2 - 1]} == ${die1 + die2}`
    if (die1 === die2) {
        message += " DOUBLES!"
    }
    console.log(message)
}