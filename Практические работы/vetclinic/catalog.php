<!doctype html>
<html lang="ru">
  <head>
  
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="stylesheet" type="text/css" href="css/steps.css">
    <script src="js/jquery-1.7.2.min.js"></script>
   
    <title>Ветеринарная клиника</title>
  </head>
  <body>
        <nav>
        <ul id="navbar">
        <li id="title"><img src="img/car.png" id="logo"></li>
                <li><a href="index.php">Главная</a></li>
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
                  <a class="popup-open" href="#">Войти</a>
                  <a class="" href="registration.php">Регистрация</a>
              </div>
              
              <button class="order-trip">Звонок</button>
            </nav>

    <?php
        require_once 'connection.php'; // подключаем скрипт
    
        // подключаемся к серверу
        $link = mysqli_connect($host, $user, $password, $database) 
            or die("Ошибка " . mysqli_error($link));

        $search_q=$_POST['search_q'];
        
        if ($search_q) {
            $search_q = trim($search_q);
            $search_q = strip_tags($search_q);

            $q= mysqli_query($link, "SELECT * FROM `tours` WHERE title LIKE '%$search_q%'");
            while ($r_p = $q->fetch_assoc()) {
                $query = "SELECT * FROM `tours` WHERE id_tour = ".$r_p["id_tour"]."";
            }
        } else { 
            $query ="SELECT * FROM tours WHERE id_direction = ".$_GET["direction"]."";
        } 
        if (!$_GET["direction"]) 
            $query ="SELECT * FROM tours";
    
    ?>
    
     <section class="all-tours">
     
     <h1>Каталог услуг:</h1>
     <form method="post" action="catalog.php" style="width: 100%;">
            <div class="input-group mb-3">
                    <input type="text" class="search-inpt" name="search_q" placeholder="Поиск по наименованию услуги">
                        <button class="search-btn" type="submit">Поиск</button>
                </div>
            </form>
    <?php
                // выполняем операции с базой данных
                
                $result = mysqli_query($link, $query) or die("Ошибка " . mysqli_error($link)); 
                if($result)
                { 
                    while($row = mysqli_fetch_array($result)) { 
                        $article = preg_match("/^((\S+\s){8})/s", $row["description"], $m) ? $m[1]: $row["description"];

                        if ($row["popular"] == "1") {
                          $span = '<span>Популярное!</span>';
                        } else {$span = '';}
                       print '<figure><a class="link-black" href="tour.php?tour='.$row["id_tour"].'">
                          <img class="photo-land" src="'.$row["image"].'">'.$span.'
                          <figcaption>
                            <h4>'.$row["title"].'</h4>
                            <p>'.$article.'...</p>
                            <div class="info">Продолжительность: '.$row["length"].' мин.</div>
                            <div class="info">Цена: '.$row["duration"].' руб. </div>
                            </figcaption>
                            </a>
                        </figure>';
                      }
                };
      ?>
  </section>

    <div class="popup-fade">
      <div class="popup">
        <a class="popup-close" href="#">Закрыть</a>
        <h3>Авторизация</h3>
        <form action="index.php" method="POST">
          <label>Логин</label><br><input type="text" required placeholder="Введите логин"><br>
          <label>Пароль</label><br><input type="password" required placeholder="Введите пароль"><br>
          <button>Войти</button>
        </form>
      </div>		
    </div>


    <footer>
      Гусев Ф.А. 181-321
    </footer>

     </body>
     <script type="text/javascript" src="js/slide.js"></script>
</html>