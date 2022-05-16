
 
var sonuc
const cevir = (tx) =>                               //   Arrow Function
parseInt(document.getElementById(tx).value)  /*   veya  Number(document.getElementById(tx).value) */




/* function cevir(tx){
    return parseInt(document.getElementById(tx).value)
}
 */
function topla(){

 /*    sonuc = cevir("sayi1") + cevir("sayi2") */
    /* if(isNaN(sonuc)){

       console.log("yes")
      }
      else{
      
        console.log("no")
      
      } */

      var sayi1= parseInt(document.getElementById("sayi1").value);    // Eğer bu şekilde tanımlayacaksan her metodun içinde ayrı ayrı tanımlamalısın 
      var sayi2= parseInt(document.getElementById("sayi2").value);
      sonuc = sayi1 + sayi2
      
document.getElementById('result').innerHTML = sonuc                        /*   javascript sayıyı ondalığa çaviriyor */
}

const  cikar = () =>   document.getElementById('result').innerHTML = cevir("sayi1") - cevir("sayi2")   // En sade hali
    

  
    




function carp(){
    sonuc = cevir("sayi1") * cevir("sayi2")
    document.getElementById('result').innerHTML = sonuc
    
}


function bol(){
    sonuc = cevir("sayi1") / cevir("sayi2")
    document.getElementById('result').innerHTML = sonuc
  
}
