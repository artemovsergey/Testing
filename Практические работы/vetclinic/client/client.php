<?php
    session_start(); 
?> 
<!doctype html>
<html lang="ru">
  <head>
  
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" type="text/css" href="../css/style.css">
    <link rel="stylesheet" type="text/css" href="../css/steps.css">
    <script src="../js/jquery-1.7.2.min.js"></script>
    
    <title>Ветеринарная клиника</title>
  </head>
  <body>
<?php 
           if (!isset($_SESSION['id_cl'])) {

            echo '
            <img class="back-client" src="../img/back-client.jpg">
            <section class="auth-client">
            <div class="form-client">
              <h3>Вход в личный кабинет:</h3>
              <br><br>
              <form action="client.php" method="POST">
                      <label for="login">Введите логин</label><br>
                    <input name="login" type="text" required><br>
                      <label for="pass">Введите пароль</label><br>
                    <input name="pass" type="password" id="pass" required> <br>
                  <button>Войти</button><br><br>
                    <a href="../index.php" style="color: black;">На главную</a>
              </form>
            </div>
            </section>';

            require_once '../connection.php'; // подключаем скрипт
                
                // подключаемся к серверу
                $link = mysqli_connect($host, $user, $password, $database) 
                    or die("Ошибка " . mysqli_error($link));
                   
                $sql_res = mysqli_query($link, 'SELECT id_user, FIO, login, pass, role FROM users');
                for ($i=0; $i < mysqli_num_rows($sql_res); $i++) {
                    $row = mysqli_fetch_array($sql_res, MYSQLI_ASSOC);
                    // print_r($row);
                    $adm_id = $row['id_user'];
                    $adm_FIO = $row['FIO'];
                    $adm_log = $row['login'];
                    $adm_pass = $row['pass'];
                    $adm_role = $row['role'];
                    // echo '<br>'.$adm_log.' '.$adm_pass;
                    if(password_verify($_POST['pass'], $adm_pass) == TRUE && $_POST['login'] == $adm_log && $adm_role == "P") {
                        $_SESSION['id_cl'] = $adm_id;
                        $_SESSION['id_FIO'] = $adm_FIO;
                        echo "<script>window.location = 'client.php'</script>";
                    } 
                }
    
                

            }  else {
                  echo '
                  <nav>
                  <ul id="navbar">
                          <li id="title"><img src="../img/car.png" id="logo"></li>
                          <li><a href="../index.php">Главная</a></li>
                          <li><a href="#">Новости</a></li>
                          <li><a href="#">Каталог</a>
                            <ul>
                              <li><a href="../catalog.php?direction=2">Прибалтика</a></li>
                              <li><a href="../catalog.php?direction=3">Европа</a></li>
                              <li><a href="../catalog.php?direction=4">Скандинавия</a></li>
                              <li><a href="../catalog.php?direction=1">Россия</a></li>
                            </ul>
                          </li>
                          <li><a href="#">О нас</a></li>
                        </ul>
                        <div class="auth">
                            <h4 style="color: white;">'.$_SESSION['id_FIO'].'</h4>
                        </div>
                        <form method="POST">
                            <button name="exit" class="order-trip">Выйти</button>
                        </form>
                      </nav>';

              if (isset($_POST["exit"])) {
                session_destroy();
                echo "<script>window.location = 'client.php'</script>";
              }

              if ($_GET["a"] == "add") require 'trip-add.php';
            }
             

?> 
     </body>
     <script src="../js/form.js"></script>
     <script src="../js/chart.js"></script>
</html>