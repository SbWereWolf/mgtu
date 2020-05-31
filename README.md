# Тестовое задание

## Исходные данные
1. Создайте базу данных (MS SQL) и в ней 2 таблицы:

Users

|Id| Name|
|--|-----|
|1| Вася|
|2| Петя|
|3| Маша|
|4| Саша|


Emails

Id| UserId| Email
--|-------|------
1| 1| ewrg@erge.er
2| 1| edfqew@erg.ru
3| 2| sef@rwq.sd
4| 4| lfd@ds.sw
5| 3| ergwer@dfq.re
6| 3| dwretj@tyjket.hr
7| 4| ewrgwe@yjke.wer
8| 2| ergeh@etyj.tr

2. Создайте проект ASP.NET, MVC, .NET Framework

3. Базу данных интегрируйте в проект (Entity Framework).

## Задание:
Создайте страницу, на которой расположен выпадающий список с именами пользователей. При
выборе пользователя на страницу из базы подтягиваются его емейлы (ajax, jquery).
На этой же странице, предусмотрите возможность добавлять в базу данных новые емейлы для
выбранного пользователя.

## Ожидаемый результат
Запакуйте решение вместе с базой данных в архив, залейте на облачный диск (или иное
хранилище).

# Решение
- База данных прилагается к проекту, разворачивать отдельно не требуется
- Разворачивание приложения не предусмотрена, запускать следует только из IDE Visual Studio
- Создана одна страница, на которой расположен выпадающий список для выбора пользователя
- Для выбранного пользователя выводятся все его адреса электронной почты
- Для выбранного пользователя можно добавить адрес с помощью поля для ввода текста и кнопки "Добавить" (пустой адрес допускается, дублирование адресов допускается, маски ввода нет)
- Обработки ошибок, валидации данных не реализовано
