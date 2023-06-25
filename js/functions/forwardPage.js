export function forwardPage(e) {

   
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