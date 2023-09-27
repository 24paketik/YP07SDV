# Введение
## Цели
• Восстановление базы данных из скрипта
• Импорт данных
• Разработка
# Общее описание
## Разработка
### Список услуг
В данной подсистеме необходимо добавить режим администратора. Для активации данного режима 
необходимо ввести код (на этапе разработки код всегда будет одинаковый = 0000). Список услуг должен 
быть виден всем в клиентской зоне (обычный режим), а функции добавления, удаления, редактирования 
данных об услуге, а также запись клиента на услугу и просмотр ближайших записей должен быть доступен 
только администратору (режим администратора).
Необходимо отобразить услуги в виде списка, который должен соответствовать макету, 
предоставленному в ресурсах к заданию. Однако это не означает, что необходимо следовать макету в 
точности до пикселя - это всего лишь схема расположения элементов, на которую нужно ориентироваться 
при разработке пользовательского интерфейса.
У каждой услуги должны отображаться следующие данные: наименование услуги, стоимость, 
продолжительность, миниатюра главного изображения, размер скидки.
Для привлечения клиентов некоторые услуги могут предоставляться по скидке. Если у услуги скидка 
положительна, то услуга должна быть показана со светло-зеленым фоном, а основная цена должна быть 
перечеркнута и рядом написана итоговая цена (не размер скидки).
Реализуйте возможность сортировки списка услуг по их стоимости (по возрастанию и по убыванию). 
Сортировка должна быть реализована отдельно (не с помощью стандартных функций элементов 
управления), потому что в дальнейшем планируется усложнение этого функционала путем добавления 
дополнительных условий.
Реализуйте фильтрацию списка услуг по размеру скидки. В выпадающем списке для фильтрации должны 
быть следующие варианты: от 0 до 5%, от 5% до 15%, от 15% до 30%, от 30% до 70%, от 70% до 100%, где 
нижняя граница включается в поиск, а верхняя - нет (min <= x < max). Например, услуга со скидкой 30% 
будет в диапазоне от 30% до 70%, а не от 15% до 30%. Должна быть возможность сбросить параметры 
фильтрации (например, с помощью выбора значения “Все”). Фильтрация должна работать в реальном 
времени (то есть без необходимости нажатия кнопки “найти”).
На странице со списком услуг, необходимо добавить возможность поиска услуг по названию и описанию 
товара. Поиск должен работать в реальном времени (то есть без необходимости нажатия кнопки “найти”).
Функции фильтрации и поиска должны применяться совместно к итоговой выборке.
В нижней части окна необходимо показывать количество выведенных данных и общее количество 
записей в базе. Например, 230 из 450. В случае если данные в таблицу выводятся после фильтрации или 
поиска, количество выведенных данных необходимо обновить исходя из размера выборки. 
Необходимо предусмотреть возможность удаления услуги. При этом должны соблюдаться следующие 
условия. Если у услуги есть дополнительные фотографии, то они могут быть удалены вместе с услугой. Но 
если есть информация о записях на услуги (прошлые или будущие), то удаление услуги из базы данных должно быть запрещено.
### Добавление/редактирование услуги
Необходимо добавить возможность редактирования данных существующей услуги, а также добавление новой услуги в новом окне - форме для добавления/редактирования.
Услуга должна содержать следующие данные: название, стоимость, длительность, описание, скидку, основное изображение.
При открытии формы для редактирования все поля выбранного объекта должны быть подгружены в соответствующие поля из базы данных.
При добавлении новой услуги идентификатор должен автоматически генерироваться, а поле для идентификатора отсутствует. В случае если пользователь редактирует услугу, то поле с идентификатором доступно только для чтения.
При добавлении услуги необходимо проверять, существует ли такая услуга в системе (по названию). 
Названия у услуг не должны быть одинаковы. 
Нужно учесть, что длительность оказания услуги не может быть больше, чем 4 часа, а также не может принимать отрицательные значения.
Предусмотрите возможность добавления/замены одного основного изображения к услуге. На экране должна показываться миниатюра выбранной фотографии.
После редактирования/добавления услуги данные в окне списка услуг должны быть обновлены.
Необходимо запретить открывать одновременно более одного окна редактирования.
Работа с дополнительными изображениями к услуге
К каждой услуге должна быть возможность добавить одно или более изображений с примерами предоставления услуги.
При открытии формы для редактирования ранее добавленные дополнительные изображения к услуге должны подгружаться из базы данных.
При добавлении файлов на экране должны появляться миниатюры изображений. Предусмотрите также возможность удаления добавленных изображений у существующей услуги.
При добавлении изображений копируйте их в директорию с вашим проектом, чтобы пользователь мог удалить исходное изображение.
Дополнительные изображения (пути до файлов) должны сохраняться в базе данных для каждой услуги.
### Запись клиента на услугу
При выборе определенной услуги необходимо реализовать возможность добавления записи клиента на определенную услугу.
На форме добавления записи на услугу должны отображаться данные о ней (наименование и длительность в минутах).
Список клиентов, включающий фамилию, имя и отчество, должен быть загружен из базы данных в выпадающий список.
При вводе даты оказания услуги, пользователь должен иметь возможность выбрать дату через календарь.
Присутствует поле для ввода времени начала оказания услуги. Поле для ввода может содержать только цифры и двоеточие, а введенное значение должно быть действительным временем. На основании длительности оказания услуги и времени начала рассчитывается время окончания.
После успешного ввода всех данных запись клиента должна сохраняться в базе данных.
### Ближайшие записи
Создайте окно, где администратор сможет просматривать ближайшие записи на услуги на сегодня и завтра. Записи должны быть по умолчанию отсортированы по дате и времени по возрастанию.
Каждая запись должна включать в себя следующую информацию: наименование услуги, ФИО клиента, email и телефон, дата и время записи, а также сколько времени осталось до начала услуги (в формате часов и минут, например, 2 часа 5 минут). Если до начала оказания услуги осталось меньше одного часа, то оставшееся время необходимо выделить красным цветом.
Данное окно должно обновляться каждые тридцать секунд, так как чаще всего оно будет всегда открыто у администратора.