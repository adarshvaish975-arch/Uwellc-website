/* ==========================
   UWELLC PREMIUM CSS
   Part 1
========================== */

*{
margin:0;
padding:0;
box-sizing:border-box;
}

html{
scroll-behavior:smooth;
}

body{

font-family:'Poppins',sans-serif;
background:#ffffff;
color:#111;
overflow-x:hidden;

}

.container{

width:90%;
max-width:1350px;
margin:auto;

}

section{

padding:100px 0;

}

img{

max-width:100%;
display:block;

}

a{

text-decoration:none;

}

ul{

list-style:none;

}

/* HEADER */

header{

position:fixed;
top:0;
left:0;
width:100%;
background:rgba(255,255,255,.90);
backdrop-filter:blur(18px);
z-index:999;
transition:.4s;

}

.navbar{

height:85px;
display:flex;
justify-content:space-between;
align-items:center;

}

.logo{

font-size:34px;
font-weight:800;
letter-spacing:2px;
color:#111;

}

.logo span{

color:#C9A227;

}

.menu{

display:flex;
gap:45px;

}

.menu a{

font-size:16px;
font-weight:600;
color:#111;
transition:.3s;

}

.menu a:hover{

color:#C9A227;

}

.btn{

padding:16px 34px;
border-radius:60px;
background:#111;
color:white;
font-weight:600;
transition:.3s;

}

.btn:hover{

background:#C9A227;
color:#111;

}
/* ==========================
   HERO SECTION
========================== */

.hero{

height:100vh;
display:flex;
align-items:center;
justify-content:center;
text-align:center;
background:
linear-gradient(rgba(0,0,0,.55),rgba(0,0,0,.55)),
url('https://images.unsplash.com/photo-1512069772995-ec65ed45afd6?auto=format&fit=crop&w=1800&q=80');

background-size:cover;
background-position:center;

color:white;

}

.hero-content{

max-width:900px;

}

.hero h1{

font-size:72px;
font-weight:800;
line-height:1.1;
margin-bottom:25px;

}

.hero span{

color:#C9A227;

}

.hero p{

font-size:22px;
opacity:.9;
margin-bottom:45px;

}

.hero-buttons{

display:flex;
justify-content:center;
gap:20px;
flex-wrap:wrap;

}

.btn-outline{

padding:16px 34px;
border:2px solid #C9A227;
color:#C9A227;
border-radius:50px;
transition:.3s;

}

.btn-outline:hover{

background:#C9A227;
color:#111;

}

/* ==========================
SECTION TITLE
========================== */

.section-title{

text-align:center;
font-size:48px;
font-weight:800;
margin-bottom:60px;

}

.section-title span{

color:#C9A227;

}

/* ==========================
PREMIUM CARDS
========================== */

.grid{

display:grid;
grid-template-columns:repeat(auto-fit,minmax(320px,1fr));
gap:35px;

}

.card{

background:#fff;
border-radius:22px;
padding:35px;
box-shadow:0 15px 40px rgba(0,0,0,.08);
transition:.4s;

}

.card:hover{

transform:translateY(-12px);
box-shadow:0 20px 60px rgba(0,0,0,.18);

}

.card h3{

font-size:28px;
margin-bottom:20px;
color:#111;

}

.card p{

line-height:1.8;
color:#666;

}
/* ==========================
PRODUCT SECTION
========================== */

.products{
background:#f8f8f8;
}

.product-card{
background:#fff;
border-radius:24px;
overflow:hidden;
transition:.4s;
box-shadow:0 15px 40px rgba(0,0,0,.08);
}

.product-card:hover{
transform:translateY(-12px);
box-shadow:0 25px 60px rgba(0,0,0,.15);
}

.product-image{
height:320px;
background:#fff;
display:flex;
justify-content:center;
align-items:center;
padding:30px;
}

.product-image img{
max-height:280px;
object-fit:contain;
}

.product-info{
padding:30px;
}

.product-info h3{
font-size:30px;
margin-bottom:15px;
}

.product-info p{
color:#666;
line-height:1.8;
margin-bottom:25px;
}

.gold-btn{
display:inline-block;
padding:14px 30px;
background:#C9A227;
color:#111;
font-weight:700;
border-radius:50px;
transition:.3s;
}

.gold-btn:hover{
background:#111;
color:#fff;
}

/* ==========================
WHY CHOOSE US
========================== */

.why{
background:#111;
color:#fff;
}

.why .card{
background:#1d1d1d;
color:#fff;
}

.why .card h3{
color:#C9A227;
}

.why .card p{
color:#ddd;
}

/* ==========================
ABOUT
========================== */

.about-text{
max-width:850px;
margin:auto;
text-align:center;
font-size:20px;
line-height:2;
color:#555;
}
/* ==========================
CONTACT
========================== */

.contact{
background:#ffffff;
}

.contact-box{
background:#111;
color:#fff;
padding:50px;
border-radius:25px;
text-align:center;
box-shadow:0 20px 60px rgba(0,0,0,.15);
}

.contact-box h2{
font-size:42px;
margin-bottom:20px;
color:#C9A227;
}

.contact-box p{
font-size:18px;
line-height:2;
color:#ddd;
}

/* ==========================
FOOTER
========================== */

footer{
background:#000;
color:#999;
padding:40px 20px;
text-align:center;
}

footer h3{
color:#C9A227;
margin-bottom:10px;
}

footer a{
color:#C9A227;
margin:0 10px;
}

footer a:hover{
color:#fff;
}

/* ==========================
ANIMATIONS
========================== */

.card,
.product-card,
.btn,
.gold-btn{
transition:all .35s ease;
}

.hero h1,
.hero p,
.section-title{
animation:fadeUp 1s ease;
}

@keyframes fadeUp{
0%{
opacity:0;
transform:translateY(30px);
}
100%{
opacity:1;
transform:translateY(0);
}
}

/* ==========================
RESPONSIVE
========================== */

@media(max-width:992px){

.hero h1{
font-size:48px;
}

.hero p{
font-size:18px;
}

.menu{
gap:20px;
}

.section-title{
font-size:36px;
}

}

@media(max-width:768px){

.navbar{
flex-direction:column;
height:auto;
padding:20px 0;
}

.menu{
flex-wrap:wrap;
justify-content:center;
margin-top:15px;
}

.hero{
padding:120px 20px;
}

.hero h1{
font-size:38px;
}

.hero-buttons{
flex-direction:column;
align-items:center;
}

.contact-box{
padding:30px;
}

}
