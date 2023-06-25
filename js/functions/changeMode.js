

function darkMode() {

    toggleIcon.children[0].textContent = 'Dark Mode'
    toggleIcon.children[1].classList.remove('fa-sun')
    toggleIcon.children[1].classList.add('fa-moon')

}

function lightMode() {

    toggleIcon.children[0].textContent = 'Light Mode'
    toggleIcon.children[1].classList.remove('fa-moon')
    toggleIcon.children[1].classList.add('fa-sun')

}


export function switchTheme(event) {
   
    if (event.target.checked) {
        document.documentElement.setAttribute('data-theme', 'light')
        lightMode()

    } else {
        document.documentElement.removeAttribute('data-theme', 'light')
        darkMode()
    }
}