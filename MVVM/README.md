# Model-View-ViewModel Pattern 
> Presentation 모델 패턴에서 파생된 디자인 패턴으로 '비지니스 로직'과 '프레젠테이션 로직'을 UI로 부터 분리 (테스트, 유지 보수 재사용의 용이성)

## 구성요소
1. Model
 - 사용할 데이터에 관련된 행위 및 데이터를 다룸(비지니스 로직, 유효성 검사, 데이터를 포함하는 앱의 도메인 모델)

2. View
 - UI에 관련된 것 (구조, 레이아웃, 형태에 대한 정의)
 - 애니메이션과 같은 UI 로직은 포함하지만 비지니스 로직은 포함하지 않음
 - ViewModel에서 제공하는 메서드와 필드로 구현된 기능들을 어떻게 보여줄 것인지 결정

3. ViewModel
 - View가 사용할 메서드와 필드를 구현하고 View에게 상태 변화를 알림 (View는 ViewModel의 상태변화를 Observing)

## 장단점
###장점
 - ViewModel이 Model과 View 사이를 Binding 하기 때문에 변경이 생겼을 때 변경을 최소화할 수 있음
 - Model(데이터)과 ViewModel(Binder)이 View(화면)로부터 독립적
 - 개발자와 UI/UX 디자이너가 독립적으로 작업할 수 있음

### 단점
 - 큰 프로젝트를 위해 고안된 디자인 패턴이기 떄문에, 작은 프로젝트에서 사용하게 되면 오버헤드가 커짐
 - 애플리케이션의 사이즈가 너무 커지면 데이터 바인딩으로 인해 메모리 소모가 증가함