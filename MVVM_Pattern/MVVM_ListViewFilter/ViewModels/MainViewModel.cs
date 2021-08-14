using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using MVVM_ListViewFilter.Models;

namespace MVVM_ListViewFilter.ViewModels {
    /// <summary>
    /// MVVM 패턴을 이용한 ListView에 대한 Filter 기능 구현
    /// </summary>
    public class MainViewModel {
        // Property
        private string _nameFilter = string.Empty;

        public string NameFilter {
            get => _nameFilter;
            set {
                _nameFilter = value;
                // TextBox의 내용이 변경되면 검색 조건이 변한 것이므로 새로고침하여 데이터를 다시 검색
                OnFilterChanged();
            }
        }

        // Data의 변경 사항이 View에도 Notify되어야 하기 때문에 Source는 ObservableCollection 이어야 함
        private ObservableCollection<Student> StudentNameFilter { get; set; }

        private CollectionViewSource StudentCollectionViewSource { get; set; }

        public ICollectionView StudentCollection {
            get { return StudentCollectionViewSource.View; }
        }

        public MainViewModel() {
            StudentNameFilter = new ObservableCollection<Student>();

            AddDummyData();

            StudentCollectionViewSource = new CollectionViewSource();
            StudentCollectionViewSource.Source = this.StudentNameFilter;
            StudentCollectionViewSource.Filter += ApplyNameFilter;
        }

        private void AddDummyData() {
            StudentNameFilter.Add(new Student {Age = 20, Country = "Korea", Name = "김철수"});
            StudentNameFilter.Add(new Student {Age = 20, Country = "China", Name = "Jimmy Zhang"});
            StudentNameFilter.Add(new Student {Age = 20, Country = "Korea", Name = "김영희"});
            StudentNameFilter.Add(new Student {Age = 21, Country = "United States", Name = "James"});
            StudentNameFilter.Add(new Student {Age = 22, Country = "Japan", Name = "Yuya"});
            StudentNameFilter.Add(new Student {Age = 23, Country = "Russia", Name = "Alexander "});
            StudentNameFilter.Add(new Student {Age = 24, Country = "Korea", Name = "옥동자"});
            StudentNameFilter.Add(new Student {Age = 25, Country = "China", Name = "Tim"});
            StudentNameFilter.Add(new Student {Age = 26, Country = "Korea", Name = "구준표"});
            StudentNameFilter.Add(new Student {Age = 27, Country = "Korea", Name = "yun-e(깃허브 주인)"});
            StudentNameFilter.Add(new Student {Age = 28, Country = "China", Name = "Yuho"});
            StudentNameFilter.Add(new Student {Age = 29, Country = "Korea", Name = "김수안무거북이와두루미"});
            StudentNameFilter.Add(new Student {Age = 30, Country = "Japan", Name = "Yosuke"});
            StudentNameFilter.Add(new Student {Age = 30, Country = "Korea", Name = "금잔디"});
            StudentNameFilter.Add(new Student {Age = 30, Country = "Canada", Name = "Henry"});
        }

        private void OnFilterChanged() {
            // 새로고침 하게되면 CollectionViewSource의 Source로 지정된 StudentNameFilter가 차례로 ApplyNameFilter의 FilterEventArgs로 들어감
            StudentCollectionViewSource.View.Refresh();
        }


        // 조건에 부합 -> e.Accepted = True
        // 부합하지 않음 -> e.Accepted = False
        void ApplyNameFilter(object sender, FilterEventArgs e) {
            Student svm = (Student) e.Item;

            // SearchBar(NameFilter)이 비어있다면 모든 List를 보여줘야 하기 때문에 True 대입
            if (string.IsNullOrWhiteSpace(this.NameFilter) || this.NameFilter.Length == 0) {
                e.Accepted = true;
            }
            else {
                // 대소문자를 구분하지 않기 위해 모두 소문자로 변경하여 검색
                // 완전 일치가 아닌 '포함'하고 있어도 찾기 위해 Equals가 아닌 Contains 사용
                e.Accepted = svm.Name.ToLower().Contains(NameFilter.ToLower());
            }
        }
    }
}