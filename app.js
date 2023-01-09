const sections = document.querySelectorAll('.section')
const sectBtns = document.querySelectorAll('.controlls')
const sectBtn = document.querySelectorAll('.control')
const allSections = document.querySelector('.main-content')
const toggleIcon = document.getElementById('toggle-icon')
console.log(toggleIcon.children)
const textBox = document.getElementById('text-box')

function PageTransitions() {
    // Button click active class
    for(let i=0; i < sectBtn.length; i++){
        sectBtn[i].addEventListener('click', function() {
            let currentBtn = document.querySelectorAll('.active-btn')
            currentBtn[0].className = currentBtn[0].className.replace('active-btn', '')
            this.className += ' active-btn'
        })
    }

    //Sections Active class
    allSections.addEventListener('click', (e)=> {
        const id = e.target.dataset.id;
       
        if(id) {
            // remove selected from the other btns
            sectBtns.forEach((btn) => {
                btn.classList.remove('active')
            })
            e.target.classList.add('active')

            // hide other sections
            sections.forEach((section) => {
                section.classList.remove('active')
            })
            const element = document.getElementById(id)
            element.classList.add('active')
        }
    })

    //Toggle theme
//     const themeBtn = document.querySelector('.theme-btn')
//     themeBtn.addEventListener('click', ()=>{
//         let element = document.documentElement
//         console.log(element)
//         document.documentElement.setAttribute('data-theme', 'light')
//         //element.classList.toggle('light-mode')
//     })
// }

}

PageTransitions()

const toogleSwitch = document.querySelector('input[type="checkbox"]')

function darkMode(){
  
    toggleIcon.children[0].textContent = 'Dark Mode'
    toggleIcon.children[1].classList.remove('fa-sun')
    toggleIcon.children[1].classList.add('fa-moon')

}

function lightMode(){
  
    toggleIcon.children[0].textContent = 'Light Mode'
    toggleIcon.children[1].classList.remove('fa-moon')
    toggleIcon.children[1].classList.add('fa-sun')

}

// Switch Theme Dynamically
function switchTheme(event){
    //console.log(event.target.checked)
    if(event.target.checked){
        document.documentElement.setAttribute('data-theme', 'light')
        lightMode()

    }else{
       document.documentElement.removeAttribute('data-theme', 'light')
       darkMode()
    }
}

//Event Listener
toogleSwitch.addEventListener('change', switchTheme)