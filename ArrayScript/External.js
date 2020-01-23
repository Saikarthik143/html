var domain = [ "DotNet", "java", "Dw", "DLD"];
var text = " ";
var i;
for (i = 0; i < domain.length; i++) {
    text += domain[i] + "<br>";
}
document.write(text);

function getAlert() {
    var n = isNaN("2");
    var n1 = isNaN("abc");
    var n2 = isNaN(123);
    var n3 = eval("45*2");
    document.getElementById("ref").innerHTML += n + "<br>";
    document.getElementById("ref").innerHTML += n1 + "<br>";
    document.getElementById("ref").innerHTML += n2 + "<br>";
    document.getElementById("ref").innerHTML += n3 + "<br>";
    var n4 = parseInt("10", 2);
    var n5 = parseFloat("wdwd56");//convert string to float
    var n6 = parseFloat("123.456");
    var n7 = parseInt("11", 8);
    var n8 = parseInt("15", 10);
    document.getElementById("ref").innerHTML += n4 + "<br>";
    document.getElementById("ref").innerHTML += n5 + "<br>";
    document.getElementById("ref").innerHTML += n6 + "<br>";
    document.getElementById("ref").innerHTML += n7 + "<br>";
    document.getElementById("ref").innerHTML += n8 + "<br>";
}
getAlert();
    