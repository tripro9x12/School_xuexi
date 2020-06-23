//Object prototype(nguyên mẫu).

//tạo bản thiết kế
function User(firstName, lastName, avatar){
    this.firstName = firstName;
    this.lastName = lastName;
    this.avatar = avatar;

    this.getName = function(){
        return `${this.firstName} ${this.lastName}`;
    }
}

//protype dùng để khởi tạo thuộc tính or phương thức chung ở bên ngoài constructor(bản thiết kế);
User.prototype.class = 'F8';
User.prototype.getClass = function(){
    return this.class;
}

User.prototype.getTen = function(){
    return `${this.firstName} ${this.lastName}` ;
}



//khởi tạo
var myName = new User('Trí', 'Huỳnh', 'Avatar');
var user = new User('Thạnh', 'Huỳnh', 'Avatar');
console.log(myName);
console.log(user);

console.log(user.getClass());
console.log(myName.getTen());


var zhongguo = '我是败类中的败类'
for(var i of zhongguo){
     console.log(i);
}