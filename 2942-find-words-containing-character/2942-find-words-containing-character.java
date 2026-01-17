class Solution {
    public List<Integer> findWordsContaining(String[] words, char x) {
        List<Integer> numbers = new ArrayList<Integer>();
        for(int i = 0; i < words.length; i++) {
            for (int j = 0; j < words[i].length(); j++) {
                if (words[i].charAt(j) == x) {
                    numbers.add(i);
                    break;
                }
            }
        }
        return numbers;
    }
}