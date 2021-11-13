const btnSwitch = document.querySelector('#checkbox');
const spanSwitch = document.querySelector('#span-switch');
const view = document.querySelector('#view');
const price = document.getElementById('pricing__permonth-number');
const slider = document.querySelector('#pricing-range');
const btn = document.querySelector('.btn-submit');
const Discount = document.querySelector('.dsc');



let active = false;
let views = 10;
let pricePerMount = 8;
slider.value=20;
 view.textContent = "10K pagesviews";
    // printingPrice(8);
    setBar(20);

view.textContent=`${views}K Pageviews`;
price.innerHTML=`$${pricePerMount.toFixed(2)}`



btnSwitch.addEventListener('click', ()=> {
  active=!active;

})


// Making slider work
function setBar(value) {
slider.style.setProperty("--value", value);
}




// setBar(50);
// slider.style.setProperty("--value", 50);

function printingPrice(amount) {
  
  if (active) {
    Total=price.innerHTML=`$ ${amount.toFixed(2) - amount.toFixed(2) * (0.25)}`
    Discount.classList.add('discount');
    
    
  } else {
    price.innerHTML = `$ ${amount.toFixed(2)}`;
    Discount.classList.remove('discount');
  }
}

function printPageViews(view) {
  view.textContent = `${view}k pagesview`;
}

slider.oninput = function () {

if (Number(this.value) === 20) {
    // printPageViews(10);
    view.textContent = "10K pagesviews";
    printingPrice(8);
    setBar(20);
  } else if (Number(this.value) === 40) {
    // printPageViews(50);
    view.textContent = "50K pagesviews";
    printingPrice(12);
    setBar(40);
  } else if (Number(this.value) === 60) {
    // printPageViews(100);
    view.textContent = "100K pagesviews";
    printingPrice(16);
    setBar(60);
  } else if (Number(this.value) === 80) {
    // printPageViews(500);
    view.textContent = "500K pagesviews";
    printingPrice(24);
    setBar(80);
  } else if (Number(this.value) === 100) {
    view.textContent = "1M pagesviews";
    printingPrice(36);
    setBar(100);
  }
};

// Refreshing page on button click
// function refreshPage() {
//   window.location.reload();
// }

btn.addEventListener('click',()=>{
  window.location.reload();
})


// Event handler
btnSwitch.addEventListener("click", ()=>{
  slider.oninput();
});
slider.addEventListener("click", function () {
  slider.oninput();
});