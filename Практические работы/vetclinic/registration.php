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
                  <a class="popup-open" href="client/client.php">Войти</a>
                  <a class="" href="registration.php">Регистрация</a>
              </div>
              
              <button class="order-trip">Звонок</button>
            </nav>

            <h1>Регистрация:</h1>

    <form action="registration.php" method="POST" enctype="multipart/form-data" class="big-form">
                      <label for="FIO">Фамилия, Имя:</label><i> *</i><br>
                        <input name="FIO" type="text" required placeholder="Иван Иванов"><br>
                      <label for="login">E-mail:</label><i> *</i><br>
                        <input type="email" name="login" rows="5" required placeholder="example@mail.ru"></textarea><br>
                      <label for="pass">Пароль:</label><i> *</i><br>
                        <input name="pass" type="password" required><br>
                      <label for="password">Повторите пароль:</label><i> *</i><br>
                        <input name="password" type="password" required><br>
                      <label for="agree">Я даю свое согласие на обработку персональных данных:</label><i> *</i>
                        <input name="agree" type="checkbox" id="agree" required><br>
                      <i>* Поля, отмеченные звездочкой, обязательны для заполнения</i><br><br>
                      <button name="button" value="Сохранить">Зарегистрироваться</button>
                      <br><br><br><br>
                  </form>
<?php 
                  require_once 'connection.php'; // подключаем скрипт
                
                  // подключаемся к серверу
                  $link = mysqli_connect($host, $user, $password, $database) 
                      or die("Ошибка " . mysqli_error($link));
                 
                 // если были переданы данные для добавления в БД
                 if( isset($_POST['button']) && $_POST['button']== 'Сохранить')
                 {               
                 $pass_hash = password_hash($_POST['password'], PASSWORD_DEFAULT);

                 $sql_res_prod=mysqli_query($link, 'INSERT INTO users (`FIO`, `login`, `pass`, `role`) VALUES (
                      "'.htmlspecialchars($_POST['FIO']).'",
                      "'.htmlspecialchars($_POST['login']).'",
                      "'.$pass_hash.'",
                      "P")');
                 
                 // если при выполнении запроса произошла ошибка – выводим сообщение
                 if( mysqli_errno($link) )
                 echo '<hr><div class="error col" style="color:red; font-size:20px">Запись не добавлена</div>'.mysqli_error($link);
                 else // если все прошло нормально – выводим сообщение
                 echo '<hr><div class="ok col" style="color:green; font-size:20px">Запись добавлена</div>';
                 
                 }
?>

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
      <a href="admin/admin.php">Вход для администратора</a>
    </footer>

     </body>
     <script type="text/javascript" src="js/slide.js"></script>
</html>


