//kiểu dữ liệu là String, (không dùng)
var date2 = Date();
console.log(typeof date2);
console.log(date2);




//kiểu dữ liệu là object
var date = new Date();
console.log(typeof date);
console.log(date);


var year = date.getFullYear();      // trả về năm
var month = date.getMonth() + 1 ;  //(trả về từ 0-11 nên phải +1)
var day = date.getDate();

console.log(day);
console.log(month);
console.log(year);
console.log(`${day}/${month}/${year}`)

//giờ phút giây
var hours = date.getHours();       //giờ
var minutes = date.getMinutes();   //phút
var seconds = date.getSeconds();   //giây
console.log(`${hours}:${minutes}:${seconds}`)
