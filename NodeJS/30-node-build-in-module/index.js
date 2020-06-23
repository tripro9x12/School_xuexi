var fs = require('fs');
var text = fs.readFileSync('./text.txt', {encoding: 'utf8'}); //đọc file text
console.log(text);

fs.writeFileSync('./text-2.txt',  'I\'m Học viên CodersX');  // ghi file;
var a = fs.readFileSync('text-2.txt', {encoding: 'utf8'});
console.log(a);

var path = require('path');
var b = path.basename('C/A/A/A/B.html');
console.log(b);