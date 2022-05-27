// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function change(decoded, encoded) { 
    var randstring = ""; 
    var rslength = chars.length - got.length; 
    var decrypted = document.getElementById(decoded); 
    var encrypted = document.getElementById(encoded); 

    for(var x=0;x<rslength;x++) randstring += chars.charAt(Math.floor(Math.random() * chars.length)); 
    if(randstring.charAt(0) == chars.charAt(got.length)) { 
        got += randstring.charAt(0); 
        decrypted.innerHTML = got; 
    } 
    else encrypted.innerHTML = randstring; 

    if(chars.length > got.length) setTimeout(`change("${decoded}", "${encoded}")`, 1);  
    else encrypted.innerHTML = ""; 
}

function decrypt(decoded, encoded) { 
    var decrypted = document.getElementById(decoded); 
    
    chars = decrypted.innerHTML; 
    decrypted.innerHTML = ""; 
    got = ""; 
    setTimeout(`change("${decoded}", "${encoded}")`, 1); 
} 

function startTimer(timer) {
  [min, sec] = timer.split(":");
  [min, sec] = [parseInt(min), parseInt(sec)];
  setInterval(function() {
    if (min >= 0)
      document.getElementById("timer").innerHTML = (min).toString().padStart(2, '0') + ':' + (sec).toString().padStart(2, '0');
    sec--;
    if (sec < 0) {
      min--;
      sec = 59;
      if (min <= 0) $("#defeat-msg").modal("show");
    }
  }, 1000);
}

function useClue(num) {
  let used = document.getElementById("clues-used").value
  if (!used.includes(num)) document.getElementById("clues-used").value += num.toString()
}