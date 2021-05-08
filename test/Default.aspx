<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="contenedor sobre-nosotros">
            <h2 class="titulo">Nuestro producto</h2>
            <div class="contenedor-sobre-nosotros">
                <img src="img/ilustracion2.svg" alt="" class="imagen-about-us">
                <div class="contenido-textos">
                    <h3><span>1</span>Los mejores productos</h3>
                    <p>El inicio de esta pagina esta hecha solo con html y css, es responsive, las imagenes son recursos del 
                        proyecto, no de la base de datos, eso se realizó en la seccion de productos</p>
                    <!-- Segunda seccion -->
                    <h3><span>2</span>Los mejores productos</h3>
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Commodi consectetur rem ratione,
                        doloremque quasi omnis veniam velit eius amet. Facere harum libero minima natus. In repudiandae
                        inventore sequi doloribus minima!</p>
                </div>
            </div>
        </section>
        <section class="portafolio">
            <div class="contenedor">
                <h2 class="titulo">Portafolio</h2>
                <div class="galeria-port">
                    <!-- Las 8 fotos -->
                    <div class="imagen-port">
                        <img src="img/img1.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img2.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img3.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img4.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img5.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img6.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img7.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                    <div class="imagen-port">
                        <img src="img/img8.jpg" alt="">
                        <div class="hover-galeria">
                            <img src="img/icono1.png" alt="">
                            <p>Nuestro trabajo</p>
                        </div>
                    </div>

                </div>
            </div>
        </section>
        <section class="clientes contenedor">
            <h2 class="titulo">Que dicen nuestros clientes</h2>
            <div class="cards">

                <div class="card">
                    <img src="img/face1.jpg" alt="">
                    <div class="contenido-texto-card">
                        <h4>Nombre</h4>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Cum, modi! </p>
                    </div>
                </div>
                <div class="card">
                    <img src="img/face2.jpg" alt="">
                    <div class="contenido-texto-card">
                        <h4>Nombre</h4>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Cum, modi! </p>
                    </div>
                </div>
            </div>
        </section>
        <section class="about-services">
            <div class="contenedor">
                <h2 class="titulo">Nuestros Servicios</h2>
                <div class="servicio-cont">
                    <div class="servicio-ind">
                        <img src="img/ilustracion1.svg" alt="">
                        <h3>Name</h3>
                        <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Assumenda, incidunt?</p>
                    </div>
                    <div class="servicio-ind">
                        <img src="img/ilustracion4.svg" alt="">
                        <h3>Name</h3>
                        <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Assumenda, incidunt?</p>
                    </div>
                    <div class="servicio-ind">
                        <img src="img/ilustracion3.svg" alt="">
                        <h3>Name</h3>
                        <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Assumenda, incidunt?</p>
                    </div>
                </div>
            </div>
        </section>
    </main>



</asp:Content>
