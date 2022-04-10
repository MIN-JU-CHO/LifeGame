# LifeGame
 
<Tasks to do>
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
(6, 7 확장 -> 스크롤뷰)
8. 빌딩 수 늘리기

<Issues and Corrections>

*04/07*
1. Monster에 Bullet이 닿기도 전에 사라지던 현상
 -> BulletCtrl 원래는 모두 Destroy하던 것을 =>

if (collision.gameObject.tag=="Enemy"|| collision.gameObject.tag == "Bottom")
        {
            Destroy(gameObject);
        }

 -> 혹시 모를 오류 방지 차원으로 콜라이더 Hierarchy 수정 (+DetectRange) : BeforeCorrectCollidersOfMonster.PNG => AfterCorrectCollidersOfMonster.PNG

*04/09*
1. BuildingView UI 에서 Floor3 눌렀을 때 다른 Floor의 타이머가 불러져 재시작됨 (돈은 그대로)
 -> 버튼을 누를 때 몇 층인지 모른 채로 if문 1층부터 3층까지 차례대로 불러져서 그렇다. 가능한 것 먼저 earn 되던 것. =>
 변수 floor 및 함수 SelectFloor1(), SelectFloor2(), SelectFloor3() 생성
2. Monster Scene에서 light 제대로 안들어오는 것
 -> Scene에서 Background SpriteRenderer Order in layer을 -N로 바꿨더니, 총알(얘도 +N'로 바꿈)도 잘 보이고, Light Sprite Object도 잘 보인다.
3. Town Scene에서 Building이나 (GoTo)Monster 오브젝트가 잘 클릭이 안됨
 -> 영역별로 MapRestrict에서 Collider 설치했던 것들 때문이었음. //// 미해결
4. Scene 변환 시 구매한 가구가 초기화 되는 현상
 -> 가구 구매 시 Instantiate로 프리펩 복제하기 때문 => DontDestroyOnLoad과 씬 변환 시 해당 오브젝트 SetActive()로 해결

*04/10*
1. MosnterManager 몬스터 3마리 생성해놓고 하나 죽을 때마다 새로 생성할 때 1초 기다리게끔 하는 법
 -> CreateMonster 함수에서 몬스터 index를 매개변수로 받는데, Invoke는 함수 부를 때 인수를 넣을 수 없으므로, DeleteMonster에서
 코루틴 함수를 불러 (인수 전달) 1초 기다린 후 CreateMonster를 호출(인수 전달)하게끔 구현 했다.
2. 몬스터 체력 게이지 바 UI를 몬스터 기준으로 생성하는 법
 -> Canvas를 몬스터 오브젝트 하위로 생성하고, Render Mode를 World Space로 바꾸고, Event Camera는 씬 Main Camera으로 해준다.
 그 하위에 UI Image를 생성해서 하얀색 직사각형 sprite를 넣어주고, Color는 빨간색.
 sprite를 넣으면 Image Type을 Filled로 바꿔주고, Fill Method는 Horizontal, Fill Origin은 Left로 해준다.
3. MonsterCtrl에서 감지 범위 안에 들어올 때 StartChase를 호출하는데, 이 상태에서 BulletCtrl이 Damage하면 Attack당하는 애니메이션 트리거가 호출되지 않음. //// 미해결