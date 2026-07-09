# leetcode-by-sev

Решения задач LeetCode на C# (.NET 8).

## Структура проекта

```
LeetCode/
├── Topics/
│   ├── Arrays/          # задачи на массивы
│   ├── LinkedLists/     # задачи на связные списки
│   ├── Trees/           # (будущее)
│   ├── DynamicProgramming/
│   └── ...
└── Models/              # общие структуры данных

LeetCode.Tests/
└── Topics/              # тесты зеркалят структуру решений
```

Каждый файл с решением содержит:
- номер и ссылку на задачу LeetCode
- сложность (Easy / Medium / Hard) и тему
- описание алгоритма
- оценку времени и памяти (Time / Space)

## Задачи

### Arrays

| # | Задача | Сложность | Алгоритм |
|---|--------|-----------|----------|
| 283 | [Move Zeroes](https://leetcode.com/problems/move-zeroes/) | Easy | Two Pointers |
| 724 | [Find Pivot Index](https://leetcode.com/problems/find-pivot-index/) | Easy | Prefix Sum |
| 179 | [Largest Number](https://leetcode.com/problems/largest-number/) | Medium | Custom Sort |
| 442 | [Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/) | Medium | Index Negation |
| 525 | [Contiguous Array](https://leetcode.com/problems/contiguous-array/) | Medium | Prefix Sum + Hash Map |
| 560 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium | Prefix Sum + Hash Map |
| 845 | [Longest Mountain in Array](https://leetcode.com/problems/longest-mountain-in-array/) | Medium | Single Pass |

### Linked Lists

| # | Задача | Сложность | Алгоритм |
|---|--------|-----------|----------|
| 2 | [Add Two Numbers](https://leetcode.com/problems/add-two-numbers/) | Medium | Iterative / Recursive |

## Запуск тестов

```bash
dotnet test
```
