// Put your code here

const createEnemy = (firstName, lastName, offenses, isreallyhated) => {
    return {
      FirstName: firstName,
      LastName: lastName,
      Offenses: offenses,
      IsReallyHated: isreallyhated,
      addOffenses: (offense) => {
        this.offenses.push(offense);
      },
    };
  };

const enemies = []
enemies.push(createEnemy("Joshua", "Flowers", ["Being a jerk to me in elementary school", "Not being nice to me in elementary school"], false))
enemies.push(createEnemy("Darth", "Vader", ["Cut off Luke's hand", "Murdered all those kids", "Unkind management practices"], false))
enemies.push(createEnemy("Betty", "Rudelady", ["Phone calls in the theater", "Phone calls on the bus", "Phone calls in line at the grocery store", "Poor conversattionalist"], true))
enemies.push(createEnemy("Leon", "Peck", ["Keeps giving me a hotplate"], false))

console.log("My Enemies List!")
console.log("-----------------")

enemies.forEach((enemy) => {
    if (enemy.IsReallyHated) {
        console.log(`${enemy.FirstName} ${enemy.LastName} (Really, really dislike!)`)
    } 
    else {
        console.log(`${enemy.FirstName} ${enemy.LastName}`)
    }
})
