<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ulog.aspx.cs" Inherits="_1.ulog" %>

<html lang="per" dir="rtl">
   <!-- Basic -->
   <meta charset="utf-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <!-- Mobile Metas -->
   <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
   <!-- Site Metas -->
   <title>طلای قهرمانی پور</title>
   <meta name="keywords" content="">
   <meta name="description" content="">
   <meta name="author" content="">
   <!-- site icon -->
   <link rel="icon" href="images/fevicon.png" type="image/png" />
   <!-- Bootstrap core CSS -->
   <link href="css/bootstrap.css" rel="stylesheet">
   <!-- FontAwesome Icons core CSS -->
   <link href="css/font-awesome.min.css" rel="stylesheet">
   <!-- Custom animate styles for this template -->
   <link href="css/animate.css" rel="stylesheet">
   <!-- Custom styles for this template -->
   <link href="style.css" rel="stylesheet">
   <!-- Responsive styles for this template -->
   <link href="css/responsive.css" rel="stylesheet">
   <!-- Colors for this template -->
   <link href="css/colors.css" rel="stylesheet">
   <!-- light box gallery -->
   <link href="css/ekko-lightbox.css" rel="stylesheet">
   <!--[if lt IE 9]>
   <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
   <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
   <![endif]-->
   </head>>
<body id="home_page" class="home_page">
    <form id="form1" runat="server">
       <div id="preloader">
         <img class="preloader" src="images/logo.png" alt="#">
      </div>
      <!-- end loader -->
      <!-- header -->
      <header class="header">

        <div class="header_top_section" dir="rtl">
           <div class="container">
              <div class="row">
               <div class="col-lg-3">
                  <div class="full">
                     <div class="logo">
                        <a href="index.html"><img src="images/logo.png" alt="#" /></a>
                     </div>
                  </div>
               </div>
               <div class="col-lg-9 site_information">
                  <div class="full">
                      <div class="top_section_info">
                         <ul>
                           <li><img src="images/i1.png" alt="#" /> <a href="#">(  37725731 41+ )</a></li>
                           <li><img src="images/i2.png" alt="#" /> <a href="#">GOLDgahreman@gmail.com</a></li>
                           <li><img src="images/i3.png" alt="#" /> <a href="#">بناب , بازار چهارسو</a></li>
                        </ul>
                      </div>
                  </div>
               </div>
            </div>
           </div>
        </div>

        <div class="header_bottom_section">

         <div class="container">
            
           <div class="row">
               <div class="col-md-12">
                  <div class="full ">
                     <div class="main_menu" style="text-align: center; padding-left: 350px;" dir="rtl">
                        <nav class="navbar navbar-inverse navbar-toggleable-md" dir="rtl">
                           <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#cloapediamenu" aria-controls="cloapediamenu" aria-expanded="false" aria-label="Toggle navigation">
                           <span class="float-left">Menu</span>
                           <span class="float-right"><i class="fa fa-bars"></i> <i class="fa fa-close"></i></span>
                           </button>
                           <div class="collapse navbar-collapse justify-content-md-center" id="cloapediamenu" dir="rtl">
                              <ul class="navbar-nav">
                                 <li class="nav-item active">
                                    <a class="nav-link" href="index.html">خانه</a>
                                 </li>
                                 <li class="nav-item">
                                    <a class="nav-link color-aqua-hover" href="index.html.#cont">درباره ما</a>
                                 </li>
                                 <li class="nav-item">
                                    <a class="nav-link color-aqua-hover" href="index.html.#pro">جواهرات</a>
                                 </li>
                                 <li class="nav-item">
                                    <a class="nav-link color-grey-hover" href="shop.html">مغازه</a>
                                 </li>
                                 <li class="nav-item">
                                    <a class="nav-link color-grey-hover" href="index.html.#cont">ازتباط با ما</a>
                                 </li>
                              </ul>
                           </div>
                        </nav>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </header>
      <!-- end header -->
       <!-- inner page -->
      <section class="innerpage_banner">
         <div class="container">
            <div class="row">
               <div class="col-sm-12">
                  <div class="full">
                     <div class="" >
                        <div class="">
                           <h1 style=" padding-left: 900px; color: #ffffff; font-size: 100px;"><span>ورود</span></h1>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </section>
      <!-- end inner page -->
      <!-- section -->
      
      <!-- end section -->
      <!-- section -->
      <section class="layout_padding haf_layout section" dir="rtl">
         <div class="container">
            <div class="container">
               <div class="row product_section">
                  <div class="col-md-6"> 
                     <div class="full product_blog margin_top_30 mt-9">
                        <h1>ایجاد حساب کاربری جدید </h1>
                        <h3>با ایجاد حساب کاربری جدید در سایت ما شما می توانید  از تمامی مزیت های سایت سایت ما بهره مند شودید و خریدی به یاد ماندنی را تجربه کنید</h3>
                          <br>
                          <br>
                         <asp:Button ID="btncreac" runat="server" Text="ایجاد" />
                        </div>
                  </div>
                   <div class="col-md-6"> 
                      <div class="full product_blog margin_top_30">
                         <div >
                           <div style="text-align: center;">
                           <h1>ورود به سبد خرید </h1>
                         </div>
                           <br>
                           <form action="#" method="post">
                           <div class="mb-3 mt-3">
                             <label for="email" class="form-label">نام کاربری :</label>
                               <asp:TextBox ID="Textuser" runat="server"></asp:TextBox>
                           </div>
                           <div class="mb-3">
                             <label for="pwd" class="form-label">رمز عبورد :</label>
                               <asp:TextBox class="form-control" ID="Textpass" runat="server" TextMode="Password"></asp:TextBox>
                            
                           </div>
                           <div class="form-check mb-3">
                             <label class="form-check-label">
                               <input class="form-check-input" type="checkbox" name="remember"> مرا به یاد داشته باش
                             </label>
                           </div>
                               <asp:Button  class="btn btn-primary" ID="btninter" runat="server" Text="ورود" />
                         </div>
                         </form>
                     </div>
                      </div>
                   </div>
             </div>
      </section>
      <!-- end section -->
      <!-- footer -->
     <!-- footer -->
     <footer class="footer layout_padding">
      <div class="container">
         <div class="row">
            <div class="col-md-3 col-sm-12">
               <a href="index.html"><img class="img-responsive" src="images/logo_footer.png" alt="#" /></a>
            </div>

            <div class="col-md-3 col-sm-12">
               <div class="footer_link_heading">
                  <h3>آدرس</h3>
               </div>
               <div class="address_infor">
                  <p> 
                     <span class="icon"><img src="images/location_icon.png" alt="#" /></span>
                     <span class="addrs">بناب , بازار چهارسو</span>
                  </p>
               </div>
            </div>

            <div class="col-md-3 col-sm-12">
               <div class="footer_link_heading">
                  <h3>رسانه های اجتماعی</h3>
               </div>
               <div class="social_icon">
                 <ul>
                    <li><a href="#"><img src="images/fb.png" alt="#" /></a></li>
                    <li><a href="#"><img src="images/tw.png" alt="#" /></a></li>
                    <li><a href="#"><img src="images/gp.png" alt="#" /></a></li>
                    <li><a href="#"><img src="images/in.png" alt="#" /></a></li>
                 </ul>
               </div>
            </div>
            
            <div class="col-md-3 col-sm-12">
               <div class="footer_link_heading">
                  <h3>اطلاع از آخرین اخبار</h3>
               </div>
               <div class="email_address_bottom">
                  <form>
                     <fieldset>
                        <div class="field_email">
                           <input type="email" name="email" placeholder="ایمیلتان را وارد کنید">
                           <button><i class="fa fa-search"></i></button>
                        </div>
                     </fieldset>
                  </form>
               </div>
            </div>
         </div>
      </div>
   </footer>
   <!-- end footer -->
   <!-- Core JavaScript
      ================================================== -->
   <script src="js/jquery.min.js"></script>
   <script src="js/tether.min.js"></script>
   <script src="js/bootstrap.min.js"></script>
   <script src="js/parallax.js"></script>
   <script src="js/animate.js"></script>
   <script src="js/ekko-lightbox.js"></script>
   <script src="js/custom.js"></script>
    </form>
</body>
</html>