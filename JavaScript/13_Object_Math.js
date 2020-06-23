//Math.PI;
console.log('Đây là PI: ' + Math.PI)


//Math.round(); làm tròn số
console.log('đây là Math.round(làm tròn số <.49 : >5)')
console.log(Math.round(1.49));
console.log(Math.round(1.53));

//Math.abs(): giá trị tuyệt đối, viết tắt của từ absolute
console.log('đây là Math.abs(-4): ' +Math.abs(-4));

//Math.ceil(): làm tròn trên
console.log(`đây là Math.ceil(làm tròn trên >.0): ${Math.ceil(5.01)}` );

//Math.floor(): làm tròn dưới
console.log(`đây là Math.floor(làm tròn dưới <0.999999999): ${Math.floor(5.999999)}`);

//Math.random():
var random = Math.floor(Math.random() * 100);
var result = random < 10 ? `${random}% có người yêu` : `${random}% không có người yêu`;
console.log(`${result}`); 

var random2 = [
    '10 coin',
    '20 coin',
    '30 coin',
    '40 coin',
    '50 coin',
    'Chúc bạn may mắn lần sau',
]
console.log(random2[Math.floor(Math.random()*6)]);


//Math.max(): trả về số lớn nhất  
//Math.min(): trả về số bé nhất
var number = [10, 20, 40, -10, -100, 90, -90];
console.log('Đây là Math.max():' + Math.max(...number));
console.log('Đây là Math.min():' + Math.min(...number));

//Math.pow(): trả về kết quả là số mũ
var x = 2;
console.log('Đây là Math.pow()');
console.log(Math.pow(x, 2));
console.log(Math.pow(x, 3));
