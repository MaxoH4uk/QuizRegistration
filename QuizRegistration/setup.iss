; Имя приложения
#define   Name       "Quiz Registration"
; Версия приложения
#define   Version    "1.0.0"
; Фирма-разработчик
#define   Publisher  "Maximqa"
; Имя исполняемого модуля
#define   ExeName    "QuizRegistration.exe"


[Setup]
; Уникальный идентификатор приложения, 
;сгенерированный через Tools -> Generate GUID
AppId={{58A0F484-29A7-449A-A050-F7314F8D0B25}

; Прочая информация, отображаемая при установке
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}

; Путь установки по-умолчанию
DefaultDirName={pf}\{#Name}
; Имя группы в меню "Пуск"
DefaultGroupName={#Name}

; Каталог, куда будет записан собранный setup и имя исполняемого файла
OutputDir=C:\Users\Maxim\RiderProjects\mozgo quiz registration
OutputBaseFileName=QuizRegistrationSetup

; Файл иконки
SetupIconFile=C:\Users\Maxim\Desktop\shortcut.ico

; Параметры сжатия
Compression=lzma
SolidCompression=yes

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "C:\Program Files (x86)\Inno Setup 6\Languages\Russian.isl"

[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; Исполняемый файл
Source: "C:\Users\Maxim\RiderProjects\mozgo quiz registration\QuizRegistration\bin\Release\QuizRegistration.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: "C:\Users\Maxim\RiderProjects\mozgo quiz registration\QuizRegistration\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"

Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon
