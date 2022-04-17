# LifeGame

최종 발표 영상

https://youtu.be/nnoyvhAN0bI
***
##*<Tasks to do>
1. 돈 관리 (0407완료)

2. 부동산 UI (0407완료)

	- 부동산 오브젝트 클릭 시

	- 건물 매입 UI

3. 부동산 구매 스크립트 (0408 완료, 0409 Correction)

	- 업그레이드

	- 타이머를 이용한 임대료 받기

4. Town -> 노동 scene 연결 (0407완료)

	4-1 Monster -> Home 씬 전환에서 데이터 유지 불능 (0408 완료)

5. 노동 scene 몬스터 잡기 구현 (0407완료)

	5-1 플레이어 만나면 Monster 천천히 움직이게, 몬스터 기본 Idle 상태, 체력 게이지바, 맞을 때마다 돈도 벌기 (0407완료)

	5-2 플레이어 마법 쏘기 (0407완료)

	5-3 스폰포인트 (0410완료)

	5-4 MosnterManager 몬스터 3마리 생성해놓고 하나 죽을 때마다 새로 생성 (0410완료)

	5-5 몬스터 체력 게이지 바 (0410완료)

1. 가구 구매상태 저장하기 (0409 완료)

2. 부동산 구매상태 저장하기 (0408 완료)

6. 가구 늘리기 (0409 완료)

7. 빌딩 층수 늘리기 (0408 완료)

(6, 7 확장 -> 스크롤뷰) (0411 완료)

8. 빌딩 수 늘리기 (0411 완료)

9. 레벨 별 공격력 (0411 완료)

***
##<Issues and Corrections>

* *04/07*
1. Monster에 Bullet이 닿기도 전에 사라지던 현상
 -> BulletCtrl 원래는 모두 Destroy하던 것을 =>
'''
if (collision.gameObject.tag=="Enemy"|| collision.gameObject.tag == "Bottom")
        {
            Destroy(gameObject);
        }
'''
 -> 혹시 모를 오류 방지 차원으로 콜라이더 Hierarchy 수정 (+DetectRange) :
Before
![BeforeCorrectCollidersOfMonster](https://user-images.githubusercontent.com/60171052/162777652-01dd1e65-a911-4def-b733-3b249b2b6a3a.png)
After
![AfterCorrectCollidersOfMonster](https://user-images.githubusercontent.com/60171052/162777644-2eba138e-70b8-41e6-a0a3-2476b444d33c.png)

* *04/09*
1. BuildingView UI 에서 Floor3 눌렀을 때 다른 Floor의 타이머가 불러져 재시작됨 (돈은 그대로)
 -> 버튼을 누를 때 몇 층인지 모른 채로 if문 1층부터 3층까지 차례대로 불러져서 그렇다. 가능한 것 먼저 earn 되던 것. =>
 변수 floor 및 함수 SelectFloor1(), SelectFloor2(), SelectFloor3() 생성
2. Monster Scene에서 light 제대로 안들어오는 것
 -> Scene에서 Background SpriteRenderer Order in layer을 -N로 바꿨더니, 총알(얘도 +N'로 바꿈)도 잘 보이고, Light Sprite Object도 잘 보인다.
3. Town Scene에서 Building이나 (GoTo)Monster 오브젝트가 잘 클릭이 안됨
 -> 영역별로 MapRestrict에서 Collider 설치했던 것들 때문이었음. //// 미해결(0411해결)
4. Scene 변환 시 구매한 가구가 초기화 되는 현상
 -> 가구 구매 시 Instantiate로 프리펩 복제하기 때문 => DontDestroyOnLoad과 씬 변환 시 해당 오브젝트 SetActive()로 해결

* *04/10*
1. MosnterManager 몬스터 3마리 생성해놓고 하나 죽을 때마다 새로 생성할 때 1초 기다리게끔 하는 법
 -> CreateMonster 함수에서 몬스터 index를 매개변수로 받는데, Invoke는 함수 부를 때 인수를 넣을 수 없으므로, DeleteMonster에서
 코루틴 함수를 불러 (인수 전달) 1초 기다린 후 CreateMonster를 호출(인수 전달)하게끔 구현 했다.
2. 몬스터 체력 게이지 바 UI를 몬스터 기준으로 생성하는 법
 -> Canvas를 몬스터 오브젝트 하위로 생성하고, Render Mode를 World Space로 바꾸고, Event Camera는 씬 Main Camera으로 해준다.
 그 하위에 UI Image를 생성해서 하얀색 직사각형 sprite를 넣어주고, Color는 빨간색.
 sprite를 넣으면 Image Type을 Filled로 바꿔주고, Fill Method는 Horizontal, Fill Origin은 Left로 해준다.
3. MonsterCtrl에서 감지 범위 안에 들어올 때 StartChase를 호출하는데, 이 상태에서 BulletCtrl이 Damage하면 Attack당하는 애니메이션 트리거가 호출되지 않음. //// 미해결(0411해결)

* *04/11*
1. MonsterCtrl에서 감지 범위 안에 들어올 때 StartChase를 호출하는데, 이 상태에서 BulletCtrl이 Damage하면 Attack당하는 애니메이션 트리거가 호출되지 않음. //// 공격속도 0.4 이상에서만 해결
 -> StartChase는 반복적으로 호출되고, Bool 변수로 walk를 하지만, Damage는 일시적으로 호출되고, Trigger로 damage된다.
 => Damage 될 때 bool 변수로 반복문 안에서도 감지하게끔. Damage 실행 이후 bool 변수 풀릴 때는 Invoke로 0.4초 후에. 이 시간이 walk animation 시간보다 길어야한다. walk animation도 짧게 수정.
2. Find로 UI오브젝트 등을 찾는 것은 비효율적
 -> default 값이 inactive인 오브젝트들을 Find로 구현했었는데, UI 오브젝트는 이제 DontDestroy이므로 public 변수로 Inspector창에서 지정해주었다. 씬 자체에 원래 없는 오브젝트를 찾아야 하는 경우는 그대로 유지.
3. Town Scene에서 Building이나 (GoTo)Monster 오브젝트가 잘 클릭이 안됨
 -> 영역별로 MapRestrict에서 Collider 설치했던 것들 때문이었음.
 => MapRestrict에 포함된 오브젝트 모두 Layer를 Ignore Raycast로 선택했더니, Default Layer의 모든 오브젝트 OnMouseDown 함수 잘 실행됨
4. StartChase, StopChase, Damage, TimeRunningEarn 함수가 Coroutine으로 구현되어 있던 것 비효율적
 -> Update 속에서 함수를 호출하는 것으로 수정
5. BuildingTransaction Update 함수에서 timer 변수들이 제대로 작동되지 않는 이유
 -> BuildingUI를 active 시켰을 때 일반 UI처럼 'Time.time=0'으로 만들었기 때문
'''
float Timetime_privious = 0;
void Update() {
        Debug.Log(Time.time - Timetime_privious);
        Timetime_privious = Time.time;
}
'''
Update 함수에서 Time.deltaTime이 작동 안될 때는 위 코드를 이용해 디버깅한다.
6. Town Building ScrollView 구조 오류
 -> 한 스크롤 뷰 안에 content 안에 스크롤할 내용물만 있어야 한다.
Before
![20220412ScrollViewBefore](https://user-images.githubusercontent.com/60171052/162777641-211eded0-156b-4d61-b682-33e4c2398aad.png)
After
![20220412ScrollViewAfter](https://user-images.githubusercontent.com/60171052/162777630-85c016ca-15ad-4e49-ae22-3dc8dd71aac0.png)