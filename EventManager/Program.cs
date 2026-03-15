using System;

// README.md를 읽고 코드를 작성하세요.

ScoreSystem scoreSystem = new ScoreSystem();
AchievementSystem achievementSystem = new AchievementSystem();
SoundSystem soundSystem = new SoundSystem();

// 이벤트 구독
EventManager.OnGameEvent += soundSystem.OnPrintSound;
EventManager.OnGameEvent += scoreSystem.OnScoreChanged;
EventManager.OnGameEvent += achievementSystem.OnAchievement;

// 테스트 시나리오 실행
EventManager.TriggerEvent("ScoreChanged", 100);
EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
EventManager.TriggerEvent("GameOver", null);