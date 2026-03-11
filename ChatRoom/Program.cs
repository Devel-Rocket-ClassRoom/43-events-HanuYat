using System;

// README.md를 읽고 아래에 코드를 작성하세요.

ChatRoom chat = new ChatRoom();
ChatLogger logger = new ChatLogger();
NotificationService service = new NotificationService();

chat.MessageReceived += logger.Log;
chat.MessageReceived += service.Urgent;

chat.SendMessage("철수", "안녕하세요");
chat.SendMessage("영희", "긴급 회의가 있습니다");
chat.SendMessage("민수", "점심 뭐 먹을까요?");