<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <a href="https://icons8.com/icon/TTpVm8tPePng/sacola-de-compras"></a>
        <link rel="stylesheet" href="{{ asset('css/app.css')}}" type="text/css">
        <title>Home</title>
    </head>
    <body>
        <!--BARRAS DO TOPO-->
        <div class="box-claro">
            <marquee behavior="alternate">
                <img src="{{URL::asset('/imagem/zap.png')}}" class="icone-zap">
                <label for="" class="numero">(11) 4554-1650</label>
            </marquee>
        </div>
        <div class="box-escura">
            <center>
                <img src="{{URL::asset('/imagem/logoBranca.png')}}" class="logo">
                <input class="search-box" type="text" placeholder="Procurar" name="search">
                <button class="btn_prourar">PROCURAR</button>
                <a class="tag_log" href="#">LOGIN</a>
            </center>
        </div>
        <div class="box-claro-baixo">
            <br>
            <center>
                <a class="hiperlink_a" href="#">HOME</a>
                <a class="hiperlink_a" href="#">PRODUTOS</a>
                <a class="hiperlink_a" href="#">PRODUTOS SELECIONADOS</a>
                <a class="hiperlink_a" href="#">CARRINHO</a>
            </center>
        </div>
        <!--BARRAS DO TOPO/-->

        <!--SLIDE SHOW-->
        <center>
            <div class="slideshow-container">
                <div class="mySlides fade">
                    <div class="numbertext"></div>
                    <img
                        src="{{URL::asset('/imagem/img_mountains_wide.jpg')}}"
                        style="width:1349px">
                </div>
                <div class="mySlides fade">
                    <div class="numbertext"></div>
                    <img src="{{URL::asset('/imagem/img_snow_wide.jpg')}}" style="width:1349px">
                </div>
                <div class="mySlides fade">
                    <div class="numbertext"></div>
                    <img src="{{URL::asset('/imagem/img_nature_wide.jpg')}}" style="width:1349px">
                </div>
            </div>

            <div style="text-align:center; margin-top:10px">
                <span class="dot"></span>
                <span class="dot"></span>
                <span class="dot"></span>
            </div>
        </center>
        <!--SLIDE SHOW-->

        <!--JAVASCRIP DO SLIDE SHOW-->
        <script>
            var slideIndex = 0;
            showSlides();

            function showSlides() {
                var i;
                var slides = document.getElementsByClassName("mySlides");
                var dots = document.getElementsByClassName("dot");
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = "none";
                }
                slideIndex++;
                if (slideIndex > slides.length) {
                    slideIndex = 1
                }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i]
                        .className
                        .replace(" active", "");
                }
                slides[slideIndex - 1].style.display = "block";
                dots[slideIndex - 1].className += " active";
                setTimeout(showSlides, 5000); // Change image every 2 seconds
            }
        </script>
        <!--FIM DO JAVASCRIPT-->
        <br>
        <br>
        <br>

        <!--CIRCULOS DO CENTRO-->
        <center>
            <div style="margin: 10px;" class="circulo-pequeno lime"><img
                style='width:50px; margin-top:19px'
                src="https://img.icons8.com/ios/50/000000/shopping-cart-loaded--v2.png"/></div>
            <div style="margin: 10px;" class="circulo-pequeno lime"><img
                style='width:60px; margin-top:13px'
                src="https://img.icons8.com/ios/100/000000/shopping-bag--v3.png"/></div>
            <div style="margin: 10px;" class="circulo-pequeno lime"></div>
        </center>
        <!--CIRCULOS DO CENTRO/-->

        <!--CARD DOS PRODUTOS-->
        <center>

            <div class="container">
                <div class="card">
                    <img
                        src="{{URL::asset('/imagem/oleo.png')}}"
                        alt="Denim Jeans"
                        style="width:100%">
                    <h1>Oléo Mobil</h1>
                    <p class="preco">R$50,00</p>
                    <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                        Lorem jeamsun denim lorem jeansum.</p>
                    <p>
                        <button>Adiconar ao carrinho</button>
                    </p>
                </div>

                <div class="card">
                    <img
                        src="{{URL::asset('/imagem/oleo.png')}}"
                        alt="Denim Jeans"
                        style="width:100%">
                    <h1>Oléo Mobil</h1>
                    <p class="preco">R$50,00</p>
                    <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                        Lorem jeamsun denim lorem jeansum.</p>
                    <p>
                        <button>Adiconar ao carrinho</button>
                    </p>
                </div>

                <div class="card">
                    <img
                        src="{{URL::asset('/imagem/oleo.png')}}"
                        alt="Denim Jeans"
                        style="width:100%">
                    <h1>Oléo Mobil</h1>
                    <p class="preco">R$50,00</p>
                    <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                        Lorem jeamsun denim lorem jeansum.</p>
                    <p>
                        <button>Adiconar ao carrinho</button>
                    </p>
                </div>

                <div class="card">
                    <img
                        src="{{URL::asset('/imagem/oleo.png')}}"
                        alt="Denim Jeans"
                        style="width:100%">
                    <h1>Oléo Mobil</h1>
                    <p class="preco">R$50,00</p>
                    <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                        Lorem jeamsun denim lorem jeansum.</p>
                    <p>
                        <button>Adiconar ao carrinho</button>
                    </p>
                </div>
                <div id="container" style="display: none">
                    <div class="card">
                        <img
                            src="{{URL::asset('/imagem/oleo.png')}}"
                            alt="Denim Jeans"
                            style="width:100%">
                        <h1>Oléo Mobil</h1>
                        <p class="preco">R$50,00</p>
                        <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                            Lorem jeamsun denim lorem jeansum.</p>
                        <p>
                            <button>Adiconar ao carrinho</button>
                        </p>
                    </div>

                    <div class="card">
                        <img
                            src="{{URL::asset('/imagem/oleo.png')}}"
                            alt="Denim Jeans"
                            style="width:100%">
                        <h1>Oléo Mobil</h1>
                        <p class="preco">R$50,00</p>
                        <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                            Lorem jeamsun denim lorem jeansum.</p>
                        <p>
                            <button>Adiconar ao carrinho</button>
                        </p>
                    </div>

                    <div class="card">
                        <img
                            src="{{URL::asset('/imagem/oleo.png')}}"
                            alt="Denim Jeans"
                            style="width:100%">
                        <h1>Oléo Mobil</h1>
                        <p class="preco">R$50,00</p>
                        <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                            Lorem jeamsun denim lorem jeansum.</p>
                        <p>
                            <button>Adiconar ao carrinho</button>
                        </p>
                    </div>

                    <div class="card">
                        <img
                            src="{{URL::asset('/imagem/oleo.png')}}"
                            alt="Denim Jeans"
                            style="width:100%">
                        <h1>Oléo Mobil</h1>
                        <p class="preco">R$50,00</p>
                        <p>Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum.
                            Lorem jeamsun denim lorem jeansum.</p>
                        <p>
                            <button>Adiconar ao carrinho</button>
                        </p>
                    </div>
                </div>
            </div>
            <br>
        </center>
        <!--CARD DOS PRODUTOS/-->
        <hr class="hr">
        <br>
        <button id="btn" class="btn_açao">Leia Mais</button>
        <div class="footer">
            asdasdasd
        </div>
    </body>
</html>
<script>

    var btn = document.querySelector("#btn");

    btn.addEventListener("click", function () {

        var div = document.querySelector("#container");

        if (div.style.display === "none") {
            div.style.display = "block";
            btn.innerHTML = "Leia Menos"
        } else {
            div.style.display = "none";
            btn.innerHTML = "Leia Mais"
        }

    });
</script>
