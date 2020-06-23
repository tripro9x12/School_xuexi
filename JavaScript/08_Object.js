var addresskey = 'address';   //biến addresskey
var myInfor = {
    name: 'Trí Huỳnh',
    age: 22,
    gender: 'male',
    [addresskey]: 'Huế, VN',    //nhận address từ biến addresskey làm key;
    getName: function(){
        return this.name;
    }
};
//thêm 1 key mới;
myInfor.email = 'tripro9x12@gmail.com'; 
console.log(myInfor);

//gọi đến biến thì phải dùng dấu [];
var mykey = 'gender';
console.log(myInfor[mykey]);

//xóa 1 key dùng delete;
delete myInfor.address;  //tên_biến.key;
console.log(myInfor);

                          //FUNCTION -> PHƯƠNG THỨC/ METHOD();
                          //OTHERS -> THUỘC TÍNH/ PROPERTY;
//trả về kết quả name trong phương thức getName();
console.log(myInfor.getName());
