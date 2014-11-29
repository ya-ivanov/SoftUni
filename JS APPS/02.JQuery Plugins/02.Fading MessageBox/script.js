$.fn.messageBox = function($message, $typeOfMsg){
    var $bgColor = '';

    switch ($typeOfMsg){
        case 'Error': $bgColor = 'rgb(230, 61, 61)'; break;
        case 'Alert': $bgColor = 'yellow'; break;
        case 'Success': $bgColor = 'lightgreen'; break;
        case 'Info': $bgColor = 'lightblue'; break;
    }

    var $messageBox = this;
    $messageBox.css('background', $bgColor);
    $messageBox.css('border-radius', '5px');
    $messageBox.css('text-align', 'center');
    $messageBox.css('position', 'absolute');
    $messageBox.css('left', '45%');
    $messageBox.css('top', '20px');
    $messageBox.css('border', '1px dashed gray');
    $messageBox.text($message);
    $messageBox.fadeIn(400); // The time for appearing, given in the homework, look kinda slow so... 400ms is better
    $messageBox.delay(3000).fadeOut(300);
}