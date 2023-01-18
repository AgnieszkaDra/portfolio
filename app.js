const sections = document.querySelectorAll('.section')
const sectBtns = document.querySelectorAll('.controlls')
const sectBtn = document.querySelectorAll('.control')
const allSections = document.querySelector('.main-content')
console.dir(allSections)
const toggleIcon = document.getElementById('toggle-icon')
console.log(toggleIcon.children)
const textBox = document.getElementById('text-box')
const portfolioLink = document.querySelector('.portfolio-link')
const bgText = document.querySelector('.bg-text')

function PageTransitions() {
    // Button click active class
    for(let i=0; i < sectBtn.length; i++){
        sectBtn[i].addEventListener('click', function() {
            let currentBtn = document.querySelectorAll('.active-btn')
            currentBtn[0].className = currentBtn[0].className.replace('active-btn', '')
            this.className += ' active-btn'
        })
    }

   allSections.addEventListener('click', (e)=> {
        const id = e.target.dataset.id;
        console.log(id)
       
        if(id) {
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

function forwardPage(e){
    const id = e.target;
    const page = document.querySelector('#portfolios')
    const parentPage = page.parentElement
    const controlPage = document.querySelector('[data-id="portfolio"]')
    const controlId = document.querySelector('[data-id="home"]')
    
    if(id) {
        
        controlId.classList.remove('active-btn')
        controlPage.classList.add('active-btn')

        parentPage.classList.add('active')
    }
      
}



portfolioLink.addEventListener('click', forwardPage)

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


    const mql = window.matchMedia("(max-width: 768px)");
    const mqltablet = window.matchMedia("(min-width:768px)")
  const toogleIcon = this.document.querySelector('#toggle-icon')
 
 if(mql.matches){
  
  toogleIcon.style.display='none'
    bgText.style.display = 'none'
  


 } else if(mqltablet.matches){
    toogleIcon.style.display='block'
 }

const ctxToday = document.getElementById('myChartToday');
const HTML = document.querySelector('.HTMLData')
function getVal() {
    
    const val = document.querySelector('.HTMLData').value;
    
    
  }

 

function updateChart(){
    const HTMLData = document.querySelector('.HTMLData')
    const HTMLDataValue = HTMLData.value
    console.log(HTMLDataValue)

async function fetchData(){
    const HTMLData = document.querySelector('.HTMLData')
    const response = await fetch(HTMLData)


    const datapoints = await response 
    console.log(datapoints)
}
}
updateChart()


 
 


const dataYesterday = {
    labels: [
      'HTML',
      'CSS',
      'JavaScript',
      'React',
    ],
   
    datasets: [{
      label: 'My Skills',
      data: [getVal(), 10, 10, 40],
      backgroundColor: [
        'rgb(255, 99, 132)',
        'rgb(54, 162, 235)',
        'rgb(255, 205, 86)',
        'rgb(456,19,456'
      ],
      hoverOffset: 4
    }],
    textposition: "outside",
  };


           
                const HTMLDataNumber = function(){
  const HTMLData = document.querySelector('.HTMLData')
  console.log(HTMLData)
  HTMLData.addEventListener('blur',function(e){
    const HTMLDataNumber = Number(e.target.value);
  
    return HTMLDataNumber
  })
                }
                HTMLDataNumber()

  const dataToday = {
    labels: [
      'HTML',
      'CSS',
      'JavaScript',
      'React',
    ],
    datasets: [{
      label: 'My Skills',
      data: [80, 10, 10, 40],
      
      backgroundColor: [
        'rgb(255, 99, 132)',
        'rgb(54, 162, 235)',
        'rgb(255, 205, 86)',
        'rgb(456,19,456'
      ],
     //borderColor: Utils.CHART_COLORS.red,
      //backgroundColor: Utils.transparentize(Utils.CHART_COLORS.red, 0.5),
     
    }]
  };
  
  
  console.dir(dataToday.datasets[0].data[0])
  Chart.register(ChartDataLabels);
  const datapoint = ['HTML','CSS','JavaScript','React',]

  
  const chart = new Chart(ctxToday,{
    type: 'pie',
    data: dataToday,
   
    options: {
       
        plugins: {
          tooltip: {
            enabled: false, 
          },
            legend: {
            position: 'bottom',
            align: 'start',
            onHover: false,
            onLeave: false,
        },
    
    
        
          
          datalabels: {
            formatter: function(value, context, HTMLDataNumber) {
                console.log(context)
                console.log(context.chart.data.datasets[0].data)
                console.log(context.chart.data.labels[context.dataIndex])
                console.log(value)
                //return context.chart.data.labels[context.dataIndex];
                function totalSum(total, datapoint){
                    return total + datapoint
                }

                //       const HTMLData = document.querySelector('.HTMLData').value;
                // console.log(typeof val)
                // const HTMLDataNumber = Number(HTMLData)
                  const datapoints1 = context.chart.data.datasets[0].data[0]
                  const datapoints2 = context.chart.data.datasets[0].data[1]
                // const datapoints = context.chart.data.datasets[0].data
                const datapoints = [datapoints1,datapoints2]
           
          
                   //chart.update()
               
               
                
                const totalvalue = datapoints.reduce(totalSum,0)
                const percentageValue = (value/totalvalue *100).toFixed(1)
                
                return ` ${percentageValue}%`
                
              }
          },
        },

         
        
       
        events: ['mousemove', 'mouseout', 'click', 'touchstart', 'touchmove'],
         'onClick' : function (evt, item) {
            console.log ('legend onClick', evt);
            console.log('legd item',  item);
             customCanvasBackgroundColor = 'lightGreen',
              text = 'ala'
              
            item[0].element.options.backgroundColor = customCanvasBackgroundColor
            item[0].element.options.textContent = text // nie działa
            
        
        },
        'onHover' : function (evt, item) {
            console.log ('legend onClick', evt);
            console.log('legd item',  item);
             customCanvasBackgroundColor = 'lightGreen',
              text = 'ala'
              
          
        },
       

    }, 
   
 }


  )
 const val = document.querySelector('.HTMLData').value;
 console.log(typeof val)
 const valNumber = Number(val)
    //context.chart.data.datasets[0].data[0] = valNumber
    chart.update()
  console.dir(chart)
//const HTMLDataValue = chart.dataToday.datasets[0].data[0]

function getVal(){
    
                      const HTMLData = document.querySelector('.HTMLData').value;
           
                const HTMLDataNumber = Number(HTMLData)
                return HTMLDataNumber
}
  