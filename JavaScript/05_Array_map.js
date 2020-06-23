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
        name: 'Ruby',
        coin: 300
    },
    {
        id: 7,
        name: 'Ruby',
        coin: 200
    },
];
var newCourses = courses.map(function(x){
       return{
           id: x.id,
           name: `Khoá học: ${x.name}`,
           coin: x.coin,
           coinText: `Giá: ${x.coin} `
       }
})
console.log(newCourses);


//gọi 1 key bất kì;
var newmap = courses.map(y=>{
    return `<h2>${y.name}</h2>`;
})
document.write(newmap.join(' '));
