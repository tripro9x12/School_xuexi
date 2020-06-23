function showDialog(){
    alert('hello everybody');
}
showDialog();

function writeLog(x){           //x được gọi là tham số
    console.log(x);
    console.log(typeof x);
} 
writeLog("Hello Everybody");      //Hello Everybody là đối số;


function showMaker(){
    // console.log(arguments);     //dùng đối tượng arguments khi không biết tham số;

    // for(var param of arguments){           arguments: đối số;
    //     console.log(param);
    // }

    var myString = '';
    for(var i of arguments){
        myString+= `${i} - `;
    }
    console.log(myString);
}
showMaker("Log1", "Log2", "log3");


//return trong Hàm;
function sum(a, b){
    return a+b;
}
var result = sum(2, 3);
console.log(result);

// khi nhiều function trùng tên thì nó chỉ gọi đến function được khai báo cuối cùng;

//Hàm trong hàm
function showImage(){
    function showImage2(x){
        console.log(x);
    }
    showImage2("Xin chào tất cả mọi người"); //gọi đến đối số của x;
}
showImage();


// Các loại function
//declaration function(hàm khai báo(basic))   declaration: khai báo;
function show1(){
    console.log('Declaration Function');
}
show1();
//Expression function(biểu thức hàm): có thêm phép gán = ;    expression: biểu thức;
var show2 = function(){
    console.log('Expression Function');
}
show2();
setTimeout(function autoLogin(){
console.log("abc");
}, 1000);