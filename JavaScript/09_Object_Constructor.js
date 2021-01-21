//Object constructor: xây dựng đối tượng

//tạo bản thiết kế
function User(firstName, lastName, avatar) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.avatar = avatar;

    this.getName = function () {
        return `${this.firstName} ${this.lastName}`;
    }
}
class Person {
    fullName;
    age;
    constructor(fullName, age) {
        this.fullName = fullName;
        this.age = age;
    }
    toString = () => `FullName: ${this.fullName} | Age: ${this.age}`;
}
let staff_1 = new Person('Tri', 23);
console.log(staff_1.toString());

//khởi tạo
var myName = new User('Trí', 'Huỳnh', 'Avatar');
var user = new User('Thạnh', 'Huỳnh', 'Avatar');

//thêm key mới;
myName.title = 'Học Js tại F8';
user.comment = 'Free';

console.log(myName);

console.log(myName.getName());

console.log(user);

console.log(user.getName());
