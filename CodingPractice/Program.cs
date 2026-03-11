using System;

// README.md를 읽고 코드를 작성하세요.

Notify notify = SayHello;
notify += SayGoodbye;
notify();

void SayHello() => Console.WriteLine("안녕하세요!");
void SayGoodbye() => Console.WriteLine("안녕히 가세요!");
Console.WriteLine();

static void HandleClick() => Console.WriteLine("버튼이 클릭되었습니다!");
static void HandleClickAgain() => Console.WriteLine("클릭 처리 완료");

Button button = new Button();
button.Click += HandleClick;
button.Click += HandleClickAgain;
button.OnClick();
Console.WriteLine();

Player player = new Player();
player.DamageTaken += player.HealthBar;
player.DamageTaken += player.SoundManager;
player.TakeDamage(30);
Console.WriteLine();

Console.WriteLine("=== 구독 상태 ===");
Timer timer = new Timer();
timer.Tick += timer.Logger;
timer.Start();
Console.WriteLine();

Console.WriteLine("=== 구독 해제 후 ===");
timer.Tick -= timer.Logger;
timer.Start();
Console.WriteLine();

Sensor sensor = new Sensor();
sensor.Alert += message => Console.WriteLine($"[경보] {message}");
sensor.Alert += message => Console.WriteLine($"[로그] {DateTime.Now}: {message}");

sensor.Detect("움직임 감지됨");
sensor.Detect("온도 상승");
Console.WriteLine();

GameCharacter character = new GameCharacter("용사");
character.OnDeath += () => Console.WriteLine("캐릭터가 사망했습니다");
character.OnDamaged += health => Console.WriteLine($"남은 체력: {health}");
character.OnAttack += (damage, target) => Console.WriteLine($"{target}에게 {damage} 데미지!");

character.Attack(50, "슬라임");
character.TakeDamage(30);
character.TakeDamage(80);
Console.WriteLine();

Stock stock = new Stock("MSFT", 100);

stock.PriceChanged += (sender, e) =>
{
    Stock newStock = (Stock)sender;
    Console.WriteLine(newStock);
    Console.WriteLine($"  이전 가격: {e.OldPrice:C}");
    Console.WriteLine($"  현재 가격: {e.NewPrice:C}");
    Console.WriteLine($"  변동률: {e.ChangePercent:F2}%");
    Console.WriteLine();
};

stock.Price = 110.00m;
stock.Price = 105.50m;
stock.Price = 120.00m;

Car car = new Car(50);
Dashboard dashboard = new Dashboard();

dashboard.Subscrbe(car);

for (int i = 0; i < 7; i++)
{
    car.Drive();
    Console.WriteLine();
}

dashboard.Unsubscrbe(car);

SecurePublisher publisher = new SecurePublisher();

void Handler1(object sender, EventArgs e)
{
    Console.WriteLine("Handler1 실행됨");
}
void Handler2(object sender, EventArgs e)
{
    Console.WriteLine("Handler2 실행됨");
}

publisher.MyEvent += Handler1;
publisher.MyEvent += Handler2;
Console.WriteLine();

Console.WriteLine("이벤트 발생:");
publisher.RaiseEvent();
Console.WriteLine();

publisher.MyEvent -= Handler1;
Console.WriteLine();

Console.WriteLine("이벤트 발생:");
publisher.RaiseEvent();
Console.WriteLine();

GlobalNotifier.OnGlobalMessage += GlobalNotifier.Module1;
GlobalNotifier.OnGlobalMessage += GlobalNotifier.Module2;
GlobalNotifier global1 = new GlobalNotifier("시스템 시작");
Console.WriteLine();

GlobalNotifier global2 = new GlobalNotifier("데이터 로드 완료");


delegate void Notify();
delegate void EventHandler1();