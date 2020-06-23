var student = {
    name: 'David Rayy',
    class: 'VI',
    rollno: 12
}
function removeProp(prop){
    for(var i in student){
        if(i===prop){
            delete student[i];    
        }
    }
    console.log(student);
    
   
}
removeProp('name');
removeProp('class');