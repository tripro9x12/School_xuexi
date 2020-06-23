//array có thể chứa toàn bộ kiểu dữ liệu:
var languages = [
   'Javascript',
   'PHP',
   'Ruby',
   null,
   undefined,
   function(){

   },
   {},
   123
];
console.log(languages);

//cách này khuyến cáo không dùng
var array = new Array(
    'red',
    'blue',
    'green'
);
console.log(typeof array); //kiểu trả về là object;

//kiểm tra phải array hay không. dùng Array.isArray();
console.log(Array.isArray(array));

//độ dài mảng: length;
console.log(languages.length);

//lấy giá trị index;
console.log(languages[0]);


                       //LÀM VIỆC VỚI ARRAY
//1. toString(); chuyển về chuỗi
console.log(languages.toString());

//2.join(); giống kiểu toString nhưng có thể truyền giá trị vào;
console.log(languages.join(', '));

//3.pop(); xóa phần tử cuối mảng và trả về phần tử đã xóa;
console.log(array.pop());

//4.push(); thêm phần tử vào cuối mảng và trả vế độ dài mới của mảng;
console.log(array.push('yellow', 'pupper'));
console.log(array);

//5.shift(); xóa các phần tử đầu mảng và trả về các phần tử đã xóa;
console.log(array.shift());

//6.unshift(); thêm các phần tử vào đầu mảng và trả về độ dài mới của mảng;
console.log(array.unshift('red','white'));
console.log(array);

//7.splice(); xóa, chèn phần tử; splice(index, deleteIndex, 'Phần tử muốn chèn');
console.log(array.splice(1, 2, 'orange')); //truy xuất các phần tử đã xóa, và chèn 1 phần tử mới vào mảng
console.log(array);

//8.concat(); nối mảng
var color =[
    'red',
    'yellow',
    'blue',
];
var color2 =[
    'red',
    'blue',
    'green'
];
console.log(color.concat(color2));

//9.slice(); cắt và trả về các phần tử đã cắt;(copy)
console.log(color2.slice(1,3));
console.log(color2);