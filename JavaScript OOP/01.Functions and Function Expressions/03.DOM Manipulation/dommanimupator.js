var domManipulator = function() {

    function appendChild(element, selector){
        var appendTo = document.querySelector(selector);
        appendTo.appendChild(element);
    }

    function removeChild(element, selector){
        var from = document.querySelector(element);
        var removeElement = from.querySelector(selector);
        from.removeChild(removeElement);
    }

    function addHandler(selector, event, func){
        var elements = document.querySelectorAll(selector);
        for (var i = 0; i < elements.length; i++)
            elements[i].addEventListener(event, func);
    }

    function retrieveElements(selector) {
        var elements = document.querySelectorAll(selector);
        return elements;
    }

    var self = {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };

    return self;
}();


// Some Commands:

// domManipulator.addHandler('li.someItem', 'click', function() { alert('Whaaat');})

// domManipulator.removeChild('ul.superheros', 'li:first-child')

// domManipulator.retrieveElements('ul.superheros');
