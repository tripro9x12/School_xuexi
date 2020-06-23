var courses = [
    {name: 'Javascript', coin:680},
    {name: 'PHP', coin:860},
    {name: 'Ruby', coin:980}
]
Array.prototype.reduce2 = function(callback){
    var sum = 0;
    for(var i in this){
        if(this.hasOwnProperty(i)){
            var result = callback(this[i], i)
            if(result){
                sum +=this[i].coin;
                
            }
        }
    }
    return sum;
    
}



var reduce = courses.reduce2((courses, index)=>{
     return courses + index.coin;
}, 0)
console.log(reduce);