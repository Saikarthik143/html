function show() {
    var name1 = document.getElementById("txtbox1").value;
    var name2 = document.getElementById("txtbox2").value;
    var age_box = document.getElementById("Age").value;
    var address = document.getElementById("address").value;
    var gender = document.getElementById("gender").value;
    confirm("u have entered:" + "\n Name:" + name1 + " " + name2 + "\n Age: " + age_box + " address" + address + "gender:" + gender);
}
function changeColor(val) {
    if ((val.value == "") || (val.value == null)) {
        val.style.background = "yellow";
    }
    else {
        val.style.background = "green";
    }
}