-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 15 2020 г., 16:45
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `vetclinic`
--

-- --------------------------------------------------------

--
-- Структура таблицы `direction`
--

CREATE TABLE `direction` (
  `id_direction` int(11) NOT NULL,
  `name_direction` varchar(100) NOT NULL,
  `direction` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `direction`
--

INSERT INTO `direction` (`id_direction`, `name_direction`, `direction`) VALUES
(1, 'Россия', ''),
(2, 'Прибалтика', ''),
(3, 'Центральная Европа', ''),
(4, 'Скандинавия', '');

-- --------------------------------------------------------

--
-- Структура таблицы `tours`
--

CREATE TABLE `tours` (
  `id_tour` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `description` varchar(500) NOT NULL,
  `length` int(11) NOT NULL,
  `duration` int(11) NOT NULL,
  `image` varchar(200) NOT NULL,
  `popular` tinyint(1) NOT NULL,
  `id_direction` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tours`
--

INSERT INTO `tours` (`id_tour`, `title`, `description`, `length`, `duration`, `image`, `popular`, `id_direction`) VALUES
(1, 'Вакцинация собаки', 'В комплексную прививку входят антитела от лептоспироза, гепатита, чумы и вирусного энтерита.', 15, 1250, 'img/10.jpg', 1, 2),
(2, 'Комплексный осмотр', 'Основой общей профилактики болезней собаки является диспансеризация. Это систематическое наблюдение за состоянием здоровья животных с целью обнаружения болезней на ранней стадии развития и проведения профилактических или лечебных мероприятий.', 35, 2000, 'img/11.jpg', 0, 2),
(3, 'Функциональная диагностика', 'Животное не может рассказать, что его беспокоит, что болит, и поэтому функциональная диагностика является одним из качественных методов определения причин недугов домашних животных. ', 45, 2500, 'img/12.jpg', 0, 2),
(4, 'Стрижка когтей', 'В нашей клинике можно безболезненно удалить отросшие когти у вашего пернатого друга. ', 15, 500, 'img/21.jpg', 1, 4),
(5, 'Осмотр кошки', 'Основой общей профилактики болезней кошки является диспансеризация. Это систематическое наблюдение за состоянием здоровья животных с целью обнаружения болезней на ранней стадии развития и проведения профилактических или лечебных мероприятий.', 30, 1850, 'img/20.jpg', 0, 3),
(6, 'Вакцинация грызуна', 'Крыс, хомячков, морских свинок, шиншилл и кроликов необходимо обрабатывать от глистов не менее 2 раз в год специальными препаратами, которые хорошо переносятся и не вызывают осложнений.', 15, 790, 'img/18.jpg', 1, 1),
(7, 'Осмотр птицы', 'Птицы, несмотря на простоту ухода за ними, подвержены различным заболеваниям. Причем, многие болезни птиц могут передаваться человеку. Поэтому своевременное обращение к ветеринару может не только спасти питомца, но и помочь сохранить свое здоровье.', 30, 1500, 'img/19.jpg', 0, 4),
(8, 'Осмотр грызуна', 'Врач-ратолог может быстро выявить специфические заболевания грызунов, а также провести в случае необходимости дифференциальную диагностику.', 25, 650, 'img/22.jpg', 0, 1),
(9, 'Лечение зубов', 'У грызунов всех видов часто появляются проблемы с зубами. В случае возникновения таких проблем, животное может отказываться от еды, что влечет за собой серьезные проблемы. В случае отказа от еды в течение нескольких дней грызун может страдать от истощения и даже умереть.', 30, 1490, 'img/image-31.png', 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `FIO` varchar(100) NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `role` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id_user`, `FIO`, `login`, `pass`, `role`) VALUES
(1, 'Администратор', 'admin', '81dc9bdb52d04dc20036dbd8313ed055', 'A'),
(2, 'Иван Иванов', 'example@mail.ru', '$2y$10$tAi48YJ.JVlzMMmrFhDICuHHnmBjXT9UqfNQv3YPM187fQ3sB3ktm', 'P'),
(3, 'Евлампий Щекочихин-Крестовоздвиженский', 'eshk@ya.ru', '$2y$10$Nb2hYG90kCy3JLcIaQC75OXLx9fHt27uXBITNTwwYC0.xzywFjC4C', 'P');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `direction`
--
ALTER TABLE `direction`
  ADD PRIMARY KEY (`id_direction`);

--
-- Индексы таблицы `tours`
--
ALTER TABLE `tours`
  ADD PRIMARY KEY (`id_tour`),
  ADD KEY `idd` (`id_direction`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `direction`
--
ALTER TABLE `direction`
  MODIFY `id_direction` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `tours`
--
ALTER TABLE `tours`
  MODIFY `id_tour` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `tours`
--
ALTER TABLE `tours`
  ADD CONSTRAINT `idd` FOREIGN KEY (`id_direction`) REFERENCES `direction` (`id_direction`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
