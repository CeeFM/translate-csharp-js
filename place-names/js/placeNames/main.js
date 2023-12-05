// Put your code here

const names = [
   "Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
];

console.log("All Place Names");

for (const name of names) {
  console.log(name);
}

console.log(" ")

const theNames = names.filter((nm) => nm.startsWith("The"))
console.log("'The' Place Names")

for (const theName of theNames) {
  console.log(theName)
}