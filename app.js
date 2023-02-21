const sections = document.querySelectorAll('.section')
const sectBtns = document.querySelectorAll('.controlls')
const sectBtn = document.querySelectorAll('.control')
const allSections = document.querySelector('.main-content')
const toggleIcon = document.getElementById('toggle-icon')
const portfolioLink = document.querySelector('.portfolio-link')
const bgText = document.querySelector('.bg-text')
const mql = window.matchMedia("(max-width: 768px)")
const mqltablet = window.matchMedia("(min-width:768px)")
const toogleIcon = document.querySelector('#toggle-icon')
const portfolioItems = document.querySelectorAll('.portfolio-item')
const projectsAmount = document.querySelector('.projectsAmount')

function PageTransitions() {
    for (let i = 0; i < sectBtn.length; i++) {
        sectBtn[i].addEventListener('click', function () {
            let currentBtn = document.querySelectorAll('.active-btn')
            currentBtn[0].className = currentBtn[0].className.replace('active-btn', '')
            this.className += ' active-btn'
        })
    }

    allSections.addEventListener('click', (e) => {
        const id = e.target.dataset.id;
        if (id) {
            sectBtns.forEach((btn) => {
                btn.classList.remove('active')
            })
            e.target.classList.add('active')

            sections.forEach((section) => {
                section.classList.remove('active')
            })
            const element = document.getElementById(id)
            element.classList.add('active')
        }
    })
}

PageTransitions()



function forwardPage(e) {
    const id = e.target;
    const page = document.querySelector('#portfolios')
    const parentPage = page.parentElement
    const controlPage = document.querySelector('[data-id="portfolio"]')
    const controlId = document.querySelector('[data-id="home"]')

    if (id) {
        controlId.classList.remove('active-btn')
        controlPage.classList.add('active-btn')
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
    bgText.style.display = 'none'

} else if (mqltablet.matches) {
    toogleIcon.style.display = 'block'
}


const portfolioItemsNumber = portfolioItems.length
projectsAmount.innerHTML = portfolioItemsNumber + '+'


// let imgElement = document.getElementById('imageSrc');
// let inputElement = document.getElementById('fileInput');
// inputElement.addEventListener('change', (e) => {
//   imgElement.src = URL.createObjectURL(e.target.files[0]);
// }, false);
// imgElement.onload = function() {
//   let mat = cv.imread(imgElement);
//   cv.imshow('canvasOutput', mat);
//   mat.delete();
// };
// var Module = {
//   // https://emscripten.org/docs/api_reference/module.html#Module.onRuntimeInitialized
//   onRuntimeInitialized() {
//     document.getElementById('status').innerHTML = 'OpenCV.js is ready.';
//   }
// };


const uri = '../img/cv.pdf'
const name = 'cv.pdf'


function downloadURI(uri, name) 
{
    alert('URI')
    var link = document.createElement("a");
    link.download = name;
    link.href = uri;
    link.click();
    console
}
