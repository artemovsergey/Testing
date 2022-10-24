<?php
    session_start(); 
?> 
<!doctype html>
<html lang="ru">
  <head>
  
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="stylesheet" type="text/css" href="css/steps.css">
    <script src="js/jquery-1.7.2.min.js"></script>
   
    <title>Ветеринарная клиника "Шанс-вет"</title>
  </head>
  <body>
        <nav>
        <ul id="navbar">
                <li id="title"><img src="img/car.png" id="logo"></li>
                <li><a href="#">Главная</a></li>
                <li><a href="#">Новости</a></li>
                <li><a href="#">Услуги</a>
                  <ul>
                    <li><a href="catalog.php?direction=2">Собаки</a></li>
                    <li><a href="catalog.php?direction=3">Кошки</a></li>
                    <li><a href="catalog.php?direction=4">Птицы</a></li>
                    <li><a href="catalog.php?direction=1">Грызуны</a></li>
                  </ul>
                </li>
                <li><a href="#">О нас</a></li>
              </ul>
              <div class="auth">
              <?php
               if (isset($_SESSION['id_FIO'])) {
                echo '<h4 style="color: white;"><a href="client/client.php">'.$_SESSION['id_FIO'].'</a></h4>';
               } else {
                 echo '<a href="client/client.php">Войти</a>
                 <a class="" href="registration.php">Регистрация</a>';
               }
              ?>
              </div>
              
              <button class="order-trip popup-open">Звонок</button>
            </nav>

     <div id="slider-wrap">
          <div id="slider">
            <div class="slide" style="background: url(img/1.jpg) no-repeat center; background-size: cover;">
              <div class="z1text">Ветеринарная клиника 24/7</div>
              <p class="description">Наша команда профессиональных врачей позаботится о вашем питомце!
              Наша ветеринарная клиника предлагает полный набор услуг.
              Мы готовы помочь вам с любыми проблемами и в любых ситуациях!</p>
                <button class="calc-trip">Записаться</button> 
              </div>
            <div class="slide" style="background: url(img/2.jpg) no-repeat center; background-size: cover;">
              <div class="z1text">Современное оборудование</div> 
              <p class="description">Наша ветеринарная клиника оснащена современным оборудованием для обследований и передового лечения четвероногих друзей. У нас доступно любое оборудование для проведения лабораторных исследований, рентгенографии, ультразвуковых и эндоскопических исследований.</p>
                <button class="calc-trip">Записаться</button> 
            </div>
            <div class="slide" style="background: url(img/3.jpg) no-repeat center; background-size: cover;">
              <div class="z1text">Чипирование питомцев</div> 
              <p class="description">Чипирование котят можно делать уже на первом месяце жизни, при условии, что животное не болеет. Так же желательно производить процедуру до прививки от бешенства.</p>
                <button class="calc-trip">Записаться</button> 
            </div>
            <div class="slide" style="background: url(img/4.jpg) no-repeat center; background-size: cover;">
              <div class="z1text">Стационар для живонтых</div>
              <p class="description">После обследования Вашего питомца ветеринарный специалист может рекомендовать пребывание в стационаре. Интенсивность оказания медицинской помощи зависит от состояния животного и может варьироваться от простого наблюдения и кормления до постоянного 24-часового мониторинга медицинским персоналом отделения интенсивной терапии.</p>
                <button class="calc-trip">Записаться</button> 
            </div>
          </div>
      </div>
        
    <article>
      <p id="text-introduction">Ветеринарная клиника на "Шанс-вет" представляет собой клинико-диагностическое учреждение, 
      в котором проводится комплекс лабораторных обследований, необходимых для выявления заболевания у животного, 
      и методов его лечения с применением современных технологий ветеринарной медицины. </p>
      <h3>Наши преимущества: </h3>
      <ul class="country">
        <li><img class="flags" src="img/5.jpg"><span>Профессиональные врачи</span></li>
        <li><img class="flags" src="img/6.png"><span>Современное оборудование</span></li>
        <li><img class="flags" src="img/7.png"><span>Широкий спектр<br> услуг</span></li>
        <li><img class="flags" src="img/8.png"><span>Удобное<br> расположение</span></li>
      </ul>
    </article>

    <article>
        <p id="text-introduction">Предварительной записи не требуется. 
        В большинстве случаев питомцы осматриваются и получают необходимое лечение в течении 60 минут. 
        Наши специалисты на месте проведут диагностические тесты и мероприятия в своей лаборатории. 
        Удобное расположение клиники, отдельно стоящее здание, своя большая парковка для клиентов. </p>
    </article>

    <section>
        <div class="image-tape">
            <img src="img/13.jpg">
            <img src="img/14.jpg">
            <img src="img/15.jpg">
            <img src="img/16.jpg">
            <img src="img/17.jpg">
        </div>
    </section>
    
    
 
    <div class="popup-fade">
      <div class="popup">
        <a class="popup-close" href="#">Закрыть</a>
        <h3>Заказать звонок</h3>
        <form action="index.php" method="POST">
          <label>Фамилия и имя</label><i> *</i><br><input type="text" required placeholder="Иван Иванов"><br>
          <label>Номер телефона</label><i> *</i><br><input type="tel" required placeholder="+7 (916) 123-45-67" value="+7" minlength="12"><br>
          <label for="agree" style="font-size: 10px;">Я даю свое согласие на обработку персональных данных:</label><i> *</i>
                        <input name="agree" type="checkbox" id="agree" required><br>
                      <i>* Поля, отмеченные звездочкой, обязательны для заполнения</i><br><br>
          <button>Оставить заявку</button>
        </form>
      </div>		
    </div>

    
   
   
    <footer>
      Гусев Ф.А. 181-321
      <a href="admin/admin.php">Вход для администратора</a>
    </footer>

     </body>
     <script type="text/javascript" src="js/slide.js"></script>
</html>