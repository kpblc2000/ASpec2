View
 [> Album]
  > AlbumView
    AlbumCreateEditView
    ...
 > UserControls
  > AlbumUserControl
    AlbumCreateEditUserControl
ViewModel
 [> Album]
  > AlbumViewModel
    AlbumCreateEditViewModel

***
AlbumView вызывает AlbumCreateEditView. Сохранение выполняется в "родительском" представлении / ViewModel. Клонирование объекта выполняется внутри "родителя". Запись изменений / обновлений - в "родителе"