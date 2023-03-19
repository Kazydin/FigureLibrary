-- pl/sql
-- конструкции WITH вместо таблиц из БД, пример данных

/*WITH products AS (
      SELECT 'Банан' AS NAME, 1 AS ID FROM dual
      UNION ALL
      SELECT 'Мороженое', 2 AS ID FROM dual
      UNION ALL
      SELECT 'Груша', 3 AS ID FROM dual
      UNION ALL
      SELECT 'Яблоко', 4 AS ID FROM dual
      UNION ALL
      SELECT 'Молоко', 5 AS ID FROM dual
      UNION ALL
      SELECT 'Котлеты', 6 AS ID FROM dual
), categories AS (
      SELECT 'Фрукты' AS NAME, 1 AS ID FROM dual
      UNION ALL
      SELECT 'Дороже 50 рублей', 2 AS ID FROM dual
      UNION ALL
      SELECT 'Популярные', 3 AS ID FROM dual
      UNION ALL
      SELECT 'Отсутствуют на складке', 4 AS ID FROM dual
), product_category_references AS (
      SELECT 1 AS product_id, 1 AS category_id FROM dual
      UNION ALL
      SELECT 3 AS product_id, 1 AS category_id FROM dual
      UNION ALL
      SELECT 4 AS product_id, 1 AS category_id FROM dual
      UNION ALL
      SELECT 2 AS product_id, 2 AS category_id FROM dual
      UNION ALL
      SELECT 6 AS product_id, 2 AS category_id FROM dual
      UNION ALL
      SELECT 2 AS product_id, 3 AS category_id FROM dual
      UNION ALL
      SELECT 4 AS product_id, 3 AS category_id FROM dual
      UNION ALL
      SELECT 6 AS product_id, 3 AS category_id FROM dual
      UNION ALL
      SELECT 6 AS product_id, 4 AS category_id FROM dual
)*/
SELECT
      p.name,
      c.name AS category_name
FROM products p
LEFT JOIN product_category_references pcr
      ON pcr.product_id = p.id
LEFT JOIN categories c
      ON c.id = pcr.category_id
ORDER BY p.name