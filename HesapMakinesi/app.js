function engelle() {

    document.getElementById("sayi").disabled = true;
}

function clr() {
    document.getElementById("sayi").value = ""
}

function dis(val) {
    document.getElementById("sayi").value += val

}
//function for evaluation
function solve() {
    let x = document.getElementById("sayi").value
    let y = eval(x)
    document.getElementById("sayi").value = y

}
//function for clearing the display
function doMath(val) {
    //var result = ""
   // console.log("hello")

    var inputNum1 =document.getElementById("sayi").value;
    
   /* if(isNaN(inputNum1))
    {
        console.log("yes")
    }*/
    
   
        var  result = Math.sqrt(inputNum1);
        document.getElementById("sayi").value = result;
    
    
   
    
    
}


