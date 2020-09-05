// NODE.JS APP TO TEST THE SHREDDER!
/*
<c> SHarkbyteprojects
*/
const towatch="TestFile.txt";/*NAME OF THE FILE THAT YOU SHRED TO WATCH IT WHILE THE SHREDDER SHREDS IT!
------------------------

*/

const fs = require("fs");
function xxxs(){
    try{
    const xxx=fs.readFileSync(towatch);
    console.log("ByteLength:");
    console.log(xxx.length.toString());
    console.log("Bytes:");
    console.log(xxx);
    console.log("UTF8:");
    console.log(xxx.toString("utf8"));
    console.log("----END----");
    }catch(e){
        console.log("File Err\n");
    }
}
xxxs();
function watc(){
try{
fs.watch(towatch, xxxs);
}catch(e){
    watc();
}
}
watc();