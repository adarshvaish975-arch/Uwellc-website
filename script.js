/*=====================================
UWELLC PREMIUM JS
======================================*/

// Header scroll effect

const header = document.querySelector(".header");

window.addEventListener("scroll", () => {

if(window.scrollY > 50){

header.style.background = "rgba(255,255,255,.98)";
header.style.boxShadow = "0 10px 30px rgba(0,0,0,.08)";

}else{

header.style.background = "rgba(255,255,255,.92)";
header.style.boxShadow = "none";

}

});


// Smooth scroll

document.querySelectorAll('a[href^="#"]').forEach(anchor=>{

anchor.addEventListener("click",function(e){

e.preventDefault();

const target=document.querySelector(this.getAttribute("href"));

if(target){

target.scrollIntoView({

behavior:"smooth"

});

}

});

});


// Fade animation

const sections=document.querySelectorAll(
".about,.brand-section,.why-uwellc,.products-section,.how-use-section,.packaging-section,.testimonials-section,.contact-section,.icon-section,.footer-banner-section"
);

const observer=new IntersectionObserver(entries=>{

entries.forEach(entry=>{

if(entry.isIntersecting){

entry.target.style.opacity="1";

entry.target.style.transform="translateY(0)";

}

});

},{
threshold:.15
});

sections.forEach(section=>{

section.style.opacity="0";

section.style.transform="translateY(50px)";
section.style.transition=".8s";

observer.observe(section);

});
