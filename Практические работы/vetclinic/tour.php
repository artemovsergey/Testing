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
        
        
        $query ="SELECT * FROM tours WHERE id_tour = ".$_GET["tour"]."";
        
        if (!$_GET["tour"]) 
            $query ="SELECT * FROM tours";
    
    ?>
    
<article>
     
    <?php
                // выполняем операции с базой данных
                
                $result = mysqli_query($link, $query) or die("Ошибка " . mysqli_error($link)); 
                if($result)
                { 
                    while($row = mysqli_fetch_array($result)) { 

                       print '
                       <div class="tour-container">
                        <div class="tour-image">
                            <img class="big-photo-tour" src="'.$row["image"].'">
                        </div>
                          <div class="tour-info">
                            <h1>'.$row["title"].'</h1>
                            <p style="line-height: 30px;">'.$row["description"].'</p>
                            <table>
                              <tr>
                                <td>Продолжительность процедуры:</td><td>'.$row["length"].' мин.</td>
                              </tr>
                              <tr>
                                <td>Цена: </td><td>'.$row["duration"].' руб.</td>
                              </tr>
                            </table>
                            <button>Записаться на процедуру</button>
                          </div>
                        </div>';
                      }
                };
      ?>
</article>

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

     </body>
     <script type="text/javascript" src="js/slide.js"></script>
</html>