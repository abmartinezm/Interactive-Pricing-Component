// var slider = document.getElementById("range");
// var output = document.getElementById("output");
// var Dollars= document.getElementById("dollars");

// var BtnRound = document.getElementById('btn');
// // output.innerHTML = slider.value/1000; // Display the default slider value
// var Total=8;
// Dollars.value=Total.toFixed(2);
// Update the current slider value (each time you drag the slider handle)


/* ========================== § DOM ELEMENTS === */
// Price
const priceRangeEl = document.getElementById("price__range");
const priceTimespanEl = document.getElementById("timespan");
const priceEl = document.getElementById("price");
const pageviewsEl = document.getElementById("pageviews");

// Toggle
const monthlyBillingEl = document.getElementById("monthly-billing");
const yearlyBillingEl = document.getElementById("yearly-billing");
const toggleElArr = [monthlyBillingEl, yearlyBillingEl];

/* ========================== § DATA === */
const prices = {
  1: {
    pageviews: "10k",
    cost: 8,
  },
  2: {
    pageviews: "50k",
    cost: 12,
  },
  3: {
    pageviews: "100k",
    cost: 16,
  },
  4: {
    pageviews: "500k",
    cost: 24,
  },
  5: {
    pageviews: "1M",
    cost: 36,
  },
};

const price = class {
  constructor(option, discount) {
    this.option = option;
    this.discount = discount;
  }

  get pageviews() {
    return prices[this.option].pageviews + " Pageviews";
  }

  get cost() {
    const costCalc = this.discount ? prices[this.option].cost * 0.75 : prices[this.option].cost;
    return `${costCalc.toFixed(2)}`;
  }
};

// monthlyBillingEl.addEventListener('click',()=>{
//   console.log('btn')
// })

/* ========================== § DISCOUNT CHECK === */
function discountCheck() {
  return yearlyBillingEl.checked;
}

/* ========================== § OFFER SELECTED === */
function offerSelected() {
  return priceRangeEl.value;
}

/* ========================== § PERCENT SLIDER === */
const numberOffers = priceRangeEl.max - priceRangeEl.min;
const sliderPercent = () => (100 / numberOffers) * (offerSelected() - priceRangeEl.min);

/* ========================== § UPDATE FUNCTION === */
function updatePrice() {
  const currentPrice = new price(offerSelected(), discountCheck());

  pageviewsEl.innerText = currentPrice.pageviews;
  priceEl.innerText = currentPrice.cost;
  document.documentElement.style.setProperty("--gradient-slider-track", sliderPercent() + "%");
}

updatePrice();

/* ========================== § EVENT LISTENER SLIDER === */
priceRangeEl.addEventListener("input", function () {
  updatePrice();
});

toggleElArr.forEach((el) => {
  el.addEventListener("input", function () {
    updatePrice();
  });
});

















































// slider.value=10000;
// output.innerHTML=10;

// slider.oninput = function() {
  
//   output.innerHTML = parseInt(this.value/1000);

//     // console.log(slider.value )
//     if(slider.value <=10000){
//       Total=8;
//       BtnRound.addEventListener('click',()=>{
//         clickFunction()

//       })
      
  
//     }

//     if(slider.value >=50000){
//       Total=12;
//       BtnRound.addEventListener('click',()=>{
//         clickFunction()

//       })

//     }

//     if(slider.value >=100000){
//       Total=16;
      
//       BtnRound.addEventListener('click',()=>{
//         clickFunction()

//       })
//     }

//     if(slider.value >=500000){
//       Total=24;
//       BtnRound.addEventListener('click',()=>{
//         clickFunction()

//       })
//     }

//     if(slider.value >=1000000){
//       Total=36;
//       BtnRound.addEventListener('click',()=>{
//         clickFunction()

//       })
//     }

    

//     // console.log(Total)

//   Dollars.value=Total.toFixed(2);
 

  
// } 



// var clickFunction = function () {

//   Dollars.value=Total*.25;
//   //do some stuff here
//   window.addEventListener('click',clickFunction, false );

// };
// window.removeEventListener("click", clickFunction, false);



// window.onload=function() {

//     var input = document.getElementById('btn');
//     var clickCounter = 0;
//     input.onclick = function () {
//         clickCounter++;
//         if (clickCounter == 2) {
//             window.alert("Hello");
//             Dollars.value=""
//         }
//     };

// }