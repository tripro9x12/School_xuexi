var courses =[
    {
        id: 1,
        name: 'Javascript',
        coin: 250
    },
    {
        id: 2,
        name: 'HTML, CSS',
        coin: 0
    },
    {
        id: 3,
        name: 'Ruby',
        coin: 0
    },
    {
        id: 4,
        name: 'PHP',
        coin: 400
    },
    {
        id: 5,
        name: 'ReactJS',
        coin: 500
    },
    {
        id: 6,
        name: 'PHP',
        coin: 0
    },

];

//forEach() duyệt qua các phần tử của mảng
courses.forEach((courses, index)=>{
    console.log(index, courses);
});

//every(): trả về true or false(duyệt từng phần từ, case sai sẽ dừng lại);
function everyy(boolean){
    return boolean.every(function(boolean, index){
        console.log(index, boolean.coin == 0);
    });
}
everyy(courses);

//some(): trả về true or false(duyệt qua từng phần tử, case đúng sẽ dừng lại)
function somee(boolean){
    return boolean.some((boolean, index)=>{
        console.log(index, boolean.coin === 0);
    });
}
somee(courses);

//find(): trả về tất cả kết quả đúng
function findd(z){
    var b = z.find((z)=>{
        return z.name =='PHP';
    })
    console.log(b);
}
findd(courses);

//filter(); trả về tất cả kết quả đúng
function filterr(z){
    var a = z.filter((z)=>{
        return z.coin === 0;
    })
    console.log(a);
}
filterr(courses);

//map() duyệt qua các phần tử của mảng; giống với forEach();
function show(x){
    return x.map((x, y)=>{
       console.log(y, x.name);
    })
}
show(courses);


//reduce(); giá trị đầu = giá trị đầu + giá trị sau
function reducee(x){
    var c =  x.reduce((x, y)=>{
       return x + y.coin;
    }, 0);
    console.log(c)
}
reducee(courses);
//sort(); sắp xếp giá trị
function sapxep(x){
      var d = x.map((x)=>{
          return x.coin
      }).sort((x,y)=>{
          return x-y;
      })
    console.log(d);
}
sapxep(courses);