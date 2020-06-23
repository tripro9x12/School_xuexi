//Toán tử 3 ngôi;
var course = {
    name: 'Javascript',
    coin: 250
}
if(course.coin>0){
    // console.log(course.coin + "Coins");
    console.log(`${course.coin} Coins`);
}
else{
    console.log('Free');
}

var result = course.coin > 0 ? `${course.coin} Coins` : 'Miễn Phí';
console.log(result);