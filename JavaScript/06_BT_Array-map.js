Array.prototype.map2 = function(callback){
    var ouput;
    for(var index in this){
        if(this.hasOwnProperty(index)){    // index gần nhất
           ouput = callback(this[index], index);
        }                          
    }
}
var courses = [
    'Javascript',
    'PHP',
    'Ruby'
];
courses.map2(function(course, index, array){
    console.log(course, index);
})
