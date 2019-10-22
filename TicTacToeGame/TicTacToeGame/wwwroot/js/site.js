// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let hubUrl = '/gameHub';
let httpConnection = new signalR.httpConnection(hubUrl);
let hubConnection = new signalR.hubConnection(httpConnection);
var playerName = "";
var playerImage = "";
var hash = "#";
hubConnection.start();

$("#btnRegister").click(function () {
    playerName = $('#name').val();
    playerImage = $('#previewImage').attr('src');

    var data = playerName.concat(hash, playerImage);

    hubConnection.invoke('RegisterPlayer', data);
});

$("#image").change(function () {
    readUrl(this);
});

function readUrl(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = imageIsLoaded;
        reader.readAsDataURL(input.files[0]);
    }
}

function imageIsLoaded(e) {
    if (e.target.result) {
        $('#previewImage').attr('src', e.target.result);
        $('#divPreviewImage').show();
    }
}

$("#btnFindOpponentPlayer").click(function () {
    hubConnection.invoke('FindOpponent');
});

hubConnection.on('registrationComplete', data => { //// Fires on registration complete. Invoked by server hub
    $("#divRegister").hide();  // hide the registration div
    $("#divFindOpponentPlayer").show(); // display find opponent player div.
});

hubConnection.on('opponentNotFound', data => { //// Fires when no opponent is found.
    $('#divFindOpponentPlayer').hide(); //// hide the find opponent player section.
    $('#divFindingOpponentPlayer').show(); //// display the finding opponent player div.
});

hubConnection.on('opponentFound', (data, image) => { //// Fires when opponent player is found.
    $('#divFindOpponentPlayer').hide();
    $('#divFindingOpponentPlayer').hide();
    $('#divGame').show();  //// Show game board section.
    $('#divGameInformation').show(); //// Show game information
    $('#divOpponentPlayer').show(); //// Show opponent player image.
    opponentImage = image;  //// sets the opponent player image for display
    $('#opponentImage').attr('src', opponentImage); //// Binds the opponent player image
    $('#divGameInfo').html("<br/><span><strong> Hey " +
        playerName + "! You are playing against <i>" + data + "</i></strong ></span > ");  //// displays the information of 
        ////  opponent that the player is playing against.
        //// Draw the tic-tac-toe game board, A 3x3 grid :) by proper styling.
   for(var i = 0; i < 9; i++) {
        $("#divGameBoard").append("<span class='marker' id=" + i
        + " style='display:block;border:2px solid black; height: 100px; width: 100px; float: left; margin: 10px; '>" 
        + i + "</span>");
}
});

//// Triggers on clicking the grid cell.
$(document).on('click', '.marker', function () {
    if ($(this).hasClass("notAvailable")) { //// CEll is already taken.
        return;
    }
    hubConnection.invoke('MakeAMove', $(this)[0].id); // Cell is valid, send details to hub
});

// Fires when player has to make a move.
hubConnection.on('waitingForMove', data => {
    $('#divinfo').html("<br/><span><strong> Your turn <i>" + playerName + "</i>! Make a winning move! </strong></span>");
});

//// Fires when move is made by either player.
hubConnection.on('moveMade', data => {
    if (data.Image == playerImage) { //// Move made by player.
        $("#" + data.ImagePosition).addClass("notAvailable");
        $("#" + data.ImagePosition).css('background-image',
            'url(' + data.Image + ')');
        $('#divInfo').html("<br/><strong>Waiting for <i>" +
            data.OpponentName + "</i> to make a move. </strong > ");
    }
    else {
        $("#" + data.ImagePosition).addClass("notAvailable");
        $("#" + data.ImagePosition).css('background-image',
            'url(' + data.Image + ')');
        $('#divInfo').html("<br/><strong>Waiting for <i>" +
            data.OpponentName + "</i> to make a move.</strong > ");
    }
});


//// Fires when the game ends.
hubConnection.on('gameOver', data => {
    $('#divGame').hide();
    $('#divInfo').html("<br/><span><strong>Hey " + playerName +
        "! " + data + " </strong></span>");
    $('#divGameBoard').html(" ");
    $('#divGameInfo').html(" ");
    $('#divOpponentPlayer').hide();
});

//// Fires when the opponent disconnects.
hubConnection.on('opponentDisconnected', data => {
    $("#divRegister").hide();
    $('#divGame').hide();
    $('#divGameInfo').html(" ");
    $('#divInfo').html("<br/><span><strong>Hey " + playerName +
        "! Your opponent disconnected or left     the battle! You are the winner! Hip Hip Hurray!!!</strong ></span > ");
});

