/*=====================================
UWELLC PREMIUM JS
FINAL STABLE VERSION
======================================*/

// Header Scroll Effect
const header = document.querySelector(".header");

if (header) {
  window.addEventListener("scroll", () => {
    if (window.scrollY > 50) {
      header.style.background = "rgba(255,255,255,0.98)";
      header.style.boxShadow = "0 10px 30px rgba(0,0,0,0.08)";
    } else {
      header.style.background = "rgba(255,255,255,0.92)";
      header.style.boxShadow = "none";
    }
  });
}

// Smooth Scroll
document.querySelectorAll('a[href^="#"]').forEach(link => {
  link.addEventListener("click", function (e) {

    const target = document.querySelector(this.getAttribute("href"));

    if (target) {
      e.preventDefault();

      target.scrollIntoView({
        behavior: "smooth",
        block: "start"
      });
    }

  });
});
