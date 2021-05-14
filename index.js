
let arr = ["abc573","a5b7c3"]

function string2int(input) {
  
  let output = "";
  for (var i = 0; i < input.length; i++) {

    let inputStr = (input.charAt(i));
    if (Number(inputStr)) {
      output += inputStr.toString();
    }
  }

  return output;
}

arr.forEach(e => {
  console.log(`Output`, string2int(e))
});
