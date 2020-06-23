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
var a = courses.reduce((x, y)=>{
    return x + y.coin;
}, 0);
console.log(a);

var b = courses.map(x=>{
    return x.coin;
}).reduce((x,y)=>{
    return x+y;
}, 0);
console.log(b);

var array = courses.reduce((a, b)=>{
    return a.concat(b.name);
}, [])
console.log(array.join(' - '));