// Put your code here

console.log("Do you believe in magic?")
console.log("------------------------")

const createSpell = (name, isevil, energyrequired) => {
    return {
      Name: name,
      IsEvil: isevil,
      EnergyRequired: energyrequired
    };
  };

const spells = []

spells.push(createSpell("Turn enemy into a newt", true, 5.1))
spells.push(createSpell("Conjure some gold for a local charity", false, 2.99))
spells.push(createSpell("Give a deaf person the ability to heal", false, 12.2))
spells.push(createSpell("Make yourself emperor of the universe", true, 100.0))
spells.push(createSpell("Convince your relatives your political views are corre)ct", false, 2921.5))

console.log()
console.log("Good Book")

spells.forEach((spell) => {
    if (!spell.IsEvil) {
        console.log(`   ${spell.Name}`)
    }
})

console.log()
console.log("Evil Book")

spells.forEach((spell) => {
    if (spell.IsEvil) {
        console.log(`   ${spell.Name}`)
    }
})
