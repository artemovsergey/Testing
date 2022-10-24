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
           if (!isset($_SESSION['id'])) {

            echo '
            <section class="all-tours">
              <h3>Вход (Администратор)</h3>
              <br><br>
              <form action="admin.php" method="POST">
                      <label for="login">Введите логин</label><br>
                    <input name="login" type="text" required><br>
                      <label for="pass">Введите пароль</label><br>
                    <input name="pass" type="password" id="pass" required> <br>
                  <button>Войти</button><br><br>
                    <a href="../index.php" style="color: black;">На главную</a>
              </form>
            </section>';

            require_once '../connection.php'; // подключаем скрипт
                
                // подключаемся к серверу
                $link = mysqli_connect($host, $user, $password, $database) 
                    or die("Ошибка " . mysqli_error($link));
                    // безопасность превыше всего! - без хеширования паролей не обойтись
                $pass_hash = md5($_POST['pass']);
                
                $sql_res = mysqli_query($link, "SELECT * FROM users WHERE role = 'A'");
                for ($i=0; $i < mysqli_num_rows($sql_res); $i++) {
                    $row = mysqli_fetch_array($sql_res, MYSQLI_ASSOC);
                    // print_r($row);
                    $adm_id = $row['id_user'];
                    $adm_fio = $row['FIO'];
                    $adm_log = $row['login'];
                    $adm_pass = $row['pass'];
                    //echo '<br>'.$adm_log.' '.$adm_pass;
                }
    
                if($adm_pass == $pass_hash && $_POST['login'] == $adm_log) {
                    $_SESSION['id'] = $adm_id;
                    echo "<script>window.location = 'admin.php'</script>";
                }

            }  else {
                  echo '
                   <nav>
                    <ul id="navbar">
                      <li id="title"><img src="../img/admin.png" id="logo"></li>
                      <li><a href="admin.php">Главная</a></li>
                      <li><a href="?a=add">Добавить тур</a></li>
                      <li><a href="#">Каталог туров</a>
                        <ul>
                          <li><a href="../catalog.php?direction=2">Прибалтика</a></li>
                          <li><a href="../catalog.php?direction=3">Европа</a></li>
                          <li><a href="../catalog.php?direction=4">Скандинавия</a></li>
                          <li><a href="../catalog.php?direction=1">Россия</a></li>
                        </ul>
                      </li>
                      <li><a href="#">Клиенты</a></li>
                    </ul>
                    <form method="POST">
                      <button name="exit" class="order-trip">Выйти</button>
                    </form>
                  </nav>';
              if (isset($_POST["exit"])) {
                session_destroy();
                echo "<script>window.location = 'admin.php'</script>";
              }

              if ($_GET["a"] == "add") require 'trip-add.php';
            }
             

?> 

     </body>
     <script src="../js/form.js"></script>
     <script src="../js/chart.js"></script>
</html>