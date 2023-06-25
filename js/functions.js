console.log('fun')
export default function pageTransitions (btns, sec) {
    alert('transitions')
    for (let i = 0; i < btns.length; i++) {
        btns[i].addEventListener('click', function () {
            alert('click')
            let currentBtn = sec.querySelectorAll('.active-btn')
            currentBtn[0].className = currentBtn[0].className.replace('active-btn', '')
            this.className += ' active-btn'
        })
    }

    allSections.addEventListener('click', (e) => {
        const id = e.target.dataset.id;
        
        if (id) {
          
            btns.forEach((btn) => {
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