var readlineSync = require('readline-sync');
//string
// var name = readlineSync.question("What your name?");
// console.log(`Hi,tên của tôi là: ${name} !!!`);

// //array
// var languages = [];
// var language = readlineSync.question('ngon ngu ban dang hoc la gi?');
// languages.push(language);
// console.log(`Tiếng ${languages} ...`);

//Object
var pet ={};
var name = readlineSync.question('Your pet name');
var gender = readlineSync.question('Gender: (Female/Male/Othes) ');
var age = readlineSync.question('Age: ');
var weight = readlineSync.question('Weight: ');

pet.name = name;
pet.gender = gender;
pet.age = parseInt(age);
pet.weight = parseInt(weight);
console.log(pet);