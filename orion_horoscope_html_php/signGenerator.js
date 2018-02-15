function Sign(intStartDate,intEndDate,image ,n,startDate,endDate, description){
    this.img = image;
    this.desc = description;
    this.name = n;
    this.sD = startDate;
    this.eD = endDate;
    this.intSD = intStartDate;
    this.intED = intEndDate;
    this.readPair = function () {
        var str = '';
        // create row
        str += '<tr id="'+this.name+'" class="signs_tr_pair"><td class="imageSide">';
        // open first cell
        str += '<center><img src="' + this.img + '" class="signs_image" /></center>';
        // close first cell and start the second
        str += '</td><td class="sign_description">';
        // add title then start date end date then description
        str += '<p >';
        str += '<h2>' + this.name + '</h2>';
        str += '</br><span>' + this.sD + ' to ' + this.eD + '</span></br>';
        str += '<span>' + this.desc + '</span>';
        str += '</td></tr>';
        return str;
    };
    this.readInpair = function () {
        var str = '';
        str += '<tr id="'+this.name+'" class="signs_tr_inpair"><td class="sign_description">';
        // open first cell
        // add title then start date end date then description
        str += '<p >';
        str += '<h2>' + this.name + '</h2>';
        str += '</br><span>' + this.sD + ' to ' + this.eD + '</span></br>';
        str += '<span>' + this.desc + '</span>';
        // close first cell and start the second
        str += '</td><td class="imageSide">';
        str += '<center><img src="' + this.img + '" class="signs_image" /></center>';
        str += '</td></tr>';
        return str;
    };
}


var signs = new Array();

function GenerateSigns(){
    var allDescription =
    "Burning like a fire on Mars , Aries is honest but too instinctive... this makes that person very very weak in general.</br>Attack 9000 and defense 1000|" +
    "Hard-headed and stable ,the Taurus is able to withstand a wall on full force like a bull,and will never lose contact with earth.</br>Attack 7000 and defense 3000|" +
    "Superficial but adaptable ,Gemini is like mercury ,slips trough cracks and hands with his lies,but always fails when he hits the ground.</br>Attack 8200 and defense 1800|" +
    "Protector and jealous,devoted and capricious following it's love like Moon follows Earth, sticking like water on clothes.</br>Attack 5000 and defense 5000|" +
    "Authoritarian and full of pride Leo stays upright no matter what even if sun is hitting him and makes him burn like fire.</br>Attack 10 and defense 9990|" +
    "Disciplinated and logical makes of Virgo someone that lacks of flexibility.Breaks like crystal if hit.</br>Attack 9990 and defense 10|" +
    "Diplomatic, hesitant and indecisive , Libra gets lost on daily choice making decisions but does that all with formality.</br>Attack 5000 and defense 5000|" +
    "Deep,generous ,the Scorpio bites like a ruthless and selfish looser, there is no mercy in his attack,is impredictable like Pluto.</br>Attack 9000 and defense 1000|" +
    "Wise and creative ,the Sagitarius knows how to be way too moralistic, burns like fire and jumps like Jupiter.</br>Attack 4000 and defense 6000|" +
    "Patient but internalized ,Capricorn is like hospitalized patient that looks on a telescope out for Saturn.</br>Attack 2000 and defense 8000|" +
    "Liberal like Uranus,acts always unusual to situation and makes actions that have no sense in the context.</br>Attack 5000 and defense 5000|" +
    "Charitable but irrresponsible , Pisces changes like water on Neptune when he's in charge of something.</br>Attack 1000 and defense 9000|";
    
    
    var strix = allDescription.split('|');
    sings = new Array();
    var sign0 = new Sign(321,419,"ressources/signs/aries-300px.png",'Aries','March 21','April 19',
    strix[0]);
    var sign1 = new Sign(420,520,"ressources/signs/taurus-300px.png",'Taurus','April 20','May 20',
    strix[1]);
    var sign2 = new Sign(521,620,"ressources/signs/gemini-300px.png",'Gemini','May 21','June 20',
    strix[2]);
    var sign3 = new Sign(621,722,"ressources/signs/cancer-300px.png",'Cancer','June 21','July 22',
    strix[3]);
    var sign4 = new Sign(723,822,"ressources/signs/leo-300px.png",'Leo','July 23','August 22',
    strix[4]);
    var sign5 = new Sign(823,922,"ressources/signs/virgo-300px.png",'Virgo','August 23','September 22',
    strix[5]);
    var sign6 = new Sign(923,1023,"ressources/signs/libra-300px.png",'Libra','September 23','October 23',
    strix[6]);
    var sign7 = new Sign(1024,1121,"ressources/signs/scorpio-300px.png",'Scorpio','October 24','November 21',
    strix[7]);
    var sign8 = new Sign(1122,1221,"ressources/signs/sagittarius-300px.png",'Sagittarius','November 22','December 21',
    strix[8]);
    var sign9 = new Sign(1222,1319,"ressources/signs/capricorn-300px.png",'Capricorn','december 22','January 19',
    strix[9]);
    var sign10 = new Sign(120,218,"ressources/signs/aquarius-300px.png",'Aquarius','January 20','February 18',
    strix[10]);
    var sign11 = new Sign(219,320,"ressources/signs/pisces-300px.png",'Pisces','February 19','March 20',
    strix[11]);
  
    signs.push(sign0);
    signs.push(sign1);
    signs.push(sign2);
    signs.push(sign3);
    signs.push(sign4);
    signs.push(sign5);
    signs.push(sign6);
    signs.push(sign7);
    signs.push(sign8);
    signs.push(sign9);
    signs.push(sign10);
    signs.push(sign11);
}

function GenerateSignsMenu(menuID){
    var strx = "<tr>";
    for(var i = 0; i<signs.length;i++){
        strx += '<td class="thumbnail_sign"><a href="#'+signs[i].name+'"><img class="sign_menu_image" src="' + signs[i].img + '"/></br><span>'+signs[i].name+'</span></a></td>';
    }
    strx += '</tr>';
    document.getElementById(menuID).innerHTML = strx;
}

function GenerateSignsTable(tableID){
    var generatedString = "";

    for(var i = 0; i<signs.length;i++){
        if(i%2==0){
            generatedString += signs[i].readPair();
        }else{
            generatedString += signs[i].readInpair();
            }
            generatedString += '<tr><td colspan="2"></br></td></tr>';
    }

    document.getElementById(tableID).innerHTML = generatedString;


}


function GatherInfo(birthMonth,birthDay,name,targetID){
    var stringtoReturn = '';
    var nameGathered = document.getElementById(name).value;
    var birthDate = parseInt(document.getElementById(birthMonth).value)*100+parseInt(document.getElementById(birthDay).value);
    if(birthDate<=119){
        birthDate+=1200;
    }
    var signID=-1;// to be set
    if  (parseInt(document.getElementById(birthMonth).value) < 13 && parseInt(document.getElementById(birthDay).value) < 32) {
      
        for (var i = 0; i < signs.length; i++) {
            if (birthDate >= signs[i].intSD && birthDate <= signs[i].intED) {
              
                signID = i;
            }
          
        } 
    }
   
     stringtoReturn += '<center><p id="message_byDate">Hi,'+nameGathered+'</br>';
    if (signID != -1) {
        stringtoReturn += "Your sign " + signs[signID].name + " is at it's best today !! You will live another happy day!!";
        stringtoReturn += '</br></br></br><img class="signs_image" src="' + signs[signID].img + '"/>';
        
        stringtoReturn += '</br></br></br>' + signs[signID].desc;
        stringtoReturn += '</p></center>';
    }else{
        stringtoReturn += "The date you entered is wrong,please fix it and try again!!";

        stringtoReturn += '</p></center>';
    }

    document.getElementById(targetID).innerHTML = stringtoReturn;
}