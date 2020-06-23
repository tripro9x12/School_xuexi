var courses = [
    {name: 'Javascript', coin:680},
    {name: 'PHP', coin:860},
    {name: 'Ruby', coin:980}
]
Array.prototype.filter2 = function(callback){
    var output = [];
    for(var index in this){
        if(this.hasOwnProperty(index)){
            var result = callback(this[index], index, this);
            if(result){
               output.push(this[index]);
        }}
        
    }
    console.log(output)
    // return output;
}


var filterResult = courses.filter2((course, index, array)=>{
   
     return course.coin > 700;
})
// console.log(filterResult);
