var name = "Hello world!";
//Đây là kiểu string cơ bản;

var newstring = new String("Hello world!");
document.writeln(newstring);
document.writeln(typeof newstring); //kiểu dữ liệu của new String là 1 object;

var fullname = "Đây là dấu \\"; //dùng 2 gạch \\ để in ra dấu \

var fullName = "Hello \'World\'";
document.writeln(fullName);

var ten = "Tri Huynh";
var lop = "12b6";
document.writeln(ten.length);
document.writeln("\n toi la: " + ten +' ' + lop);

//Templete ES6; String
 console.log(`Tôi tên: ${ten} ${lop}`);


 // LÀM VIỆC VỚI CHUỖI

 //độ dài của chuỗi: length
 var newString = "Hoc JS Tai JS F8 JS"
 console.log(newString.length);

//Find Index: tìm kiếm vị trí chuỗi;
 console.log(newString.indexOf('JS'));
 console.log(newString.indexOf('JS', 6));   //Vị trí tiếp theo sau JS
 console.log(newString.lastIndexOf('JS'));

 //cut String: slice();
 console.log(newString.slice(0,3));


//replace : thay thế
console.log(newString.replace('JS', 'Javascipt')); //thay thế từ đầu tiên tìm kiếm được;
console.log(newString.replace(/JS/g, 'Javascript')); //thay thế toàn bộ dùng /.../g ;


//Viết hoa toàn bộ: toUpperCase
console.log(newString.toUpperCase());
//Viết thườn toàn bộ: toLowerCase
console.log(newString.toLowerCase());

//trim(): loại bỏ khoảng chắn 2 đầu;
console.log(newString.trim());

//Split() tách các phần tử(chú ý điểm chung);
var languages = 'javascipt, php, ruby';
console.log(languages.split(','));
var js = 'javascipt';
console.log(js.split(''));


//charAt(); trả về 1 kí tự;
console.log(js.charAt(1));