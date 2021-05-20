namespace src.Questions.Numers {
    public class VersionControl {
        public int FirstBadVersion (int n) {

            int l = 1;
            int r = n;
            while (l < r) {
                int m = l + (r - l) / 2;
                if (IsBadVersion (m))
                    r = m;
                else
                    l = m + 1;
            }
            return l;
        }

        private bool IsBadVersion (int version) {
            return version >= 4;
        }
    }
}