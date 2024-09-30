// ProjectCard Hovering
window.resetAnimation = function(element) {
    element.style.animation = 'none';
    element.offsetHeight; 
    element.style.animation = null; 
}

// Homepage scrollspy
var scrollSpy = null;

window.initializeScrollSpy = function(dotnetHelper) {
    console.log('initializeScrollSpy called');
    
    const sections = document.querySelectorAll("div[id]");
    const navItems = document.querySelectorAll(".navigation-item");
    
    function updateSection() {
        let currentSection = "";
        const scrollPosition = window.scrollY;
        sections.forEach((section) => {
            const sectionTop = section.offsetTop;
            const sectionHeight = section.clientHeight;
            if (scrollPosition >= sectionTop - sectionHeight / 3) {
                currentSection = section.getAttribute("id");
            }
        });
        
        console.log(`Current section: ${currentSection}`);
        dotnetHelper.invokeMethodAsync('UpdateCurrentSection', currentSection);
    }

    scrollSpy = throttle(updateSection, 100);

    window.addEventListener('scroll', scrollSpy);
    updateSection(); // Call once to set initial state
}

window.removeScrollSpy = function() {
    console.log('removeScrollSpy called');
    if (scrollSpy) {
        window.removeEventListener('scroll', scrollSpy);
        scrollSpy = null;
    }
}

window.scrollToElement = function(elementId) {
    console.log(`scrollToElement called with elementId: ${elementId}`);
    const element = document.getElementById(elementId);
    if (element) {
        element.scrollIntoView({ behavior: 'smooth' });
    } else {
        console.warn(`Element with id ${elementId} not found`);
    }
}

function throttle(func, limit) {
    let inThrottle;
    return function() {
        const args = arguments;
        const context = this;
        if (!inThrottle) {
            func.apply(context, args);
            inThrottle = true;
            setTimeout(() => inThrottle = false, limit);
        }
    }
}