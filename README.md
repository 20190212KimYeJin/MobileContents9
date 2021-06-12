# MobileContents9
문화테크노학과 20190133 김혜원  
문화테크노학과 20190212 김예진  

# 게임 이름🎮
### MONDE STONÉE (몬 스토니) : 돌로 이루어진 세계

# 제작 의도🎮
포스트 아포칼립스 세계관을 통해 자연에 대한 경고와 더불어 현대를 살아가는 우리에게 없는 시대를 체험함으로써 신선함을 맛볼 수 있다. 마지막에는 석화된 인간들을 구출하고 문명을 재건설함으로써 성취감을 느끼게 한다.

# 주요 타깃🎮
- **최근 유행하고 있는 스팀게임과 인디게임의 유저를 겨냥**
- **스토리 위주의 신박한 게임을 좋아하는 사람들을 주요 타깃으로 함**
- (+) 기존의 FPS 게임에서 지루함을 느낀 게임 마니아층. 신선한 주제로 처음 게임을 접하는 사람들도 재미있게 즐길 수 있게 함.

# 스토리 모티브🎮
![L_1252094](https://user-images.githubusercontent.com/84370027/121769429-739ef280-cb9e-11eb-8f05-3b97a2095f46.jpg)
- 스토리 모티브 : Dr.Stone
- 일본 연재 만화

# 게임 스토리(시나리오)🎮
![12](https://user-images.githubusercontent.com/84370027/120946357-27efe180-c777-11eb-8921-33fdca5acad5.JPG)
**(석화된 인간 : 인간 Asset에 Material을 입혀 구현)**  
여느 날과 다르지 않던 지구의 운명을 바꿀 초록빛이 우주에서 떨어졌다. 그 초록빛으로 인해 인간들은 모두 석화되고 만다. 인간이 모두 석화되자 지구의 모든 건물들은 부식되고, 숲이 울창해지면서 점점 동물들의 터전으로 변하게 된다. 약 1000년 뒤, 동물의 왕국이 된 현재, 1000년 전에 석화되었던 당신이 깨어나게 된다. 몸을 감싸고 있던 암석을 뚫고 나와 눈을 뜨게 된 당신은 1000년 사이에 지구가 변한 것을 깨닫게 된다. 단, 유일하게 인간의 흔적이 남아있는 스톤월드에서 당신은 혼자서 지구의 문명을 다시 불러일으키려고 한다. 그러기 위해서는 집을 짓고, 고기를 먹고, 주변의 천적들과도 싸우면서 하루하루를 살아가야 한다. 그리고 당신은 문명을 일으키기 위해 텅 빈 도시 속에 석화된 인간들을 풀어낼 방법을 궁리한다.  과연 당신은 석화된 인간들을 해방시키고, 1000년 전의 문명을 다시 이룩할 수 있을까?

# 사용 에셋
![그림1](https://user-images.githubusercontent.com/84370027/121770073-30468300-cba2-11eb-838c-dbe4effd71d2.png)
- Unity Asset Store에서 다운로드

# 순서도📃
![그림16](https://user-images.githubusercontent.com/84370027/121769346-0f7c2e80-cb9e-11eb-898d-c653999eea63.png)

# 코드 별 순서도
**레퍼런스 강의와 기타 수업 자료 등을 응용하여 구현한 코드 위주**
![그림17](https://user-images.githubusercontent.com/84370027/121769699-1f950d80-cba0-11eb-952b-7c834844ab1b.png)
![그림18](https://user-images.githubusercontent.com/84370027/121769701-202da400-cba0-11eb-9373-f75096a02462.png)
![그림19](https://user-images.githubusercontent.com/84370027/121769702-20c63a80-cba0-11eb-892c-e12a4df69cd9.png)
![그림20](https://user-images.githubusercontent.com/84370027/121769704-20c63a80-cba0-11eb-9099-4c30c6ea185f.png)
![그림21](https://user-images.githubusercontent.com/84370027/121769705-215ed100-cba0-11eb-9a78-c4372e3b9869.png)
![그림22](https://user-images.githubusercontent.com/84370027/121769707-215ed100-cba0-11eb-91d7-d7290bc25527.png)
![그림23](https://user-images.githubusercontent.com/84370027/121769709-21f76780-cba0-11eb-8c88-55e74fa18be1.png)

# 스크립트🔗
https://github.com/20190212KimYeJin/MobileContents9/tree/master/Scripts

# 제작 과정🎮
![11](https://user-images.githubusercontent.com/84370027/120946073-2bcf3400-c776-11eb-8717-665177c136e6.JPG)
- 상호 간 프로젝트 공유 방법 : Github 및 유니티 콜라보레이트(Collabolate) 서비스 이용

## 마을 전체🎮
![7](https://user-images.githubusercontent.com/84370027/120945710-0c83d700-c775-11eb-825b-0fac01739426.JPG)
![그림1](https://user-images.githubusercontent.com/84370027/121770346-c202c000-cba3-11eb-875a-d9ecaf5a22e8.png)
- Terrain 기능 활용
- 황폐화된 도시와 동물 및 적들이 모여 있는 숲을 펜스로 구분

## FPS Player👤
![a](https://user-images.githubusercontent.com/84370027/121770241-39841f80-cba3-11eb-9432-ddb3a6ea5105.JPG)
- 곡괭이를 들고 시작하는 Player
- 1인칭이므로 Player안에 Main Camera를 넣고 플레이어 시점에서 클리어 할 수 있도록 구현
- 게임 플레이 중에는 Player가 자신의 모습을 활용할 수 없어 Capsule로만 몸체 구현
- PlayerController.cs : 움직임 및 시야 조정 등
- StatusController.cs : 왼쪽 하단 상태 체크 담당 등

## 맨손 구현🖐
![2](https://user-images.githubusercontent.com/84370027/120945314-83b86b80-c773-11eb-9e35-240e810977c8.JPG)
맨손 구현
- Hand.cs : 무기 구분, 공격 시간과 딜레이 담당 등
- HandController.cs : 근접 무기 공격 제어

## 총 구현🔫
![3](https://user-images.githubusercontent.com/84370027/120945345-a21e6700-c773-11eb-8422-cedeac743802.JPG)
총 구현
- Gun.cs : 무기 구분, 사정거리, 탄피 관리 등
- GunController : 반동, 정조준, 이펙트 등 담당

## 도끼 구현🪓
![13](https://user-images.githubusercontent.com/84370027/120948128-78b60900-c77c-11eb-8267-1e6836913254.JPG)
- Hand.cs : 무기 구분, 공격 시간과 딜레이 담당 등
- HandController.cs : 근접 무기 공격 제어
**cs 이름은 hand로 설정되어 있으나, 근접무기 전체를 통칭함**

## 곡괭이 구현⛏
![캡처](https://user-images.githubusercontent.com/84370027/120945204-1efd1100-c773-11eb-9697-deacff62adec.JPG)
플레이 시작 화면(곡괭이로 시작)
- Hand.cs : 무기 구분, 공격 시간과 딜레이 담당 등
- HandController.cs : 근접 무기 공격 제어

## 아이템 줍기 구현🎮
![5](https://user-images.githubusercontent.com/84370027/120945465-0f31fc80-c774-11eb-83c4-cc7b573bde7b.JPG)  
- 아이템 가까이 다가가면 문구가 뜨고 E키를 눌러 습득
- Item.cs : 아이템 이름, 설며으 유형, 인벤토리 이미지, 프리팹 설정용
- ItemPickup.cs : 아이템 구분용
- ActionController.cs : 아이템 습득 사정거리, 충돌체 정보 확인, 레이어 확인, 출력 UI 담당

## 인벤토리 구현🎮
![6](https://user-images.githubusercontent.com/84370027/120945469-122ced00-c774-11eb-9d5b-4b063b1ed322.JPG) 
- 습득한 아이템은 I키를 눌러 인벤토리에서 확인 가능
- 마우스를 아이템에 갖다대면 아이템 설명팁이 뜨고, 오른쪽 마우스 버튼을 눌러 이용 가능
- Inventory.cs : 인벤토리 창 열고 닫기, 아이템 종류 구분, 습득 아이템 저장 등 

## 펜스🚫
![image](https://user-images.githubusercontent.com/84370027/121770303-8962e680-cba3-11eb-8613-5988ccfde02a.png)
- Collider를 추가하여 플레이어가 뚫고 지나가지 못하도록 설정
- 입구에는 Collider가 설정된 바위가 막고 있어 게임 최초에는 곡괭이로 부숴야만 숲으로 갈 수 있음

## 마을 외곽(숲)🎮
![8](https://user-images.githubusercontent.com/84370027/120945713-10aff480-c775-11eb-9de5-cb0e03148adc.JPG)
나가는 길
- 돌과 펜스에는 Collider가 붙어있어 그냥 지나갈 수 없다.
- 돌을 곡괭이로 세 번 내려치면 돌이 깨지고 이후 나갈 수 있다.  

## 사냥 1🐷
![그림3](https://user-images.githubusercontent.com/84370027/121768924-d9d64600-cb9b-11eb-9337-3e4c765dc036.png)
- 돼지의 눈 앞에 다가가면 반대 방향으로 도망가도록 시야각 구현
- 돼지를 근접 무기로 두 번 때리면 사망 애니메이션 진행 후 Destroy
- 돼지 소리 구현(일반 울음소리, 때리면 나는 소리, 죽으면 나는 소리)
- Pig.cs : 이중상속, 일반 상태일 때 애니메이션 재생 관리
- WeekAnimal.cs 시야각에 따라 플레이어 반대방향으로 뛸 수 있도록 구현, 데미지를 입어 도망가는 것 구현
- Animal.cs : 동물 전체 관리, 이름, 속도, 드랍 아이템, 사운드, 네비게이션 등 담당

## 플레이어를 따라오는 적🕷
![그림11](https://user-images.githubusercontent.com/84370027/121768954-f2466080-cb9b-11eb-98cd-d8c515caec29.png)
- 정해진 루트를 자유롭게 돌아다니는 거미
- 거미에게 설정된 Collider안에 플레이어가 들어오면 플레이어를 목적지로 함
- SpiderMove.cs : PatrolRoute를 따라 걷도록 설정, 플레이어와 닿으면 플레이어 돌진 구현

## 물
![wa](https://user-images.githubusercontent.com/84370027/121770477-713f9700-cba4-11eb-95fc-00fba88c2c26.JPG)
- 움푹 파인 지형을 만들어 물 구현  
![ea](https://user-images.githubusercontent.com/84370027/121770479-7270c400-cba4-11eb-9104-6b4230fea47e.JPG)
- 물 안에서 헤엄치는 정어리 구현

## 낮과 밤☀🌙
![그림8](https://user-images.githubusercontent.com/84370027/121768985-186c0080-cb9c-11eb-8033-8926b8a04ef2.png)
![그림9](https://user-images.githubusercontent.com/84370027/121768986-19049700-cb9c-11eb-9479-c1f8977bb705.png)
![그림10](https://user-images.githubusercontent.com/84370027/121768987-19049700-cb9c-11eb-8d32-3a1acebd37ba.png)
- 시간이 흐를수록 해가 떨어지며 낮과 밤이 반복되는 것을 확인할 수 
- 기준 시간 : 10초
- DayAndNight.cs : 게임세계 속 시간 구분, 낮과 밤의 Fog 관리 및 계산

## 모닥불🔥
![그림4](https://user-images.githubusercontent.com/84370027/121769164-06d72880-cb9d-11eb-951e-a4364828d80d.jpg)
![그림5](https://user-images.githubusercontent.com/84370027/121769029-4cdfbc80-cb9c-11eb-85ab-e7b0cb586b84.png)
- Tab키를 눌러 모닥불 소환 창 불러오기 및 닫기
- 마우스 왼쪽 클릭으로 설치
- 설치불가 지역은 빨간색으로 표시
- CraftManual.cs : 이름, 프리팹, 미리보기 프리팹 관리

## 클리어 조건 구현🧪
![그림13](https://user-images.githubusercontent.com/84370027/121769066-77ca1080-cb9c-11eb-9efa-5eef20af40f3.png)
![그림14](https://user-images.githubusercontent.com/84370027/121769067-78fb3d80-cb9c-11eb-9c6f-70c39634c4d0.png)
- 전체 맵 곳곳에 배치되어 있는 바위 중에서 3개의 바위를 부수면 '석화 부활액' 드랍
- 인벤토리에 들어있는 석화 부활액을 3개 연달아 사용하면 클리어
- = 왼쪽 아래 게이지 중 녹색의 석화 게이지를 다 채우면 클리어
- 석화 게이지는 게임 시작과 동시에 줄어들며 이를 다시 채우는 것을 목적으로 함
- 석화 부활액 사용 시 효과음이 들리도록 설정
- RealRock.cs : 바위 체력, 파편 관리, 이펙트, **드랍 아이템 관리**
- Rock.cs : **일반 바위** 바위 체력, 파편 관리, 이펙트

## 도움말
![그림12](https://user-images.githubusercontent.com/84370027/121769130-d7282080-cb9c-11eb-8588-89e4815288e9.png)
- 원활한 게임 플레이를 위해 Q키를 누르면 언제든지 도움말 창을 활성화하고 끌 수 있음
- Guide.cs : 창 활성화 여부 판단, 창 열고 닫기 관리

## 일시정지 메뉴
![ddd](https://user-images.githubusercontent.com/84370027/121770145-8b787580-cba2-11eb-890d-d4b638fb9885.JPG)
- 플레이 중 P를 누르면 일시정지 메뉴를 언제든지 활성화하고 끌 수 있음
- Pause.cs : 창 활성화 여부 판단, 창 열고 닫기 관리

## 배경음악
![그림15](https://user-images.githubusercontent.com/84370027/121769169-0fc7fa00-cb9d-11eb-8c92-88dc87c25fed.png)
- 모티브가 된 '닥터 스톤'의 오리지널 사운드 트랙에서 사용
- 게임 타이틀, 플레이, 클리어의 분위기와 맞는 음악을 선정

## 타이틀 및 클리어 씬
![Title](https://user-images.githubusercontent.com/84370027/121769198-3ab24e00-cb9d-11eb-9729-1cc6a48e1e9a.jpg)
- 타이틀 씬
- 유저의 주 활동이 이루어지는 공간을 배경으로 석화된 사람의 모습이 메인으로 들어와 있다
- 시작, 로드, 종료 버튼 구현
- 사용된 폰트 : tower ruins 
- Title.cs : 플레이 씬으로의 이동, 버튼 클릭시 이벤트 관리
- SaveNLoad.cs : 플레이어 위치 값, 인벤토리, 세이브 폴더 값 관리


![Clear](https://user-images.githubusercontent.com/84370027/121769200-3be37b00-cb9d-11eb-9abd-2ac07195193b.jpg)
- 클리어 씬
- 물약을 사용해서 석화를 풀었음을 의미하는 장면으로 구성
- UI - Video Player 기능을 통해 비디오로 보여주도록 함
- 게임 클리어 이후 X창을 눌러 게임을 나가게 함

## 유니티 프로젝트
![캡처](https://user-images.githubusercontent.com/84370027/121769498-dabca700-cb9e-11eb-9a75-925c63bf4e4a.JPG)

# 참고 레퍼런스
- https://keidy.tistory.com/254

# 사용 폰트
- G Market Sans Bold, Medium
