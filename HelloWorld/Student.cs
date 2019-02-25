namespace Models {
    public class Student : Person {
        public string StudentId { get; set; }

        public override string ToString() {
            return $"{StudentId} " + base.ToString();
        }
    }
}