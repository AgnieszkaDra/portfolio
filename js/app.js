

const sections = document.querySelectorAll('.section')
const sectBtns = document.querySelectorAll('.controlls')
const sectBtn = document.querySelectorAll('.control')
const secHeader = document.querySelector('.section.header')

// const homeBtns = homeControlls.querySelectorAll('.control')
const homeBtns = document.querySelectorAll('.control')
const secAbout = document.querySelector('.section.about')


const secPortfolio = document.querySelector('.section.portfolio')
const portfolioControlls = document.querySelector('.controlls.portfolio')

const secContact = document.querySelector('.section.contact')

// const contactBtns = contactControlls.querySelectorAll('.control')
const contactBtns = document.querySelectorAll('.control')
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

const toogleSwitch = document.querySelector('input[type="checkbox"]')



if (mql.matches) {
    toogleIcon.style.display = 'none'
    

} else if (mqltablet.matches) {
    toogleIcon.style.display = 'block'
}


const portfolioItemsMyOwnNumber = portfolioItemsMyOwn.length
projectsAmountMyOwn.innerHTML = portfolioItemsMyOwnNumber + '+'

const portfolioItemsCourseNumber = portfolioItemsCourse.length
projectsAmountCourse.innerHTML = portfolioItemsCourseNumber + '+'

   
   
// function PageTransitions() {
//     alert('tran')
//     for (let i = 0; i < sectBtn.length; i++) {
//         sectBtn[i].addEventListener('click', function () {
//             alert('click btn')
//             let currentBtn = document.querySelectorAll('.active-btn')
//             currentBtn[0].className = currentBtn[0].className.replace('active-btn', '')
//             this.className += ' active-btn'
//         })
//     }

//     allSections.addEventListener('click', (e) => {
//         const id = e.target.dataset.id;
        
//         if (id) {
//             alert('id')
//             sectBtns.forEach((btn) => {
//                 btn.classList.remove('active')
//             })
//             e.target.classList.add('active')

//             sections.forEach((section) => {
//                 section.classList.remove('active')
//             })
//             const element = document.getElementById(id)
//             element.classList.add('active')
//         }
//     })
// }




