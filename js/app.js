import { pageTransitions } from "./functions"

const sections = document.querySelectorAll('.section')
const sectBtns = document.querySelectorAll('.controlls')
const sectBtn = document.querySelectorAll('.control')
const secHeader = document.querySelector('.section.header')
const homeControlls = document.querySelector('.controlls.home')
const homeBtns = homeControlls.querySelectorAll('.control')
const secAbout = document.querySelector('.section.about')
const aboutControlls = document.querySelector('.controlls.about')
const aboutBtns = aboutControlls.querySelectorAll('.control')
const secPortfolio = document.querySelector('.section.portfolio')
const portfolioControlls = document.querySelector('.controlls.portfolio')
const portfolioBtns = portfolioControlls.querySelectorAll('.control')
const secContact = document.querySelector('.section.contact')
const contactControlls = document.querySelector('.controlls.contact')
const contactBtns = contactControlls.querySelectorAll('.control')
const allSections = document.querySelector('.main-content')
const toggleIcon = document.getElementById('toggle-icon')
const portfolioLink = document.querySelector('.portfolio-link')
const bgText = document.querySelector('.bg-text')
const mql = window.matchMedia("(max-width: 768px)")
const mqltablet = window.matchMedia("(min-width:769px)")
const toogleIcon = document.querySelector('#toggle-icon')
const portfolioItemsMyOwn = document.querySelectorAll('.portfolio-item.myown')
const portfolioItemsCourse = document.querySelectorAll('.portfolio-item.course')
const projectsAmountMyOwn = document.querySelector('.projectsAmountMyOwn')
const projectsAmountCourse = document.querySelector('.projectsAmountCourse')

console.log(sections)


const result = pageTransitions(homeBtns, secHeader)
result(homeBtns, secHeader)
pageTransitions(aboutBtns, secAbout)
pageTransitions(portfolioBtns, secPortfolio)
pageTransitions(contactBtns, secContact)





function forwardPage(e) {

   
    const id = e.target;
    const header = id.closest('.header')
 
    const page = document.querySelector('#portfolios')
    const parentPage = page.parentElement.parentElement
   
    const controlPage = parentPage.querySelector('[data-id="portfolio"]')
  
    const controlId = parentPage.querySelector('[data-id="home"]')
   

    if (id) {
        controlId.classList.remove('active-btn')
        controlPage.classList.add('active-btn')
        header.classList.remove('active')
        parentPage.classList.add('active')
    }
}

portfolioLink.addEventListener('click', forwardPage)

const toogleSwitch = document.querySelector('input[type="checkbox"]')

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


function switchTheme(event) {
   
    if (event.target.checked) {
        document.documentElement.setAttribute('data-theme', 'light')
        lightMode()

    } else {
        document.documentElement.removeAttribute('data-theme', 'light')
        darkMode()
    }
}

//Event Listener
toogleSwitch.addEventListener('change', switchTheme)

if (mql.matches) {
    toogleIcon.style.display = 'none'
    

} else if (mqltablet.matches) {
    toogleIcon.style.display = 'block'
}


const portfolioItemsMyOwnNumber = portfolioItemsMyOwn.length
projectsAmountMyOwn.innerHTML = portfolioItemsMyOwnNumber + '+'

const portfolioItemsCourseNumber = portfolioItemsCourse.length
projectsAmountCourse.innerHTML = portfolioItemsCourseNumber + '+'



