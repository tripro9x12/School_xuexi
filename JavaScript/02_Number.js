var num = 2;
var number = new Number(3);
console.log(typeof number);  //kiểu object; tránh sử dụng;


var age = 22;
var PI = 3.14;

var result = 20 / 'ABC';
console.log(isNaN(result)); //Kiểm tra NaN


//toString;
var number2 = 3.15;
var number3 = number2.toString();
console.log(number3);
console.log(typeof number3);


//toFixed();
//làm tròn số nhưng nó là kiểu string 
var so = 3.49;
console.log(so.toFixed(4));
var so2 = 3.5;
console.log(so2.toFixed());
console.log(typeof so2.toFixed());
