# TeamWork

# Basic knowledge
Ссылки:
- [Руководство по C#.](https://professorweb.ru/my/csharp/charp_theory/level1/index.php)
- [Руководство по оформлению .md файлов.](https://paulradzkov.com/2014/markdown_cheatsheet/)
- [GitHub ознакомление с платформой](https://docs.github.com/en/github/managing-your-work-on-github)
---
## Git
**Список комманд, которые часто используются в Git**

---

### Getting & Creating Projects

<details>
    <summary>Развернуть</summary>

| Команда | Описание |
| ------- | ----------- |
| `git init` | Инициализация локального репозитория Git  |
| `git clone ssh://git@github.com/[username]/[repository-name].git` | Создать локальную копию удаленного репозитория |

</details>

### Basic Snapshotting

<details>
    <summary>Развернуть</summary>

| Команда | Описание |
| ------- | ----------- |
| `git status` | Проверить статус |
| `git add [file-name.txt]` | Добавить файл в область подготовки |
| `git add -A` | Добавить все новые и измененные файлы в область подготовки |
| `git commit -m "[commit message]"` | Зафиксировать изменения |
| `git rm -r [file-name.txt]` | Удалить файл (или папку) |

</details>

### Branching & Merging

<details>
    <summary>Развернуть</summary>

| Команда | Описание |
| ------- | ----------- |
| `git branch` | Список веток (звездочка обозначает текущую ветку) |
| `git branch -a` | Список всех веток (локальных и удаленных) |
| `git branch [branch name]` | Создать новую ветку |
| `git branch -d [branch name]` | Удалить ветку |
| `git push origin --delete [branch name]` | Удалить удаленную ветку |
| `git checkout -b [branch name]` | Создание новой ветки и переключение на нее |
| `git checkout -b [branch name] origin/[branch name]` |Клонировать удаленную ветку и переключиться на нее |
| `git branch -m [old branch name] [new branch name]` | Переименовать локальную ветку |
| `git checkout [branch name]` | Изменить ветку |
| `git checkout -` | Переключиться на ветку, где последний раз проверялся |
| `git checkout -- [file-name.txt]` | Отменить изменения в файле |
| `git merge [branch name]` |Объединить ветку с активной веткой |
| `git merge [source branch] [target branch]` |Объединить ветку в целевую ветку |
| `git stash` | Хранить изменения в грязном рабочем каталоге |
| `git stash clear` | Удалить все спрятанные записи |

</details>

### Sharing & Updating Projects

<details>
    <summary>Развернуть</summary>

| Команда | Описание |
| ------- | ----------- |
| `git push origin [branch name]` | Отправляет ветку в удаленный репозиторий |
| `git push -u origin [branch name]` | Отправляет изменения в удаленный репозиторий (и запомните ветку) |
| `git push` | Отправляет изменения в удаленный репозиторий (запомненная ветка) |
| `git push origin --delete [branch name]` | Удалить удаленную ветку |
| `git pull` |Обновите локальный репозиторий до последнего обновления |
| `git pull origin [branch name]` | Получить изменения из удаленного репозитория |
| `git remote add origin ssh://git@github.com/[username]/[repository-name].git` | Добавить удаленный репозиторий |
| `git remote set-url origin ssh://git@github.com/[username]/[repository-name].git` | Установите исходную ветку репозитория на SSH |

</details>

### Inspection & Comparison

<details>
    <summary>Развернуть</summary>

| Команда | Описание |
| ------- | ----------- |
| `git log` | Посмотреть изменения |
| `git log --summary` | Посмотреть изменения (подробно) |
| `git log --oneline` | Посмотреть изменения (кратко) |
| `git diff [source branch] [target branch]` | Предварительный просмотр изменений перед объединением |

### Login

<details>
    <summary>Развернуть</summary>

| Команда | Описание |
| ------- | ----------- |
| `git config --global user.name ` | Вводим имя пользователя |
| `git config --global user.email` | Вводим почту пользователя |

</details>


