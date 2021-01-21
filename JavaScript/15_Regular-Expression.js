let path = /freetuts.net/i;
if (path.test("freetuts")) {
    console.log("trong chuỗi có chữ freetuts");
} else {
    console.log("trong chuỗi không có freetuts");
}

if (/t+/.test("freetuts")) {
    console.log("có chữ t");
} else {
    console.log("ko có chữ t");
}