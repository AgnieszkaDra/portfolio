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

const ctxYesterday = document.getElementById('myChartYesterday');
 const ctxToday = document.getElementById('myChartToday');
 const ctxTomorrow = document.getElementById('myChartTomorrow');
 

const dataYesterday = {
    labels: [
      'HTML',
      'CSS',
      'JavaScript',
      'React',
    ],
   
    datasets: [{
      label: 'My Skills',
      data: [60, 10, 10, 40],
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

  const dataToday = {
    labels: [
      'HTML',
      'CSS',
      'JavaScript',
      'React',
    ],
    datasets: [{
      label: 'My Skills',
      data: [60, 10, 10, 40],
      backgroundColor: [
        'rgb(255, 99, 132)',
        'rgb(54, 162, 235)',
        'rgb(255, 205, 86)',
        'rgb(456,19,456'
      ],
      hoverOffset: 9
    }]
  };

  
  console.dir(dataToday.datasets[0].data[0])
  Chart.register(ChartDataLabels);
  const datapoint = ['HTML','CSS','JavaScript','React',]
  const dataTomorrow = {
    labels: [
      'HTML',
      'CSS',
      'JavaScript',
      'React',
    ],
       plugins: [ChartDataLabels],
    
 
    datasets: [{
      label: 'My Skills',
      data: [60, 10, 10, 40],
      backgroundColor: [
        'rgb(255, 99, 132)',
        'rgb(54, 162, 235)',
        'rgb(255, 205, 86)',
        'rgb(456,19,456'
      ],
      hoverOffset: 4,
      pieceLabel: {
        // mode 'label', 'value' or 'percentage', default is 'percentage'
        //mode: (!mode) ? 'value' : mode,
    
        // precision for percentage, default is 0
        precision: 0,
    
        // font size, default is defaultFontSize
        fontSize: 18,
    
        // font color, default is '#fff'
        fontColor: '#fff',
    
        // font style, default is defaultFontStyle
        fontStyle: 'bold',
    
        // font family, default is defaultFontFamily
        fontFamily: "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif"
    }
    }]
  
    }

    console.log(dataTomorrow)
  
  const chart = new Chart(ctxYesterday, {
    type: 'pie',
    data: dataYesterday,
    options: {
       
        plugins: {
          tooltip: {
            enabled: false,
          },
          datalabels: {
            formatter: function(value, context) {
                console.log(context)
                console.log(context.chart.data.datasets[0].data)
                console.log(context.chart.data.labels[context.dataIndex])
                console.log(value)
                //return context.chart.data.labels[context.dataIndex];
                function totalSum(total, datapoint){
                    return total + datapoint
                }
                const datapoints = context.chart.data.datasets[0].data
                const datapointsArray = Object.entries(datapoints)
               
                
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
              
          alert('Click Two Times')
            
        
        },
        

        
 },
//  plugins:[ {
//             tooltip: {
//               // Tooltip will only receive click events
//               events: ['click']
//             },
//             beforeEvent(chart, args, pluginOptions) {
//                 const event = args.event;
//                 if (event.type === 'click') {
//                     console.log(args)
//                     console.log(args.event.chart.data.datasets[0].backgroundColor)
                 
//                 }
//               }
//         },
//     ]
    
 });


  new Chart(ctxToday, {
    type: 'pie',
    data: dataToday
    
  });

  new Chart(ctxTomorrow, {
    type: 'pie',
    data: dataTomorrow
    
  });


  